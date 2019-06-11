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
using System.Globalization;

namespace LibraryManagement
{
    public partial class Form_LapPhieuThu : Form
    {
        private DocGiaDTO docgia;

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

        public Form_LapPhieuThu()
        {
            InitializeComponent();
            loaddata();
        }
        #region method

        void loaddata()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT Madocgia[Mã Độc Giả], Hoten[Họ Tên], Tongno[Tổng Nợ] FROM dbo.DOC_GIA");

            if (data.Rows.Count > 0)
            {
                cmb_madg.DisplayMember = "Mã Độc Giả";
                cmb_madg.ValueMember = "Mã Độc Giả";
                cmb_madg.DataSource = data;

                comboBox_ten.DisplayMember = "Họ Tên";
                comboBox_ten.ValueMember = "Mã Độc Giả";
                comboBox_ten.DataSource = data;

                cmb_madg.SelectedIndex = 0;
                comboBox_ten.SelectedIndex = 0;
            }
            else
            {
                cmb_madg.DataSource = null;
                comboBox_ten.DataSource = null;
            }
            dateTimePicker_lpthu_ngaythu.Value = DateTime.Now;
        }

        void loadtongno(string tt)
        {
            int id = Convert.ToInt32(tt);
            docgia = DocGiaDAO.Instance.GetDocGiabyID(id);
            // txt_lpthu_tongno.Text = docgia.Tongno;
            float temp = (float)Convert.ToDouble(docgia.Tongno);
            txt_lpthu_tongno.Text = temp.ToString();
        }

        public bool IsNumber(string pValue)
        {
            foreach (Char c in pValue)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }

        void capnhatphieuthu(float sotienthu)
        {
            
            int themphieuthu = DataProvider.Instance.ExecuteNonQuery("INSERT INTO dbo.PHIEU_THU ( Madocgia , Ngaythu , Sotienthu , Tongnolucthu  )VALUES  ("+docgia.Madocgia+" , '"+dateTimePicker_lpthu_ngaythu.Value+"' , "+sotienthu+" ,"+docgia.Tongno+" )");
            int capnhattongno = DataProvider.Instance.ExecuteNonQuery("UPDATE dbo.DOC_GIA SET Tongno -='" + sotienthu + "' WHERE Madocgia='" + docgia.Madocgia + "'");
            if ((capnhattongno > 0)&&(themphieuthu>0))
                MessageBox.Show("Lập Phiếu Thu Thành Công");
            else
                MessageBox.Show("Lập Phiếu Thu Thất Bại");
            loaddata();
        }

        #endregion

        #region event

        private void button_lptthu_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmb_madg_SelectedIndexChanged(object sender, EventArgs e)
        {
            string temp = cmb_madg.SelectedValue.ToString();
            loadtongno(temp);
            txt_lpthu_sotienthu.ResetText();
            txt_lpthu_conlai.ResetText();
        }

        private float sotienthu=0;

        private void button_lpthu_Click(object sender, EventArgs e)
        {
            if (sotienthu!=0)
            {
                capnhatphieuthu(sotienthu);
                sotienthu = 0;
            }
        }

        private void txt_lpthu_sotienthu_TextChanged(object sender, EventArgs e)
        {
            float temp, conlai;
            float tongno = (float)Convert.ToDouble(docgia.Tongno);
            if (txt_lpthu_sotienthu.Text != "")
            {
                if (IsNumber(txt_lpthu_sotienthu.Text) == false)
                {
                    MessageBox.Show("Số tiền nhập chưa đúng!!\nMời nhập lại!");
                    txt_lpthu_sotienthu.ResetText();
                }
                else
                {
                    temp = (float)Convert.ToDouble(txt_lpthu_sotienthu.Text);
                    if (temp > tongno)
                    {
                        MessageBox.Show("Số Tiền Thu Khong Được Lớn Hơn Tổng Nợ! \nMời Nhập Lại!");
                        txt_lpthu_sotienthu.ResetText();
                    }
                    else
                    {
                        temp = (float)Convert.ToDouble(txt_lpthu_sotienthu.Text);
                        conlai = tongno - temp;
                        txt_lpthu_conlai.Text = conlai.ToString();
                        sotienthu = temp;
                    }
                }
            }
        }

        #endregion
    }
}