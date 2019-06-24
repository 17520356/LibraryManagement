using LibraryManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DAO
{
    public class PhieuTraDAO
    {
        private static PhieuTraDAO instance;

        public static PhieuTraDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new PhieuTraDAO();
                return instance;
            }

            set
            {
                instance = value;
            }
        }
        PhieuTraDAO() { }
        public int getmax_phieutra()
        {
            string temp = DataProvider.Instance.ExecuteReader("SELECT MAX(Maphieutra) FROM dbo.PHIEU_TRA");
            if (temp != "")
            {
                int rs = Convert.ToInt32(temp);
                return rs;
            }
            return 0;
        }
        public List<PhieuTraDTO> hienthiphieutra(int masach)
        {

            List<PhieuTraDTO> phieutra = new List<PhieuTraDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC dbo.LIST_phieutra @masach = " + masach + "");
            foreach (DataRow item in data.Rows)
            {
                PhieuTraDTO pt = new PhieuTraDTO(item);
                phieutra.Add(pt);
            }
            return phieutra;
        }
        public List<PhieuTraDTO> chitietphieutra(int maphieutra)
        {
            List<PhieuTraDTO> phieutra = new List<PhieuTraDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC dbo.chitietphieutra @maphieutra = '" + maphieutra+"'");
            foreach (DataRow item in data.Rows)
            {
                PhieuTraDTO pt = new PhieuTraDTO(item);
                phieutra.Add(pt);
            }
            return phieutra;
        }

    }
}
