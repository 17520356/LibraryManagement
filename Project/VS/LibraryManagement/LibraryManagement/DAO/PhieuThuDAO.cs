using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DAO
{
    public class PhieuThuDAO
    {
        private static PhieuThuDAO instance;

        public static PhieuThuDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new PhieuThuDAO();
                return instance;
            }

            set
            {
                instance = value;
            }
        }
        public PhieuThuDAO() { }
        public DataTable search(string hoten)
        {
            int maphieuthu = Convert.ToInt32(DataProvider.Instance.ExecuteReader("EXEC dbo.timkiemphieuthu @hoten = N'" + hoten + "'"));

            string query = "EXEC dbo.timkiempthu @maphieuthu = " + maphieuthu + " ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            return data;
        }
    }
}
