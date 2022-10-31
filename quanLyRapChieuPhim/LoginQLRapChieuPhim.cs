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
    public partial class LoginQLRapChieuPhim : Form
    {
        LoginConnect db = new LoginConnect();
        public LoginQLRapChieuPhim()
        {
            InitializeComponent();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (db.conn)
                {
                    SqlCommand cmd = new SqlCommand("sp_role_login", db.conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    db.conn.Open();
                    cmd.Parameters.AddWithValue("@uname", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@upass", txtPassword.Text);
                    SqlDataReader rd = cmd.ExecuteReader();
                    if (rd.HasRows)
                    {
                        rd.Read();
                        if (rd[4].ToString() == "Admin")
                        {
                            LoginConnect.type = "A";
                        }
                        else if (rd[4].ToString() == "User")
                        {
                            LoginConnect.type = "U";
                        }
                        frmQuanLyRapChieuPhim d = new frmQuanLyRapChieuPhim();
                        d.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("ERROR");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoginQLRapChieuPhim_Load(object sender, EventArgs e)
        {

        }
    }
}
