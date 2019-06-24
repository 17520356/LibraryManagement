using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DTO
{
    public class ChiTietPhieuMuonDTO
    {
        private int masach;
        private string tensach;
        private DateTime ngayhethan;
        private string tinhtrang;

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

        public string Tinhtrang
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

        public ChiTietPhieuMuonDTO(int masach, string tensach, DateTime ngayhethan, string tinhtrang)
        {
            this.Masach = masach;
            this.Tensach = tensach;
            this.Ngayhethan = ngayhethan;
            this.Tinhtrang = tinhtrang;
        }
        public ChiTietPhieuMuonDTO(DataRow row)
        {
            this.Masach = (int)row["Mã Sách"];
            this.Tensach = row["Tên Sách"].ToString();
            this.Ngayhethan =(DateTime)row["Ngày Hết Hạn"];
            this.Tinhtrang = row["Tình Trạng"].ToString();

        }
    }
}
