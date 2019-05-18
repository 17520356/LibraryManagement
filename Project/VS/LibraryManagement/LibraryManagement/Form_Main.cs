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
    public partial class Form_Main : Form
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
                loginacc = value;
            }
        }
        public Form_Main(AccountDTO acc)
        {
            InitializeComponent();
            bt_timkiemsach.Visible = false;
            bt_themsach.Visible = false;
            bt_timkiemdocgia.Visible = false;
            bt_themdocgia.Visible = false;
            bt_timkiemphieuthu.Visible = false;
            bt_lapphieuthu.Visible = false;
            bt_timkiemphieutra.Visible = false;
            bt_lapphieutra.Visible = false;
            bt_timphieumuon.Visible = false;
            bt_lapphieumuon.Visible = false;
            bt_tk_sachtratre.Visible = false;
            bt_tk_theloai.Visible = false;

            this.loginacc = acc;
            Label_Nhom_NguoiDung.Text = AccountDAO.Instance.TenNhomNguoiDung(acc.Username);
            
        }


        private void panel_docgia_Paint(object sender, PaintEventArgs e)
        {

        }
        private void picture_Main_Click(object sender, EventArgs e)
        {
            bt_timkiemsach.Visible = false;
            bt_themsach.Visible = false;
            bt_timkiemdocgia.Visible = false;
            bt_themdocgia.Visible = false;
            bt_timkiemphieuthu.Visible = false;
            bt_lapphieuthu.Visible = false;
            bt_timkiemphieutra.Visible = false;
            bt_lapphieutra.Visible = false;
            bt_timphieumuon.Visible = false;
            bt_lapphieumuon.Visible = false;
            bt_tk_sachtratre.Visible = false;
            bt_tk_theloai.Visible = false;
            panel_main.BackColor = Color.WhiteSmoke;
        }

        private void bt_docgia_Click(object sender, EventArgs e)
        {
            bt_timkiemdocgia.Visible = true;
            bt_themdocgia.Visible = true;
            bt_timkiemsach.Visible = false;
            bt_themsach.Visible = false;
            bt_timkiemphieuthu.Visible = false;
            bt_lapphieuthu.Visible = false;
            bt_timkiemphieutra.Visible = false;
            bt_lapphieutra.Visible = false;
            bt_timphieumuon.Visible = false;
            bt_lapphieumuon.Visible = false;
            bt_tk_sachtratre.Visible = false;
            bt_tk_theloai.Visible = false;
            panel_main.BackColor = Color.Silver; 
        }

        private void bt_sach_Click(object sender, EventArgs e)
        {
            bt_timkiemsach.Visible = true;
            bt_themsach.Visible = true;
            bt_timkiemdocgia.Visible = false;
            bt_themdocgia.Visible = false;
            bt_timkiemphieuthu.Visible = false;
            bt_lapphieuthu.Visible = false;
            bt_timkiemphieutra.Visible = false;
            bt_lapphieutra.Visible = false;
            bt_timphieumuon.Visible = false;
            bt_lapphieumuon.Visible = false;
            bt_tk_sachtratre.Visible = false;
            bt_tk_theloai.Visible = false;
            panel_main.BackColor = Color.SandyBrown;

        }

        private void bt_phieumuon_Click(object sender, EventArgs e)
        {
            bt_timphieumuon.Visible = true;
            bt_lapphieumuon.Visible = true;
            bt_timkiemsach.Visible = false;
            bt_themsach.Visible = false;
            bt_timkiemdocgia.Visible = false;
            bt_themdocgia.Visible = false;
            bt_timkiemphieuthu.Visible = false;
            bt_lapphieuthu.Visible = false;
            bt_timkiemphieutra.Visible = false;
            bt_lapphieutra.Visible = false;
            bt_tk_sachtratre.Visible = false;
            bt_tk_theloai.Visible = false;
            panel_main.BackColor = Color.Cyan;
        }

        private void bt_phieutra_Click(object sender, EventArgs e)
        {
            bt_timkiemphieutra.Visible = true;
            bt_lapphieutra.Visible = true;
            bt_timkiemsach.Visible = false;
            bt_themsach.Visible = false;
            bt_timkiemdocgia.Visible = false;
            bt_themdocgia.Visible = false;
            bt_timkiemphieuthu.Visible = false;
            bt_lapphieuthu.Visible = false;
            bt_timphieumuon.Visible = false;
            bt_lapphieumuon.Visible = false;
            bt_tk_sachtratre.Visible = false;
            bt_tk_theloai.Visible = false;
            panel_main.BackColor = Color.SpringGreen;
        }

        private void bt_phieuthu_Click(object sender, EventArgs e)
        {
            bt_timkiemphieuthu.Visible = true;
            bt_lapphieuthu.Visible = true;
            bt_timkiemsach.Visible = false;
            bt_themsach.Visible = false;
            bt_timkiemdocgia.Visible = false;
            bt_themdocgia.Visible = false;
            bt_timkiemphieutra.Visible = false;
            bt_lapphieutra.Visible = false;
            bt_timphieumuon.Visible = false;
            bt_lapphieumuon.Visible = false;
            bt_tk_sachtratre.Visible = false;
            bt_tk_theloai.Visible = false;
            panel_main.BackColor = Color.PaleGoldenrod;
        }
        private void button_ThongKe_Click(object sender, EventArgs e)
        {
            bt_tk_sachtratre.Visible = true;
            bt_tk_theloai.Visible = true;
            bt_timkiemphieuthu.Visible = false;
            bt_lapphieuthu.Visible = false;
            bt_timkiemsach.Visible = false;
            bt_themsach.Visible = false;
            bt_timkiemdocgia.Visible = false;
            bt_themdocgia.Visible = false;
            bt_timkiemphieutra.Visible = false;
            bt_lapphieutra.Visible = false;
            bt_timphieumuon.Visible = false;
            bt_lapphieumuon.Visible = false;
           
            panel_main.BackColor = Color.Pink;
        }


        private void bt_timkiemsach_Click(object sender, EventArgs e)
        {
            Form_TimSach f = new Form_TimSach();
            f.ShowDialog();
        }

      
        private void bt_themsach_Click(object sender, EventArgs e)
        {
            Form_ThemSach f = new Form_ThemSach();
            f.ShowDialog();
        }

        private void bt_timkiemdocgia_Click(object sender, EventArgs e)
        {
            Form_TimDocGia f = new Form_TimDocGia();
            f.ShowDialog();
        }

        private void bt_themdocgia_Click(object sender, EventArgs e)
        {
            Form_ThemDocGia f = new Form_ThemDocGia();
            f.ShowDialog();
        }

        private void bt_timphieumuon_Click(object sender, EventArgs e)
        {
            Form_TimPhieuMuon f = new Form_TimPhieuMuon();
            f.ShowDialog();
        }

        private void bt_lapphieumuon_Click(object sender, EventArgs e)
        {
            Form_LapPhieuMuon f = new Form_LapPhieuMuon();
            f.ShowDialog();
        }

        private void bt_timkiemphieutra_Click(object sender, EventArgs e)
        {
            Form_TimPhieuTra f = new Form_TimPhieuTra();
            f.ShowDialog();
        }

        private void bt_lapphieutra_Click(object sender, EventArgs e)
        {
            Form_LapPhieuTra f = new Form_LapPhieuTra();
            f.ShowDialog();
        }

        private void bt_timkiemphieuthu_Click(object sender, EventArgs e)
        {
            Form_TimKiemPhieuThu f = new Form_TimKiemPhieuThu();
            f.ShowDialog();
        }

        private void bt_lapphieuthu_Click(object sender, EventArgs e)
        {
            Form_LapPhieuThu f = new Form_LapPhieuThu();
            f.ShowDialog();
        }

        private void bt_tk_theloai_Click(object sender, EventArgs e)
        {
            Form_ThongKeTheoTheLoai f = new Form_ThongKeTheoTheLoai();
            f.ShowDialog();
        }

        private void bt_tk_sachtratre_Click(object sender, EventArgs e)
        {
            Form_ThongKeSachTraTre f = new Form_ThongKeSachTraTre();
            f.ShowDialog();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Admin f = new Form_Admin();
            f.ShowDialog();
        }

        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_info_user f = new Form_info_user(loginacc);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }

}
