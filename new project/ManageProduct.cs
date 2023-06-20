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

namespace new_project
{
    public partial class ManageProduct : Form
    {
        public ManageProduct()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=user;Initial Catalog=INVENTOERYMANAGEMENTSYSTEM;Integrated Security=True");
        void fillCategory()
        {
            string query = "Select * from CategoryTb1";
            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataReader rdr;
            try
            {
                Con.Open();
                DataTable dt = new DataTable()
;
                dt.Columns.Add("Categoryname", typeof(string));
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                catcombo.ValueMember = "Categoryname";
                catcombo.DataSource = dt;
                Con.Close();
            }

            catch
            {

            }
            
        }
        private void label3_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
        }
        void population()
        {
            try
            {
                Con.Open();
                string Myquery = "select * from ProductTb1";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(dataAdapter);
                var ds = new DataSet();
                dataAdapter.Fill(ds);
                ProductGV.DataSource = ds.Tables[0];

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

                
                SqlCommand cmd = new SqlCommand("INSERT INTO ProductTb1 VALUES(@pidTb, @pnameTb,@pqTb,@ppTb,@pdTb)", Con);
                cmd.Parameters.AddWithValue("@pidTb", pidTb.Text);
                cmd.Parameters.AddWithValue("@pnameTb", pnameTb.Text);
                cmd.Parameters.AddWithValue("@pqTb", pqTb.Text);
                cmd.Parameters.AddWithValue("@ppTb", ppTb.Text);
                cmd.Parameters.AddWithValue("@pdTb", pdTb.Text);
                //cmd.Parameters.AddWithValue("@pcTb", pcTb.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Successfully Added");
                cmd.ExecuteNonQuery();
                Con.Close();

            }
            catch 
            {
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE ProductTb1 set Productname = '" + pnameTb.Text + "'", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product Successfully Updated");
                    Con.Close();
                    population();


                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (pidTb.Text == "")
            {
                MessageBox.Show("Enter the Product Name");
            }
            else
            {
                Con.Open();
                string Myquery = "Delete from ProductTb1 where ProductnameTb  = '" + pidTb.Text + "';";
                SqlCommand cmd = new SqlCommand(Myquery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Successfully Deleted");
                Con.Close();
                population();

            }
        }

        private void ProductGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            pidTb.Text = ProductGV.SelectedRows[0].Cells[1].Value.ToString();
            pnameTb.Text = ProductGV.SelectedRows[0].Cells[1].Value.ToString();
            pqTb.Text = ProductGV.SelectedRows[0].Cells[2].Value.ToString();
            ppTb.Text = ProductGV.SelectedRows[0].Cells[2].Value.ToString();
            pdTb.Text = ProductGV.SelectedRows[0].Cells[2].Value.ToString();
            catcombo.Text = ProductGV.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void ManageProduct_Load(object sender, EventArgs e)
        {
            population();
        }

        private void catcombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillCategory();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home_Page home_Page = new Home_Page();
            home_Page.Show();
            this.Hide();
        }
    }
}
