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
    public partial class ViewOrders : Form
    {
        public ViewOrders()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=user;Initial Catalog=INVENTOERYMANAGEMENTSYSTEM;Integrated Security=True");
        void populationorders()
        {
            try
            {
                Con.Open();
                string Myquery = "select * from ProductTb1";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(dataAdapter);
                var ds = new DataSet();
                dataAdapter.Fill(ds);
                viewordersGV.DataSource = ds.Tables[0];

                Con.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void CategoryGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ViewOrders_Load(object sender, EventArgs e)
        {
            
            populationorders();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Order Summary", new Font("Century", 25, FontStyle.Bold), Brushes.Red, new Point(230));
            e.Graphics.DrawString("Order ID: " + viewordersGV.SelectedRows[0].Cells[0].Value.ToString(), new Font("Century", 20, FontStyle.Bold), Brushes.Red, new Point(80, 100));
            e.Graphics.DrawString("Customer ID: " + viewordersGV.SelectedRows[0].Cells[1].Value.ToString(), new Font("Century", 20, FontStyle.Bold), Brushes.Red, new Point(80, 133));
            e.Graphics.DrawString("Customer Name: " + viewordersGV.SelectedRows[0].Cells[2].Value.ToString(), new Font("Century", 20, FontStyle.Bold), Brushes.Red, new Point(80, 166));
            e.Graphics.DrawString("Customer Name: " + viewordersGV.SelectedRows[0].Cells[3].Value.ToString(), new Font("Century", 20, FontStyle.Bold), Brushes.Red, new Point(80, 169));
            e.Graphics.DrawString("Order Date: " + viewordersGV.SelectedRows[0].Cells[4].Value.ToString(), new Font("Century", 20, FontStyle.Bold), Brushes.Red, new Point(80, 232));
            e.Graphics.DrawString("PoweredByCodeSpace", new Font("Century", 25, FontStyle.Bold), Brushes.Red, new Point(230, 350));
        }

    }
}
