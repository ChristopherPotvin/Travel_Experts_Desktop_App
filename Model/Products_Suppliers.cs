using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
///  Untested
/// </summary>

namespace Model
{
    public class Products_Suppliers
    {
        // Member fields
        private int productSupplierId;
        private int productId;
        private int supplierId;

        // Getters/Setters
        public int ProductSupplierId { get => productSupplierId; set => productSupplierId = value; }
        public int ProductId { get => productId; set => productId = value; }
        public int SupplierId { get => supplierId; set => supplierId = value; }

        // Constructors
        public Products_Suppliers(int pId, int sId)
        {
            ProductId = pId;
            SupplierId = sId;
        }

        public Products_Suppliers(int psId,int pId, int sId)
        {
            ProductSupplierId = psId;
            ProductId = pId;
            SupplierId = sId;
        }

        public Products_Suppliers() { }
    }
}
