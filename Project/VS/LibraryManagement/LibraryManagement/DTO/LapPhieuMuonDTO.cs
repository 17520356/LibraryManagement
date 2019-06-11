using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DTO
{
    public class LapPhieuMuonDTO
    {
        private int masach;
        private string tensach;
        private string theloai;
        private string tentacgia;

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

        public string Theloai
        {
            get
            {
                return theloai;
            }

            set
            {
                theloai = value;
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

        public LapPhieuMuonDTO(int masach,string tensach,string theloai,string tentacgia)
        {
            this.Masach = masach;
            this.Tensach = tensach;
            this.Theloai = theloai;
            this.Tentacgia = tentacgia;
        }
        public LapPhieuMuonDTO(DataRow row)
        {
            this.Masach = (int)row["Mã Sách"];
            this.Tensach = row["Tên Sách"].ToString();
            this.Theloai = row["Thể Loại"].ToString();
            this.Tentacgia = row["Tên Tác Giả"].ToString();

        }
    }
}
