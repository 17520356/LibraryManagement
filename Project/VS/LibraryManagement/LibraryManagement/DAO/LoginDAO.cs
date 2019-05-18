using LibraryManagement.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LibraryManagement.DAO
{
    public class LoginDAO
    {
        private LoginDAO() { }
        private static LoginDAO instance;
        public static LoginDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new LoginDAO();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }
        public bool checklogin(string username, string password)
        {
            string query = "usp_login @username , @password";
            DataTable result = DataProvider.Instance.ExecuteQuery(query,new object[] {username , password });
            if (result.Rows.Count > 0)
                return true;
            return false;
        }
        public bool checkUsername(string username)
        {
            string query = "usp_check_login @username ";
            DataTable result = DataProvider.Instance.ExecuteQuery(query,new object[] { username });
            if (result.Rows.Count > 0)
                return true;
            return false;
        }
  
    }
}

