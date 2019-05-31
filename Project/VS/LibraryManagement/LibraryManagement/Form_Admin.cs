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
    public partial class Form_Admin : Form
    {
        BindingSource Binding_acc = new BindingSource();

        private AccountDTO acc;

        public AccountDTO Acc
        {
            get
            {
                return acc;
            }

            set
            {
                acc = value;
            }
        }

        public Form_Admin(AccountDTO acc)
        {
            InitializeComponent();
           
            this.acc = acc;
            load();
        }
        #region method
        void load()
        {
            dataGridView_taikhoan.DataSource = Binding_acc;
            load_quidinh();
            load_acc();
            bindinh_acc();
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

        //quan ly tai khoan
        void load_acc()
        {
            DataTable data = AccountDAO.Instance.Load_acc();
            Binding_acc.DataSource = data;
        }

        void bindinh_acc()
        {
            txt_tendangnhap.DataBindings.Add(new Binding("Text", dataGridView_taikhoan.DataSource, "Tên Đăng Nhập", true, DataSourceUpdateMode.Never));
            txt_tennhom.DataBindings.Add(new Binding("Text", dataGridView_taikhoan.DataSource, "Tên Nhóm", true, DataSourceUpdateMode.Never));
            numericUpDown_manhom.DataBindings.Add(new Binding("value", dataGridView_taikhoan.DataSource, "Mã Nhóm", true, DataSourceUpdateMode.Never));
        }

        #endregion

        #region event
      
        //button_out
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

        private void button_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //--
        private void button_theloai_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_quidinh_theloai f = new Form_quidinh_theloai();
            f.ShowDialog();
            this.Show();
        }

        //button_update
        private void button_update_Click(object sender, EventArgs e)
        {
            int Ntuoitoithieu = Convert.ToInt32(numericUpDown_tuoitoithieu.Value);
            int Ntuoitoida = Convert.ToInt32(numericUpDown_tuoitoida.Value);
            int Nthoihanthe = Convert.ToInt32(numericUpDown_thedocgia.Value);
            if (Ntuoitoida <= Ntuoitoithieu)
                MessageBox.Show("Tuổi Tối Đa Phải Lớn Hơn Tuổi Tối Thiểu");
            else
            {
                ParaDAO.Instance.update_quidinh("tuoitoithieu", Ntuoitoithieu);
                ParaDAO.Instance.update_quidinh("tuoitoida", Ntuoitoida);
                ParaDAO.Instance.update_quidinh("thoihanthe", Nthoihanthe);

                MessageBox.Show("Cập Nhật Thành Công");
                load_quidinh();
            }
        }

        private void button_muon_capnhat_Click(object sender, EventArgs e)
        {
            int Nslsachtoida = Convert.ToInt32(numericUpDown_slmax.Value);
            int Nsongaymuontoida = Convert.ToInt32(numericUpDown_daymax.Value);

            ParaDAO.Instance.update_quidinh("soluongsachtoida", Nslsachtoida);
            ParaDAO.Instance.update_quidinh("songaymuontoida", Nsongaymuontoida);

            MessageBox.Show("Cập Nhật Thành Công");
            load_quidinh();
        }

        private void button_sach_update_Click(object sender, EventArgs e)
        {
            int Nsltheloai = Convert.ToInt32(numericUpDown_sltheloai.Value);
            int Nkcnamxb = Convert.ToInt32(numericUpDown_namxb.Value);

            ParaDAO.Instance.update_quidinh("soluongtheloai", Nsltheloai);
            ParaDAO.Instance.update_quidinh("khoangcachnamxuatban", Nkcnamxb);

            MessageBox.Show("Cập Nhật Thành Công");
        }

        //reset pass
        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_tendangnhap.Text != "")
            {
                string tendangnhap = txt_tendangnhap.Text;
                if (AccountDAO.Instance.reset_pass(tendangnhap) == true)
                    MessageBox.Show("Đặt Lại Mật Khẩu Thành Công!");
                load_acc();

            }
        }

      

        private void button_tk_them_Click(object sender, EventArgs e)
        {
            int manhom = Convert.ToInt32(numericUpDown_manhom.Value.ToString());
            string tendangnhap = txt_tendangnhap.Text;
            if (tendangnhap != "")
            {
                {
                    if (AccountDAO.Instance.check_acc(tendangnhap) == true)
                    {
                        MessageBox.Show("Đã Tồn Tại Tài Khoản Này.");
                        txt_tendangnhap.ResetText();
                    }
                    else
                    {
                        if (AccountDAO.Instance.insert_acc(tendangnhap, manhom) == true)
                            MessageBox.Show("Thêm Mới Thành Công!!");
                        else
                            MessageBox.Show("Thêm Mới Thất Bại!!");


                    }

                }
            }
            load_acc();
        }

        private void button_tk_sua_Click(object sender, EventArgs e)
        {

            string tendangnhap = txt_tendangnhap.Text;
            int Nmanhom = Convert.ToInt32(numericUpDown_manhom.Value.ToString());
            int manhom = Convert.ToInt32(DataProvider.Instance.ExecuteReader("SELECT MaNhom FROM dbo.NGUOI_DUNG WHERE TenDangNhap = '" + tendangnhap + "'"));
            if ((tendangnhap != "") && (Nmanhom != manhom))
            {
                if (acc.Username == tendangnhap)
                    MessageBox.Show("Không Thể Sửa Tài Khoản Đang Đăng Nhập!");
                else
                {
                    if (AccountDAO.Instance.update_acc(tendangnhap, Nmanhom) == true)
                        MessageBox.Show("Cập Nhật Thành Công!!");
                    else
                        MessageBox.Show("Cập Nhật Thất Bại!!");
                    txt_tendangnhap.ResetText();
                }
            }
            load_acc();
        }

        private void button_tk_xoa_Click(object sender, EventArgs e)
        {
            string tendangnhap = txt_tendangnhap.Text;
            int Nmanhom = Convert.ToInt32(numericUpDown_manhom.Value.ToString());
            int manhom = Convert.ToInt32(DataProvider.Instance.ExecuteReader("SELECT MaNhom FROM dbo.NGUOI_DUNG WHERE TenDangNhap = '" + tendangnhap + "'"));

            if ((tendangnhap != "") && (Nmanhom == manhom))
            {
                if (acc.Username == tendangnhap)
                    MessageBox.Show("Không Thể Xóa Tài Khoản Đang Đăng Nhập!");
                else
                {
                    if (AccountDAO.Instance.delete_acc(tendangnhap) == true)
                        MessageBox.Show("Xóa Thành Công!!");
                    else
                        MessageBox.Show("Xóa Thất Bại!!");
                    txt_tendangnhap.ResetText();
                }
            }
            load_acc();
        }
        #endregion



    }
}
