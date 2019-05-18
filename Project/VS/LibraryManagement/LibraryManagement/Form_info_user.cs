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
    public partial class Form_info_user : Form
    {

        private AccountDTO loginacc;

        public AccountDTO Loginacc
        {
            get
            {
                return loginacc;
            }

            set
            {
                loginacc = value; ;
            }
        }
        public Form_info_user(AccountDTO acc)
        {
            InitializeComponent();

            this.loginacc = acc;
            load_info_user(loginacc);
        }
        void load_info_user(AccountDTO acc)
        {
            txt_username.Text = acc.Username;
            txt_tennhom.Text = AccountDAO.Instance.TenNhomNguoiDung(acc.Username);
            
            
        }
        void update_info_user()
        {
            string username = txt_username.Text.ToString();
            string password = txt_if_password.Text.ToString();
            string newpass = txt_if_newpass.Text.ToString();
            string reenterpass = txt_if_reenterpass.Text.ToString();

            if (!newpass.Equals(reenterpass))
            {
                MessageBox.Show("Mật khẩu mới chưa khớp! Vui lòng nhập lại!!!!");
            }
            else
            {
                if (AccountDAO.Instance.Update_info_user(username, password, newpass) == true)
                {
                    MessageBox.Show("Cập Nhật Thông Tin Thành Công!");
                    txt_if_newpass.ResetText();
                    txt_if_reenterpass.ResetText();
                    txt_if_password.ResetText();
                }
                else
                    MessageBox.Show("Vui Lòng Điền Đúng Mật Khẩu!");
            }


        }
        private void bt_out_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_Update_Click(object sender, EventArgs e)
        {
            update_info_user();
        }

        private void button_eye_MouseHover(object sender, EventArgs e)
        {
           
        }
        bool kiemtra = true;
        private void button_eye_Click(object sender, EventArgs e)
        {
            if (kiemtra)
            {
                txt_if_newpass.UseSystemPasswordChar = false;
                txt_if_password.UseSystemPasswordChar = false;
                txt_if_reenterpass.UseSystemPasswordChar = false;
                kiemtra = false;
            }
            else
            {
                txt_if_newpass.UseSystemPasswordChar = true;
                txt_if_password.UseSystemPasswordChar = true;
                txt_if_reenterpass.UseSystemPasswordChar = true;
                kiemtra = true;
            }
        }
    }
}
