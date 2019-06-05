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
    public partial class Form_TimSach : Form
    {
        BindingSource sach_binding = new BindingSource();
        BindingSource dausach_binding = new BindingSource();
        public Form_TimSach()
        {
            InitializeComponent();
            load();
        }
        #region method

        void load()
        {
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            hienthisach();
            Binding_Sach();
            Binding_dausach();

        }

        void hienthisach()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC dbo.hienthisach");
            if (data.Rows.Count > 0)
            {
                sach_binding.DataSource = data;
                dataGridView_sach.DataSource = sach_binding;
            
            }
        }

        void hienthidausach()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT Madausach[Mã Đầu Sách], Tendausach[Tên Đầu Sách], Ten[Thể Loại], Trigia[Trị Giá], Soluong[Số Lượng] FROM dbo.DAUSACH,dbo.THE_LOAI WHERE THE_LOAI.Matheloai = DAUSACH.Matheloai");
            if (data.Rows.Count > 0)
            {
                dausach_binding.DataSource = data;
                dataGridView_sach.DataSource = dausach_binding;

            }
        }

        void Binding_Sach()
        {
                txt_masach.DataBindings.Add(new Binding("text", sach_binding, "Mã Sách", true, DataSourceUpdateMode.Never));
                txt_tendausach.DataBindings.Add(new Binding("text", sach_binding, "Tên Đầu Sách", true, DataSourceUpdateMode.Never));
                txt_theloai.DataBindings.Add(new Binding("text", sach_binding, "Thể Loại", true, DataSourceUpdateMode.Never));
                txt_tinhtrang.DataBindings.Add(new Binding("text", sach_binding, "Tình Trạng", true, DataSourceUpdateMode.Never));
                txt_nxb.DataBindings.Add(new Binding("text", sach_binding, "Nhà Xuất Bản", true, DataSourceUpdateMode.Never));
            
        }

        void Binding_dausach()
        {
                textBox1.DataBindings.Add(new Binding("text", dausach_binding, "Mã Đầu Sách", true, DataSourceUpdateMode.Never));
                textBox2.DataBindings.Add(new Binding("text", dausach_binding, "Tên Đầu Sách", true, DataSourceUpdateMode.Never));
                textBox3.DataBindings.Add(new Binding("text", dausach_binding, "Thể Loại", true, DataSourceUpdateMode.Never));
                textBox4.DataBindings.Add(new Binding("text", dausach_binding, "Trị Giá", true, DataSourceUpdateMode.Never));
                textBox5.DataBindings.Add(new Binding("text", dausach_binding, "Số Lượng", true, DataSourceUpdateMode.Never));

        }

        #endregion




        #region event
        private void button_xemchitiet_Click(object sender, EventArgs e)
        {
            Form_ChiTietSach f = new Form_ChiTietSach();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void bt_xemsach_Click(object sender, EventArgs e)
        {
            hienthisach();
            label5.Text = "Mã Sách";
            label3.Text = "Tình Trạng";
            label4.Text = "Nhà Xuất Bản";
            #region visble
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            txt_masach.Visible = true;
            txt_tendausach.Visible = true;
            txt_theloai.Visible = true;
            txt_tinhtrang.Visible = true;
            txt_nxb.Visible = true;
            #endregion
           
        }

        private void button_xemdausach_Click(object sender, EventArgs e)
        {
            label5.Text = "Mã Đầu Sách";
            label3.Text = "Trị Giá";
            label4.Text = "Số Lượng";
            hienthidausach();
            #region visible
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            txt_masach.Visible = false;
            txt_tendausach.Visible = false;
            txt_theloai.Visible = false;
            txt_tinhtrang.Visible = false;
            txt_nxb.Visible = false;
            #endregion
            
        
        }

        private void button_sachmuon_Click(object sender, EventArgs e)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC dbo.hienthisachchomuon");
            if (data.Rows.Count > 0)
                dataGridView_sach.DataSource = data;
        }

        private void button_xoasach_Click(object sender, EventArgs e)
        {

            if ((txt_masach.Visible == true)&&(txt_masach.Text!=""))
            {

                int masach = Convert.ToInt32(txt_masach.Text);
                string tensach = txt_tendausach.Text;
                if (MessageBox.Show("Bạn có thực sự muốn xóa SÁCH " + masach +" - "+ tensach+  "\nChú ý: Khi xóa sách, các phiếu có liên quan đến sách cũng bị xóa theo.", "Thông Báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    int temp = SachDAO.Instance.xoasach(masach);
                    if (temp==1)
                    {
                            MessageBox.Show("Xóa Sách Thành Công!!");
                            hienthisach();
                    }
                    if(temp==-1)
                        MessageBox.Show("Không Thể Xóa Sách Đang Cho Mượn");
                }
            }
            if ((textBox1.Visible == true) && (textBox1.Text != ""))
            {

                int madausach = Convert.ToInt32(textBox1.Text);
                string tensach = textBox2.Text;
                if (MessageBox.Show("Bạn có thực sự muốn xóa ĐẦU SÁCH " + madausach + " - " + tensach + "\nChú ý: Khi xóa sách, các phiếu có liên quan đến sách cũng bị xóa theo.", "Thông Báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    int temp = SachDAO.Instance.xoadausach(madausach);
                    if (temp == 1)
                    {
                        MessageBox.Show("Xóa Đầu Sách Thành Công!!");
                        hienthidausach();
                    }
                    if (temp == 0)
                        MessageBox.Show("Xóa Thát Bại");
                    if (temp == -1)
                        MessageBox.Show("Không Thể Xóa Do Có Sách Đang Cho Mượn Thuộc Đầu Sách Này");
                }
            }
        }
        #endregion
    }
}
