using LibraryManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DAO
{
   public class ChiTietPhieuMuonDAO
    {
        private static ChiTietPhieuMuonDAO instance;

        public static ChiTietPhieuMuonDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new ChiTietPhieuMuonDAO();
                return instance;
            }

            set
            {
                instance = value;
            }
        }
        ChiTietPhieuMuonDAO() { }

        public List<ChiTietPhieuMuonDTO> hienthiphieumuon(int maphieumuon)
        {
            List<ChiTietPhieuMuonDTO> phieumuon = new List<ChiTietPhieuMuonDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC dbo.chitietphieumuon @maphieumuon ="+maphieumuon+ "");
            foreach (DataRow item in data.Rows)
            {
                ChiTietPhieuMuonDTO pm = new ChiTietPhieuMuonDTO(item);
                phieumuon.Add(pm);
            }
            return phieumuon;
        }

    }
}
