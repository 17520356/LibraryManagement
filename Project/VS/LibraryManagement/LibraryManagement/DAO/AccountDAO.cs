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

        public DataTable Load_acc()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT TenDangNhap[Tên Đăng Nhập],NGUOI_DUNG.MaNhom[Mã Nhóm],TenNhom[Tên Nhóm] FROM dbo.NGUOI_DUNG,dbo.NHOM_NGUOI_DUNG WHERE NGUOI_DUNG.MaNhom=NHOM_NGUOI_DUNG.MaNhom");
            return data;
        }

        public bool reset_pass(string tendangnhap)
        {
            int rs = DataProvider.Instance.ExecuteNonQuery("UPDATE dbo.NGUOI_DUNG SET MatKhau = '1' WHERE TenDangNhap = '"+tendangnhap+"'");
            return rs > 0;
        }

        public bool check_acc(string tendangnhap)
        {
            string query = "usp_check_login @username ";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { tendangnhap });
            if (result.Rows.Count > 0)
                return true;
            return false;
        }

        public bool insert_acc(string tendangnhap,int manhom)
        {
            int rs = DataProvider.Instance.ExecuteNonQuery("INSERT dbo.NGUOI_DUNG ( TenDangNhap, MatKhau, MaNhom )VALUES  ( N'"+tendangnhap+"',N'1',"+manhom+")");
            return rs > 0;
        }

        public bool update_acc(string tendangnhap,int manhom)
        {
            int rs = DataProvider.Instance.ExecuteNonQuery("UPDATE dbo.NGUOI_DUNG SET MaNhom='"+manhom+"' WHERE TenDangNhap='"+tendangnhap+"'");
            return rs > 0;
        }

        public bool delete_acc(string tendangnhap)
        {
            int rs = DataProvider.Instance.ExecuteNonQuery("DELETE dbo.NGUOI_DUNG WHERE TenDangNhap='"+tendangnhap+"'");
            return rs > 0;

        }
    }
}
