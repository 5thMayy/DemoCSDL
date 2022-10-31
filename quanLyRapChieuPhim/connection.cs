using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanLyRapChieuPhim
{
    class connection
    {
        private SqlConnection sqlConnection;
        private static string connect = @"Data Source=ADMIN-PC;Initial Catalog=QLRapChieuP;Integrated Security=True";
        private SqlDataAdapter sqlDataAdapter;
        private SqlCommand sqlCommand;
        public DataTable table(string query) // Lấy bảng dữ liệu ra
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection sqlConnection = new SqlConnection(connect))
            {
                sqlConnection.Open();
                sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
                sqlDataAdapter.Fill(dataTable);
                sqlConnection.Close();
            }
            return dataTable;
        }

        public void Excute(string query) // Dung de thuc thi cac cau lenh truy van
        {
            using (SqlConnection sqlConnection = new SqlConnection(connect))
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.ExecuteNonQuery(); // Thuc thi cau lenh
                sqlConnection.Close();
            }
        }
    }
}
