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
    public partial class Form_TimPhieuMuon : Form
    {
        public Form_TimPhieuMuon()
        {
            InitializeComponent();
        }

        private void button_tpm_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_tpm_xemchitiet_Click(object sender, EventArgs e)
        {
            Form_ChiTietPhieuMuon f = new Form_ChiTietPhieuMuon();
            f.ShowDialog();
        }
    }
}
