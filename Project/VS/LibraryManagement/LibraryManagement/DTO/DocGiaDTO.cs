using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DTO
{
    public class DocGiaDTO
    {
        private int madocgia;
        private int maloaidg;
        private string hoten;
        private DateTime? ngaysinh;
        private string diachi;
        private string sodienthoai;
        private int gioitinh;
        private DateTime ngaylapthe;
        private DateTime ngayhethan;
        private string email;
        private int sosachmuon;
        private string tongno;
        private int tinhtrang;

        #region khoitao
        public int Madocgia
        {
            get
            {
                return madocgia;
            }

            set
            {
                madocgia = value;
            }
        }

        public int Maloaidg
        {
            get
            {
                return maloaidg;
            }

            set
            {
                maloaidg = value;
            }
        }

        public string Hoten
        {
            get
            {
                return hoten;
            }

            set
            {
                hoten = value;
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

        public int Gioitinh
        {
            get
            {
                return gioitinh;
            }

            set
            {
                gioitinh = value;
            }
        }

        public DateTime Ngaylapthe
        {
            get
            {
                return ngaylapthe;
            }

            set
            {
                ngaylapthe = value;
            }
        }

        public DateTime Ngayhethan
        {
            get
            {
                return ngayhethan;
            }

            set
            {
                ngayhethan = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public int Sosachmuon
        {
            get
            {
                return sosachmuon;
            }

            set
            {
                sosachmuon = value;
            }
        }

        public string Tongno
        {
            get
            {
                return tongno;
            }

            set
            {
                tongno = value;
            }
        }

        public int Tinhtrang
        {
            get
            {
                return tinhtrang;
            }

            set
            {
                tinhtrang = value;
            }
        }
        #endregion

        public DocGiaDTO(int madocgia,int maloaidg,string hoten,DateTime? ngaysinh,int gioitinh,DateTime ngaylapthe,DateTime ngayhethan,string email,int sosachmuon,string tongno,int tinhtrang, string diachi = null, string sodienthoai = null)
        {
            this.Madocgia = madocgia;
            this.Maloaidg = maloaidg;
            this.Hoten = hoten;
            this.Ngaysinh = ngaysinh;
            this.Gioitinh = gioitinh;
            this.Ngaylapthe = ngaylapthe;
            this.Ngayhethan = ngayhethan;
            this.Email = email;
            this.Sosachmuon = sosachmuon;
            this.Tongno = tongno;
            this.Tinhtrang = tinhtrang;
            this.Diachi = diachi;
            this.Sodienthoai = sodienthoai;
        }

        public DocGiaDTO (DataRow row)
        {
            this.Madocgia = (int)row["Madocgia"];
            this.Maloaidg = (int)row["maloaidg"];
            this.Hoten = row["hoten"].ToString();
            var ngaysinhTemp = row["ngaysinh"];
            if(ngaysinhTemp.ToString()!="")
                this.Ngaysinh = (DateTime?)ngaysinhTemp;
            if(gioitinh.ToString() !="")
                this.gioitinh = (int)row["gioitinh"];
            this.Ngaylapthe = (DateTime)row["ngaylapthe"];
            this.Ngayhethan = (DateTime)row["ngayhethan"];
            this.Email = row["email"].ToString();
            this.Sosachmuon = (int)row["sosachmuon"];
            this.Tongno = row["tongno"].ToString();
            this.Tinhtrang = (int)row["tinhtrang"];
            if(row["sodienthoai"].ToString()!="")
                this.Sodienthoai = row["sodienthoai"].ToString();
            if(row["Diachi"].ToString()!="")
                this.Diachi = row["Diachi"].ToString();
        }
    }
}
