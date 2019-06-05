﻿using LibraryManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DAO
{
    public class SachDAO
    {
        private static SachDAO instance;

        public static SachDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new SachDAO();
                return instance;
            }

            set
            {
                instance = value;
            }
        }

        public SachDAO() { }

        public int getmaxsach()
        {
            string temp = DataProvider.Instance.ExecuteReader("SELECT MAX(Masach) FROM dbo.CUONSACH");
            if (temp != "")
            {
                int rs = Convert.ToInt32(temp);
                return rs;
            }
            return 0;
        }

        public int getmaxdausach()
        {
            string temp = DataProvider.Instance.ExecuteReader("SELECT MAX(Madausach) FROM dbo.DAUSACH");
            if (temp != "")
            {
                int rs = Convert.ToInt32(temp);
                return rs;
            }
            return 0;
        }

        public int xoasach(int masach)
        {
            DataTable temp = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.CUONSACH WHERE Matinhtrang=1 AND Masach='" + masach + "'");
            int maphieumuon = Convert.ToInt32(DataProvider.Instance.ExecuteReader("SELECT Maphieumuon FROM dbo.CHITIET_PHIEUMUON WHERE Masach='"+masach+"'"));
            int maphieutra = Convert.ToInt32(DataProvider.Instance.ExecuteReader("SELECT maphieutra FROM dbo.CHITIET_PHIEUTRA WHERE Masach='" + masach + "'"));
            int mabaocao = Convert.ToInt32(DataProvider.Instance.ExecuteReader("SELECT Mabaocaosachtratre FROM dbo.CHITIET_BAOCAO_TRATRE WHERE Masach='" + masach + "'"));
            int madausach = Convert.ToInt32(DataProvider.Instance.ExecuteReader("SELECT CUONSACH.Madausach FROM dbo.DAUSACH,dbo.CUONSACH WHERE CUONSACH.Madausach=DAUSACH.Madausach AND Masach='"+masach+"'"));
            if (temp.Rows.Count > 0)
            {
                int rs = DataProvider.Instance.ExecuteNonQuery("xoasach @masach ='" + masach + "'");
                if (rs > 0)
                {
                    DataTable ktphieumuon = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.CHITIET_PHIEUMUON WHERE Maphieumuon='"+maphieumuon+"'");
                    DataTable ktphieutra = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.CHITIET_PHIEUTRA WHERE Maphieutra='" + maphieutra+"'");
                    DataTable ktbaocao = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.CHITIET_BAOCAO_THELOAI WHERE Mabaocaotheotheloai='"+mabaocao+"'");
                    if (ktphieumuon.Rows.Count <= 0)
                        DataProvider.Instance.ExecuteNonQuery("DELETE dbo.PHIEU_MUON WHERE Maphieumuon='"+maphieumuon+"'");
                    if(ktphieutra.Rows.Count<=0)
                        DataProvider.Instance.ExecuteNonQuery("DELETE dbo.PHIEU_TRA WHERE Maphieutra='"+maphieutra+"'");
                    if(ktbaocao.Rows.Count<=0)
                        DataProvider.Instance.ExecuteNonQuery("DELETE dbo.BAOCAO_SACH_TRATRE WHERE Mabaocaosachtratre='"+mabaocao+"'");
                    DataProvider.Instance.ExecuteNonQuery("UPDATE dbo.DAUSACH SET Soluong-=1 WHERE Madausach='"+madausach+"'");
                    DataProvider.Instance.ExecuteNonQuery("DBCC CHECKIDENT ('dbo.CUONSACH', RESEED," + getmaxsach() + ")");
                    return 1;
                }
            }
            else
                return -1;
            return 0;
            
        }

        public int xoadausach(int madausach)
        {
            DataTable sach = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.CUONSACH WHERE Madausach='"+madausach+"'");
            int masach,temp=0;
            while(sach.Rows.Count>0)
            {
                masach = Convert.ToInt32(DataProvider.Instance.ExecuteReader("SELECT TOP(1) Masach FROM dbo.CUONSACH,dbo.DAUSACH WHERE CUONSACH.Madausach=DAUSACH.Madausach AND CUONSACH.Madausach='"+madausach+"'"));
                temp = xoasach(masach);
                if ( temp== 1)
                    sach = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.CUONSACH WHERE Madausach='" + madausach + "'");
                else
                    break;
            }
            if (temp == 1)
            {
                DataProvider.Instance.ExecuteNonQuery("DELETE dbo.TACGIA_DAUSACH WHERE Madausach='" + madausach + "'");
                int rs = DataProvider.Instance.ExecuteNonQuery("DELETE dbo.DAUSACH WHERE Madausach='" + madausach + "'");
                DataProvider.Instance.ExecuteNonQuery("DBCC CHECKIDENT ('dbo.DAUSACH', RESEED," + getmaxdausach() + ")");
                if (rs > 0)
                    return 1;
                return 0;
            }
            return temp;
           
        }

        public SachDTO GetBookByID(int masach)
        {
            string query = "SELECT * FROM dbo.CUONSACH WHERE Madausach='"+masach+"'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                return new SachDTO(item);
            }
            return null;
        }
    }
}