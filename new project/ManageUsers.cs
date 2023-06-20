using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace new_project
{
    public partial class ManageUsers : Form
    {
        public ManageUsers()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=user;Initial Catalog=INVENTOERYMANAGEMENTSYSTEM;Integrated Security=True");
            private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        void population()
        {
            try
            {
                Con.Open();
                string Myquery = "select * from UserTb1";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(Myquery,Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(dataAdapter);
                var ds = new DataSet();
                dataAdapter.Fill(ds);
                UsersGV.DataSource = ds.Tables[0];

                Con.Close();
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Con.State == ConnectionState.Closed)
                {
                    Con.Open();
                }

                SqlCommand cmd = new SqlCommand("INSERT INTO UserTb1 VALUES(@unameTb, @fnameTb, @passwordTb,@telenTb)", Con);
                cmd.Parameters.AddWithValue("@unameTb", unameTb.Text);
                cmd.Parameters.AddWithValue("@fnameTb", fnameTb.Text);
                cmd.Parameters.AddWithValue("@passwordTb", passwordTb.Text);
                cmd.Parameters.AddWithValue("@telenTb", telenTb.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Users Successfully Added");
                Con.Close();
            }
            catch 
            {
                MessageBox.Show("An Error Occurred: " + "Telephone Number dublicate.Please add new telephone number.");
            }
        }


        private void UsersGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
            {
                

                unameTb.Text = UsersGV.SelectedRows[0].Cells[0].Value.ToString();
                fnameTb.Text = UsersGV.SelectedRows[0].Cells[1].Value.ToString();
                passwordTb.Text = UsersGV.SelectedRows[0].Cells[2].Value.ToString();
                telenTb.Text = UsersGV.SelectedRows[0].Cells[3].Value.ToString();
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (telenTb.Text == "")
            {
                MessageBox.Show("Enter the Users Phone Number");
            }
            else
            {
                Con.Open( );
                string Myquery = "Delete from userTb1 where Utelenum  = '" + telenTb.Text + "';";
                SqlCommand cmd  = new SqlCommand(Myquery, Con);
                cmd.ExecuteNonQuery( );
                MessageBox.Show("User Successfully Deleted");
                Con.Close();
                population();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE UserTb1 set Uname = '"+unameTb.Text+ "',Ufullname = '"+fnameTb.Text+"',Upassword = '"+passwordTb.Text+"'where Utelenum ='"+telenTb.Text+"'", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Users Successfully Updated");
                    Con.Close();
                    population();


                }
                catch 
                {

                }
            }
        }

        private void ManageUsers_Load(object sender, EventArgs e)
        {
            population();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home_Page home_Page = new Home_Page();
            home_Page.Show();
            this.Hide();
        }
    }
}
