using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace new_project
{
    public partial class Home_Page : Form
    {
        public Home_Page()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ManageCategory cat = new ManageCategory();
            cat.Show();
            this.Hide();
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ManageCustomers cust = new ManageCustomers();
            cust.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Manage_Order orders = new Manage_Order();
            orders.Show();
            this.Hide();
        }


        private void pictureBox4_Click(object sender, EventArgs e)
        {
            ManageUsers users = new ManageUsers();
            users.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            ManageProducts cat = new ManageProducts();
            cat.ShowDialog(); // Show the form as a modal dialog
            this.Hide();
        }




        private void button1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();  
            this.Hide();
        }
    }
}
