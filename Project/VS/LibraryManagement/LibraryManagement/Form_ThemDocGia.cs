using LibraryManagement.DAO;
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
    public partial class Form_ThemDocGia : Form
    {
        public Form_ThemDocGia()
        {
            InitializeComponent();
        }

        #region method
        void themdocgia()
        {

            string tendg = txt_tdg_ten.Text;
            int loaidg = 1;
            if (radioButton1.Checked == true)
                loaidg = 1;
            else
                loaidg = 2;
            int gioitinh = 1;
            if (radioButton_tdg_nam.Checked == true)
                gioitinh = 1;
            else
                gioitinh = 2;
            string diachi = txt_tdg_diachi.Text;
            string sodt = txt_tdg_sodt.Text;
            string email = txt_tdg_email.Text;
            DateTime ngaysinh = dateTimePicker_tdg_ngaysinh.Value;
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
                    if (DocGiaDAO.Instance.insert_docgia(tendg, loaidg, ngaysinh, gioitinh, diachi, sodt, email) == true)
                        MessageBox.Show("Thêm Mới Thành Công");
                    txt_tdg_ten.ResetText();
                    txt_tdg_diachi.ResetText();
                    txt_tdg_sodt.ResetText();
                    txt_tdg_email.ResetText();

                }
            }
        }
        #endregion

        #region event
        private void button_tdg_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        

        private void button_tdg_them_Click(object sender, EventArgs e)
        {
            themdocgia();
   
        }
        #endregion
    }
}
