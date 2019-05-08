using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DAO
{
    public class DataProvider
    {
        private static DataProvider instance;

        public static DataProvider Instance
        {
            get
            {
                if (instance == null)
                    instance = new DataProvider();
                return DataProvider.instance;
            }

           private set
            {
                DataProvider.instance = value;
            }
        }

        private DataProvider() { }

        private string connectionSTR = "Data Source=PINKGERMANY;Initial Catalog=LibraryManagement;Integrated Security=True";

        DataTable data = new DataTable();

        public DataTable ExecuteQuery(string query)
        {
          
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(data);

                connection.Close();
            }
            return data;
        }
    }
}
