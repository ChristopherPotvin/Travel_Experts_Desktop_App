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

        // This needs a default constructor
        public Products() { }

        public Products(int productId, string ProdName)
        {
            ProductId = productId;
            ProductName = ProdName;
        }

    }
}
