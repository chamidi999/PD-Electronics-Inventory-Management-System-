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
using System.Data.Sql;
//using System.Data.SqlClient;

namespace new_project
{
    public partial class ManageCustomers : Form
    {
        public ManageCustomers()
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
                string Myquery = "select * from CustomerTb1";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(dataAdapter);
                var ds = new DataSet();
                dataAdapter.Fill(ds);
                CustomersGV.DataSource = ds.Tables[0];

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

                
                SqlCommand cmd = new SqlCommand("INSERT INTO CustomerTb1 VALUES(@cidTb, @cnameTb,@telenTb)", Con);
                cmd.Parameters.AddWithValue("@cidTb", cidTb.Text);
                cmd.Parameters.AddWithValue("@cnameTb", cnameTb.Text);
                cmd.Parameters.AddWithValue("@telenTb", telenTb.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Users Successfully Added");
                cmd.ExecuteNonQuery();
                Con.Close();
                
            }
            catch 
            {
                
            }
                }

        private void ManageCustomers_Load(object sender, EventArgs e)
        {
            population();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (cidTb.Text == "")
            {
                MessageBox.Show("Enter the Customer Phone Number");
            }
            else
            {
                
                string Myquery = "Delete from CustomerTb1 where Customerid  ='" + cidTb.Text + "';";
                SqlCommand cmd = new SqlCommand(Myquery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Successfully Deleted");
                Con.Close();
                population();

            }
        }

        private void CustomersGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cidTb.Text = CustomersGV.SelectedRows[0].Cells[0].Value.ToString();
            cnameTb.Text = CustomersGV.SelectedRows[0].Cells[1].Value.ToString();
            telenTb.Text = CustomersGV.SelectedRows[0].Cells[2].Value.ToString();
            Con.Open();

            SqlDataAdapter sda = new SqlDataAdapter("select Count(*) from OrderTb1 where Customerid = " + cidTb.Text, Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            orderlabel.Text = dt.Rows[0][0].ToString();

            SqlDataAdapter sda1 = new SqlDataAdapter("select Sum(TotalAmt) from OrderTb1 where Customerid = " + cidTb.Text, Con);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            amountlabel.Text = dt1.Rows[0][0].ToString();

            SqlDataAdapter sda2 = new SqlDataAdapter("select Max(OrderDate) from OrderTb1 where Customerid = " + cidTb.Text, Con);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            datelabel.Text = dt2.Rows[0][0].ToString();

            Con.Close();
        }


        private void ManageCustomers_Load_1(object sender, EventArgs e)
        {
            population();
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
                    SqlCommand cmd = new SqlCommand("UPDATE CustomerTb1 set Customername = '" + cnameTb.Text + "'Customertelen = '" + telenTb.Text + "'where Customerid ='"+cidTb+"'", Con);
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

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home_Page home_Page = new Home_Page();
            home_Page.Show();
            this.Hide();
        }
    }
    }

