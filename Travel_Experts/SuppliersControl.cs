using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Query;

namespace Travel_Experts
{
    public partial class SuppliersControl : UserControl
    {

        List<Suppliers> suppliersList =SuppliersDB.GetSuppliers();

        public SuppliersControl()
        {
            InitializeComponent();
        }

        private void SuppliersControl_Load(object sender, EventArgs e)
        {
            var supplierLinq = from sup in suppliersList
                           select new
                           {
                               sup.SupName
                           };

            foreach (var item in supplierLinq)
            {
                supNameComboBox.Items.Add(item.SupName);
            }
        }
    }
}
