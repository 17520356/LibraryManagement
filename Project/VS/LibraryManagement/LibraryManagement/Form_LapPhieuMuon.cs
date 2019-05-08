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
    public partial class Form_LapPhieuMuon : Form
    {
        public Form_LapPhieuMuon()
        {
            InitializeComponent();
            dateTimePicker_lpm_ngaymuon.Value = DateTime.Today;
        }

        private void button_lpm_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
