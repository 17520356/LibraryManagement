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
    public partial class Form_ChiTietDauSach : Form
    {
        private int madausach;
        private List<TacGiaDTO> danhsachduphong;
        public Form_ChiTietDauSach(int id)
        {
            InitializeComponent();
            this.madausach = id;
            danhsachduphong = SachDAO.Instance.tacgia_dausach(madausach);
            hienthi();

        }
        #region method

        void hienthi()
        {
            label_madausach.Text = madausach.ToString();

            txt_tendausach.Text = DataProvider.Instance.ExecuteReader("SELECT Tendausach FROM dbo.DAUSACH WHERE Madausach='" + madausach + "'");

            DataTable theloai = DataProvider.Instance.ExecuteQuery("SELECT Matheloai[Mã Thể Loại],Ten[Thể Loại] FROM dbo.THE_LOAI");
            cmb_theloai.DisplayMember = "Thể Loại";
            cmb_theloai.ValueMember = "Mã Thể Loại";
            cmb_theloai.DataSource = theloai;
            cmb_theloai.Text = DataProvider.Instance.ExecuteReader("SELECT Ten FROM dbo.THE_LOAI,dbo.DAUSACH WHERE DAUSACH.Matheloai=THE_LOAI.Matheloai AND Madausach='" + madausach + "'");

            DataTable nhaxb = DataProvider.Instance.ExecuteQuery("SELECT MaNXB[Mã Nhà Xuất Bản],TenNXB[Nhà Xuất Bản] FROM dbo.NHA_XUAT_BAN");
            cmb_nhaxuatban.DisplayMember = "Nhà Xuất Bản";
            cmb_nhaxuatban.ValueMember = "Mã Nhà Xuất Bản";
            cmb_nhaxuatban.DataSource = nhaxb;
            cmb_nhaxuatban.Text = DataProvider.Instance.ExecuteReader("SELECT TenNXB FROM dbo.NHA_XUAT_BAN,dbo.DAUSACH WHERE DAUSACH.MaNXB=NHA_XUAT_BAN.MaNXB AND Madausach='" + madausach + "'");

            DataTable ngonngu = DataProvider.Instance.ExecuteQuery("SELECT Mangonngu[Mã Ngôn Ngữ],Ngonngu[Ngôn Ngữ] FROM dbo.NGON_NGU");
            cmb_ngonngu.DisplayMember = "Ngôn Ngữ";
            cmb_ngonngu.ValueMember = "Mã Ngôn Ngữ";
            cmb_ngonngu.DataSource = ngonngu;
            cmb_ngonngu.Text = DataProvider.Instance.ExecuteReader("SELECT Ngonngu FROM dbo.NGON_NGU,dbo.DAUSACH WHERE DAUSACH.Mangonngu=NGON_NGU.Mangonngu AND Madausach='" + madausach + "'");

            DataTable tacgia = DataProvider.Instance.ExecuteQuery("SELECT Matacgia[Mã Tác Giả],Tentacgia[Tên Tác Giả] FROM dbo.TAC_GIA");
            comboBox_tacgia.DisplayMember = "Tên Tác Giả";
            comboBox_tacgia.ValueMember = "Mã Tác Giả";
            comboBox_tacgia.DataSource = tacgia;
            comboBox_tacgia.Text = DataProvider.Instance.ExecuteReader("SELECT Tentacgia FROM dbo.TAC_GIA,dbo.TACGIA_DAUSACH WHERE TAC_GIA.Matacgia=TACGIA_DAUSACH.Matacgia AND Madausach='" + madausach + "'");

            txt_trigia.Text = DataProvider.Instance.ExecuteReader("SELECT Trigia FROM dbo.DAUSACH WHERE Madausach='" + madausach + "'");

            List<TacGiaDTO> dstacgia = SachDAO.Instance.tacgia_dausach(madausach);
            foreach (TacGiaDTO item in dstacgia)
            {
                ListViewItem ListItem = new ListViewItem(item.Matacgia.ToString());
                ListItem.SubItems.Add(item.Tentacgia);
                listView_tacgia.Items.Add(ListItem);
            }

        }

        void themtacgia(int matacgia)
        {
            List<TacGiaDTO> dstacgia = SachDAO.Instance.hienthitacgia(matacgia);

            foreach (TacGiaDTO item in dstacgia)
            {
                ListViewItem lsItem = new ListViewItem(item.Matacgia.ToString());
                lsItem.SubItems.Add(item.Tentacgia);
                listView_tacgia.Items.Add(lsItem);
            }
        }

        void capnhatdsduphong()
        {
            DataProvider.Instance.ExecuteNonQuery("DELETE dbo.TACGIA_DAUSACH WHERE Madausach='" + madausach + "'");
            foreach (TacGiaDTO item in danhsachduphong)
            {
                DataProvider.Instance.ExecuteNonQuery("INSERT INTO dbo.TACGIA_DAUSACH (Matacgia, Madausach )VALUES ( " + item.Matacgia + ", " + madausach + ")");
            }

        }

        public bool kiemtra()
        {
            if (txt_tendausach.Text == "")
            {
                MessageBox.Show("Tên Đầu Sách Không Được Để Trống");
                return false;
            }
            if (txt_trigia.Text == "")
            {
                MessageBox.Show("Trị Giá Không Được Để Trống");
                return false;
            }
            if (txt_tendausach.Text != "")
            {
                DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.DAUSACH WHERE Tendausach=N'" + txt_tendausach.Text + "' AND Madausach!='" + madausach + "'");
                if (data.Rows.Count > 0)
                {
                    MessageBox.Show("Tên Đầu Sách Đã Tồn Tại\nMời Nhập Lại");
                    txt_tendausach.ResetText();
                    return false;
                }
            }
            if (listView_tacgia.Items.Count <= 0)
            {
                MessageBox.Show("Tác Giả Không Được Để Trống");
                return false;
            }
            if (txt_trigia.Text != DataProvider.Instance.ExecuteReader("SELECT Trigia FROM dbo.DAUSACH WHERE Madausach='" + madausach + "'"))
            {
                if (SachDAO.Instance.IsNumber(txt_trigia.Text) == false)
                {
                    MessageBox.Show("Giá Trị Nhập Sai\nMời Nhập Lại!");
                    txt_trigia.ResetText();
                    return false;
                }
            }
            return true;
        }

        #endregion

        #region event



        private void button_chinhsua_Click(object sender, EventArgs e)
        {
            txt_tendausach.ReadOnly = false;
            cmb_theloai.Enabled = true;
            cmb_nhaxuatban.Enabled = true;
            cmb_ngonngu.Enabled = true;
            dateTimePicker_namxuatban.Enabled = true;
            txt_trigia.ReadOnly = false;
            comboBox_tacgia.Enabled = true;
            button_themtg.Enabled = true;
            button_xoatg.Enabled = true;
        }


        private void button_luu_Click(object sender, EventArgs e)
        {
            string tendausach = txt_tendausach.Text;
            int matheloai = Convert.ToInt32(cmb_theloai.SelectedValue);
            int manhaxuatban = Convert.ToInt32(cmb_nhaxuatban.SelectedValue);
            int mangonngu = Convert.ToInt32(cmb_ngonngu.SelectedValue);
            DateTime ngayxuatban = dateTimePicker_namxuatban.Value;
            string trigia = txt_trigia.Text;

            if (kiemtra() == true)
            {
                if (SachDAO.Instance.capnhatdausach(madausach, tendausach, matheloai, manhaxuatban, mangonngu, trigia, ngayxuatban) == true)
                {
                    MessageBox.Show("Cập Nhật Thành Công");
                    txt_tendausach.ReadOnly = true;
                    cmb_theloai.Enabled = false;
                    cmb_nhaxuatban.Enabled = false;
                    cmb_ngonngu.Enabled = false;
                    dateTimePicker_namxuatban.Enabled = false;
                    txt_trigia.ReadOnly = true;
                    comboBox_tacgia.Enabled = false;
                    button_themtg.Enabled = false;
                    button_xoatg.Enabled = false;
                }
                else
                    MessageBox.Show("Cập Nhật Thất Bại");
            }
        }

        private void button_themtg_Click(object sender, EventArgs e)
        {
            int matacgia = Convert.ToInt32(comboBox_tacgia.SelectedValue);
            bool check = false;
            if (listView_tacgia.Items.Count > 0)
            {
                foreach (ListViewItem item in listView_tacgia.Items)
                {

                    if (item.Text == matacgia.ToString())
                    {
                        MessageBox.Show("Tác Giả Đã Tồn Tại");
                        check = false;
                        break;
                    }
                    else
                        check = true;

                }
            }
            else
                check = true;
            if (check == true)
            {
                themtacgia(matacgia);
                DataProvider.Instance.ExecuteNonQuery("INSERT INTO dbo.TACGIA_DAUSACH (Matacgia, Madausach )VALUES ( " + matacgia + ", " + madausach + ")");
            }
        }

        private void button_xoatg_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView_tacgia.Items)
            {

                if (item.Checked == true)
                {
                    DataProvider.Instance.ExecuteNonQuery("DELETE dbo.TACGIA_DAUSACH WHERE Madausach='" + madausach + "' AND Matacgia='" + Convert.ToInt32(item.Text) + "'");
                    item.Remove();
                }
            }
        }

        private void button_cts_thoat_Click(object sender, EventArgs e)
        {
            if (txt_tendausach.ReadOnly == false)
            {
                if (MessageBox.Show("Bạn chưa lưu dữ liệu! Bạn có chắc chắn muốn thoát không?\nNếu thoát, các dữ liệu vừa thay đổi sẽ không được cập nhật! ", "Thông Báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    capnhatdsduphong();
                    Close();
                }
            }
            else
                this.Close();
        }

        private void dateTimePicker_namxuatban_ValueChanged(object sender, EventArgs e)
        {
            int khoangcachnamxb = Convert.ToInt32(DataProvider.Instance.ExecuteReader("SELECT Giatri FROM dbo.THAM_SO WHERE Tenthamso='khoangcachnamxuatban'"));
            TimeSpan time = DateTime.Now - dateTimePicker_namxuatban.Value;
            if (time.TotalDays / 365 > khoangcachnamxb)
            {
                MessageBox.Show("Chỉ Nhận Sách Xuất Bản Trong " + khoangcachnamxb + " Năm Trở Lại!");
                dateTimePicker_namxuatban.ResetText();
            }
        }
        #endregion

        private void button_cts_xoa_Click(object sender, EventArgs e)
        {
            string tensach = DataProvider.Instance.ExecuteReader("SELECT Tendausach FROM dbo.DAUSACH WHERE Madausach='" + madausach + "'");
            if (MessageBox.Show("Bạn có thực sự muốn xóa ĐẦU SÁCH " + madausach + " - " + tensach + "\nChú ý: Khi xóa sách, các phiếu có liên quan đến sách cũng bị xóa theo.", "Thông Báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                int temp = SachDAO.Instance.xoadausach(madausach);
                if (temp == 1)
                {
                    MessageBox.Show("Xóa Đầu Sách Thành Công!!");
                    this.Close();
                }
                if (temp == 0)
                    MessageBox.Show("Xóa Thát Bại");
                if (temp == -1)
                    MessageBox.Show("Không Thể Xóa Do Có Sách Đang Cho Mượn Thuộc Đầu Sách Này");
            }
        }
    }
}
