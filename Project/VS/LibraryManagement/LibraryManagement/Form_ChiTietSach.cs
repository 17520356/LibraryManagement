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
    public partial class Form_ChiTietSach : Form
    {
        public Form_ChiTietSach()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_chinhsua_Click(object sender, EventArgs e)
        {
            cmb_cts_theloai.Enabled = true;
            txt_cts_ngonngu.ReadOnly = false;
            txt_cts_nhaxb.ReadOnly = false;
            txt_cts_namxb.ReadOnly = false;
            txt_cts_trigia.ReadOnly = false;
            txt_cts_tacgia.ReadOnly = false;
            txt_cts_tinhtrang.ReadOnly = false;
            dateTimePicker_cts_ngaynhap.Enabled = true;
        }

  
    }
}
