using LibraryManagement.DAO;
using LibraryManagement.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class Form_LapPhieuTra : Form
    {
        public Form_LapPhieuTra()
        {
            InitializeComponent();
            hienthi();
        }
        #region method
        void hienthi()
        {
            DataTable docgia = DataProvider.Instance.ExecuteQuery("SELECT DISTINCT DOC_GIA.Madocgia,Hoten FROM dbo.DOC_GIA,dbo.PHIEU_MUON WHERE DOC_GIA.Madocgia=PHIEU_MUON.Madocgia");
            if (docgia.Rows.Count > 0)
            {
                cmb_madg.DisplayMember = "Madocgia";
                cmb_madg.ValueMember = "Madocgia";
                cmb_madg.DataSource = docgia;

                cmb_hoten.DisplayMember = "Hoten";
                cmb_hoten.ValueMember = "Madocgia";
                cmb_hoten.DataSource = docgia;
            }
            DataTable sach = DataProvider.Instance.ExecuteQuery("EXEC dbo.hienthiphieutra @madocgia = "+Convert.ToInt32(cmb_madg.Text)+"");
            if (sach.Rows.Count > 0)
            {
                cmb_masach.DisplayMember = "Masach";
                cmb_masach.ValueMember = "Masach";
                cmb_masach.DataSource = sach;

                cmb_tensach.DisplayMember = "Tendausach";
                cmb_tensach.ValueMember = "Masach";
                cmb_tensach.DataSource = sach;
            }
        }
        bool kiemtra(int masach)
        {
            if (listView_sach.Items.Count > 0)
            {
                foreach (ListViewItem item in listView_sach.Items)
                {
                    if (masach.ToString() == item.Text)
                    {
                        MessageBox.Show("Sách Đã Tồn Tại");
                        return false;
                    }
                }
            }
            return true;
        }
        public int getmax_phieutra()
        {
            string temp = DataProvider.Instance.ExecuteReader("SELECT MAX(Maphieutra) FROM dbo.PHIEU_TRA");
            if (temp != "")
            {
                int rs = Convert.ToInt32(temp);
                return rs;
            }
            return 0;
        }
        #endregion
        #region event
        private void button_lpt_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        private void cmb_madg_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable sach = DataProvider.Instance.ExecuteQuery("EXEC dbo.hienthiphieutra @madocgia = " + Convert.ToInt32(cmb_madg.Text) + "");
            if (sach.Rows.Count > 0)
            {
                cmb_masach.DisplayMember = "Masach";
                cmb_masach.ValueMember = "Masach";
                cmb_masach.DataSource = sach;

                cmb_tensach.DisplayMember = "Tendausach";
                cmb_tensach.ValueMember = "Masach";
                cmb_tensach.DataSource = sach;
            }
            listView_sach.Items.Clear();
        }

        private void bt_themsach_Click(object sender, EventArgs e)
        {
            int masach = Convert.ToInt32(cmb_masach.SelectedValue);
            if(kiemtra(masach)==true)
            {
                List<LapPhieuMuonDTO> danhsachphieutra = PhieuMuonDAO.Instance.hienthiphieumuon(masach);
                foreach (LapPhieuMuonDTO item in danhsachphieutra)
                {
                    ListViewItem ds = new ListViewItem(item.Masach.ToString());
                    ds.SubItems.Add(item.Tensach);
                    ds.SubItems.Add(item.Theloai);
                    ds.SubItems.Add(item.Tentacgia);
                    listView_sach.Items.Add(ds);
                }
            }
        }

        private void bt_xoasach_Click(object sender, EventArgs e)
        {
            if (listView_sach.Items.Count > 0)
            {
                foreach (ListViewItem item in listView_sach.Items)
                {
                    if (item.Checked == true)
                        item.Remove();
                }
            }
        }

        private void button_lpm_lapphieumuon_Click(object sender, EventArgs e)
        {
            if(listView_sach.Items.Count>0)
            {
                int madocgia = Convert.ToInt32(cmb_madg.SelectedValue);


                int rs = DataProvider.Instance.ExecuteNonQuery("INSERT INTO dbo.PHIEU_TRA ( Madocgia, Ngaytra, Tienphat ) VALUES  ( "+madocgia+",GETDATE(), '0' )");

                int result = 0, tongtienphat = 0, tienphattungsach, tinhtrang, masach,songay;

                if (rs > 0)
                {
                    int max = getmax_phieutra();
                    foreach (ListViewItem item in listView_sach.Items)
                    {
                        tienphattungsach = 0;
                        masach = Convert.ToInt32(item.Text);
                        tinhtrang = Convert.ToInt32(DataProvider.Instance.ExecuteReader("SELECT tinhtrang FROM  dbo.CHITIET_PHIEUMUON WHERE Masach='" + masach + "'"));

                        if (tinhtrang == 3)
                        {
                            songay = Convert.ToInt32(DataProvider.Instance.ExecuteReader("SELECT DATEDIFF(Dd,Ngayhethan,GETDATE()) FROM dbo.CHITIET_PHIEUMUON WHERE Masach='" + masach + "'"));
                            tienphattungsach = songay * 1000;
                        }
                        tongtienphat += tienphattungsach;
                        result = DataProvider.Instance.ExecuteNonQuery("INSERT INTO dbo.CHITIET_PHIEUTRA ( Maphieutra , Masach ,Tienphattungsach)VALUES  ( " + max + " ,  " + masach + " , '" + tienphattungsach + "' )");

                        DataProvider.Instance.ExecuteNonQuery("UPDATE dbo.CHITIET_PHIEUMUON SET tinhtrang='1' WHERE Masach='" + masach + "'");

                        DataProvider.Instance.ExecuteNonQuery("UPDATE dbo.CUONSACH SET Matinhtrang='1' WHERE Masach='" + masach + "'");

                    }
                }
                if (result > 0)
                {
                    DataProvider.Instance.ExecuteNonQuery("UPDATE dbo.DOC_GIA SET Sosachmuon-='" + listView_sach.Items.Count + "' WHERE Madocgia='" + madocgia + "'");

                    DataProvider.Instance.ExecuteNonQuery("UPDATE dbo.DOC_GIA SET Tongno+='" + tongtienphat + "' WHERE Madocgia='" + madocgia + "'");

                    MessageBox.Show("Thêm Mới Thành Công");

                  

                    listView_sach.Items.Clear();

                    hienthi();
                }
            }
        }
    }
}
