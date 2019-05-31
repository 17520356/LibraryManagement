using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DAO
{
    public class TypeDAO
    {
        private TypeDAO() { }
        private static TypeDAO instance;

        public static TypeDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new TypeDAO();
                return instance;
            }

            set
            {
                instance = value;
            }
        }

        public bool checktentheloai(string tentheloai)
        {
            int rs  = Convert.ToInt32(DataProvider.Instance.ExecuteReader("SELECT count(*) FROM dbo.THE_LOAI WHERE Ten='"+tentheloai+"'"));
            return rs >0;
        }

        public bool insert_theloai(string tentheloai)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT  * FROM dbo.THE_LOAI");
            if(data.Rows.Count<=0)
               DataProvider.Instance.ExecuteNonQuery("DBCC CHECKIDENT ('dbo.THE_LOAI', RESEED," + getmax() + ")");
            int rs = DataProvider.Instance.ExecuteNonQuery("INSERT INTO dbo.THE_LOAi ( Ten )	VALUES  ( N'"+tentheloai+"')");
            return rs > 0;
        }

        public bool update_theloai(int matheloai, string tentheloai)
        {
            int rs = DataProvider.Instance.ExecuteNonQuery("UPDATE dbo.THE_LOAI SET Ten ='"+tentheloai+"' WHERE Matheloai='"+matheloai+"'");
            return rs > 0;
        }

        public bool delete_theloai(int matheloai)
        {
            int rs = DataProvider.Instance.ExecuteNonQuery("DELETE FROM dbo.THE_LOAI WHERE Matheloai='"+matheloai+"'");
            DataProvider.Instance.ExecuteNonQuery("DBCC CHECKIDENT ('dbo.THE_LOAI', RESEED," + getmax() + ")");
            return rs > 0;
        }

        public bool checkdelete(int matheloai)
        {
            string rs = DataProvider.Instance.ExecuteReader("SELECT * FROM dbo.DAUSACH WHERE Matheloai = '" + matheloai + "'");
            return rs!=null;
        }

        public int getmax()
        {
            string temp= DataProvider.Instance.ExecuteReader("SELECT MAX(Matheloai) FROM dbo.THE_LOAI");
            if(temp!="")
            {
                int rs = Convert.ToInt32(temp);
                return rs ;
            }
            return 0;
        }

    }
}
