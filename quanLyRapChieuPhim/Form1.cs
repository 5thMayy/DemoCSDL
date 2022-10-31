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
    public partial class frmQuanLyRapChieuPhim : Form
    {
        connection db = new connection();
        public frmQuanLyRapChieuPhim()
        {
            InitializeComponent();
        }

        private void frmQuanLyRapChieuPhim_Load(object sender, EventArgs e)
        {
            if (LoginConnect.type == "A")
            {
                btnFunction.Visible = true;
                btnProcedure.Visible = true;
                btnView.Visible = true;
                lbWelcome.Text = "Bạn đang đăng nhập với tư cách admin";
            } else if (LoginConnect.type == "U")
            {
                btnFunction.Visible = false;
                btnProcedure.Visible = false;
                btnView.Visible = false;
                lbWelcome.Text = "Bạn đang đăng nhập với tư cách khách hàng";
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            view exview = new view();
            exview.Show();
            this.Hide();
        }

        private void btnProcedure_Click(object sender, EventArgs e)
        {
            Procedure procedure = new Procedure();
            procedure.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginQLRapChieuPhim lgQLRAP = new LoginQLRapChieuPhim();
            lgQLRAP.Show();
            this.Hide();
        }

        private void btnFunction_Click(object sender, EventArgs e)
        {
            Function function = new Function();
            function.Show();
            this.Hide();
        }
    }
}
