﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Query;

namespace Travel_Experts
{
    public partial class PackagesControl : UserControl
    {
        public Packages package;

        public PackagesControl()
        {
            InitializeComponent();
        }


        private void populateDg()
        {

            List<Products> productsList = ProductsDB.GetProducts();
            List<Suppliers> suppliersList = SuppliersDB.GetSuppliers();
            List<Products_Suppliers> psList = Product_SuppliersDB.GetSuppliers();


            var listings = from ps in psList
                           join product in productsList on ps.ProductId equals product.ProductId
                           join supplier in suppliersList on ps.SupplierId equals supplier.SupplierId
                           select new { product.ProductName, supplier.SupName };


            dgPS.DataSource = listings.ToList();



        }

        private void PackagesControl_Load(object sender, EventArgs e)
        {
            txtName.Enabled = false;
            txtPrice.Enabled = false;
            txtCommission.Enabled = false;
            dateStart.Enabled = false;
            dateEnd.Enabled = false;
            richTxtDescription.Enabled = false;
            btnDelete.Visible = false;
            btnUpdate.Visible = false;
            btnSearch.Visible = false;
            txtID.Visible = false;
            lblId.Visible = false;

            populateDg();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (Validator1.IsProvided(txtID, "Package ID") &&
                Validator1.IsNonNegativeInt(txtID, "Package ID"))
            {
                int packageID = Convert.ToInt32(txtID.Text);
                GetPackage(packageID);

                if (package == null)
                {
                    MessageBox.Show("No Package found with this ID. " +
                        "Please try again.", "Package Not Found");
                }
                else
                    this.DisplayPackages();
            }

        }

        private void GetPackage(int packageID)
        {
            package = PackagesDB.GetPackages(packageID);
        }

