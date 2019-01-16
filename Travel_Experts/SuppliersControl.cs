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

        private void supNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            var sup = (from x in suppliersList where x.SupName == supNameComboBox.Text select x).First();

            if (sup != null)
            {
                supNameTextBox.Text = sup.SupName;
                supplierIdTextBox.Text = sup.SupplierId.ToString();
            }
        }

        private void rbAdd_CheckedChanged(object sender, EventArgs e)
        {
            // Alter visibility
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            
            var checkedButton = gbOptions.Controls.OfType<RadioButton>()
                                .FirstOrDefault(r => r.Checked);

            switch (checkedButton.Name)
            {
                case "rbAdd":
                    // Insert new supplier
                    // Sans validation
                    Suppliers sup = new Suppliers(Convert.ToInt32(supplierIdTextBox.Text),supNameTextBox.Text);
                    SuppliersDB.Insert(sup);
                    break;

                case "rbUpdate":
                    // Update existing supplier
                    // Sans validation
                    Suppliers newSup = new Suppliers(Convert.ToInt32(supplierIdTextBox.Text), supNameTextBox.Text);
                    var oldSup = (from x in suppliersList where x.SupName == supNameComboBox.Text select x).First();
                    SuppliersDB.Update(oldSup,newSup);
                    break;

                case "rbDelete":
                    // Delete existing supplier
                    // Sans validation
                    Suppliers delSup = new Suppliers(Convert.ToInt32(supplierIdTextBox.Text), supNameTextBox.Text);
                    SuppliersDB.Delete(delSup);
                    break;
            }            
        }
    }
}
