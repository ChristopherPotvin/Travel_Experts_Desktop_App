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
using static Query.SuppliersDB;

namespace Travel_Experts
{
    public partial class SuppliersControl : UserControl
    {
        //List<Suppliers> suppliersList = SuppliersDB.GetSuppliers();

        public SuppliersControl()
        {
            InitializeComponent();            
        }

        private void repopulate()
        {
            List<Suppliers> newSuppliersList = SuppliersDB.GetSuppliers();

            var newSupplierLinq = from sup in newSuppliersList
                               select new
                               {
                                   sup.SupName
                               };

            foreach (var item in newSupplierLinq)
            {
                cbSupName.Items.Add(item.SupName);
            }
        }

        private void SuppliersControl_Load(object sender, EventArgs e)
        {

            // Alter visibility
            cbSupName.Visible = false;
            txtSupName.Visible = false;
            txtSupId.Visible = false;

            lblSupId.Visible = false;
            lblSupName.Visible = false;
            lblSupNameDD.Visible = false;

            btnApply.Visible = false;

            repopulate();
           
        }

        private void supNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            List<Suppliers> suppliersList = SuppliersDB.GetSuppliers();

            lblSupName.Visible = true;
            lblSupId.Visible = true;

            txtSupId.Visible = true;
            txtSupName.Visible = true;


            if (cbSupName.SelectedIndex != -1)
            {
                var sup = (from x in suppliersList where x.SupName == cbSupName.Text select x).First();
                txtSupName.Text = sup.SupName;
                txtSupId.Text = sup.SupplierId.ToString();
            }

        }

        private void btnApply_Click(object sender, EventArgs e)
        {

            List<Suppliers> suppliersList = SuppliersDB.GetSuppliers();

            var checkedButton = gbOptions.Controls.OfType<RadioButton>()
                                .FirstOrDefault(r => r.Checked);


            switch (checkedButton.Name)
            {
                case "rbAdd":
                    // Insert new supplier
                    // Sans validation
                    try
                    {
                        Suppliers sup = new Suppliers(Convert.ToInt32(txtSupId.Text), txtSupName.Text);
                        bool insert = SuppliersDB.Insert(sup);
                        OperationStatus(insert); //Display message to user
                    }
                    catch (DuplicateKeyException ex)
                    {
                        lblStatus.Visible = true;
                        lblStatus.BackColor = Color.Red;
                        lblStatus.Text = ex.Message;
                    }                 
                    break;

                case "rbUpdate":
                    // Update existing supplier
                    // Sans validation
                    Suppliers newSup = new Suppliers(Convert.ToInt32(txtSupId.Text), txtSupName.Text);
                    var oldSup = (from x in suppliersList where x.SupName == cbSupName.Text select x).First();
                    bool update = SuppliersDB.Update(oldSup,newSup);
                    OperationStatus(update); //Display message to user
                    break;

                case "rbDelete":
                    // Delete existing supplier
                    // Sans validation
                    Suppliers delSup = new Suppliers(Convert.ToInt32(txtSupId.Text), txtSupName.Text);
                    bool delete = SuppliersDB.Delete(delSup);
                    OperationStatus(delete); //Display message to user
                    break;
            }

            repopulate();

            btnApply.Enabled = false;
        }

        private void rbUpdate_CheckedChanged(object sender, EventArgs e)
        {

            // Alter visibility
            lblSupNameDD.Visible = true;
            cbSupName.Visible = true;

            txtSupId.Visible = false;
            txtSupName.Visible = false;
            lblSupId.Visible = false;
            lblSupName.Visible = false;

            // Remove Contents
            txtSupId.Text = null;
            txtSupName.Text = null;
            cbSupName.SelectedIndex = -1;

            // Apply Button
            btnApply.Text = "Update";
            btnApply.Visible = true;
            btnApply.Enabled = true;

            // Status Message
            lblStatus.Visible = false;
        }

        private void rbDelete_CheckedChanged(object sender, EventArgs e)
        {
            // Alter visibility
            lblSupNameDD.Visible = true;
            cbSupName.Visible = true;

            txtSupId.Visible = false;
            txtSupName.Visible = false;
            lblSupId.Visible = false;
            lblSupName.Visible = false;

            // Remove Contents
            txtSupId.Text = null;
            txtSupName.Text = null;
            cbSupName.SelectedIndex = -1;

            // Apply Button
            btnApply.Text = "Delete";
            btnApply.Visible = true;
            btnApply.Enabled = true;

            // Status Message
            lblStatus.Visible = false;
        }

        private void rbAdd_CheckedChanged(object sender, EventArgs e)
        {
            // Alter visibility
            lblSupName.Visible = true;
            lblSupId.Visible = true;

            txtSupName.Visible = true;
            txtSupId.Visible = true;

            cbSupName.Visible = false;
            lblSupNameDD.Visible = false;

            // Remove Contents
            txtSupId.Text = null;
            txtSupName.Text = null;
            cbSupName.SelectedIndex = -1;

            // Apply Button
            btnApply.Text = "Add";
            btnApply.Visible = true;
            btnApply.Enabled = true;

            // Status Message
            lblStatus.Visible = false;

        }

        private void OperationStatus(bool result)
        {

            lblStatus.Visible = true;

            if (result)
            {
                lblStatus.BackColor = Color.LawnGreen;
                lblStatus.Text = "Operation successfull";
            }
            else
            {
                lblStatus.BackColor = Color.Red;
                lblStatus.Text = "Operation not successfull";
            }

        }
    }
}
