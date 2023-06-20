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
//using System.Data.SqlClient;

namespace new_project
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=user;Initial Catalog=INVENTOERYMANAGEMENTSYSTEM;Integrated Security=True");
        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM UserTb1 WHERE Uname = '" + usernameTb.Text + "' AND password = '" + passwordTb.Text + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                ManageCustomers cust = new ManageCustomers();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Username or Password");
            }

            Con.Close();
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
                passwordTb.UseSystemPasswordChar = true;
            else
                passwordTb.UseSystemPasswordChar = false;
        }


        private void clear_Click(object sender, EventArgs e)
        {
            usernameTb.Text = "";
            passwordTb.Text = "";
        }
    }
}
