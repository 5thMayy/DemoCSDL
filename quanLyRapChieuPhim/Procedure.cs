using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace quanLyRapChieuPhim
{
    public partial class Procedure : Form
    {
        SqlConnection sqlConnection = new SqlConnection("Data Source=ADMIN-PC;Initial Catalog=QLRapChieuP;Integrated Security=True");
        connection db = new connection();
        public Procedure()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmQuanLyRapChieuPhim frmQuanLyRapChieuPhim = new frmQuanLyRapChieuPhim();
            frmQuanLyRapChieuPhim.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float i;
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("InsertNhanVien", sqlConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@maNhanVien", SqlDbType.NVarChar).Value = textBox1.Text;
            cmd.Parameters.AddWithValue("@hoNhanVien", SqlDbType.NVarChar).Value = textBox2.Text;
            cmd.Parameters.AddWithValue("@tenNhanVien", SqlDbType.NVarChar).Value = textBox4.Text;
            cmd.Parameters.AddWithValue("@diaChi", SqlDbType.NVarChar).Value = textBox3.Text;
            cmd.Parameters.AddWithValue("@soDienThoai", SqlDbType.Char).Value = textBox5.Text;
            cmd.Parameters.AddWithValue("@ngaySinh", SqlDbType.NVarChar).Value = dateTimePicker1.Value;
            cmd.Parameters.AddWithValue("@gioiTinh", SqlDbType.NVarChar).Value = textBox8.Text;
            cmd.Parameters.AddWithValue("@luong", SqlDbType.Float).Value = float.TryParse(textBox7.Text, out i);
            cmd.Parameters.AddWithValue("@caLamViec", SqlDbType.NVarChar).Value = textBox6.Text;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Đã thêm nhân viên");
            sqlConnection.Close();
            dataGridView1.DataSource = db.table("SELECT * FROM NhanVien");
        }

        private void Procedure_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            // Update
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("EXEC UpdateNhanVien '" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox4.Text + "', '" + textBox3.Text + "', '" + textBox5.Text + "', '" + dateTimePicker1.Text + "', '" + textBox8.Text + "', '" + textBox7.Text + "', '" + textBox6.Text + "'", sqlConnection);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Đã sửa nhân viên");
            sqlConnection.Close();
            dataGridView1.DataSource = db.table("SELECT * FROM NhanVien");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("EXEC DeleteNhanVien '" + textBox1.Text + "'", sqlConnection);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Đã xóa nhân viên");
            sqlConnection.Close();
            dataGridView1.DataSource = db.table("SELECT * FROM NhanVien");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmQuanLyRapChieuPhim frmQuanLyRapChieuPhim = new frmQuanLyRapChieuPhim();
            frmQuanLyRapChieuPhim.Show();
            this.Hide();
        }
    }
}
