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
    public partial class Manage_Order : Form
    {
        public Manage_Order()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=user;Initial Catalog=INVENTOERYMANAGEMENTSYSTEM;Integrated Security=True");
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
        void populationproduct()
        {
            try
            {
                Con.Open();
                string Myquery = "select * from ProductTb1";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(dataAdapter);
                var ds = new DataSet();
                dataAdapter.Fill(ds);
                ProductsGV.DataSource = ds.Tables[0];

                Con.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
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
                //catcombo.ValueMember = "Categoryname";
                //catcombo.DataSource = dt;
                SearchCombo.ValueMember = "Categoryname";
                SearchCombo.DataSource = dt;
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
        void updateproduct()
        {
            
            int id = Convert.ToInt32(product = ProductsGV.SelectedRows[0].Cells[1].Value.ToString());
            int newQty = qty = stock - Convert.ToInt32(QtyTb.Text);
            if (newQty < 0)
                MessageBox.Show("Operation Failed");
            else
            {
                Con.Open();
                string query = "Update ProductTb1 set ProdQty = " + newQty + "where Productid=" + id + ";";
                SqlCommand cmd = new SqlCommand(query, Con);
                Con.Close();
                populationproduct();
            }
            
        }
        int num = 0;
        int uprice, totalprices, qty;
        string product;
        DataTable table = new DataTable();

        private void Manage_Order_Load(object sender, EventArgs e)
        {
            population();
            populationproduct();
            fillCategory();
        }
        

        private void CustomersGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            customerid.Text = CustomersGV.SelectedRows[0].Cells[0].Value.ToString();
            
        }

        private void SearchCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string Myquery = "select * from ProductTb1";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(dataAdapter);
                var ds = new DataSet();
                dataAdapter.Fill(ds);
                ProductsGV.DataSource = ds.Tables[0];

                Con.Close();

            }
            catch 
            {
                
            }
        }
        int sum = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            if (QtyTb.Text == "")
                MessageBox.Show("Enter The Quantity of Products");
            else if (flag == 0)
                MessageBox.Show("Select The Product");
            else if (Convert.ToInt32(QtyTb.Text) > stock)
                MessageBox.Show("No Enough Stock Available");
            else
            {
                num = num + 1;
                qty = Convert.ToInt32(QtyTb.Text);
                DataTable table = new DataTable(); // Declaration and instantiation of the 'table' object
                table.Rows.Add(num, product, qty, uprice, totalprices);
                OrderGV.DataSource = table;
                flag = 0;


            }
            sum = sum + totalprices;
            TotalAmount.Text = "Rs" + sum.ToString();
            updateproduct();


        }

        private void orderidTb_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
        int flag = 0;

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void OrderGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(orderidTb.Text==""|| customerid.Text==""|| orderidTb.Text==""||TotalAmount.Text =="")
            {
                MessageBox.Show("Fill The data Correctly");
            }
            else
            {
                {
                    try
                    {
                        Con.Open();
                        SqlCommand cmd = new SqlCommand("INSERT INTO OrderTb1 VALUES(" + orderidTb.Text + "," + customerid.Text + ",'" + orderdate.Text + "'," + TotalAmount.Text+")", Con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Order Added Successfully");
                        Con.Close();
                        //population();


                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ViewOrders view = new ViewOrders();
            view.Show();
        }

        private void home_Click(object sender, EventArgs e)
        {
            Home_Page home_Page = new Home_Page();
            home_Page.Show();
            this.Hide();
        }

        int stock;
        private void ProductsGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            product = ProductsGV.SelectedRows[0].Cells[1].Value.ToString();
            qty = Convert.ToInt32(QtyTb.Text);
            stock = Convert.ToInt32(ProductsGV.SelectedRows[0].Cells[2].Value.ToString());
            uprice = Convert.ToInt32(ProductsGV.SelectedRows[0].Cells[3].Value.ToString());
            totalprices = qty * uprice;
            flag = 1;


        }
    }
}
