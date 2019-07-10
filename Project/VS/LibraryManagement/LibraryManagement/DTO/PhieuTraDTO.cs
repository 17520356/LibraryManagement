using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DTO
{
    public class PhieuTraDTO
    {
        private int masach;
        private string tensach;
        private DateTime ngaymuon;
        private int songaymuon;
        private string tienphattungsach;

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

        public string Tensach
        {
            get
            {
                return tensach;
            }

            set
            {
                tensach = value;
            }
        }

        public DateTime Ngaymuon
        {
            get
            {
                return ngaymuon;
            }

            set
            {
                ngaymuon = value;
            }
        }

        public int Songaymuon
        {
            get
            {
                return songaymuon;
            }

            set
            {
                songaymuon = value;
            }
        }

        public string Tienphattungsach
        {
            get
            {
                return tienphattungsach;
            }

            set
            {
                tienphattungsach = value;
            }
        }
        #endregion


        public PhieuTraDTO(int maphieutra, int masach, string tensach, DateTime ngaymuon, int songaymuon, string tienphattungsach)
        {
            this.Masach = masach;
            this.Tensach = tensach;
            this.Ngaymuon = ngaymuon;
            this.Songaymuon = songaymuon;
            this.Tienphattungsach = tienphattungsach;
        }
        public PhieuTraDTO(DataRow row)
        {
            this.Masach = (int)row["Mã Sách"];
            this.Tensach = row["Tên Sách"].ToString();
            this.Ngaymuon = (DateTime)row["Ngày Mượn"];
            this.Songaymuon = (int)row["Số Ngày Trễ"];
            this.Tienphattungsach = row["Tiền Phạt"].ToString();

        }
    }
}
