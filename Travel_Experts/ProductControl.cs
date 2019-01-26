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

            repopulate();
        }


        /// <summary>
        /// Populate the cb's
        /// </summary>
        private void repopulate()
        {
            cbProdName.Items.Clear();
            cbSupplier.Items.Clear();

            List<Products> newProductList = ProductsDB.GetProducts();

            var newProductLinq = from prod in newProductList
                                  select new
                                  {
                                      prod.ProductName
                                  };

            foreach (var item in newProductLinq)
            {
                cbProdName.Items.Add(item.ProductName);
            }

            List<Suppliers> newSuppliersList = SuppliersDB.GetSuppliers();
            var newSupplierLinq = from sup in newSuppliersList
                                  select new
                                  {
                                      sup.SupName
                                  };

            foreach (var item in newSupplierLinq)
            {
                cbSupplier.Items.Add(item.SupName);

                // For update
                cbNewSup.Items.Add(item.SupName);
            }
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

                        // Get the supplier id for the selected supplier in the combo box                      
                        var supI = (from sup in suppliersList
                                                   where sup.SupName == cbSupplier.Text
                                                   select sup.SupplierId).First();

                        // Insert the product supplier
                        Products_Suppliers pS = new Products_Suppliers(insertedId, supI);
                        bool insertPs = Product_SuppliersDB.Insert(pS);

                        OperationStatus(insertPs); //Display message to user

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

                    // Get the old supplier id for the selected supplier in the combo box                      
                    var oldSupId = (from sup in suppliersList
                                 where sup.SupName == cbSupplier.Text
                                 select sup.SupplierId).First();


                    // Get the new supplier id for the selected supplier in the lower CB
                    var newSupId = (from sup in suppliersList
                                    where sup.SupName == cbNewSup.Text
                                    select sup.SupplierId).First();


                    // Old and new Products_Suppliers objects
                    Products_Suppliers oldPs = new Products_Suppliers(oldProd.ProductId, oldSupId);
                    Products_Suppliers newPs = new Products_Suppliers(oldProd.ProductId, newSupId);
                  
                    bool updatePS = Product_SuppliersDB.Update(oldPs, newPs);

                    OperationStatus(updatePS); //Display message to user

                    break;

                case "rbDelete":
                    // Delete existing supplier
                    // Sans validation

                    // Get the supplier id for the selected supplier in the combo box                      
                    var prd = (from pr in productList
                                where pr.ProductName == cbProdName.Text
                                select pr.ProductId).First();

                    List<Products_Suppliers> psList = Product_SuppliersDB.GetSuppliers();

                    foreach (Products_Suppliers item in psList)
                    {
                        if (item.ProductId == prd)
                        {
                            Product_SuppliersDB.Delete(item.ProductId);
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
                var sup = (from x in productList where x.ProductName == cbProdName.Text select x).First();

                txtProdName.Text = sup.ProductName.ToString();

            }
        }

        private void rbAdd_CheckedChanged(object sender, EventArgs e)
        {

            // Alter visibility
            lblPnameTxt.Visible = true;
            lblSupName.Visible = true;
            lblPnameCb.Visible = false;
            lblNewSup.Visible = false;

            txtProdName.Visible = true;
            cbSupplier.Visible = true;           
            cbProdName.Visible = false;
            cbNewSup.Visible = false;

            btnSubmit.Visible = true;
            btnProdClear.Visible = true;

            // Remove Contents
            txtProdName.Text = null;
            cbSupplier.SelectedIndex = -1;
        }

        private void rbUpdate_CheckedChanged(object sender, EventArgs e)
        {
            // Alter visibility           
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
            txtProdName.Text = null;
            cbProdName.SelectedIndex = -1;
            cbSupplier.SelectedIndex = -1;
            cbNewSup.SelectedIndex = -1;

        }

        private void rbDelete_CheckedChanged(object sender, EventArgs e)
        {
            // Alter visibility
            lblPnameCb.Visible = true;
            lblPnameTxt.Visible = false;
            lblSupName.Visible = false;
            lblNewSup.Visible = false;

            txtProdName.Visible = false;
            cbProdName.Visible = true;
            cbSupplier.Visible = false;
            cbNewSup.Visible = false;

            btnSubmit.Visible = true;
            btnProdClear.Visible = true;

            // Remove Contents
            txtProdName.Text = null;
            cbProdName.SelectedIndex = -1;
            cbSupplier.SelectedIndex = -1;
            cbNewSup.SelectedIndex = -1;

        }
    }
}