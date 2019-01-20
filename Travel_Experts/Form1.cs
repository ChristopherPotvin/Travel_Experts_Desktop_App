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

        /// <summary>
        /// Form Control Windows
        /// </summary>
        
        private void Form1_Load(object sender, EventArgs e)
        {
            Navigation(false);
            homeControl1.BringToFront();
            DateTime dateTime = DateTime.Now;
            txtTime.Text = dateTime.ToString();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            //homeControl1.BringToFront();
            suppliersControl1.BringToFront();
        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            suppliersControl1.BringToFront();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            productControl1.BringToFront();
        }

        private void btnPackages_Click(object sender, EventArgs e)
        {
            packagesControl1.BringToFront();
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            previewControl1.BringToFront();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            administratorControl1.BringToFront();
        }

        /// <summary>
        /// Social Media Icons
        /// </summary>

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

        /// <summary>
        /// Exit Button
        /// </summary>

        private void pbShutdown_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Change navigation based on user login status
        /// </summary>

        public void Navigation(bool TF)
        {
            btnPackages.Enabled =TF;
            btnProducts.Enabled = TF;
            btnSuppliers.Enabled = TF;
            btnPreview.Enabled = TF;
            btnAdmin.Enabled = TF;
        }

     
    }
}
