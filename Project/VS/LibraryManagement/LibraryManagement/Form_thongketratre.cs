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
    public partial class Form_thongketratre : Form
    {
        public Form_thongketratre()
        {
            InitializeComponent();
        }
        DateTime date;
        private void button_tao_Click(object sender, EventArgs e)
        {
            date = dateTimePicker1.Value;
            int day, month, year;
            day = date.Day;
            month = date.Month;
            year = date.Year;
            DataProvider.Instance.ExecuteNonQuery("insert into BAOCAO_SACH_TRATRE(Ngay,Thang,Nam) values ("+day+ "," + month + "," + year + ")");
            int mabaocao = Convert.ToInt32(DataProvider.Instance.ExecuteReader("select MAX(Mabaocaosachtratre) from BAOCAO_SACH_TRATRE"));
            DataTable chitiet = DataProvider.Instance.ExecuteQuery("select Masach,Ngaymuon,Songaytre from CHITIET_PHIEUTRA where Songaytre>0");
            if (chitiet.Rows.Count > 0)
            {
                foreach (DataRow row in chitiet.Rows)
                {
                    DataProvider.Instance.ExecuteNonQuery("insert into CHITIET_BAOCAO_TRATRE(Mabaocaosachtratre,Masach,Ngaymuon,Songaytratre) values (" + mabaocao + "," + row[0] + ",'" + row[1] + "'," + row[2] + ")");
                }
            }
            MessageBox.Show("Tạo Thành Công");
            hienthithongke();
        }
        void hienthithongke()
        {
            date = dateTimePicker1.Value;
            int day, month, year;
            day = date.Day;
            month = date.Month;
            year = date.Year;
            DataTable data = DataProvider.Instance.ExecuteQuery("exec baocaotratre @Ngay = " + day + ", @thang = " + month + " , @nam=" + year + "");
            dataGridView1.DataSource = data;
        }

        private void button_xem_Click(object sender, EventArgs e)
        {
            hienthithongke();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
