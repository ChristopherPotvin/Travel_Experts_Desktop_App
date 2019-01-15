using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Suppliers
    {

        //Member fields
        private int supplierId;
        private string supName;

        //Properties
        public int SupplierId
        {
            get => supplierId;

            set
            {
                if (value > 0)
                {
                    supplierId = value;
                }

            }
        }

        public string SupName { get => supName; set => supName = value; }

        //Constructor
        public Suppliers(int supplierId, string supName)
        {
            SupplierId = supplierId;
            SupName = supName;
        }

        public override string ToString()
        {
            return SupName + " " + SupplierId;
        }

    }
}
