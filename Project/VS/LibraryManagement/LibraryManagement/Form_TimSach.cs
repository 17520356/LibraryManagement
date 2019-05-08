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
        public Form_TimSach()
        {
            InitializeComponent();
        }

        private void button_xemchitiet_Click(object sender, EventArgs e)
        {
            Form_ChiTietSach f = new Form_ChiTietSach();
            f.ShowDialog();
        }

        private void button_tk_lapphieumuon_Click(object sender, EventArgs e)
        {
            Form_LapPhieuMuon f = new Form_LapPhieuMuon();
            f.ShowDialog();
        }
    }
}
