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
    public partial class Form_ChiTietDocGia : Form
    {
        private DocGiaDTO docgia;
        private int id;
        public DocGiaDTO Docgia
        {
            get
            {
                return docgia;
            }

            set
            {
                docgia = value;
            }
        }

        public Form_ChiTietDocGia(int temp)
        {
            InitializeComponent();
            this.id = temp;
            loaddata();
            dateTimePicker_ngaysinh.MaxDate = DateTime.Now;
        }

        #region method

        void loaddata()
        {
            docgia = DocGiaDAO.Instance.GetDocGiabyID(id);
            label_ctdg_madg.Text = "Mã Độc Giả: "+docgia.Madocgia.ToString();
            if (docgia.Maloaidg == 1)
            {
                radioButton_ldg_x.Checked = true;
                radioButton_ldg_y.Checked = false;
            }
            else
            {
                radioButton_ldg_x.Checked = false;
                radioButton_ldg_y.Checked = true;
            }
            if (docgia.Ngaysinh.ToString() != "")
                txt_ngaysinh.Text = docgia.Ngaysinh.ToString();
            txt_ctdg_tendg.Text = docgia.Hoten.ToString();
            if(docgia.Diachi!="")
                txt_ctdg_diachi.Text = docgia.Diachi;
            if (docgia.Sodienthoai!= "")
                txt_ctdg_sodt.Text = docgia.Sodienthoai;
            if (docgia.Gioitinh == 1)
            {
                radioButton_ctdg_nam.Checked = true;
                radioButton_ctdg_nu.Checked = false;
            }
            else
            {
                radioButton_ctdg_nam.Checked = false;
                radioButton_ctdg_nu.Checked = true;
            }
            if (docgia.Tinhtrang == 0)
                txt_tinhtrang.Text = "không Thể Mượn";
            if(docgia.Tinhtrang==1)
                txt_tinhtrang.Text = "Có Thể Mượn";
            if (docgia.Tinhtrang == 2)
                txt_tinhtrang.Text = "Thẻ Quá Hạn";
            txt_ctdg_ssdangmuon.Text = docgia.Sosachmuon.ToString();
            txt_ctdg_tongno.Text = docgia.Tongno;
            txt_ngaylapthe.Text = docgia.Ngaylapthe.ToString();
            TimeSpan time = docgia.Ngayhethan - DateTime.Now;
            if(time.Days>=0)
                numericUpDown_ctdg.Value = time.Days;
            //

           

        }

        void UpdateDocGia()
        {
            string tendg = txt_ctdg_tendg.Text;
            int loaidg = 1;
            if (radioButton_ldg_x.Checked == true)
                loaidg = 1;
            else
                loaidg = 2;
            int gioitinh = 1;
            if (radioButton_ctdg_nam.Checked == true)
                gioitinh = 1;
            else
                gioitinh = 2;
            string diachi = txt_ctdg_diachi.Text;
            string sodt = txt_ctdg_sodt.Text;
            string email = txt_ctdg_email.Text;
            DateTime ngaysinh = dateTimePicker_ngaysinh.Value;
            TimeSpan time = DateTime.Now - ngaysinh;
            int tuoitoithieu = Convert.ToInt32(DataProvider.Instance.ExecuteReader("SELECT Giatri FROM dbo.THAM_SO WHERE Tenthamso='tuoitoithieu'"));
            int tuoitoida = Convert.ToInt32(DataProvider.Instance.ExecuteReader("SELECT Giatri FROM dbo.THAM_SO WHERE Tenthamso='tuoitoida'"));
            
            if ((time.Days / 365 < tuoitoithieu) || (time.Days / 365 > tuoitoida))
            {
                if (time.Days / 365 < tuoitoithieu)
                    MessageBox.Show("Tuổi của độc giả không được nhỏ hơn " + tuoitoithieu + "\n Mời Nhập Lại!");
                if (time.Days / 365 > tuoitoida)
                    MessageBox.Show("Tuổi của độc giả không được lớn hơn " + tuoitoida + "\n Mời Nhập Lại!");


            }
            else
            {
                if (tendg != "")
                {
                    if (DocGiaDAO.Instance.update_docgia(docgia.Madocgia, tendg, loaidg, ngaysinh, gioitinh, diachi, sodt, email) == true)
                        MessageBox.Show("Cập Nhật Thành Công");
                    loaddata();
                }
            }
        }

        #endregion

        #region event
        private void button_ctdg_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_ctdg_chinhsua_Click(object sender, EventArgs e)
        {
            txt_ctdg_tendg.ReadOnly = false;
            radioButton_ldg_y.Enabled = true;
            radioButton_ldg_x.Enabled = true;
            txt_ngaysinh.Visible = false;
            dateTimePicker_ngaysinh.Visible = true;
            if(docgia.Ngaysinh.ToString()!="")
                dateTimePicker_ngaysinh.Value = docgia.Ngaysinh.Value;
            txt_ctdg_diachi.ReadOnly = false;
            radioButton_ctdg_nam.Enabled = true;
            radioButton_ctdg_nu.Enabled = true;
            txt_ctdg_sodt.ReadOnly = false;
            txt_ctdg_email.ReadOnly = false;

        }

        private void button_ctdg_luu_Click(object sender, EventArgs e)
        {
            UpdateDocGia();
            txt_ctdg_tendg.ReadOnly = true;
            radioButton_ldg_y.Enabled = false;
            radioButton_ldg_x.Enabled = false;
            txt_ngaysinh.Visible = true;
            dateTimePicker_ngaysinh.Visible = false;
            txt_ctdg_diachi.ReadOnly = true;
            radioButton_ctdg_nam.Enabled = false;
            radioButton_ctdg_nu.Enabled = false;
            txt_ctdg_sodt.ReadOnly = true;
            txt_ctdg_email.ReadOnly = true;
        }

        private void button_ctdg_xoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn xóa độc giả " + docgia.Hoten + "\n Chú ý: Khi xóa độc giả, các phiếu có liên quan đến độc giả cũng bị xóa theo.", "Thông Báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                int rs = DocGiaDAO.Instance.delete_docgia(docgia.Madocgia);
                if (rs == -2)
                    MessageBox.Show("Không Thể Xóa. Độc Giả Vẫn Còn Sách Đang Mượn");
                if (rs == -3)
                    MessageBox.Show("Không Thể Xóa. Độc Giả Vẫn Chưa Trả Hết Nợ.");
                if (rs == 0)
                    MessageBox.Show("Xóa Thất Bại");
                if (rs == 1)
                    MessageBox.Show("Xóa Thành Công");
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            docgia.Ngayhethan=docgia.Ngayhethan.AddMonths(1);
            int rs = DataProvider.Instance.ExecuteNonQuery("UPDATE dbo.DOC_GIA SET Ngayhethan ='"+docgia.Ngayhethan+ "' WHERE Madocgia='"+docgia.Madocgia+"'");
            if (rs > 0)
                MessageBox.Show("Gia Hạn Thành Công");
            loaddata();
        }
        #endregion
    }
}

