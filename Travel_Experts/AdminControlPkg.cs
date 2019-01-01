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
    public partial class AdminControlPkg : UserControl
    {
        public AdminControlPkg()
        {
            InitializeComponent();
        }

        private void AdminControlPkg_Load(object sender, EventArgs e)
        {
            //select a default value for search option (combo box)
            cboSearch.SelectedIndex = 0;
            cboDate.SelectedIndex = 0;
            cboCurrency.SelectedIndex = 0;
        }

        //button to allow user to search in the database based on their search criteria
        private void btnSearch_Click(object sender, EventArgs e)
        {
            switch (cboSearch.SelectedItem.ToString())
            {
                case "All":
                    //validate input from user
                    if (!Validator.IsProvided(txtSearch, lblEmpty)) { }
                    else
                    {
                    }
                    break;

                case "Id":
                    if (!Validator.IsProvided(txtSearch, lblEmpty) ||
                        !Validator.IsNonZeroPositiveInt(txtSearch, lblId)) { }
                    else
                    {
                    }
                    break;

                case "Name":
                    if (!Validator.IsProvided(txtSearch, lblEmpty) ||
                        !Validator.IsString(txtSearch, lblName)) { }
                    else
                    {
                    }
                    break;

                case "Start Date":
                case "End Date":
                    break;

                case "Base Price":
                case "Commission":
                    if (!Validator.IsProvided(txtSearch, lblEmpty) ||
                        !Validator.IsNonNegativeDecimal(txtSearch, lblCurrency)) { }
                    else
                    {
                    }
                    break;
            }
        }

        //change visibility of text fields and labels based on user choice
        private void cboSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSearch.SelectedItem.ToString() == "All" ||
                cboSearch.SelectedItem.ToString() == "Id" ||
                cboSearch.SelectedItem.ToString() == "Name")
            {
                cboDate.Visible = false;
                cboCurrency.Visible = false;
                dateTimePicker1.Visible = false;
                lblSearch.Visible = true;
                txtSearch.Visible = true;
            }
            else if (cboSearch.SelectedItem.ToString() == "Start Date" ||
                     cboSearch.SelectedItem.ToString() == "End Date")
            {
                cboDate.Visible = true;
                cboCurrency.Visible = false;
                dateTimePicker1.Visible = true;
                lblSearch.Visible = false;
                txtSearch.Visible = false;
            }
            else
            {
                cboDate.Visible = false;
                cboCurrency.Visible = true;
                dateTimePicker1.Visible = false;
                lblSearch.Visible = false;
                txtSearch.Visible = true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //reset default value for search option (combo box)
            cboSearch.SelectedIndex = 0;
            cboDate.SelectedIndex = 0;
            cboCurrency.SelectedIndex = 0;
            
            //reset default visibility for text field and label
            cboDate.Visible = false;
            cboCurrency.Visible = false;
            dateTimePicker1.Visible = false;
            lblSearch.Visible = true;
            txtSearch.Visible = true;

            //clear text fields
            txtSearch.Text = "";

            //focus on search text field
            txtSearch.Focus();
        }
    }
}
