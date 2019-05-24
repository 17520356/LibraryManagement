using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DAO
{
    public class ParaDAO
    {
        public ParaDAO() { }
        private static ParaDAO instance;

        public static ParaDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new ParaDAO();
                return instance;
            }

            set
            {
                instance = value;
            }
        }
        public string load_quidinhDAO(string thamso)
        {
            string rs =DataProvider.Instance.ExecuteReader("SELECT giatri FROM dbo.THAM_SO WHERE Tenthamso = '"+thamso+"';");
            return rs;
        }
        public string update_quidinh(string thamso, int giatri)
        {
            string rs = DataProvider.Instance.ExecuteReader("EXEC dbo.update_quidinh_docgia @thamso = N'"+thamso+"', @giatri = '" + giatri + "'");
            return rs;
        }

    }
  
}
