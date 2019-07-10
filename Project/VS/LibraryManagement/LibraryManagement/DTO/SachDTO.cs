using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DTO
{
    public class SachDTO
    {
        private int masach;
        private int madausach;
        private int matinhtrang;
        private DateTime ngaynhap;
        #region khoitao
        public int Masach
        {
            get
            {
                return masach;
            }

            set
            {
                masach = value;
            }
        }

        public int Madausach
        {
            get
            {
                return madausach;
            }

            set
            {
                madausach = value;
            }
        }

        public int Matinhtrang
        {
            get
            {
                return matinhtrang;
            }

            set
            {
                matinhtrang = value;
            }
        }

        public DateTime Ngaynhap
        {
            get
            {
                return ngaynhap;
            }

            set
            {
                ngaynhap = value;
            }
        }
        #endregion
        

        public SachDTO(int masach,int madausach,int matinhtrang,int matheloai,DateTime ngaynhap)
        {
            this.Masach = masach;
            this.Madausach = madausach;
            this.Matinhtrang = matinhtrang;
            this.Ngaynhap = ngaynhap;
        }
        public SachDTO(DataRow row)
        {
            this.Masach = (int)row["Masach"];
            this.Madausach = (int)row["Madausach"];
            this.Matinhtrang = (int)row["Matinhtrang"];
            this.Ngaynhap = (DateTime)row["Ngaynhap"];
        }
    }
}
