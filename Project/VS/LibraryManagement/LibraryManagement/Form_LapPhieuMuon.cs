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
    public partial class Form_LapPhieuMuon : Form
    {
        public Form_LapPhieuMuon()
        {
            InitializeComponent();
            dateTimePicker_lpm_ngaymuon.Value = DateTime.Today;
            hienthi();
        }

        #region method
        void hienthi()
        {
            DataTable docgia = DataProvider.Instance.ExecuteQuery("SELECT Madocgia,Hoten FROM dbo.DOC_GIA");
            if (docgia.Rows.Count > 0)
            {
                cmb_lpm_madg.DisplayMember = "Madocgia";
                cmb_lpm_madg.ValueMember = "Madocgia";
                cmb_lpm_madg.DataSource = docgia;

                cmb_hoten.DisplayMember = "Hoten";
                cmb_hoten.ValueMember = "Madocgia";
                cmb_hoten.DataSource = docgia;
            }
            DataTable sach = DataProvider.Instance.ExecuteQuery("SELECT Masach,Tendausach FROM dbo.DAUSACH,dbo.CUONSACH WHERE CUONSACH.Madausach=DAUSACH.Madausach AND Matinhtrang='1'");
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
            int madocgia = Convert.ToInt32(cmb_lpm_madg.SelectedValue);
            int thamso = Convert.ToInt32(DataProvider.Instance.ExecuteReader("SELECT Giatri FROM dbo.THAM_SO WHERE Tenthamso='soluongsachtoida'"));

            int sosachmuon = Convert.ToInt32(DataProvider.Instance.ExecuteReader("SELECT Sosachmuon FROM dbo.DOC_GIA WHERE Madocgia='" + madocgia + "'"));

            if (listView_sach.Items.Count + sosachmuon >= thamso)
            {
                MessageBox.Show("Độc Giả đang mượn " + sosachmuon + " sách!\nSố sách mượn không được vượt quá " + thamso + "");
                return false;
            }
            if (listView_sach.Items.Count >= thamso)
            {
                MessageBox.Show("Số sách mượn không được vượt quá " + thamso + "");
                return false;
            }
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
            int tinhtrang = Convert.ToInt32(DataProvider.Instance.ExecuteReader("SELECT tinhtrang FROM dbo.DOC_GIA WHERE Madocgia='" + madocgia + "'"));
            if (tinhtrang == 2)
            {
                MessageBox.Show("Thẻ độc giả đã quá hạn! Không thể mượn.");
                return false;
            }
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC dbo.kiemtradocgiamuonsachquahan @madocgia = '" + madocgia + "'");
            if (data.Rows.Count > 0)
            {
                MessageBox.Show("Độc giả có sách mượn quá hạn! Không thể mượn");
                return false;
            }
            return true;
        }

        void themsach()
        {
            int masach = Convert.ToInt32(cmb_masach.SelectedValue);

            if (kiemtra(masach) == true)
            {
                List<LapPhieuMuonDTO> danhsachpm = PhieuMuonDAO.Instance.hienthiphieumuon(masach);
                foreach (LapPhieuMuonDTO item in danhsachpm)
                {
                    ListViewItem ds = new ListViewItem(item.Masach.ToString());
                    ds.SubItems.Add(item.Tensach);
                    ds.SubItems.Add(item.Theloai);
                    ds.SubItems.Add(item.Tentacgia);
                    listView_sach.Items.Add(ds);
                }
            }
        }

        #endregion
        #region event 
        private void button_lpm_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
      


        private void bt_themsach_Click(object sender, EventArgs e)
        {
            themsach();
        }

        private void bt_xoasach_Click(object sender, EventArgs e)
        {
            if(listView_sach.Items.Count>0)
            {
                foreach(ListViewItem item in listView_sach.Items)
                {
                    if (item.Checked == true)
                        item.Remove();
                }
            }
        }

        private void button_lpm_lapphieumuon_Click(object sender, EventArgs e)
        {
            if (listView_sach.Items.Count > 0)
            {
                int madocgia = Convert.ToInt32(cmb_lpm_madg.SelectedValue);

                DateTime ngaymuon = dateTimePicker_lpm_ngaymuon.Value;
               
                int thamsongayhethan = Convert.ToInt32(DataProvider.Instance.ExecuteReader("SELECT Giatri FROM dbo.THAM_SO WHERE Tenthamso='songaymuontoida'"));

                DateTime ngayhethan = ngaymuon.AddDays(thamsongayhethan);

                int rs = DataProvider.Instance.ExecuteNonQuery("EXEC dbo.themphieumuon @madocgia = " + madocgia + " , @ngaymuon = '" + ngaymuon + "' ");

                int result = 0;

                if (rs > 0)
                {
                    int max = PhieuMuonDAO.Instance.getmax_pm();
                    foreach (ListViewItem item in listView_sach.Items)
                    {
                        result = DataProvider.Instance.ExecuteNonQuery("EXEC dbo.themchitietphieumuon @maphieumuon = " + max + ",  @masach = " + Convert.ToInt32(item.Text) + " ,   @ngayhethan = '" + ngayhethan + "' ");

                        DataProvider.Instance.ExecuteNonQuery("UPDATE dbo.CUONSACH SET Matinhtrang='2' WHERE Masach='" + Convert.ToInt32(item.Text) + "'");
                    }
                }
                if (result > 0)
                {
                    MessageBox.Show("Thêm Mới Thành Công");
                    DataProvider.Instance.ExecuteNonQuery("UPDATE dbo.DOC_GIA SET Sosachmuon+='" + listView_sach.Items.Count + "' WHERE Madocgia='" + madocgia + "'");
                    
                    listView_sach.Items.Clear();
                    hienthi();
                }
            }
        }

        private void cmb_lpm_madg_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView_sach.Items.Clear();
        }
        #endregion
    }
}
