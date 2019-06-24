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
    public partial class Form_ChiTietPhieuTra : Form
    {
        int maphieutra;
        public Form_ChiTietPhieuTra(int id)
        {
            InitializeComponent();
            this.maphieutra = id;
            hienthi();
        }
        #region method
        void hienthi()
        {
            hienthithongtindocgia();
            List<PhieuTraDTO> chitietpt = PhieuTraDAO.Instance.chitietphieutra(maphieutra);
            dateTimePicker_ngaytra.Value = Convert.ToDateTime(DataProvider.Instance.ExecuteReader("SELECT Ngaytra FROM dbo.PHIEU_TRA WHERE Maphieutra='" + maphieutra + "'"));
            foreach (PhieuTraDTO item in chitietpt)
            {
                ListViewItem danhsach = new ListViewItem(item.Masach.ToString());
                danhsach.SubItems.Add(item.Tensach);
                danhsach.SubItems.Add(item.Ngaymuon.ToString());
                danhsach.SubItems.Add(item.Songaymuon.ToString());
                danhsach.SubItems.Add(item.Tienphattungsach);
                listView_sach.Items.Add(danhsach);
            }
        }
        void hienthithongtindocgia()
        {
            string madocgia = DataProvider.Instance.ExecuteReader("SELECT Madocgia FROM dbo.PHIEU_TRA WHERE Maphieutra= '" + maphieutra + "'");
            string tendocgia= DataProvider.Instance.ExecuteReader("SELECT Hoten FROM dbo.PHIEU_TRA,dbo.DOC_GIA WHERE Maphieutra= '" + maphieutra + "' AND DOC_GIA.Madocgia=PHIEU_TRA.Madocgia");
            string tienphat = DataProvider.Instance.ExecuteReader("SELECT Tienphat FROM dbo.PHIEU_TRA WHERE Maphieutra= '" + maphieutra + "' ");
            string tongno = DataProvider.Instance.ExecuteReader("SELECT Tongno FROM dbo.DOC_GIA,dbo.PHIEU_TRA WHERE Maphieutra= '" + maphieutra + "'  AND DOC_GIA.Madocgia=PHIEU_TRA.Madocgia");
            txt_hoten.Text = tendocgia;
            txt_madocgia.Text = madocgia;
            txt_tienphat.Text = tienphat;
            txt_tongno.Text = tongno;
        }

        #endregion

        private void button_ctpm_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
