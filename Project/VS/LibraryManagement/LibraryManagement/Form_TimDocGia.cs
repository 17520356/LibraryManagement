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
    public partial class Form_TimDocGia : Form
    {
        public Form_TimDocGia()
        {
            InitializeComponent();
            LoadDocGia();
        }

        private void button_dg_xemchitiet_Click(object sender, EventArgs e)
        {
            Form_ChiTietDocGia f = new Form_ChiTietDocGia();
            f.ShowDialog();
        }

        private void button_dg_lapphieumuon_Click(object sender, EventArgs e)
        {
            Form_LapPhieuMuon f = new Form_LapPhieuMuon();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void button_dg_phieutra_Click(object sender, EventArgs e)
        {
            Form_LapPhieuTra f = new Form_LapPhieuTra();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        void LoadDocGia()
        {
            string query = "Select * from DOC_GiA";
    
            dataGridView_docgia.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
