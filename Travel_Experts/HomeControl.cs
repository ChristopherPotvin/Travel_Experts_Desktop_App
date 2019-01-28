using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Login;
using System.Data.SqlClient;

namespace Travel_Experts
{
    public partial class HomeControl : UserControl
    {
        public HomeControl()
        {
            InitializeComponent();
        }

        ////Instantiate login object with the correct login information (placeholder)
        //Login.Login login = new Login.Login("mileycyrus", 12345);

        private void btnLogin_Click(object sender, EventArgs e)
        {

            //if /*ErrorProvider.ValidProvided(txtUname,"User Name",errorProvider1) && ErrorProvider.ValidProvided(txtPword,"Password",errorProvider1) && ErrorProvider.ValidInt(txtPword, "Password", errorProvider1)*/
            //{
                //define local variables from the user inputs 
                //string user = txtUname.Text;
                //int pass = Convert.ToInt32(txtPword.Text);

                SqlConnection sqlcon = new SqlConnection("AzureConnection");
                string query = "Select * from AgentLogin Where AgentID = '" + txtAgentID.Text.Trim() + "' and AgentName = '" + txtUname.Text.Trim() + "' and AgentPassword = '" + txtPword.Text.Trim();
                SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);


                //check if the entered information matches the placeholder
                if (dtbl.Rows.Count == 0)
                {
                    //Access the partent form and enable the side navigation
                    Form1 mainForm = (Form1)this.Parent;
                    mainForm.Navigation(true);

                    // Disable the visibility of the login groupbox
                    gbLogin.Visible = false;
                }
                else
                {
                    //show default login error message 
                    MessageBox.Show("Incorrect Login Information");
                }
            //}    
        }
    }
}
