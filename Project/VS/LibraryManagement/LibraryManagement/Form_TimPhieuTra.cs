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
    public partial class Form_TimPhieuTra : Form
    {
        public Form_TimPhieuTra()
        {
            InitializeComponent();
        }

        private void button_tpt_xemchitiet_Click(object sender, EventArgs e)
        {
            Form_ChiTietPhieuTra f = new Form_ChiTietPhieuTra();
            f.ShowDialog();
        }

        private void button_tpt_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
