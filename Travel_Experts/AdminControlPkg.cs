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
        //declare connection string variable
        string connectionString = @"Data Source = projectteamno7.database.windows.net; Initial Catalog = travelexperts; User ID = runner; Password = Travel123";
        string pkgQryAll = "SELECT * FROM Packages"; //select all tables from packages in database

        public AdminControlPkg()
        {
            InitializeComponent();
        }

        private void AdminControlPkg_Load(object sender, EventArgs e)
        {
            

            //set the source of the data to be displayed in the grid view
            packageGridView.DataSource = bindingSourcePackage;

            //get table for packages
            Database.GetData(connectionString, pkgQryAll, packageGridView, bindingSourcePackage);

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
                        Database.GetData(connectionString, "SELECT * from Packages where lower(CONCAT(PackageId, PkgName, PkgStartDate, PkgEndDate,PkgBasePrice,PkgAgencyCommission)) like '%" + txtSearch.Text.ToLower() + "%'", packageGridView, bindingSourcePackage);

                        //if there are is no match to the database:
                        if (packageGridView.Rows.Count == 1)
                        {
                            MessageBox.Show("Unable to find a match");
                            Database.GetData(connectionString, pkgQryAll, packageGridView, bindingSourcePackage);
                        }
                    }
                    break;

                case "Id":
                    if (!Validator.IsProvided(txtSearch, lblEmpty) ||
                        !Validator.IsNonZeroPositiveInt(txtSearch, lblId)) { }
                    else
                    {
                        Database.GetData(connectionString, "SELECT * from Packages where lower(PackageId) like '%" + txtSearch.Text + "%'", packageGridView, bindingSourcePackage);
                        //if there are is no match to the database:
                        if (packageGridView.Rows.Count == 1)
                        {
                            MessageBox.Show("Unable to find a match");
                            Database.GetData(connectionString, pkgQryAll, packageGridView, bindingSourcePackage);
                        }
                    }
                    break;

                case "Name":
                    if (!Validator.IsProvided(txtSearch, lblEmpty) ||
                        !Validator.IsString(txtSearch, lblName)) { }
                    else
                    {
                        Database.GetData(connectionString, "SELECT * from Packages where lower(PkgName) like '%" + txtSearch.Text + "%'", packageGridView, bindingSourcePackage);
                        //if there are is no match to the database:
                        if (packageGridView.Rows.Count == 1)
                        {
                            MessageBox.Show("Unable to find a match");
                            Database.GetData(connectionString, pkgQryAll, packageGridView, bindingSourcePackage);
                        }
                    }
                    break;

                case "Start Date":
                case "End Date":
                    string tableDate;
                    if (cboSearch.SelectedItem.ToString() == "Start Date")
                    {
                        tableDate = "PkgStartDate";
                    }
                    else { tableDate = "PkgEndDate"; }
                    switch (cboDate.SelectedItem.ToString())
                    {
                        case "Before:":
                            var sqlBefore = String.Format("SELECT * from Packages where {0} <= '{1}'", tableDate, dateTimePicker1.Value.Date);
                            Database.GetData(connectionString, sqlBefore, packageGridView, bindingSourcePackage);
                            //if there are is no match to the database:
                            if (packageGridView.Rows.Count == 1)
                            {
                                MessageBox.Show("Unable to find a match");
                                Database.GetData(connectionString, pkgQryAll, packageGridView, bindingSourcePackage);
                            }
                            break;
                        case "After:":
                            var sqlAfter = String.Format("SELECT * from Packages where {0} >= '{1}'", tableDate, dateTimePicker1.Value.Date);
                            Database.GetData(connectionString, sqlAfter, packageGridView, bindingSourcePackage);
                            //if there are is no match to the database:
                            if (packageGridView.Rows.Count == 1)
                            {
                                MessageBox.Show("Unable to find a match");
                                Database.GetData(connectionString, pkgQryAll, packageGridView, bindingSourcePackage);
                            }
                            break;
                        case "Exactly on:":
                            var sqlExact = String.Format("SELECT * from Packages where {0} = '{1}'", tableDate, dateTimePicker1.Value.Date);
                            Database.GetData(connectionString, sqlExact, packageGridView, bindingSourcePackage);
                            //if there are is no match to the database:
                            if (packageGridView.Rows.Count == 1)
                            {
                                MessageBox.Show("Unable to find a match");
                                Database.GetData(connectionString, pkgQryAll, packageGridView, bindingSourcePackage);
                            }
                            break;
                    }
                    break;

                case "Base Price":
                case "Commission":
                    if (!Validator.IsProvided(txtSearch, lblEmpty) ||
                        !Validator.IsNonNegativeDecimal(txtSearch, lblCurrency)) { }
                    else
                    {
                        string tableCurrency;
                        if (cboSearch.SelectedItem.ToString() == "Base Price")
                        {
                            tableCurrency = "PkgBasePrice";
                        }
                        else { tableCurrency = "PkgAgencyCommission"; }
                        switch (cboCurrency.SelectedItem.ToString())
                        {
                            case "Above:":
                                var sqlAbove = String.Format("SELECT * from Packages where {0} >= '{1}'", tableCurrency, Convert.ToDecimal(txtSearch.Text));
                                Database.GetData(connectionString, sqlAbove, packageGridView, bindingSourcePackage);
                                //if there are is no match to the database:
                                if (packageGridView.Rows.Count == 1)
                                {
                                    MessageBox.Show("Unable to find a match");
                                    Database.GetData(connectionString, pkgQryAll, packageGridView, bindingSourcePackage);
                                }
                                break;

                            case "Below:":
                                var sqlBelow = String.Format("SELECT * from Packages where {0} <= '{1}'", tableCurrency, Convert.ToDecimal(txtSearch.Text));
                                Database.GetData(connectionString, sqlBelow, packageGridView, bindingSourcePackage);
                                //if there are is no match to the database:
                                if (packageGridView.Rows.Count == 1)
                                {
                                    MessageBox.Show("Unable to find a match");
                                    Database.GetData(connectionString, pkgQryAll, packageGridView, bindingSourcePackage);
                                }
                                break;

                            case "Exactly:":
                                var sqlExact = String.Format("SELECT * from Packages where {0} = '{1}'", tableCurrency, Convert.ToDecimal(txtSearch.Text));
                                Database.GetData(connectionString, sqlExact, packageGridView, bindingSourcePackage);
                                //if there are is no match to the database:
                                if (packageGridView.Rows.Count == 1)
                                {
                                    MessageBox.Show("Unable to find a match");
                                    Database.GetData(connectionString, pkgQryAll, packageGridView, bindingSourcePackage);
                                }
                                break;
                        }
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

            //visible false error messages if any
            lblCurrency.Visible = false;
            lblEmpty.Visible = false;
            lblId.Visible = false;
            lblName.Visible = false;

            //clear text fields and background color
            txtSearch.Text = "";
            txtSearch.BackColor = Color.White;

            //focus on search text field
            txtSearch.Focus();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to refresh the table? Unsaved data will be lost", "Message", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Database.GetData(connectionString, pkgQryAll, packageGridView, bindingSourcePackage);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Database.EditData(bindingSourcePackage);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Database.DeleteData("Packages", "PackageId", packageGridView);
        }

        private void pctExcel_Click(object sender, EventArgs e)
        {
            Exportto.Excel(packageGridView, "Package Information", saveExcelDialog);
        }

        private void pctPdf_Click(object sender, EventArgs e)
        {
            Exportto.Pdf(packageGridView, "Package Information", savePdfDialog);
        }

        private void packageGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Please enter a valid value", "Data Type Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
