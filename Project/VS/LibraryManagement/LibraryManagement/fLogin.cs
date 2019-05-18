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
    
    public partial class fLogin : Form
    {
        public User_DTO user = new User_DTO();
        public fLogin()
        {
            InitializeComponent();
        }
        public User_DTO getuser()
        { 
                user.Username = txt_username.Text.ToString();
                user.Password = txt_password.Text.ToString();
                return user;
        }
   

        private void bt_out_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát chương trình?", "Thông Báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
                e.Cancel = true;
        }
        private void bt_login_Click(object sender, EventArgs e)
        {
            if (LoginDAO.Instance.checklogin(getuser().Username, getuser().Password) == true)
            {
                AccountDTO loginAccount = AccountDAO.Instance.GetAccByUsername(getuser().Username);
                Form_Main f = new Form_Main(loginAccount);
                this.Hide();  
                txt_username.ResetText();
                txt_password.ResetText();
                this.txt_username.Select();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                if (LoginDAO.Instance.checkUsername(getuser().Username) == false)
                    MessageBox.Show("Sai tên đăng nhập!");
                else
                    MessageBox.Show("Sai mật khẩu!");
            }
            }
    }
}
