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
    public partial class Form_ChiTietSach : Form
    {
        private SachDTO sach;
        public SachDTO Sach
        {
            get
            {
                return sach;
            }

            set
            {
                sach = value;
            }
        }
        public Form_ChiTietSach(int id)
        {
            InitializeComponent();
            sach = SachDAO.Instance.GetBookByID(id);
            hienthi();
        }
        #region method
        void hienthi()
        {
            label_masach.Text = sach.Masach.ToString();

            DataTable tensach = DataProvider.Instance.ExecuteQuery("SELECT Madausach[Mã Đầu Sách],Tendausach[Tên Đầu Sách] FROM dbo.DAUSACH");
            cmb_tensach.DisplayMember = "Tên Đầu Sách";
            cmb_tensach.ValueMember = "Mã Đầu Sách";
            cmb_tensach.DataSource = tensach;
            cmb_tensach.Text = DataProvider.Instance.ExecuteReader("SELECT Tendausach FROM dbo.DAUSACH WHERE Madausach='"+sach.Madausach+"'");

            DataTable tinhtrang = DataProvider.Instance.ExecuteQuery("SELECT Matinhtrang[Mã Tình Trạng],Tinhtrang[Tình Trạng] FROM dbo.TINHTRANG_SACH");
            cmb_tinhtrang.DisplayMember = "Tình Trạng";
            cmb_tinhtrang.ValueMember = "Mã Tình Trạng";
            cmb_tinhtrang.DataSource = tinhtrang;
            cmb_tinhtrang.Text = DataProvider.Instance.ExecuteReader("SELECT Tinhtrang FROM dbo.TINHTRANG_SACH,dbo.CUONSACH WHERE CUONSACH.Matinhtrang=TINHTRANG_SACH.Matinhtrang AND Masach='"+sach.Masach+"'");

            txt_theloai.Text = DataProvider.Instance.ExecuteReader("SELECT Ten FROM dbo.DAUSACH,dbo.THE_LOAI WHERE DAUSACH.Matheloai=THE_LOAI.Matheloai AND Madausach='" + sach.Madausach + "'");
            txt_nhaxb.Text = DataProvider.Instance.ExecuteReader("SELECT TenNXB FROM dbo.DAUSACH,dbo.NHA_XUAT_BAN WHERE DAUSACH.MaNXB=NHA_XUAT_BAN.MaNXB AND Madausach='" + sach.Madausach + "'");
            txt_ngonngu.Text = DataProvider.Instance.ExecuteReader("SELECT Ngonngu FROM dbo.DAUSACH,dbo.NGON_NGU WHERE DAUSACH.Mangonngu=NGON_NGU.Mangonngu AND Madausach='" + sach.Madausach + "'");
            txt_namxb.Text = DataProvider.Instance.ExecuteReader("SELECT Namxuatban FROM dbo.DAUSACH WHERE Madausach='" + sach.Madausach + "'");
            txt_trigia.Text = DataProvider.Instance.ExecuteReader("SELECT Trigia FROM dbo.DAUSACH WHERE Madausach='" + sach.Madausach + "'");
    
            dateTimePicker_cts_ngaynhap.Value = sach.Ngaynhap;

            DataTable tacgia = DataProvider.Instance.ExecuteQuery("SELECT TAC_GIA.Matacgia,Tentacgia FROM dbo.TACGIA_DAUSACH,dbo.TAC_GIA WHERE TAC_GIA.Matacgia=TACGIA_DAUSACH.Matacgia AND Madausach='" + sach.Madausach + "'");
            dataGridView_tacgia.DataSource = tacgia;

        }
        private int namxuatban;
        void hienthisausukien()
        {
            int madausach = sach.Madausach;
            if (cmb_tensach.ValueMember != "")
                madausach = Convert.ToInt32(cmb_tensach.SelectedValue);
            txt_theloai.Text = DataProvider.Instance.ExecuteReader("SELECT Ten FROM dbo.DAUSACH,dbo.THE_LOAI WHERE DAUSACH.Matheloai=THE_LOAI.Matheloai AND Madausach='" + madausach + "'");
            txt_nhaxb.Text = DataProvider.Instance.ExecuteReader("SELECT TenNXB FROM dbo.DAUSACH,dbo.NHA_XUAT_BAN WHERE DAUSACH.MaNXB=NHA_XUAT_BAN.MaNXB AND Madausach='" + madausach + "'");
            txt_ngonngu.Text = DataProvider.Instance.ExecuteReader("SELECT Ngonngu FROM dbo.DAUSACH,dbo.NGON_NGU WHERE DAUSACH.Mangonngu=NGON_NGU.Mangonngu AND Madausach='" + madausach + "'");
            txt_namxb.Text = DataProvider.Instance.ExecuteReader("SELECT Namxuatban FROM dbo.DAUSACH WHERE Madausach='" + madausach + "'");
            txt_trigia.Text = DataProvider.Instance.ExecuteReader("SELECT Trigia FROM dbo.DAUSACH WHERE Madausach='" + madausach + "'");

            DataTable tacgia = DataProvider.Instance.ExecuteQuery("SELECT TAC_GIA.Matacgia,Tentacgia FROM dbo.TACGIA_DAUSACH,dbo.TAC_GIA WHERE TAC_GIA.Matacgia=TACGIA_DAUSACH.Matacgia AND Madausach='" + madausach + "'");
            dataGridView_tacgia.DataSource = tacgia;

            namxuatban = Convert.ToInt32(DataProvider.Instance.ExecuteReader("SELECT YEAR(Namxuatban) FROM dbo.DAUSACH WHERE Madausach='" + madausach + "'"));
        }
        #endregion
        private void button_chinhsua_Click(object sender, EventArgs e)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.CUONSACH,dbo.CHITIET_PHIEUMUON WHERE CHITIET_PHIEUMUON.Masach=CUONSACH.Masach AND dbo.CUONSACH.Masach='" + sach.Masach + "' AND tinhtrang!='1'");
            if (data.Rows.Count > 0)
                MessageBox.Show("Không Thể Chỉnh Sửa Sách Đang Cho Mượn");
            else
            {
                cmb_tensach.Enabled = true;
                cmb_tinhtrang.Enabled = true;
                dateTimePicker_cts_ngaynhap.Enabled = true;

                label_cts_tensach.ForeColor = Color.Red;
                label_tinhtrang.ForeColor = Color.Red;
                label_ngaynhap.ForeColor = Color.Red;
            }
        }

        private void cmb_tensach_SelectedIndexChanged(object sender, EventArgs e)
        {
            hienthisausukien();
        }

        private void button_luu_Click(object sender, EventArgs e)
        {
            int matinhtrang = Convert.ToInt32(cmb_tinhtrang.SelectedValue);
            int madausach = sach.Madausach;
                madausach = Convert.ToInt32(cmb_tensach.SelectedValue);
            int rs = 0;
            if (madausach != sach.Madausach)
            {
                rs = DataProvider.Instance.ExecuteNonQuery("UPDATE dbo.CUONSACH SET Madausach='" + madausach + "',Matinhtrang='" + matinhtrang + "',Ngaynhap='" + dateTimePicker_cts_ngaynhap.Value + "' WHERE Masach='" + sach.Masach + "'");
                DataProvider.Instance.ExecuteNonQuery("UPDATE dbo.DAUSACH SET Soluong+='1' WHERE Madausach='"+madausach+"'");
                DataProvider.Instance.ExecuteNonQuery("UPDATE dbo.DAUSACH SET Soluong-='1' WHERE Madausach='" + sach.Madausach + "'");
            }
            else
                rs = DataProvider.Instance.ExecuteNonQuery("UPDATE dbo.CUONSACH SET Madausach='" + madausach + "',Matinhtrang='" + matinhtrang + "',Ngaynhap='" + dateTimePicker_cts_ngaynhap.Value + "' WHERE Masach='" + sach.Masach + "'");
            if (rs>0)
            {
                MessageBox.Show("Lưu Thành Công");
                cmb_tensach.Enabled = false;
                cmb_tinhtrang.Enabled = false;
                dateTimePicker_cts_ngaynhap.Enabled = false;

                label_cts_tensach.ForeColor = Color.Black;
                label_tinhtrang.ForeColor = Color.Black;
                label_ngaynhap.ForeColor = Color.Black;
            }
        }

        private void dateTimePicker_cts_ngaynhap_ValueChanged(object sender, EventArgs e)
        {
            int ngaynhap = dateTimePicker_cts_ngaynhap.Value.Year;
            int temp = ngaynhap - namxuatban;
            if (temp < 0)
            {
                MessageBox.Show("Năm Nhập Không Được Nhỏ Hơn Năm Xuất Bản");
                dateTimePicker_cts_ngaynhap.ResetText();
            }
        }

        private void button_cts_xoa_Click(object sender, EventArgs e)
        {
             string tensach = cmb_tensach.SelectedText;
             if (MessageBox.Show("Bạn có thực sự muốn xóa SÁCH " + sach.Masach + " - " + tensach + "\nChú ý: Khi xóa sách, các phiếu có liên quan đến sách cũng bị xóa theo.", "Thông Báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
              {
                 int temp = SachDAO.Instance.xoasach(sach.Masach);
                 if (temp == 1)
                  {
                       MessageBox.Show("Xóa Sách Thành Công!!");
                       this.Close();
                  }
                  if (temp == -1)
                      MessageBox.Show("Không Thể Xóa Sách Đang Cho Mượn");
                }
            }

        private void button_cts_thoat_Click(object sender, EventArgs e)
        {
            if (cmb_tensach.Enabled == true)
            {
                if (MessageBox.Show("Bạn chưa lưu dữ liệu! Bạn có chắc chắn muốn thoát không?\nNếu thoát, các dữ liệu vừa thay đổi sẽ không được cập nhật! ", "Thông Báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    this.Close();
            }
            if (cmb_tensach.Enabled == false)
                this.Close();
        }
    }
}
