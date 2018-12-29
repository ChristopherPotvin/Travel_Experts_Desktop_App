using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Travel_Experts
{
    public partial class SuppliersControl : UserControl
    {
        public SuppliersControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event Handlers
        /// </summary>

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if 
                (
                ErrorProvider.ValidProvided(txtSearch,"Supplier Name Search",errorProvider1)
                )
            {
                //Placeholder
                MessageBox.Show(Convert.ToString(txtSearch.Text));
            }         
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if
                (
                ErrorProvider.ValidProvided(txtSupName,"Supplier Name",errorProvider1) &&
                ErrorProvider.ValidInt(txtSupId,"Supplier Id", errorProvider1)               
                )
            {
                //Instantiate Object
                Model.Suppliers supplier = new Model.Suppliers(Convert.ToInt32(txtSupId.Text), Convert.ToString(txtSupName.Text));

                //Placeholder
                MessageBox.Show(supplier.ToString());
            }
        }
    }
}
