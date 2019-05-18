using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DTO
{
   public  class User_DTO
    {
        public string username;
        public string password;
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
        public User_DTO() { }
        public User_DTO(string username,string password)
        {
            this.username = username;
            this.password = password;
        }
       
    }
}
