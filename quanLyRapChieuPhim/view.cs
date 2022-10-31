using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanLyRapChieuPhim
{
    public partial class view : Form
    {
        connection db = new connection();
        public view()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.table("SELECT * FROM ExView");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmQuanLyRapChieuPhim frmQuanLyRapChieuPhim = new frmQuanLyRapChieuPhim();
            frmQuanLyRapChieuPhim.Show();
            this.Hide();
        }
    }
}
