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
        private bool ktphieuthu = false;
        #region method
        void loaddata()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC dbo.hienthiphieuthu");
            if (data.Rows.Count > 0)
            {
                phieuthu.DataSource = data;
                ktphieuthu = true;
            }
        }
        void BindingPhieuThu()
        {
            if (ktphieuthu == true)
            {
                txt_maphiethu.DataBindings.Add(new Binding("Text", phieuthu, "Mã Phiếu Thu", true, DataSourceUpdateMode.Never));
                txt_hoten.DataBindings.Add(new Binding("Text", phieuthu, "Họ Tên", true, DataSourceUpdateMode.Never));
                txt_tongno.DataBindings.Add(new Binding("Text", phieuthu, "Tổng Nợ Lúc Thu", true, DataSourceUpdateMode.Never));
                txt_sotienthu.DataBindings.Add(new Binding("Text", phieuthu, "Số Tiền Thu", true, DataSourceUpdateMode.Never));
                txt_conlai.DataBindings.Add(new Binding("Text", phieuthu, "Còn Lại", true, DataSourceUpdateMode.Never));
                dateTimePicker_ngaythu.DataBindings.Add(new Binding("Value", phieuthu, "Ngày Thu", true, DataSourceUpdateMode.Never));
            }
        }
        #endregion

        #region event

        private void button_tpthu_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        private void button_tpthu_xemtatca_Click(object sender, EventArgs e)
        {
            loaddata();
        }
        public int getmax()
        {
            string temp = DataProvider.Instance.ExecuteReader("SELECT MAX(Maphieuthu) FROM dbo.PHIEU_THU");
            if (temp != "")
            {
                int rs = Convert.ToInt32(temp);
                return rs;
            }
            return 0;
        }
        bool xoaphieuthu(int maphieuthu)
        {
            int rs = DataProvider.Instance.ExecuteNonQuery("DELETE dbo.PHIEU_THU WHERE Maphieuthu='"+maphieuthu+"'");
            DataProvider.Instance.ExecuteNonQuery("DBCC CHECKIDENT ('dbo.PHIEU_THU', RESEED," + getmax() + ")");
            return rs > 0;

        }
        private void button_tpthu_xoa_Click(object sender, EventArgs e)
        {
            int maphieuthu=0;
            if(ktphieuthu==true)
            {
                maphieuthu = Convert.ToInt32(txt_maphiethu.Text);
                if (MessageBox.Show("Bạn muốn xóa phiếu thu "+maphieuthu+" thuộc độc giả "+txt_hoten.Text+"?", "Thông Báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    if (xoaphieuthu(maphieuthu) == true)
                        MessageBox.Show("Xóa thành công!");
                    loaddata();
                }
            }
        }
    }
}
