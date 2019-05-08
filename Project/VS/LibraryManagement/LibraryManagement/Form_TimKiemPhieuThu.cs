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
    public partial class Form_TimKiemPhieuThu : Form
    {
        public Form_TimKiemPhieuThu()
        {
            InitializeComponent();
        }

        private void button_tpthu_xemchitiet_Click(object sender, EventArgs e)
        {
            Form_ChiTietPhieuThu f = new Form_ChiTietPhieuThu();
            f.ShowDialog();
        }

        private void button_tpthu_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
