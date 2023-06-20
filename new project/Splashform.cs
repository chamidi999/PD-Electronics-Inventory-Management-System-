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
    public partial class Splashform : Form
    {
        public Splashform()
        {
            InitializeComponent();
        }
        int startpoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            StartPosition += 1;
            progress.Value = startpoint;
            if(progress.Value == 100 ) 
            { 
               progress.Value = 0;
               timer1.Stop();
                Home_Page login = new Home_Page();
                this.Hide();
                login.Show();
            }
        }

        private void progress_Click(object sender, EventArgs e)
        {

        }

        private void Splashform_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
