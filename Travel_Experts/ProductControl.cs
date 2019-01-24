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

            }
        }

        private void btnProdApply_Click(object sender, EventArgs e)
        {

            string productName = GetProductName();
            int productID = GetProductId();

            if (productName != null && productID != 0)
            {
                Products products = new Products(Convert.ToInt32(txtProdID.Text), txtProdName.Text);
                ProductsDB.InsertProduct(products);
            }
           
        }

        
        private void ClearControls()
        {
            txtProdID.Text = "";
            txtProdName.Text = "";
            btnModify.Enabled = false;
            btnDelete.Enabled = false;
            txtProdID.Select();
        }

        private void DisplayProduct()
        {
            txtProdName.Text = product.ProductName;
            btnModify.Enabled = true;
            btnProdAdd.Enabled = true;
            btnDelete.Enabled = true;
        }
    }
}
