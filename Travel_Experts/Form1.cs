using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Travel_Experts
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            homeControl1.BringToFront();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            homeControl1.BringToFront();
        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            suppliersControl1.BringToFront();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            productControl21.BringToFront();
        }

        private void btnPackages_Click(object sender, EventArgs e)
        {
            packages1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            administratorControl1.BringToFront();
        }

        private void picBoxFB_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/");
        }

        private void pictureBoxInsta_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/");
        }

        private void pictureBoxTwitter_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.twitter.com/");
        }

        private void pictureBoxTwitt_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/");

        }

    }
}
