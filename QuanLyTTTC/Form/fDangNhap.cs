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

namespace QuanLyTTTC
{
    public partial class fDangNhap : Form
    {
        String query;
        ConnectBase connect = new ConnectBase();
        public fDangNhap()
        {
            InitializeComponent();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
        }

        private void guna2ButtonLogin_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2TextBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2ButtonSignup_Click(object sender, EventArgs e)
        {
            fDangKi dk = new fDangKi();
            this.Hide();
            dk.Show();
        }

        private void guna2ControlBoxMinimize_Click(object sender, EventArgs e)
        {
        }
    }
}
