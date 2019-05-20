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
    public partial class Form_Admin : Form
    {
        public Form_Admin()
        {
            InitializeComponent();
            load_quidinh();
        }

        private void button_theloai_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_quidinh_theloai f = new Form_quidinh_theloai();
            f.ShowDialog();
            this.Show();
        }

        private void button_out_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_sach_out_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button_muon_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void load_quidinh()
        {
            int tuoitoithieu = Convert.ToInt32(ParaDAO.Instance.load_quidinhDAO("tuoitoithieu"));
            numericUpDown_tuoitoithieu.Value = tuoitoithieu;

            int tuoitoida = Convert.ToInt32(ParaDAO.Instance.load_quidinhDAO("tuoitoida"));
            numericUpDown_tuoitoida.Value = tuoitoida;

            int thoihanthe = Convert.ToInt32(ParaDAO.Instance.load_quidinhDAO("thoihanthe"));
            numericUpDown_thedocgia.Value = thoihanthe;

            int soluongtheloai = Convert.ToInt32(ParaDAO.Instance.load_quidinhDAO("soluongtheloai"));
            numericUpDown_sltheloai.Value = soluongtheloai;

            int khoangcachnamxuatban = Convert.ToInt32(ParaDAO.Instance.load_quidinhDAO("khoangcachnamxuatban"));
            numericUpDown_namxb.Value = khoangcachnamxuatban;

            int soluongsachtoida = Convert.ToInt32(ParaDAO.Instance.load_quidinhDAO("soluongsachtoida"));
            numericUpDown_slmax.Value = soluongsachtoida;

            int songaymuontoida = Convert.ToInt32(ParaDAO.Instance.load_quidinhDAO("songaymuontoida"));
            numericUpDown_daymax.Value = songaymuontoida;
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            int Ntuoitoithieu = Convert.ToInt32(numericUpDown_tuoitoithieu.Value);
            int Ntuoitoida = Convert.ToInt32(numericUpDown_tuoitoida.Value);
            int Nthoihanthe = Convert.ToInt32(numericUpDown_thedocgia.Value);
            if (Ntuoitoida <= Ntuoitoithieu)
                MessageBox.Show("Tuổi Tối Đa Phải Lớn Hơn Tuổi Tối Thiểu");
            else
            {
                    DataProvider.Instance.ExecuteNonQuery("EXEC dbo.update_quidinh_docgia @thamso = N'tuoitoithieu' , @giatri ='" + Ntuoitoithieu + "'");
                    DataProvider.Instance.ExecuteNonQuery("EXEC dbo.update_quidinh_docgia @thamso = N'tuoitoida' , @giatri ='" + Ntuoitoida + "'");
                    DataProvider.Instance.ExecuteNonQuery("EXEC dbo.update_quidinh_docgia @thamso = N'thoihanthe' , @giatri ='" + Nthoihanthe + "'");

                    MessageBox.Show("Cập Nhật Thành Công");
            }
        }

        private void button_muon_capnhat_Click(object sender, EventArgs e)
        {
            int Nslsachtoida = Convert.ToInt32(numericUpDown_slmax.Value);
            int Nsongaymuontoida = Convert.ToInt32(numericUpDown_daymax.Value);
     
                DataProvider.Instance.ExecuteNonQuery("EXEC dbo.update_quidinh_docgia @thamso = N'soluongsachtoida' , @giatri ='" + Nslsachtoida + "'");
                DataProvider.Instance.ExecuteNonQuery("EXEC dbo.update_quidinh_docgia @thamso = N'songaymuontoida' , @giatri ='" + Nsongaymuontoida + "'");

                MessageBox.Show("Cập Nhật Thành Công");
        }

        private void button_sach_update_Click(object sender, EventArgs e)
        {
            int Nsltheloai = Convert.ToInt32(numericUpDown_sltheloai.Value);
            int Nkcnamxb = Convert.ToInt32(numericUpDown_namxb.Value);

            DataProvider.Instance.ExecuteNonQuery("EXEC dbo.update_quidinh_docgia @thamso = N'soluongtheloai' , @giatri ='" + Nsltheloai + "'");
            DataProvider.Instance.ExecuteNonQuery("EXEC dbo.update_quidinh_docgia @thamso = N'khoangcachnamxuatban' , @giatri ='" + Nkcnamxb + "'");

            MessageBox.Show("Cập Nhật Thành Công");
        }
    }
}
