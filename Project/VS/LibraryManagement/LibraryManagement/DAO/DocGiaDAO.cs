using LibraryManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DAO
{
    public class DocGiaDAO
    {
        
        private static DocGiaDAO instance;

        public static DocGiaDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new DocGiaDAO();
                return instance;
            }

            set
            {
                instance = value;
            }
        }

        public DocGiaDAO() { }
        
        public DataTable loaddata()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT Madocgia [Mã Độc Giả],Hoten [Họ Tên],Tenloai [Loại Độc Giả],Ngaylapthe[Ngày Lập Thẻ],Ngayhethan[Ngày Hết Hạn],Sosachmuon[Số Sách Mượn],Tongno [Tổng Nợ] FROM dbo.DOC_GIA,dbo.LOAI_DG WHERE DOC_GIA.Maloaidg=dbo.LOAI_DG.Maloaidg");
            return data;
        }

        public DocGiaDTO GetDocGiabyID(int id)
        {
            string query = "SELECT * FROM dbo.DOC_GIA WHERE Madocgia='" + id + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
         foreach(DataRow item in data.Rows )
            {
                return new DocGiaDTO(item);
            }
            return null;
        }
        public DataTable search(string hoten)
        {
            int madocgia = Convert.ToInt32(DataProvider.Instance.ExecuteReader("EXEC dbo.timkiemdocgia @hoten = N'" + hoten + "'"));

            string query = "EXEC dbo.timdocgiabangiD @madocgia = " + madocgia + " ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            return data;
        }

        public bool update_docgia(int madocgia,string hoten,int maloaidg,DateTime ngaysinh,int gioitinh, string diachi=null,string sodt=null,string email=null)
        {
            string query= "update_docgia @madocgia , @hoten , @maloaidg , @ngaysinh , @gioitinh , @diachi , @sodt , @email ";
            int rs = DataProvider.Instance.ExecuteNonQuery(query,new object[] {madocgia,hoten,maloaidg,ngaysinh,gioitinh,diachi,sodt,email });
            return rs > 0;
        }

        public bool insert_docgia(string hoten ,int maloaidg ,DateTime ngaysinh, int gioitinh,DateTime ngaylapthe,DateTime ngayhethan, string diachi = null, string sodt = null, string email = null)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT  * FROM dbo.DOC_GIA");
            if(data.Rows.Count<=0)
                DataProvider.Instance.ExecuteNonQuery("DBCC CHECKIDENT ('dbo.DOC_GIA', RESEED," + getmax() + ")");
            string query = "insert_docgia @hoten , @maloaidg , @ngaysinh , @gioitinh , @diachi , @sodt , @email , @ngaylapthe , @ngayhethan ";
            int rs = DataProvider.Instance.ExecuteNonQuery(query,new object[] {hoten,maloaidg,ngaysinh,gioitinh,diachi,sodt,email,ngaylapthe,ngayhethan });
            return rs > 0;
            
        }

        public int getmax()
        {
            string temp = DataProvider.Instance.ExecuteReader("SELECT MAX(Madocgia) FROM dbo.DOC_GIA");
            if(temp!="")
            {
                int rs = Convert.ToInt32(temp);
                return rs ;
            }
            return 0;
        }

        public int delete_docgia(int madocgia)
        {
            int sosachmuon = Convert.ToInt32(DataProvider.Instance.ExecuteReader("	SELECT Sosachmuon FROM dbo.DOC_GIA WHERE Madocgia='" + madocgia + "' "));
            float tongno =(float)Convert.ToDouble(DataProvider.Instance.ExecuteReader("SELECT Tongno FROM dbo.DOC_GIA WHERE Madocgia='" + madocgia + "' "));
            if ((sosachmuon == 0) &&(tongno == 0))
            {
                int rs = DataProvider.Instance.ExecuteNonQuery("EXEC dbo.delete_docgia @madocgia = " + madocgia + "");
                if (rs > 0)
                {
                    DataProvider.Instance.ExecuteNonQuery("DBCC CHECKIDENT ('dbo.DOC_GIA', RESEED," + getmax() + ")");
                    return rs = 1;
                }
                return 0;
            }
            else
            {
                if (sosachmuon > 0)
                    return -2;
                return -3;
            }
        }
   
    }
}
