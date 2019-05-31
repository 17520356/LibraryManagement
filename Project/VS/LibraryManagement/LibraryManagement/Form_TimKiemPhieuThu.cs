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
    public partial class Form_TimKiemPhieuThu : Form
    {
        BindingSource phieuthu = new BindingSource();
        public Form_TimKiemPhieuThu()
        {
            InitializeComponent();
            dataGridView_phiethu.DataSource = phieuthu;
            loaddata();
            BindingPhieuThu();
        }
        #region method
        void loaddata()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT Maphieuthu [Mã Phiếu Thu],Hoten [Họ Tên],Tongno[Tổng Nợ],Sotienthu [Số Tiền Thu],ngaythu [Ngày Thu] FROM dbo.PHIEU_THU,dbo.DOC_GIA WHERE DOC_GIA.Madocgia=dbo.PHIEU_THU.Madocgia");

            if (data.Rows.Count > 0)
                phieuthu.DataSource = data;
        }
        void BindingPhieuThu()
        {
            txt_maphiethu.DataBindings.Add(new Binding("Text", phieuthu,"Mã Phiếu Thu", true, DataSourceUpdateMode.Never));
            txt_hoten.DataBindings.Add(new Binding("Text", phieuthu, "Họ Tên", true, DataSourceUpdateMode.Never));
            txt_tongno.DataBindings.Add(new Binding("Text", phieuthu, "Tổng Nợ", true, DataSourceUpdateMode.Never));
            txt_sotienthu.DataBindings.Add(new Binding("Text", phieuthu, "Số Tiền Thu", true, DataSourceUpdateMode.Never));
            dateTimePicker_ngaythu.DataBindings.Add(new Binding("Value", phieuthu, "Ngày Thu", true, DataSourceUpdateMode.Never));
          
            
        }
        #endregion

        #region event
        private void button_tpthu_xemchitiet_Click(object sender, EventArgs e)
        {
            
            Form_ChiTietPhieuThu f = new Form_ChiTietPhieuThu();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void button_tpthu_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        private void button_tpthu_xemtatca_Click(object sender, EventArgs e)
        {
            loaddata();
        }

        private void button_tpthu_xoa_Click(object sender, EventArgs e)
        {

        }
    }
}
