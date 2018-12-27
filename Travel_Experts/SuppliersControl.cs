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
    public partial class SuppliersControl : UserControl
    {
        public SuppliersControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Access form elements and validate
        /// </summary>

        private string GetSearch()
        {
            if (Validator.IsString(txtSearch, lblSearchSupplier))
            {
                return Convert.ToString(txtSearch.Text);
            }
            return null;
        }

        private int GetSupId()
        {
            if (Validator.IsNonNegativeInt(txtSupId, lblSearchSupplier))
            {
                return Convert.ToInt32(txtSupId.Text);
            }
            return 0;
        }

        private string GetSupName()
        {
            if (Validator.IsString(txtSupName, lblSupplierName))
            {
                return Convert.ToString(txtSupName.Text);
            }
            return null;
        }

        /// <summary>
        /// Event Handlers
        /// </summary>

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchVal = GetSearch();

            if (searchVal != null)
            {
                //Placeholder
                MessageBox.Show(searchVal.ToString());
            }         
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            string supName = GetSupName();
            int? supId = GetSupId();

            if(supId != 0 && supName != null)
            {
                //Instantiate Object
                Model.Suppliers supplier = new Model.Suppliers(GetSupId(), GetSupName());

                //Placeholder
                MessageBox.Show(supplier.ToString());
            }
        }
    }
}
