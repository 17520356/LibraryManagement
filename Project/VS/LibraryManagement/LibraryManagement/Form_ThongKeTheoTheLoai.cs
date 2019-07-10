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
    public partial class Form_ThongKeTheoTheLoai : Form
    {
        public Form_ThongKeTheoTheLoai()
        {
            InitializeComponent();
            
        }
        DateTime date;
        private void button_tao_Click(object sender, EventArgs e)
        {
            date = dateTimePicker1.Value;
            int month = date.Month;
            int year = date.Year;
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from BAOCAO_MUONSACH_THELOAI where Thang = " + month + " and Nam = " + year + "");

            
                DataTable temp = DataProvider.Instance.ExecuteQuery("exec baocao_theloai_tongluotmuon @thang = " + month + ", @nam= " + year + "");
    
                    int mabaocao = Convert.ToInt32(DataProvider.Instance.ExecuteReader("select MAX(Mabaocaotheotheloai)from BAOCAO_MUONSACH_THELOAI"));
                    DataTable chitiet = DataProvider.Instance.ExecuteQuery("exec chitietbaocaotheotheloai @thang = " + month + ", @nam= " + year + "");
                    foreach (DataRow row in chitiet.Rows)
                    {
                        DataProvider.Instance.ExecuteNonQuery("insert into CHITIET_BAOCAO_THELOAI(Mabaocaotheotheloai,Matheloai,Luotmuon,Tile) values(" + mabaocao + "," + row[0] + "," + row[1] + "," + row[2] + ")");
                    }
                MessageBox.Show("Tạo Thành Công");
                    hienthibaocao();
                
            
        }
        void hienthibaocao ()
        {
            date = dateTimePicker1.Value;
            int month = date.Month;
            int year = date.Year;
            DataTable baocao = DataProvider.Instance.ExecuteQuery("exec hienthithongketheotheloai @thang = " + month + ", @nam= " + year + "");
            dataGridView1.DataSource = baocao;
            string tongluotmuot = DataProvider.Instance.ExecuteReader("select Tongluotmuon from BAOCAO_MUONSACH_THELOAI B where B.Thang=" + month + " and B.Nam=" + year + "");
            textBox1.Text = tongluotmuot;
        }

        private void button_xem_Click(object sender, EventArgs e)
        {
            hienthibaocao();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
