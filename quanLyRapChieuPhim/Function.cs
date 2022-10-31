using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanLyRapChieuPhim
{
    public partial class Function : Form
    {
        SqlConnection sqlConnection = new SqlConnection("Data Source=ADMIN-PC;Initial Catalog=QLRapChieuP;Integrated Security=True");
        public Function()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            string query = "SELECT dbo.[tongTienVe] (@maNhanVien)";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            cmd.Parameters.AddWithValue("@maNhanVien", textBox1.Text);
            cmd.CommandType = CommandType.Text;
            lbResult.Text = "Tổng số tiền vé mà nhân viên có mã " + textBox1.Text + " đã bán ra là: " + cmd.ExecuteScalar().ToString() + "VND";
            sqlConnection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmQuanLyRapChieuPhim frmQuanLyRapChieuPhim = new frmQuanLyRapChieuPhim();
            frmQuanLyRapChieuPhim.Show();
            this.Hide();
        }
    }
}
