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
        }

        private void button_ad_quidinh_out_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_ad_theloai_Click(object sender, EventArgs e)
        {
            Form_quidinh_theloai f = new Form_quidinh_theloai();
            f.ShowDialog();
        }
    }
}
