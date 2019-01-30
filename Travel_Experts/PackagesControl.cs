using System;
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

        private void PackagesControl_Load(object sender, EventArgs e)
        {
            populateDg();

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

                        // Packages Object
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
                                // Add the package
                                this.PutPackageData(package);
                                int currentID = PackagesDB.AddPackage(package);

                                // Create the Packages_Package_Suppliers
                                foreach (Products_Suppliers addPS in psAddList)
                                {

                                    int currentPSID = addPS.ProductSupplierId;

                                    Packages_Products_Suppliers ppsAdd = new Packages_Products_Suppliers(currentID,currentPSID);
                                    Packages_Products_SuppliersDB.Insert(ppsAdd);

                                }
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

        private void populateDg()
        {

            List<Products> productsList = ProductsDB.GetProducts();
            List<Suppliers> suppliersList = SuppliersDB.GetSuppliers();
            List<Products_Suppliers> psList = Product_SuppliersDB.GetSuppliers();
      
            cbProduct.ValueMember = "ProductId";
            cbProduct.DisplayMember = "ProductName";
            cbProduct.DataSource = productsList;
  
        }

        private void cbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Products> productsList = ProductsDB.GetProducts();
            List<Suppliers> suppliersList = SuppliersDB.GetSuppliers();
            List<Products_Suppliers> psList = Product_SuppliersDB.GetSuppliers();

            int selected = Convert.ToInt32(cbProduct.SelectedValue);

            var listings = from ps in psList
                            join product in productsList on ps.ProductId equals product.ProductId
                            join supplier in suppliersList on ps.SupplierId equals supplier.SupplierId
                            where product.ProductId == selected
                            select new { product.ProductId, supplier.SupName, supplier.SupplierId };

            List<Products_Suppliers> addList = new List<Products_Suppliers>();

            foreach (var listing in listings)
            {
                Products_Suppliers newPS = new Products_Suppliers(Convert.ToInt32(listing.ProductId), Convert.ToInt32(listing.SupplierId));
                addList.Add(newPS);

            }

            lbPS.DataSource = null;
            lbPS.Items.Clear();

            // Get the display member to sho as Supplier Name
            lbPS.ValueMember = "SupplierId";
            lbPS.DisplayMember = "SupplierId";

            lbPS.DataSource = addList.ToList();

        }

        List<Products_Suppliers> psAddList = new List<Products_Suppliers>();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            List<Products_Suppliers> psList = Product_SuppliersDB.GetSuppliers();


            int selectedPID = Convert.ToInt32(cbProduct.SelectedValue);

            int selectedSupID = Convert.ToInt32(lbPS.SelectedValue);

            var current = from ps in psList where ps.ProductId == Convert.ToInt32(cbProduct.SelectedValue) && ps.SupplierId == Convert.ToInt32(lbPS.SelectedValue) select ps;
  
            lbAdded.Items.Add(cbProduct.SelectedItem + " " + lbPS.SelectedItem);

            foreach (var item in current)
            {
                Products_Suppliers psAdd = new Products_Suppliers(Convert.ToInt32(item.ProductSupplierId), Convert.ToInt32(item.ProductId), Convert.ToInt32(item.SupplierId));
                psAddList.Add(psAdd);
            }
               
        }
    }
}
