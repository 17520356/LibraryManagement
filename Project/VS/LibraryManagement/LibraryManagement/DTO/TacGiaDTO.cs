using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DTO
{
    public  class TacGiaDTO
    {
        private int matacgia;
        private string tentacgia;
        private string diachi;
        private string sodienthoai;
        private DateTime? ngaysinh;
        private string ghichu;

        #region khoitao
        public int Matacgia
        {
            get
            {
                return matacgia;
            }

            set
            {
                matacgia = value;
            }
        }

        public string Tentacgia
        {
            get
            {
                return tentacgia;
            }

            set
            {
                tentacgia = value;
            }
        }

        public string Diachi
        {
            get
            {
                return diachi;
            }

            set
            {
                diachi = value;
            }
        }

        public string Sodienthoai
        {
            get
            {
                return sodienthoai;
            }

            set
            {
                sodienthoai = value;
            }
        }

        public DateTime? Ngaysinh
        {
            get
            {
                return ngaysinh;
            }

            set
            {
                ngaysinh = value;
            }
        }

        public string Ghichu
        {
            get
            {
                return ghichu;
            }

            set
            {
                ghichu = value;
            }
        }
        #endregion

        public TacGiaDTO(int matacgia,string tentacgia,string diachi,string sodienthoai,string ghichu,DateTime? ngaysinh)
        {
            this.Matacgia = matacgia;
            this.Tentacgia = tentacgia;
            this.Diachi = diachi;
            this.Sodienthoai = sodienthoai;
            this.Ghichu = ghichu;
            this.Ngaysinh = ngaysinh;
        }
        public TacGiaDTO(DataRow row)
        {
            this.Matacgia = (int)row["Matacgia"];
            this.Tentacgia = row["Tentacgia"].ToString();
            this.Diachi = row["Diachi"].ToString();
            this.Sodienthoai = row["Sodienthoai"].ToString();
            this.Ghichu = row["Ghichu"].ToString();
            var ngaysinhTemp = row["ngaysinh"];
            if (ngaysinhTemp.ToString() != "")
                this.Ngaysinh = (DateTime?)ngaysinhTemp;
        }
    }
}
