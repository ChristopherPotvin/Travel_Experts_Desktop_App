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
    }
}
