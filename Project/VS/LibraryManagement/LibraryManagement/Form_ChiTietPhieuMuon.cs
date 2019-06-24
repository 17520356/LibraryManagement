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
    public partial class Form_ChiTietPhieuMuon : Form
    {
        private int maphieumuon;
        public Form_ChiTietPhieuMuon(int id)
        {
            InitializeComponent();
            this.maphieumuon = id;
            hienthi();
        }
        #region method
        void hienthi()
        {
            hienthicombobox();
            List<ChiTietPhieuMuonDTO> chitietpm = ChiTietPhieuMuonDAO.Instance.hienthiphieumuon(maphieumuon);
            dateTimePicker_lpm_ngaymuon.Value = Convert.ToDateTime(DataProvider.Instance.ExecuteReader("SELECT Ngaymuon FROM dbo.PHIEU_MUON WHERE Maphieumuon='"+maphieumuon+"'"));
            foreach(ChiTietPhieuMuonDTO item in chitietpm)
            {
                ListViewItem danhsach = new ListViewItem(item.Masach.ToString());
                danhsach.SubItems.Add(item.Tensach);
                danhsach.SubItems.Add(item.Ngayhethan.ToString());
                danhsach.SubItems.Add(item.Tinhtrang);
                listView_sach.Items.Add(danhsach);
            }
        }
        void hienthicombobox()
        {
            DataTable docgia = DataProvider.Instance.ExecuteQuery("SELECT Madocgia,Hoten FROM dbo.DOC_GIA WHERE tinhtrang='1'");
            if (docgia.Rows.Count > 0)
            {
                cmb_madg.DisplayMember = "Madocgia";
                cmb_madg.ValueMember = "Madocgia";
                cmb_madg.DataSource = docgia;
                cmb_madg.Text = DataProvider.Instance.ExecuteReader("SELECT DOC_GIA.Madocgia FROM dbo.PHIEU_MUON,dbo.DOC_GIA WHERE DOC_GIA.Madocgia=PHIEU_MUON.Madocgia AND Maphieumuon='"+maphieumuon+"'");

                cmb_hoten.DisplayMember = "Hoten";
                cmb_hoten.ValueMember = "Madocgia";
                cmb_hoten.DataSource = docgia;
                cmb_hoten.Text = DataProvider.Instance.ExecuteReader("SELECT DOC_GIA.Hoten FROM dbo.PHIEU_MUON,dbo.DOC_GIA WHERE DOC_GIA.Madocgia=PHIEU_MUON.Madocgia AND Maphieumuon='" + maphieumuon + "'");
            }
            DataTable sach = DataProvider.Instance.ExecuteQuery("SELECT Masach,Tendausach FROM dbo.CUONSACH,dbo.DAUSACH WHERE  CUONSACH.Madausach=DAUSACH.Madausach AND Matinhtrang='1'");
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
        #endregion
        #region event
        private void button_ctpm_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }



    

        private void button_giahan_Click(object sender, EventArgs e)
        {
            int giahan,masach,tinhtrang;
            string thongbaothanhcong = "";
            string thongbaothatbai = "";
            foreach (ListViewItem item in listView_sach.Items)
            {
                if (item.Checked == true)
                {
                    masach = Convert.ToInt32(item.Text);
                    giahan = Convert.ToInt32(DataProvider.Instance.ExecuteReader("SELECT giahan FROM dbo.CHITIET_PHIEUMUON WHERE Masach='" + masach + "' AND Maphieumuon='" + maphieumuon + "'"));
                    tinhtrang = Convert.ToInt32(DataProvider.Instance.ExecuteReader("SELECT tinhtrang FROM dbo.CHITIET_PHIEUMUON WHERE Masach='" + masach + "' AND Maphieumuon='" + maphieumuon + "'"));
                    if (tinhtrang != 1)
                    {
                        if (giahan == 1)
                        {
                            DataProvider.Instance.ExecuteNonQuery("UPDATE dbo.CHITIET_PHIEUMUON SET Ngayhethan=DATEADD(DAY,3,Ngayhethan) WHERE Maphieumuon='" + maphieumuon + "' AND Masach='" + masach + "'");
                            DataProvider.Instance.ExecuteNonQuery("UPDATE dbo.CHITIET_PHIEUMUON SET giahan='2' WHERE Maphieumuon='" + maphieumuon + "' AND Masach='" + masach + "'");
                            thongbaothanhcong += masach + " - ";
                        }
                        else
                            thongbaothatbai += masach + " - ";
                    }
                    else
                        MessageBox.Show("Sách đã trả.");
                }
            }
            if (thongbaothanhcong != "")
                MessageBox.Show("Gia hạn thành công sách " + thongbaothanhcong);
            if (thongbaothatbai != "")
                MessageBox.Show("Sách " + thongbaothatbai + " đã gia hạn.\nKhông thể gia hạn thêm.");
            listView_sach.Items.Clear();
            hienthi();
        }
        #endregion
    }
}
