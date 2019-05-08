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
    public partial class Form_ChiTietPhieuMuon : Form
    {
        public Form_ChiTietPhieuMuon()
        {
            InitializeComponent();
        }

        private void button_ctpm_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_ctpm_chinhsua_Click(object sender, EventArgs e)
        {
            cmb_ctpm_madg.Enabled = true;
          
            dateTimePicker_ctpm_ngaymuon.Enabled = true;
            
        }

    }
}
