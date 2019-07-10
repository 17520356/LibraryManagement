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
    public partial class Form_TimPhieuTra : Form
    {

        BindingSource bd_phieutra = new BindingSource();

        public Form_TimPhieuTra()
        {
            InitializeComponent();
            hienthi();
            if (dataGridView_phieutra.Rows.Count > 0)
                binding_phieutra();
        }
        #region method
        void hienthi()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC dbo.phieutra_datagridview");
            dataGridView_phieutra.DataSource = bd_phieutra;
            bd_phieutra.DataSource = data;
           
        }
        void binding_phieutra()
        {
            txt_maphieutra.DataBindings.Add(new Binding("text", bd_phieutra, "Mã Phiếu Trả", true, DataSourceUpdateMode.Never));
            txt_madocgia.DataBindings.Add(new Binding("text", bd_phieutra, "Mã Độc Giả", true, DataSourceUpdateMode.Never));
            txt_hoten.DataBindings.Add(new Binding("text", bd_phieutra, "Họ Tên", true, DataSourceUpdateMode.Never));
            txt_ngaytra.DataBindings.Add(new Binding("text", bd_phieutra, "Ngày Trả", true, DataSourceUpdateMode.Never));
        }

        #endregion
        #region event

        private void button_tpm_timkiem_Click(object sender, EventArgs e)
        {
            if (textBox_tpm.Text != "")
                bd_phieutra.DataSource = PhieuTraDAO.Instance.search(textBox_tpm.Text);
            else
                hienthi();
        }
        private void button_xemchitiet_Click(object sender, EventArgs e)
        {
            int id;
            if (txt_maphieutra.Text != "")
            {
                id = Convert.ToInt32(txt_maphieutra.Text);
                Form_ChiTietPhieuTra f = new Form_ChiTietPhieuTra(id);
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
        }

        private void button_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
      

        private void button_tpm_xemtatca_Click(object sender, EventArgs e)
        {
            hienthi();
        }
        #endregion

       
    }
}