        private void DisplayPackages()
        {
            txtID.Text = package.PackageId.ToString();
            txtName.Text = package.PkgName;
            txtPrice.Text = package.PkgBasePrice.ToString();
            txtCommission.Text = package.PkgAgencyCommission.ToString();
            dateStart.Text = package.PkgStartDate.ToString();
            dateEnd.Text = package.PkgEndDate.ToString();
            richTxtDescription.Text = package.PkgDesc;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (radAdd.Checked == true)
            {
                try
                {
                    if (Validator1.IsProvided(txtName, "Package Name") &&
                        Validator1.IsProvided(txtPrice, "Base Price") &&
                        Validator1.IsNonNegativeDecimal(txtPrice, "Base Price") &&
                        Validator1.IsProvided(txtCommission, "Agency Commission") &&
                        Validator1.IsNonNegativeDecimal(txtCommission, "Agency Commission") &&
                        Validator1.IsProvided(richTxtDescription, "Description"))
                    {
                        Packages package = new Packages();

                        package.PkgName = txtName.Text;
                        package.PkgBasePrice = Convert.ToDecimal(txtPrice.Text);
                        package.PkgAgencyCommission = Convert.ToDecimal(txtCommission.Text);
                        package.PkgStartDate = Convert.ToDateTime(dateStart.Text);
                        package.PkgEndDate = Convert.ToDateTime(dateEnd.Text);
                        package.PkgDesc = richTxtDescription.Text;

                        if (package.PkgBasePrice < package.PkgAgencyCommission ||
                           package.PkgEndDate < package.PkgStartDate)
                        {
                            MessageBox.Show("Base Price must be greater than Commission Price or " +
                                "End Date must be later than Start Date");
                        }
                        else
                        {
                            DialogResult result = MessageBox.Show("Add " + package.PkgName + "?",
                            "Confirm Add", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (result == DialogResult.Yes)
                            {
                                this.PutPackageData(package);
                                package.PackageId = PackagesDB.AddPackage(package);
                            }
                        }
                        MessageBox.Show(package.PkgName + " added successfully");
                        this.ClearControls();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }


            }
            else if (radUpdate.Checked == true)
            {
                try
                {

                    if (Validator1.IsProvided(txtID, "PackageID") &&
                       Validator1.IsNonNegativeInt(txtID, "PackageID") &&
                       Validator1.IsProvided(txtName, "Package Name") &&
                       Validator1.IsProvided(txtPrice, "Base Price") &&
                       Validator1.IsNonNegativeDecimal(txtPrice, "Base Price") &&
                       Validator1.IsProvided(txtCommission, "Agency Commission") &&
                       Validator1.IsNonNegativeDecimal(txtCommission, "Agency Commission") &&
                       Validator1.IsProvided(richTxtDescription, "Description"))
                    {

                    }

                    Packages newPackage = new Packages();
                    newPackage.PackageId = Convert.ToInt32(txtID.Text);
                    newPackage.PkgName = txtName.Text;
                    newPackage.PkgBasePrice = Convert.ToDecimal(txtPrice.Text);
                    newPackage.PkgAgencyCommission = Convert.ToDecimal(txtCommission.Text);
                    newPackage.PkgStartDate = Convert.ToDateTime(dateStart.Text);
                    newPackage.PkgEndDate = Convert.ToDateTime(dateEnd.Text);
                    newPackage.PkgDesc = richTxtDescription.Text;

                    if (newPackage.PkgBasePrice < newPackage.PkgAgencyCommission ||
                          newPackage.PkgEndDate < newPackage.PkgStartDate)
                    {
                        MessageBox.Show("Base Price must be greater than Commission Price or " +
                           "End Date must be later than Start Date");
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("Update " + package.PkgName + "?",
                        "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            if (!PackagesDB.UpdatePackage(package, newPackage))
                            {
                                MessageBox.Show("Another user has updated or " +
                                     "deleted that package.", "Database Error");
                            }
                            else
                            {
                                package = newPackage;
                            }
                        }
                        {
                            MessageBox.Show(package.PkgName + " Updated successfully");
                            this.ClearControls();
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }

            }
            else
            {
                DialogResult result = MessageBox.Show("Delete " + package.PkgName + "?",
                    "Confirm delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        if (!PackagesDB.DeletePackage(package))
                        {
                            MessageBox.Show("Another user has updated or deleted " + "that package.",
                                "Database Error");
                            this.GetPackage(package.PackageId);
                            if (package != null)
                                this.DisplayPackages();
                            else
                            {
                                this.ClearControls();
                            }
                        }
                        else
                        {
                            MessageBox.Show(package.PkgName + " deleted successfully");
                            this.ClearControls();
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ex.GetType().ToString());
                    }
                }

            }
        }

        private void PutPackageData(Packages package)
        {
            package.PkgName = txtName.Text;
            package.PkgBasePrice = Convert.ToDecimal(txtPrice.Text);
            package.PkgAgencyCommission = Convert.ToDecimal(txtCommission.Text);
            package.PkgStartDate = Convert.ToDateTime(dateStart.Text);
            package.PkgEndDate = Convert.ToDateTime(dateEnd.Text);
            package.PkgDesc = richTxtDescription.Text;
        }

        private void radAdd_CheckedChanged(object sender, EventArgs e)
        {
            txtID.Visible = false;
            lblId.Visible = false;
            btnDelete.Visible = false;
            btnSearch.Visible = false;
            btnUpdate.Visible = false;
            txtName.Enabled = true;
            txtPrice.Enabled = true;
            txtCommission.Enabled = true;
            dateStart.Enabled = true;
            dateEnd.Enabled = true;
            richTxtDescription.Enabled = true;
        }

        private void ClearControls()
        {
            txtID.Text = "";
            txtName.Text = "";
            txtPrice.Text = "";
            txtCommission.Text = "";
            dateStart.Text = "";
            dateEnd.Text = "";
            richTxtDescription.Text = "";
        }

        private void radUpdate_CheckedChanged(object sender, EventArgs e)
        {
            txtName.Enabled = true;
            txtPrice.Enabled = true;
            txtCommission.Enabled = true;
            dateStart.Enabled = true;
            dateEnd.Enabled = true;
            richTxtDescription.Enabled = true;
            btnDelete.Visible = false;
            btnUpdate.Visible = true;
            txtID.Visible = true;
            lblId.Visible = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Validator1.IsProvided(txtID, "Package ID") &&
                 Validator1.IsNonNegativeInt(txtID, "Package ID"))
            {
                int packageID = Convert.ToInt32(txtID.Text);
                GetPackage(packageID);

                if (package == null)
                {
                    MessageBox.Show("No Package found with this ID. " +
                        "Please try again.", "Package Not Found");
                }
                else
                    this.DisplayPackages();
            }
        }

        private void radDelete_CheckedChanged(object sender, EventArgs e)
        {
            txtName.Enabled = false;
            txtPrice.Enabled = false;
            txtCommission.Enabled = false;
            dateStart.Enabled = false;
            dateEnd.Enabled = false;
            richTxtDescription.Enabled = false;
            btnDelete.Visible = true;
            btnUpdate.Visible = false;
            txtID.Visible = true;
            lblId.Visible = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (Validator1.IsProvided(txtID, "Package ID") &&
     Validator1.IsNonNegativeInt(txtID, "Package ID"))
            {
                int packageID = Convert.ToInt32(txtID.Text);
                GetPackage(packageID);

                if (package == null)
                {
                    MessageBox.Show("No Package found with this ID. " +
                        "Please try again.", "Package Not Found");
                }
                else
                    this.DisplayPackages();
            }
        }

        private void radioSearch_CheckedChanged(object sender, EventArgs e)
        {
            txtName.Enabled = false;
            txtPrice.Enabled = false;
            txtCommission.Enabled = false;
            dateStart.Enabled = false;
            dateEnd.Enabled = false;
            richTxtDescription.Enabled = false;
            btnDelete.Visible = false;
            btnUpdate.Visible = false;
            btnSearch.Visible = true;
            txtID.Visible = true;
            lblId.Visible = true;
        }

        private void btnSelected_Click(object sender, EventArgs e)
        {

            // Testing method. We need to create entries for products_suppliers and then Packages_Products_Suppliers 
            // based on the selections made in this datagrid view 

  
            // Need to make Products_Suppliers(s) for the package, these will have a ProductSupplierId. Use this to create entries int Packages_Products_Suppliers


            Int32 selectedCellCount =
                    dgPS.GetCellCount(DataGridViewElementStates.Selected);
            if (selectedCellCount > 0)
            {
                if (dgPS.AreAllCellsSelected(true))
                {
                    MessageBox.Show("All cells are selected", "Selected Cells");
                }
                else
                {
                    System.Text.StringBuilder sb =
                        new System.Text.StringBuilder();

                    for (int i = 0;
                        i < selectedCellCount; i++)
                    {
                        int rowIndex = dgPS.SelectedCells[i].RowIndex;
                        int colIndex = dgPS.SelectedCells[i].ColumnIndex;

                        string myvalue = dgPS.Rows[rowIndex].Cells[colIndex].Value.ToString();

                        sb.Append(myvalue);
                        sb.Append(Environment.NewLine);

                    }

                    sb.Append("Total: " + selectedCellCount.ToString());
                    MessageBox.Show(sb.ToString(), "Selected Cells");
                }
            }
        }
    }
}
