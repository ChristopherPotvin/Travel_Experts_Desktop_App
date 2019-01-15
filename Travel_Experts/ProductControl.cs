﻿using System;
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
 
        private int GetProductId()
        {
            if (Validator.IsNonNegativeInt(txtProdID, lblProdId) && Validator.IsProvided(txtProdID, lblProdId) && Validator.IsNonNegativeDouble(txtProdID, lblProdName)
                && Validator.IsNonNegativeDecimal(txtProdID, lblProdId))
            {
              
            }
            return 0;
           
        }
        
        private void btnProdApply_Click(object sender, EventArgs e)
        {

            string productName = GetProductName();
            int productId = GetProductId();

            if (productName != null && productId != 0)
            {
                Model.Products products = new Model.Products (GetProductId(), GetProductName()); // creating the object
               
                MessageBox.Show(products.ToString()); // Showing the object
            }
        }
    }
}
