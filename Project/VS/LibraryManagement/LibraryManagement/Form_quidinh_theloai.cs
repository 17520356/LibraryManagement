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
    public partial class Form_quidinh_theloai : Form
    {
        BindingSource theloai = new BindingSource();
        public Form_quidinh_theloai()
        {
            InitializeComponent();
            load();
        }
        void load()
        {
            dataGridView_theloai.DataSource = theloai;
            loaddata();
            biding_theloai();
        }

        private void button_ad_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void loaddata()
        {
            DataTable rs = DataProvider.Instance.ExecuteQuery("SELECT Matheloai [Mã Thể Loại], Ten [Tên Thể Loại] FROM dbo.THE_LOAI");
            theloai.DataSource = rs;

        }
        void biding_theloai()
        {
            txt_maloaisach.DataBindings.Add(new Binding("Text", dataGridView_theloai.DataSource, "Mã Thể Loại",true,DataSourceUpdateMode.Never));
            txt_tentheloai.DataBindings.Add(new Binding("Text", dataGridView_theloai.DataSource, "Tên Thể Loại", true, DataSourceUpdateMode.Never));
        }

        private void button_ad_them_Click(object sender, EventArgs e)
        {

            int maloaisach = Convert.ToInt32(txt_maloaisach.Text);
            string tentheloaisach = txt_tentheloai.Text;
            if (txt_tentheloai.Text != "")
            {
              
                int soluongtheloai = Convert.ToInt32(DataProvider.Instance.ExecuteReader("SELECT COUNT(*) FROM dbo.THE_LOAI"));
                int thamsotheloai = Convert.ToInt32(DataProvider.Instance.ExecuteReader("SELECT Giatri FROM dbo.THAM_SO WHERE Tenthamso ='soluongtheloai'"));
                if (soluongtheloai >= thamsotheloai)
                    MessageBox.Show("Số Lượng Thể Loại Của Cách Không Vượt Quá " + thamsotheloai + "....Vui lòng cập nhật lại tham số");
                else
                {
                    if (TypeDAO.Instance.checktentheloai(tentheloaisach) == true)
                    {
                        MessageBox.Show("Đã Tồn Tại Thể Loại Này.");
                        txt_tentheloai.ResetText();
                    }
                    else
                    {
                        if (TypeDAO.Instance.insert_theloai(tentheloaisach) == true)
                            MessageBox.Show("Thêm Mới Thành Công!!");
                        else
                            MessageBox.Show("Thêm Mới Thất Bại!!");
                        txt_tentheloai.ResetText();

                    }
                    loaddata();
                }
            }
        }

        private void button_ad_luu_Click(object sender, EventArgs e)
        {
            if ((txt_maloaisach.Text != "") && (txt_tentheloai.Text != ""))
            {
                int maloaisach = Convert.ToInt32(txt_maloaisach.Text);

                string tentheloaisach = txt_tentheloai.Text;
                if (TypeDAO.Instance.checktentheloai(tentheloaisach) == true)
                {
                    MessageBox.Show("Đã Tồn Tại Thể Loại Này.");
                    txt_tentheloai.ResetText();
                }
                else
                {
                    if (TypeDAO.Instance.update_theloai(maloaisach, tentheloaisach) == true)
                        MessageBox.Show("Cập Nhật Thành Công!!");
                }
                loaddata();
            }
        }

        private void button_ad_xoa_Click(object sender, EventArgs e)
        {
            if ((txt_maloaisach.Text != "")&&(txt_tentheloai.Text!=""))
            {
                int maloaisach = Convert.ToInt32(txt_maloaisach.Text);
                if (TypeDAO.Instance.checkdelete(maloaisach) == true)
                    MessageBox.Show("Không thể xóa do đang tồn tại sách thuộc thể loại này!!");
                else
                {
                    if (TypeDAO.Instance.delete_theloai(maloaisach) == true)
                        MessageBox.Show("Xóa Thành Công!!");
                    else
                        MessageBox.Show("Xóa Thất Bại!!");
                    txt_tentheloai.ResetText();
                    loaddata();
                }
            }
        }
    }
}
