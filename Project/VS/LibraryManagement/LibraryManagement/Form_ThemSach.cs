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
    public partial class Form_ThemSach : Form
    {
        public Form_ThemSach()
        {
            InitializeComponent();
            hienthi();
        }
        #region method

        void hienthi()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT Madausach[Mã Đầu Sách],Tendausach[Tên Đầu Sách]FROM dbo.DAUSACH");
            if(data.Rows.Count>0)
            {
                comboBox_tendausach.DisplayMember = "Tên Đầu Sách";
                comboBox_tendausach.ValueMember = "Mã Đầu Sách";
                comboBox_tendausach.DataSource = data;
            }
        }

        #endregion

        #region event
        private void button_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
        private int namxuatban;
        private int madausach = 1;
        private string tendausach;

        private void comboBox_tendausach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox_tendausach.ValueMember!="")
                madausach = Convert.ToInt32(comboBox_tendausach.SelectedValue.ToString());
            string theloai = DataProvider.Instance.ExecuteReader("SELECT Ten[Thể Loại] FROM dbo.DAUSACH D,dbo.THE_LOAI T	WHERE D.Matheloai=T.Matheloai AND D.Madausach='"+madausach+"'");

            string nxb = DataProvider.Instance.ExecuteReader("SELECT N.TenNXB[Nhà Xuất Bản] FROM dbo.DAUSACH D,dbo.NHA_XUAT_BAN N	WHERE N.MaNXB=D.MaNXB AND D.Madausach='"+madausach+"'");

            string ngonngu = DataProvider.Instance.ExecuteReader("SELECT Ngonngu[Ngôn Ngữ] FROM dbo.DAUSACH D,dbo.NGON_NGU WHERE D.Mangonngu=dbo.NGON_NGU.Mangonngu AND D.Madausach='"+madausach+"'");

            string namxb = DataProvider.Instance.ExecuteReader("SELECT D.Namxuatban[Năm Xuất Bản] FROM dbo.DAUSACH D	WHERE D.Madausach='"+madausach+"'");

            string trigia = DataProvider.Instance.ExecuteReader("SELECT D.Trigia[Trị Giá] FROM dbo.DAUSACH D WHERE D.Madausach='"+madausach+"'");

            textBox_theloai.Text = theloai;
            textBox_nhaxb.Text = nxb;
            textBox_ngonngu.Text = ngonngu;
            textBox_namxb.Text = namxb;
            textBox_trigia.Text = trigia;
            namxuatban =Convert.ToInt32(DataProvider.Instance.ExecuteReader("SELECT YEAR(Namxuatban)FROM dbo.DAUSACH WHERE Madausach = '"+madausach+"'"));
            tendausach = DataProvider.Instance.ExecuteReader("SELECT Tendausach FROM dbo.DAUSACH WHERE Madausach = '" + madausach + "'");
            

        }

        private void dateTimePicker_ngaynhap_ValueChanged(object sender, EventArgs e)
        {
            int ngaynhap = dateTimePicker_ngaynhap.Value.Year;
            int temp = ngaynhap - namxuatban;
            if(temp<0)
            {
                MessageBox.Show("Năm Nhập Không Được Nhỏ Hơn Năm Xuất Bản");
                dateTimePicker_ngaynhap.ResetText();
            }
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            int soluong =Convert.ToInt32(numericUpDown_soluong.Value);
            if (MessageBox.Show("Bạn muốn thêm  " + soluong + " Sách " + madausach + " - " + tendausach + "", "Thông Báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                while (soluong > 0)
                {
                    DataProvider.Instance.ExecuteNonQuery("INSERT INTO dbo.CUONSACH ( Madausach, Matinhtrang, Ngaynhap )VALUES  ( '" + madausach + "', 1, '" + dateTimePicker_ngaynhap.Value + "')");
                    soluong--;
                }
                if (soluong == 0)
                {
                    DataProvider.Instance.ExecuteNonQuery("UPDATE dbo.DAUSACH SET Soluong+='" + soluong + "' WHERE Madausach='" + madausach + "'");
                    MessageBox.Show("Thêm Mới Thành Công");
                }
            }
        }

        #endregion
    }
}
