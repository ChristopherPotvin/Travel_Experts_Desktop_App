using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Model
{
    public class Products
    {
        private int productId; // var for product ID
        private string ProdName; // var for product name


        public int ProductId // getting and setting the product ID
        {
            get => productId;

            set
            {
                if (value > 0)
                {
                    productId = value;
                }
            }
        }

        public string ProductName { get => ProdName; set => ProdName = value; } // setting and getting the product name

        public Products(int productId, string productName) // the custom constructor passing the var product ID and product Name as parameters

        {
            ProductId = productId;
            ProductName = productName;
        }

        public override string ToString() // displaying the Product ID and Product Name
        {
            return "Product ID: " + ProductId + " Product Name: " + ProductName;
        }
    }
}
