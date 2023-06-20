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
    public partial class ManageCategory : Form
    {
        public ManageCategory()
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
                string Myquery = "select * from CategoryTb1";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(dataAdapter);
                var ds = new DataSet();
                dataAdapter.Fill(ds);
                CategoryGV.DataSource = ds.Tables[0];

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

                
                SqlCommand cmd = new SqlCommand("INSERT INTO CategoryTb1 VALUES(@catidTb, @catnameTb)", Con);
                cmd.Parameters.AddWithValue("@catidTb", catidTb.Text);
                cmd.Parameters.AddWithValue("@catnameTb", catnameTb.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category Successfully Added");
                cmd.ExecuteNonQuery();
                Con.Close();

            }
            catch
            {
                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (catnameTb.Text == "")
            {
                MessageBox.Show("Enter the Category Name");
            }
            else
            {
                Con.Open();
                string Myquery = "Delete from CategoryTb1 where Categoryname  = '" + catnameTb.Text + "';";
                SqlCommand cmd = new SqlCommand(Myquery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category Successfully Deleted");
                Con.Close();
                population();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    if (Con.State == ConnectionState.Closed)
                    {
                        Con.Open();
                    }

                    SqlCommand cmd = new SqlCommand("UPDATE CategoryTb1 set Categoryname = '" + catnameTb.Text +  "'", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category Successfully Updated");
                    Con.Close();
                    population();


                }
                catch
                {

                }
            }
        }

        private void UsersGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            catidTb.Text = CategoryGV.SelectedRows[0].Cells[0].Value.ToString();
            catnameTb.Text = CategoryGV.SelectedRows[0].Cells[1].Value.ToString();
            
        }

        private void ManageCategory_Load(object sender, EventArgs e)
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
