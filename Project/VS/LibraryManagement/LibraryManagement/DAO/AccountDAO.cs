using LibraryManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DAO
{
    class AccountDAO
    {
        public AccountDAO() { }
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new AccountDAO();
                return instance;
            }

            set
            {
                instance = value;
            }
        }
        public AccountDTO GetAccByUsername(string username)
        {
            string query = "SELECT * FROM dbo.NGUOI_DUNG WHERE dbo.NGUOI_DUNG.TenDangNhap = '" + username + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                return new AccountDTO(item);
            }
            return null;
        }
        public string TenNhomNguoiDung(string username)
        {
            string query = "dbo.usp_nhomnguoidung @username = N'"+username+"'";
            string data = DataProvider.Instance.ExecuteReader(query);
            return data;
        }
        public bool Update_info_user(string username,string password, string newpass)
        {
            int rs = DataProvider.Instance.ExecuteNonQuery("EXEC dbo.usp_UpdateAccount @username , @password , @newpassword ", new object[] { username, password, newpass });

            return rs>0;
        }
    }
}
