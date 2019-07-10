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

        float tongno;
        bool check = false;

        #region method

        void hienthi()
        {
            DataTable docgia = DataProvider.Instance.ExecuteQuery("SELECT DISTINCT DOC_GIA.Madocgia,Hoten FROM dbo.DOC_GIA,dbo.PHIEU_MUON WHERE DOC_GIA.Madocgia=PHIEU_MUON.Madocgia AND Sosachmuon>0");
            int madocgia = Convert.ToInt32(cmb_madg.SelectedValue);

            if (docgia.Rows.Count > 0)
            {
                cmb_madg.DisplayMember = "Madocgia";
                cmb_madg.ValueMember = "Madocgia";
                cmb_madg.DataSource = docgia;

                cmb_hoten.DisplayMember = "Hoten";
                cmb_hoten.ValueMember = "Madocgia";
                cmb_hoten.DataSource = docgia;
                DataTable sach = DataProvider.Instance.ExecuteQuery("EXEC dbo.hienthiphieutra @madocgia = " + madocgia + "");
                if (sach.Rows.Count > 0)
                {
                    cmb_masach.DisplayMember = "Masach";
                    cmb_masach.ValueMember = "Masach";
                    cmb_masach.DataSource = sach;

                    cmb_tensach.DisplayMember = "Tendausach";
                    cmb_tensach.ValueMember = "Masach";
                    cmb_tensach.DataSource = sach;
                }

                
                tongno = hienthitongno();
                Txt_TongNo.Text = tongno.ToString();
            }
            else
            {
                MessageBox.Show("Tất cả Sách đã được trả");
                check = true;
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


        void hienthitien()
        {
            if (listView_sach.Items.Count > 0)
            {
                float tienphatkynay = 0;
                foreach (ListViewItem item in listView_sach.Items)
                    tienphatkynay += (float)Convert.ToDouble(item.SubItems[4].Text);

                tongno = hienthitongno();
                tongno += tienphatkynay;
                Txt_tienphat.Text = tienphatkynay.ToString();
                Txt_TongNo.Text = tongno.ToString();

            }
            else
            {
                tongno = hienthitongno();
                Txt_TongNo.Text = tongno.ToString();
                Txt_tienphat.ResetText();
            }
        }

        float hienthitongno()
        {
            return (float)Convert.ToDouble(DataProvider.Instance.ExecuteReader("SELECT Tongno FROM dbo.DOC_GIA WHERE Madocgia='" + Convert.ToInt32(cmb_madg.SelectedValue) + "'"));
        }


        #endregion
        #region event

        private void button_lpt_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmb_madg_SelectedIndexChanged(object sender, EventArgs e)
        {
            int madocgia = Convert.ToInt32(cmb_madg.SelectedValue);

            DataTable sach = DataProvider.Instance.ExecuteQuery("EXEC dbo.hienthiphieutra @madocgia = " + madocgia + "");
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

            tongno = hienthitongno();
            Txt_TongNo.Text = tongno.ToString();
            Txt_tienphat.ResetText();
        }

        private void bt_themsach_Click(object sender, EventArgs e)
        {
            int masach = Convert.ToInt32(cmb_masach.SelectedValue);
            if((kiemtra(masach)==true)&&(masach.ToString()!=""))
            {
                List<PhieuTraDTO> danhsachphieutra = PhieuTraDAO.Instance.hienthiphieutra(masach);
                foreach (PhieuTraDTO item in danhsachphieutra)
                {
                    ListViewItem ds = new ListViewItem(item.Masach.ToString());
                    ds.SubItems.Add(item.Tensach);
                    ds.SubItems.Add(item.Ngaymuon.ToString());
                    ds.SubItems.Add(item.Songaymuon.ToString());
                    ds.SubItems.Add(item.Tienphattungsach);
                    listView_sach.Items.Add(ds);
                }
            }
            hienthitien();
            
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
            hienthitien();
        }

        DateTime layngaymuon(int madocgia, int masach)
        {
            DateTime ngaymuon = Convert.ToDateTime(DataProvider.Instance.ExecuteReader("EXEC dbo.layngaymuon @masach = " + masach + " ,  @madocgia = " + madocgia + ""));
            return ngaymuon;
        }
        int maphiemuon(int madocgia, int masach)
        {
            int maphiemuon = Convert.ToInt32(DataProvider.Instance.ExecuteReader("EXEC dbo.laymaphieumuon @masach = " + masach + " ,  @madocgia = " + madocgia + ""));
            return maphiemuon;
        }

        private void button_lpm_lapphieumuon_Click(object sender, EventArgs e)
        {
            if(listView_sach.Items.Count>0)
            {
                int madocgia = Convert.ToInt32(cmb_madg.SelectedValue);
                float tienphatkynay = (float)Convert.ToDouble(Txt_tienphat.Text);
                float tongnohientai = (float)Convert.ToDouble(Txt_TongNo.Text);

                int rs = DataProvider.Instance.ExecuteNonQuery("INSERT INTO dbo.PHIEU_TRA ( Madocgia, Ngaytra, Tienphat ) VALUES  ( "+madocgia+",GETDATE(), '"+tienphatkynay+"' )");

                int result = 0, masach;

                if (rs > 0)
                {
                    int max = PhieuTraDAO.Instance.getmax_phieutra();
                    foreach (ListViewItem item in listView_sach.Items)
                    {
                        float tienphattungsach = (float)Convert.ToDouble(item.SubItems[4].Text);
                        int songaytre = Convert.ToInt32(item.SubItems[3].Text);
                        masach = Convert.ToInt32(item.Text);

                        result = DataProvider.Instance.ExecuteNonQuery("INSERT INTO dbo.CHITIET_PHIEUTRA ( Maphieutra , Masach, Ngaymuon ,Songaytre , Tienphattungsach)VALUES  ( " + max + "  ," + masach + " ,'" + layngaymuon(madocgia, masach) + "', '" + songaytre + "', '" + tienphattungsach + "' )");

                        DataProvider.Instance.ExecuteNonQuery("UPDATE dbo.CHITIET_PHIEUMUON SET tinhtrang='1' WHERE Masach='" + masach + "'AND Maphieumuon='"+maphiemuon(madocgia,masach)+"'");


                        DataProvider.Instance.ExecuteNonQuery("UPDATE dbo.CUONSACH SET Matinhtrang='1' WHERE Masach='" + masach + "'");

                    }
                }
                if (result > 0)
                {
                    DataProvider.Instance.ExecuteNonQuery("UPDATE dbo.DOC_GIA SET Sosachmuon-='" + listView_sach.Items.Count + "' WHERE Madocgia='" + madocgia + "'");

                    DataProvider.Instance.ExecuteNonQuery("UPDATE dbo.DOC_GIA SET Tongno ='" + tongnohientai + "' WHERE Madocgia='" + madocgia + "'");

                    MessageBox.Show("Thêm Mới Thành Công");

                  

                    listView_sach.Items.Clear();

                    hienthi();
                    if (check == true)
                        this.Close();
                }
            }
        }

        #endregion

        private void listView_sach_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
