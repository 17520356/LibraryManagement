using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DTO
{
    public class AccountDTO
    {
        private string username;
        private string password;
        private int type;

        public string Username
        {
            get
            {
                return username;
            }

            set
            {
                username = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        public int Type
        {
            get
            {
                return type;
            }

            set
            {
                type = value;
            }
        }

        public AccountDTO(string username,int type, string password = null)
        {
            this.Username = username;
            this.Type = type;
            this.Password = password;
        }
        public AccountDTO(DataRow row)
        {
            this.Username = row["TenDangNhap"].ToString();
            this.Type = (int)row["MaNhom"];
            this.Password = row["MatKhau"].ToString();
        }
    }
}
