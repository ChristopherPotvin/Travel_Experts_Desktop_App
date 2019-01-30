using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using Model;
using Query;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Query.ProductsDB;

namespace Travel_Experts
{
    public partial class ProductControl : UserControl
    {

        public ProductControl()
        {
            InitializeComponent();
        }

        private void ProductControl_Load(object sender, EventArgs e)
        {

            HideAll();

            repopulate();
        }

        /// <summary>
        /// Populate the cb's
        /// </summary>
        private void repopulate()
        {

            List<Products> newProductList = ProductsDB.GetProducts();
            List<Suppliers> newSuppliersList = SuppliersDB.GetSuppliers();


            // Product List Box
            cbProdName.ValueMember = "ProductId";
            cbProdName.DisplayMember = "ProductName";
            cbProdName.DataSource = newProductList;


            // Supplier List Box 
            cbSupplier.ValueMember = "SupplierId";
            cbSupplier.DisplayMember = "SupName";
            cbSupplier.DataSource = newSuppliersList;

            // New Supplier List Box
            cbNewSup.ValueMember = "SupplierId";
            cbNewSup.DisplayMember = "SupName";
            cbNewSup.DataSource = newSuppliersList;

            ClearAll();

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            List<Products> productList = ProductsDB.GetProducts();

            List<Suppliers> suppliersList = SuppliersDB.GetSuppliers();

            var checkedButton = gbOptions.Controls.OfType<RadioButton>()
                                .FirstOrDefault(r => r.Checked);


            switch (checkedButton.Name)
            {
                case "rbAdd":
                    // Insert new product and product supplier
                    // Sans validation
                    try
                    {
                        // Insert the product
                        Products prod = new Products(txtProdName.Text);

                        // Get the inserted ID
                        int insertedId = ProductsDB.InsertProduct(prod);

                        var sup = (from x in suppliersList where x.SupplierId == Convert.ToInt32(cbSupplier.SelectedValue) select x).Single();

                        // Insert the product supplier
                        Products_Suppliers pS = new Products_Suppliers(insertedId, sup.SupplierId);
                        Product_SuppliersDB.Insert(pS);

                        //Display message to user TODO

                    }
                    catch (DuplicateKeyException ex)
                    {
                        lblStatus.Visible = true;
                        lblStatus.BackColor = Color.Red;
                        lblStatus.Text = ex.Message;
                    }
                    break;

                case "rbUpdate":
                    // Update existing product and product_supplier (change product name or product_supplier)
                    // Sans validation

                    Products newProd = new Products(txtProdName.Text);

                    var oldProd = (from x in productList where x.ProductName == cbProdName.Text select x).First();
                  
                    bool updateP = ProductsDB.UpdateProduct(oldProd, newProd);

                    var oldSupId = (from x in suppliersList where x.SupplierId == Convert.ToInt32(cbSupplier.SelectedValue) select x.SupplierId).Single();

                    // Get the new supplier id for the selected supplier in the lower CB
                    var newSupId = (from x in suppliersList where x.SupplierId == Convert.ToInt32(cbNewSup.SelectedValue) select x.SupplierId).Single();

                    // Old and new Products_Suppliers objects
                    Products_Suppliers oldPs = new Products_Suppliers(oldProd.ProductId, oldSupId);
                    Products_Suppliers newPs = new Products_Suppliers(oldProd.ProductId, newSupId);
                  
                    bool updatePS = Product_SuppliersDB.Update(oldPs, newPs);

                    OperationStatus(updatePS); //Display message to user

                    break;

                case "rbDelete":
                    // Delete existing supplier
                    // Sans validation

                    var prd = (from x in productList where x.ProductId == Convert.ToInt32(cbProdName.SelectedValue) select x).Single();

                    List<Products_Suppliers> psList = Product_SuppliersDB.GetSuppliers();

                    foreach (Products_Suppliers item in psList)
                    {
                        if (item.ProductId == prd.ProductId)
                        {
                            Product_SuppliersDB.Delete(prd.ProductId);
                        }
                    }

                    Products delProd = new Products(cbProdName.Text);

                    bool delete = ProductsDB.DeleteProduct(delProd);

                    OperationStatus(delete); //Display message to user

                    break;
            }
            
            repopulate();

        }

        private void OperationStatus(bool result)
        {

            lblStatus.Visible = true;

            if (result)
            {
                lblStatus.BackColor = Color.LawnGreen;
                lblStatus.Text = "Operation successfull";
                btnSubmit.Visible = true;
            }
            else
            {
                lblStatus.BackColor = Color.Red;
                lblStatus.Text = "Operation not successfull";
            }

        }

        private void cbProdName_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Products> productList = ProductsDB.GetProducts();

            if (cbProdName.SelectedIndex != -1)
            {
                int currentProductId = Convert.ToInt32(cbProdName.SelectedValue);
                var prd = (from x in productList where x.ProductId == currentProductId select x).Single();
                txtProdName.Text = prd.ProductName.ToString();
            }
        }

        private void rbAdd_CheckedChanged(object sender, EventArgs e)
        {

            HideAll();

            // Enable controls that are needed
            lblPnameTxt.Visible = true;
            lblSupName.Visible = true;

            txtProdName.Visible = true;
            cbSupplier.Visible = true;           


            btnSubmit.Visible = true;
            btnProdClear.Visible = true;

            // Remove Contents
            txtProdName.Text = null;
            ClearAll();
        }

        private void rbUpdate_CheckedChanged(object sender, EventArgs e)
        {
            HideAll();

            // Enable controls that are needed          
            lblPnameCb.Visible = true;
            lblPnameTxt.Visible = true;
            lblSupName.Visible = true;
            lblNewSup.Visible = true;

            txtProdName.Visible = true;
            cbProdName.Visible = true;
            cbSupplier.Visible = true;
            cbNewSup.Visible = true;

            btnSubmit.Visible = true;
            btnProdClear.Visible = true;

            // Remove Contents
            ClearAll();


        }

        private void rbDelete_CheckedChanged(object sender, EventArgs e)
        {
            
            HideAll();

            // Enable controls that are needed
            lblPnameCb.Visible = true;
            cbProdName.Visible = true;
            btnSubmit.Visible = true;
            btnProdClear.Visible = true;

            // Remove Contents
            ClearAll();

        }

        private void ClearAll()
        {
            // Clear user controls

            cbProdName.ResetText();
            cbSupplier.ResetText();
            cbNewSup.ResetText();

            cbProdName.SelectedIndex = -1;
            cbSupplier.SelectedIndex = -1;
            cbNewSup.SelectedIndex = -1;

            txtProdName.Text = null;
        }

        private void HideAll()
        {
            // Alter visibility

            btnSubmit.Visible = false;
            btnProdClear.Visible = false;

            lblSupName.Visible = false;
            lblPnameTxt.Visible = false;
            lblSupName.Visible = false;
            lblPnameCb.Visible = false;
            lblNewSup.Visible = false;


            txtProdName.Visible = false;
            cbProdName.Visible = false;
            cbSupplier.Visible = false;
            cbNewSup.Visible = false;
        }
    }
}