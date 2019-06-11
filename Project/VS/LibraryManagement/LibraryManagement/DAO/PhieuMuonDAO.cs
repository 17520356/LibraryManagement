using LibraryManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DAO
{
    public class PhieuMuonDAO
    {
        private static PhieuMuonDAO instance;

        public static PhieuMuonDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new PhieuMuonDAO();
                return instance;
            }

            set
            {
                instance = value;
            }
        }
        public PhieuMuonDAO() { }

        public List<LapPhieuMuonDTO> hienthiphieumuon(int masach)
        {
            int madausach = Convert.ToInt32(DataProvider.Instance.ExecuteReader("SELECT Madausach FROM dbo.CUONSACH WHERE Masach='" + masach + "'"));
            List<LapPhieuMuonDTO> phieumuon = new List<LapPhieuMuonDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC phieumuon @masach = "+masach+" , @madausach= "+madausach+"");
            foreach(DataRow item in data.Rows)
            {
                LapPhieuMuonDTO pm = new LapPhieuMuonDTO(item);
                phieumuon.Add(pm);
            }
            return phieumuon;
        }
        public int getmax_pm()
        {
            string temp = DataProvider.Instance.ExecuteReader("SELECT MAX(Maphieumuon) FROM dbo.PHIEU_MUON");
            if (temp != "")
            {
                int rs = Convert.ToInt32(temp);
                return rs;
            }
            return 0;
        }

    }
}
