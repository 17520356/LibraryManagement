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
    public partial class Form_ThemDauSach : Form
    {
        public Form_ThemDauSach()
        {
            InitializeComponent();
            hienthidausach();
        }

        #region method
        void hienthidausach()
        {
            DataTable theloai = DataProvider.Instance.ExecuteQuery("SELECT Matheloai[Mã Thể Loại],Ten[Thể Loại] FROM dbo.THE_LOAI");
            cmb_theloai.DisplayMember = "Thể Loại";
            cmb_theloai.ValueMember = "Mã Thể Loại";
            cmb_theloai.DataSource = theloai;

            DataTable nhaxb = DataProvider.Instance.ExecuteQuery("SELECT MaNXB[Mã Nhà Xuất Bản],TenNXB[Nhà Xuất Bản] FROM dbo.NHA_XUAT_BAN");
            cmb_nhaxuatban.DisplayMember = "Nhà Xuất Bản";
            cmb_nhaxuatban.ValueMember = "Mã Nhà Xuất Bản";
            cmb_nhaxuatban.DataSource = nhaxb;

            DataTable ngonngu = DataProvider.Instance.ExecuteQuery("SELECT Mangonngu[Mã Ngôn Ngữ],Ngonngu[Ngôn Ngữ] FROM dbo.NGON_NGU");
            cmb_ngonngu.DisplayMember = "Ngôn Ngữ";
            cmb_ngonngu.ValueMember = "Mã Ngôn Ngữ";
            cmb_ngonngu.DataSource = ngonngu;

            DataTable tacgia = DataProvider.Instance.ExecuteQuery("SELECT Matacgia[Mã Tác Giả],Tentacgia[Tên Tác Giả] FROM dbo.TAC_GIA");
            comboBox_tacgia.DisplayMember = "Tên Tác Giả";
            comboBox_tacgia.ValueMember = "Mã Tác Giả";
            comboBox_tacgia.DataSource = tacgia;
        }

        void kiemtranamxb()
        {
            int khoangcachnamxb = Convert.ToInt32(DataProvider.Instance.ExecuteReader("SELECT Giatri FROM dbo.THAM_SO WHERE Tenthamso='khoangcachnamxuatban'"));
            TimeSpan time = DateTime.Now - dateTimePicker_namxuatban.Value;
            if (time.TotalDays / 365 > khoangcachnamxb)
            { 
                MessageBox.Show("Chỉ Nhận Sách Xuất Bản Trong " + khoangcachnamxb + " Năm Trở Lại!");
                dateTimePicker_namxuatban.ResetText();
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

        void themdausach()
        {
            string tendausach = txt_tendausach.Text;
            int matheloai = 1, mangonngu = 1, manhasx = 1;
            if (cmb_theloai.ValueMember != "")
                matheloai = Convert.ToInt32(cmb_theloai.SelectedValue);
            if (cmb_nhaxuatban.ValueMember != "")
                manhasx = Convert.ToInt32(cmb_nhaxuatban.SelectedValue);
            if (cmb_ngonngu.ValueMember != "")
                mangonngu = Convert.ToInt32(cmb_ngonngu.SelectedValue);
            DateTime ngayxuatban = dateTimePicker_namxuatban.Value;
            string trigia = txt_trigia.Text;
            bool rs = false;
            if (SachDAO.Instance.themdausach(tendausach, matheloai, manhasx, mangonngu, trigia, ngayxuatban) == true)
            {
                foreach (ListViewItem item in listView_tacgia.Items)
                {
                    rs = SachDAO.Instance.themtacgia_dausach(Convert.ToInt32(item.Text));
                }
                if (rs == true)
                {
                    MessageBox.Show("Thêm Mới Thành Công");
                    txt_tendausach.ResetText();
                    txt_trigia.ResetText();
                    listView_tacgia.Items.Clear();
                }
            }
        }
        #endregion


        #region event
        private void dateTimePicker_namxuatban_ValueChanged(object sender, EventArgs e)
        {
            kiemtranamxb();
        }

        private void buttonthem_Click(object sender, EventArgs e)
        {
            
            kiemtranamxb();
       
            if (txt_tendausach.Text == "")
                MessageBox.Show("Tên Đầu Sách Không Được Để Trống");
            else
            {

                if (txt_trigia.Text == "")
                    MessageBox.Show("Trị Giá Không Được Để Trống");
                else
                {
                    if (listView_tacgia.Items.Count <= 0)
                        MessageBox.Show("Tác Giả Không Được Để Trống");
                    else
                    {
                        if (SachDAO.Instance.kiemtratendausach(txt_tendausach.Text) == true)
                        {
                            MessageBox.Show("Tên Đầu Sách Đã Tồn Tại\nMời Nhập Lại");
                            txt_tendausach.ResetText();
                        }
                        else
                        {
                            if (MessageBox.Show("Bạn muốn thêm Đầu Sách "+txt_tendausach.Text+"", "Thông Báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                                themdausach();
                        }
                    }
                }
            }
        }

        private void button_themtg_Click(object sender, EventArgs e)
        {
            int matacgia = 1;
            if (comboBox_tacgia.ValueMember != "")
                matacgia = Convert.ToInt32(comboBox_tacgia.SelectedValue);
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
            if(check==true)
                themtacgia(matacgia);

        }

        private void button_xoatg_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView_tacgia.Items)
            {
                 
                if (item.Checked == true)
                    item.Remove();
            }
        }      

        private void txt_trigia_TextChanged(object sender, EventArgs e)
        {
           if( SachDAO.Instance.IsNumber(txt_trigia.Text)==false)
            {
                MessageBox.Show("Giá Trị Nhập Sai\nMời Nhập Lại!");
                txt_trigia.ResetText();
            }
        }

        private void button_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion
    }
}
