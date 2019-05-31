using LibraryManagement.DAO;
using LibraryManagement.DTO;
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
        private DocGiaDTO docgia;
        BindingSource docgia_Data = new BindingSource();

        public DocGiaDTO Docgia
        {
            get
            {
                return docgia;
            }

            set
            {
                docgia = value;
            }
        }

        public Form_TimDocGia()
        {
            InitializeComponent();
            load();
        }
      
        #region method
        void load()
        {
            dataGridView_docgia.DataSource = docgia_Data;
            LoadDocGia();
            Bindingdocgia();
        }
        void LoadDocGia()
        {
            docgia_Data.DataSource = DocGiaDAO.Instance.loaddata();
        }
        void Bindingdocgia()
        {
            txt_hoten.DataBindings.Add(new Binding("text", docgia_Data, "Họ Tên", true, DataSourceUpdateMode.Never));
            txt_ngaylapthe.DataBindings.Add(new Binding("text", docgia_Data, "Ngày Lập Thẻ", true, DataSourceUpdateMode.Never));
            txt_ngayhethan.DataBindings.Add(new Binding("text", docgia_Data, "Ngày Hết Hạn", true, DataSourceUpdateMode.Never));
            txt_sosachdangmuon.DataBindings.Add(new Binding("text", docgia_Data, "Số Sách Mượn", true, DataSourceUpdateMode.Never));
            txt_madocgia.DataBindings.Add(new Binding("text", docgia_Data, "Mã Độc Giả", true, DataSourceUpdateMode.Never));
        }
        #endregion

        #region event

        private void button_dg_xemtatca_Click(object sender, EventArgs e)
        {
            LoadDocGia();
        }

        private void button_dg_phieutra_Click(object sender, EventArgs e)
        {
            Form_LapPhieuTra f = new Form_LapPhieuTra();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void button_dg_xemchitiet_Click(object sender, EventArgs e)
        {
            if (txt_madocgia.Text != "")
            {
                int temp = Convert.ToInt32(txt_madocgia.Text);
                Form_ChiTietDocGia f = new Form_ChiTietDocGia(temp);
                this.Hide();
                f.ShowDialog();
                this.Show();
                LoadDocGia();
            }
        }

        private void button_dg_lapphieumuon_Click(object sender, EventArgs e)
        {
            Form_LapPhieuMuon f = new Form_LapPhieuMuon();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void button_xoadocgia_Click(object sender, EventArgs e)
        {
            if (txt_madocgia.Text != "")
            {
                docgia = DocGiaDAO.Instance.GetDocGiabyID(Convert.ToInt32(txt_madocgia.Text));
                if (MessageBox.Show("Bạn có thực sự muốn xóa độc giả " + docgia.Hoten + "\n Chú ý: Khi xóa độc giả, các phiếu có liên quan đến độc giả cũng bị xóa theo.", "Thông Báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    int rs = DocGiaDAO.Instance.delete_docgia(docgia.Madocgia);
                    if (rs == -2)
                        MessageBox.Show("Không Thể Xóa. Độc Giả Vẫn Còn Sách Đang Mượn");
                    if (rs == -3)
                        MessageBox.Show("Không Thể Xóa. Độc Giả Vẫn Chưa Trả Hết Nợ.");
                    if (rs == 0)
                        MessageBox.Show("Xóa Thất Bại");
                    if (rs == 1)
                        MessageBox.Show("Xóa Thành Công");
                    LoadDocGia();
                }
            }
        }
        #endregion
    }
}
