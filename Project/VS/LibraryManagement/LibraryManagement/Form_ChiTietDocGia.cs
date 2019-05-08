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
    public partial class Form_ChiTietDocGia : Form
    {
        public Form_ChiTietDocGia()
        {
            InitializeComponent();
        }

        private void button_ctdg_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_ctdg_chinhsua_Click(object sender, EventArgs e)
        {
            cmb_ctdg_loaidg.Enabled = true;
            txt_ctdg_ngaysinh.ReadOnly = false;
            txt_ctdg_diachi.ReadOnly = false;
            radioButton_ctdg_nam.Enabled = true;
            radioButton_ctdg_nu.Enabled = true;
            txt_ctdg_sodt.ReadOnly = false;
            txt_ctdg_email.ReadOnly = false;
            cmb_ctdg_tinhtrang.Enabled = true;
            txt_ctdg_ssdangmuon.ReadOnly = false;
            txt_ctdg_tongno.ReadOnly = false;
            dateTimePicker_ctdg_ngaylapthe.Enabled = true;
            numericUpDown_ctdg.Enabled = true;
        }
    }
}
