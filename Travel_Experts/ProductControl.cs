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

namespace Travel_Experts
{
    public partial class ProductControl : UserControl
    {
        private Products product;

        public ProductControl()
        {
            InitializeComponent();
        }

        private string GetProductName()
        {
            if (Validator.IsString(txtProdName, lblProdName) && Validator.IsProvided(txtProdName, lblProdName))
            {
                return Convert.ToString(txtProdName.Text);
            }

            return null;
        }

        private int GetProductId(int productId)
        {
            if (Validator.IsNonNegativeInt(txtProdID, lblProdId) && Validator.IsProvided(txtProdID, lblProdId) && Validator.IsNonNegativeDouble(txtProdID, lblProdName)
                && Validator.IsNonNegativeDecimal(txtProdID, lblProdId))

                try { product = ProductsDB.GetProductID(productId); }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());

                }

            return productId;
        }

        private void InsertProduct(Products products)
        {
            product.ProductId = Convert.ToInt32(txtProdID.Text);
            product.ProductName = txtProdName.Text;

        }

        private void btnProdSearch_Click(object sender, EventArgs e)
        {
            if (Validator.IsNonNegativeInt(txtProdID, lblProdId) && Validator.IsProvided(txtProdID, lblProdId) && Validator.IsNonNegativeDouble(txtProdID, lblProdName)
                && Validator.IsNonNegativeDecimal(txtProdID, lblProdId))
            {

                int productId = Convert.ToInt32(txtProdID.Text);
                this.GetProductId(productId);

                if (product == null)
                {
                    MessageBox.Show("There was no product found with this ID. " +
                         "Please try again.", "Product was not found");
                    this.ClearControls();
                }
                else
                {
                    this.DisplayProduct();
                }

            }
        }


        private void ClearControls()
        {
            txtProdID.Text = "";
            txtProdName.Text = "";
            btnProdSearch.Enabled = false;
            txtProdID.Select();
        }

        private void DisplayProduct()
        {
            txtProdName.Text = product.ProductName;
            btnProdSearch.Enabled = true;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (rdbAdd.Checked == true)
            {
                try
                {
                    this.InsertProduct(product);
                    DialogResult result = MessageBox.Show("Confirm Adding a New Product?",
                        "Confirm Please", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        this.InsertProduct(product);
                        product.ProductId = ProductsDB.InsertProduct(product);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }
            
            else if (rdbDelete.Checked == true)
            {
                DialogResult result = MessageBox.Show("Delete " + product.ProductName + "?",
                  "Confirm delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        if (!ProductsDB.DeleteProduct(product))
                        {
                            MessageBox.Show("Another user has updated or deleted " + "that package.",
                                "Database Error");
                            this.GetProductId(product.ProductId);
                            if (product != null)
                                this.DisplayProduct();
                            else
                            {
                                this.ClearControls();
                            }
                        }
                        else
                            this.ClearControls();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ex.GetType().ToString());
                    }
                }
            }
            else
            {
                Products newProduct = new Products();
                product.ProductId = Convert.ToInt32(txtProdID.Text);
                product.ProductName = txtProdName.Text;

                try
                {
                    DialogResult result = MessageBox.Show("Delete " + product.ProductName + "?",
                  "Confirm delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        if (!ProductsDB.UpdateProduct(product, newProduct))
                        {
                            MessageBox.Show("Another user has updated or " +
                                 "deleted that package.", "Database Error");
                        }
                        else
                        {
                            product = newProduct;
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }

            }

            
        }
    } }
