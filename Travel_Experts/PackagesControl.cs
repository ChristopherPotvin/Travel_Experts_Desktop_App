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
    public partial class PackagesControl : UserControl
    {
        public Packages package;

        public PackagesControl()
        {
            InitializeComponent();
        }

        private void PackagesControl_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int packageID = Convert.ToInt32(txtID.Text);
            GetPackage(packageID);

            if (package == null)
            {
                MessageBox.Show("No Package found with this ID. " +
                    "Please try again.", "Package Not Found");
            }
            else
                this.DisplayPackages();
        }




        private void GetPackage(int packageID)
        {
            package = PackagesDB.GetPackages(packageID);
        }

        private void DisplayPackages()
        {
            txtID.Text = package.PackageId.ToString();
            txtName.Text = package.PkgName;
            txtPrice.Text = package.PkgBasePrice.ToString();
            txtCommission.Text = package.PkgAgencyCommission.ToString();
            dateStart.Text = package.PkgStartDate.ToString();
            dateEnd.Text = package.PkgEndDate.ToString();
            richTxtDescription.Text = package.PkgDesc;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (radAdd.Checked == true)
            {
                try
                {
                    this.PutPackageData(package);
                    DialogResult result = MessageBox.Show("Confirm Adding New Package?",
                        "Confirm Please", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        this.PutPackageData(package);
                        package.PackageId = PackagesDB.AddPackage(package);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }

                
            }
            else if (radUpdate.Checked == true)
            {
                Packages newPackage = new Packages();
                package.PackageId = Convert.ToInt32(txtID.Text);
                package.PkgName = txtName.Text;
                package.PkgBasePrice = Convert.ToDecimal(txtPrice.Text);
                package.PkgAgencyCommission = Convert.ToDecimal(txtCommission.Text);
                package.PkgStartDate = Convert.ToDateTime(dateStart);
                package.PkgEndDate = Convert.ToDateTime(dateEnd);
                package.PkgDesc = richTxtDescription.Text;
                try
                {
                    DialogResult result = MessageBox.Show("Delete " + package.PkgName + "?",
                  "Confirm delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        if (!PackagesDB.UpdatePackage(package, newPackage))
                        {
                            MessageBox.Show("Another user has updated or " +
                                 "deleted that package.", "Database Error");
                        }
                        else
                        {
                            package = newPackage;
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }

            }
            else
            {
                DialogResult result = MessageBox.Show("Delete " + package.PkgName + "?",
                    "Confirm delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        if (!PackagesDB.DeletePackage(package))
                        {
                            MessageBox.Show("Another user has updated or deleted " + "that package.",
                                "Database Error");
                            this.GetPackage(package.PackageId);
                            if (package != null)
                                this.DisplayPackages();
                            else
                            {
                                this.ClearControls();
                            }
                        }
                        else
                            this.ClearControls();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message, ex.GetType().ToString());
                    }
                }
                
            }
        }

        private void PutPackageData(Packages package)
        {
            package.PackageId = Convert.ToInt32(txtID.Text);
            package.PkgName = txtName.Text;
            package.PkgBasePrice = Convert.ToDecimal(txtPrice.Text);
            package.PkgAgencyCommission = Convert.ToDecimal(txtCommission.Text);
            package.PkgStartDate = Convert.ToDateTime(dateStart);
            package.PkgEndDate = Convert.ToDateTime(dateEnd);
            package.PkgDesc = richTxtDescription.Text;
        }

        private void radAdd_CheckedChanged(object sender, EventArgs e)
        {
            txtID.Visible = false;
            lblId.Visible = false;
            btnSearch.Visible = false;
        }

        private void ClearControls()
        {
            txtID.Text = "";
            txtName.Text = "";
            txtPrice.Text = "";
            txtCommission.Text = "";
            dateStart.Text = "";
            dateEnd.Text = "";
            richTxtDescription.Text = "";
        }
    }
}
