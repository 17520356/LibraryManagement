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
            #region visible
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
            button_themdausach.Visible = false;
            #endregion
            this.loginacc = acc;
            Label_Nhom_NguoiDung.Text = AccountDAO.Instance.TenNhomNguoiDung(acc.Username);
 
            kiemtradocgia();
            kiemtratinhtrangsach();
        }
        #region method

        void kiemtradocgia()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.DOC_GIA");
            foreach(DataRow item in data.Rows)
            {
                DocGiaDTO docgia = new DocGiaDTO(item);
                if (docgia.Ngayhethan < DateTime.Now)
                    DataProvider.Instance.ExecuteNonQuery("UPDATE dbo.DOC_GIA SET tinhtrang='2' WHERE Madocgia='" + docgia.Madocgia + "'");
                
            }
        }
        void kiemtratinhtrangsach() // Kiểm tra sách, nếu chưa trả mà quá hạn thì chuyển tình trạng =3
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC dbo.hienthitinhtrangsach");
            int tinhtrang;
            foreach (DataRow item in data.Rows)
            {
                ChiTietPhieuMuonDTO chitietpm = new ChiTietPhieuMuonDTO(item);
                tinhtrang = Convert.ToInt32(chitietpm.Tinhtrang);
                if (tinhtrang != 1) 
                {
                    if (chitietpm.Ngayhethan < DateTime.Now)
                        DataProvider.Instance.ExecuteNonQuery("UPDATE dbo.CHITIET_PHIEUMUON SET tinhtrang=3 WHERE Masach='"+chitietpm.Masach+"'");
                }
            }
        }

        #endregion



        #region event
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
            button_themdausach.Visible = false;
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
            button_themdausach.Visible = false;
            panel_main.BackColor = Color.Silver; 
        }

        private void bt_sach_Click(object sender, EventArgs e)
        {
            bt_timkiemsach.Visible = true;
            bt_themsach.Visible = true;
            button_themdausach.Visible = true;
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
            button_themdausach.Visible = false;
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
            button_themdausach.Visible = false;
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
            button_themdausach.Visible = false;
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
            button_themdausach.Visible = false;
            panel_main.BackColor = Color.Pink;
        }

        private void bt_timkiemsach_Click(object sender, EventArgs e)
        {
            Form_TimSach f = new Form_TimSach();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void bt_themsach_Click(object sender, EventArgs e)
        {
            Form_ThemSach f = new Form_ThemSach();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void bt_timkiemdocgia_Click(object sender, EventArgs e)
        {
            Form_TimDocGia f = new Form_TimDocGia();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void bt_themdocgia_Click(object sender, EventArgs e)
        {
            Form_ThemDocGia f = new Form_ThemDocGia();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void bt_timphieumuon_Click(object sender, EventArgs e)
        {
            Form_TimPhieuMuon f = new Form_TimPhieuMuon();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void bt_lapphieumuon_Click(object sender, EventArgs e)
        {
            Form_LapPhieuMuon f = new Form_LapPhieuMuon();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void bt_timkiemphieutra_Click(object sender, EventArgs e)
        {
            Form_TimPhieuTra f = new Form_TimPhieuTra();
            f.ShowDialog();
        }

        private void bt_lapphieutra_Click(object sender, EventArgs e)
        {
            Form_LapPhieuTra f = new Form_LapPhieuTra();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void bt_timkiemphieuthu_Click(object sender, EventArgs e)
        {
            Form_TimKiemPhieuThu f = new Form_TimKiemPhieuThu();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void bt_lapphieuthu_Click(object sender, EventArgs e)
        {
            Form_LapPhieuThu f = new Form_LapPhieuThu();
            this.Hide();
            f.ShowDialog();
            this.Show();
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
            Form_Admin f = new Form_Admin(loginacc);
            this.Hide();
            f.ShowDialog();
            this.Show();
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

        private void button_themdausach_Click(object sender, EventArgs e)
        {
            Form_ThemDauSach f = new Form_ThemDauSach();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        #endregion
    }

}
