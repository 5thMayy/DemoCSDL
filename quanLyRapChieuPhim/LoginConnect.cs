using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace quanLyRapChieuPhim
{
    class LoginConnect
    {
        public SqlConnection conn;
        public static string connect = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Ki1Nam3\SQL\BaiTapLonSQL\quanLyRapChieuPhim\quanLyRapChieuPhim\Login.mdf;Integrated Security=True";
        public LoginConnect()
        {
            conn = new SqlConnection(connect);
        }
        public static string type;
    }
}
