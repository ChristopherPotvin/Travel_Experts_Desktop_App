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
    public partial class ProductControl2 : UserControl
    {
        public ProductControl2()
        {
            InitializeComponent();
        }

        private string getProduct_Name()
        {
            if (Validator.IsString(txtProdName, lblProdName) && Validator.IsProvided(txtProdName, lblProdName))
            {
                return Convert.ToString(txtProdName.Text);
            }

            return null;
        }
 
        private int getProduct_Id()
        {
            if (Validator.IsNonNegativeInt(txtProdID, lblProdId) && Validator.IsProvided(txtProdID, lblProdId))
            {
                return Convert.ToInt32(txtProdID.Text);
            }
            return 0;
        }

        private void btnProdApply_Click(object sender, EventArgs e)
        {

            string productName = getProduct_Name();
            int productId = getProduct_Id();

            if (productName != null && productId != 0)
            {
                Model.Products products = new Model.Products (getProduct_Id(), getProduct_Name()); // creating the object
               
                MessageBox.Show(products.ToString()); // Showing the object
            }
        }
    }
}
