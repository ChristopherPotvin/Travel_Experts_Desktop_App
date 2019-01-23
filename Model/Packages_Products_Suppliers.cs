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
    public class Packages_Products_Suppliers
    {
        // Member fields
        private int packageId;
        private int productSupplierId;

        // Getters/setters
        public int PackageId { get => packageId; set => packageId = value; }
        public int ProductSupplierId { get => productSupplierId; set => productSupplierId = value; }

        // Constructors
        public Packages_Products_Suppliers(int pId, int psId)
        {
            PackageId = pId;
            ProductSupplierId = psId;
        }

        public Packages_Products_Suppliers() { }

    }
}
