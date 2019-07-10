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
    public partial class Form_TimPhieuMuon : Form
    {
        BindingSource bd_phieumuon = new BindingSource();
        public Form_TimPhieuMuon()
        {
            InitializeComponent();
            hienthiphieumuon();
          
            if (dataGridView_phieumuon.Rows.Count > 0)
                binding_pm();
        }
        #region method
        void hienthiphieumuon()
        {
            string query = "SELECT Maphieumuon[Mã Phiếu Mượn],DOC_GIA.Madocgia[Mã Độc Giả],Hoten [Họ Tên],Ngaymuon[Ngày Mượn] FROM dbo.PHIEU_MUON,dbo.DOC_GIA WHERE DOC_GIA.Madocgia=PHIEU_MUON.Madocgia";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            dataGridView_phieumuon.DataSource = bd_phieumuon;
            bd_phieumuon.DataSource = data;
        }
        void binding_pm()
        {
            txt_maphieumuon.DataBindings.Add(new Binding("text", bd_phieumuon, "Mã Phiếu Mượn", true, DataSourceUpdateMode.Never));
            txt_madocgia.DataBindings.Add(new Binding("text", bd_phieumuon, "Mã Độc Giả", true, DataSourceUpdateMode.Never));
            txt_hoten.DataBindings.Add(new Binding("text", bd_phieumuon, "Họ Tên", true, DataSourceUpdateMode.Never));
            txt_ngaymuon.DataBindings.Add(new Binding("text", bd_phieumuon, "Ngày Mượn", true, DataSourceUpdateMode.Never));
        }
        #endregion
        #region event
        private void button_tpm_timkiem_Click(object sender, EventArgs e)
        {

            if (textBox_tpm.Text != "")
                bd_phieumuon.DataSource = PhieuMuonDAO.Instance.search(textBox_tpm.Text);
            else
               hienthiphieumuon();
        }
        private void button_tpm_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_tpm_xemchitiet_Click(object sender, EventArgs e)
        {
            int id;
            if (txt_maphieumuon.Text != "")
            {
                id = Convert.ToInt32(txt_maphieumuon.Text);
                Form_ChiTietPhieuMuon f = new Form_ChiTietPhieuMuon(id);
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
        }
        private void button_tpm_xemtatca_Click(object sender, EventArgs e)
        {
            hienthiphieumuon();
        }

        #endregion

        
    }
}

