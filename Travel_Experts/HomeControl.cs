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
using Query;

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
            if (txtAgentID.Text == "")
            {
                MessageBox.Show("Please enter a correct Agent ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
              
                return;
            }
            if (txtUname.Text == "")
            {
                MessageBox.Show("Please enter a username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                return;
            }
            if (txtPword.Text == "")
            {
                MessageBox.Show("Please enter a password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
                return;
            }
            try
            {
                string selectPassword = "SELECT AgentID, AgentName, AgentPassword FROM AgentLogin WHERE AgentID = @AgentID AND AgentName = @AgentName AND AgentPassword = @AgentPassword";

                SqlConnection conn = Connection.GetConnection();
                //conn = new SqlConnection();
                
                SqlCommand cmd = new SqlCommand(selectPassword, conn);

                SqlParameter AgentID = new SqlParameter("@AgentID", SqlDbType.Int);
                SqlParameter AgentName = new SqlParameter("@AgentName", SqlDbType.VarChar);
                SqlParameter AgentPassword = new SqlParameter("@AgentPassword", SqlDbType.VarChar);
                
                AgentID.Value = txtAgentID.Text;
                AgentName.Value = txtUname.Text;
                AgentPassword.Value = txtPword.Text;
                

                
                cmd.Parameters.Add(AgentID);
                cmd.Parameters.Add(AgentName);
                cmd.Parameters.Add(AgentPassword);

                //cmd.Connection.Open();
                conn.Open();

                SqlDataReader myReader = cmd.ExecuteReader();

                if (myReader.Read() == true)
                {
                    MessageBox.Show("You are now logged in " + txtUname.Text + "!!! ");
                    //Hide the login form
                    this.Hide();
                    Form1 mainForm = (Form1)this.Parent; //Access the parent form and enable the side navigation
                    mainForm.Navigation(true);
                    
                    gbLogin.Visible = false; // Disable the visibility of the login groupbox
                }

                else
                {
                    MessageBox.Show("Login Failed, please try again", "Login Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txtAgentID.Clear();
                    txtUname.Clear();
                    txtPword.Focus();
                }

                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }

    }
}
  ////if /*ErrorProvider.ValidProvided(txtUname,"User Name",errorProvider1) && ErrorProvider.ValidProvided(txtPword,"Password",errorProvider1) && ErrorProvider.ValidInt(txtPword, "Password", errorProvider1)*/
        ////{
        //    //define local variables from the user inputs 
        //    //string user = txtUname.Text;
        //    //int pass = Convert.ToInt32(txtPword.Text);

        //    SqlConnection sqlcon = new SqlConnection("AzureConnection");
        //    string query = "Select * from AgentLogin Where AgentID = '" + txtAgentID.Text.Trim() + "' and AgentName = '" + txtUname.Text.Trim() + "' and AgentPassword = '" + txtPword.Text.Trim();
        //    SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
        //    DataTable dtbl = new DataTable();
        //    sda.Fill(dtbl);


        //    //check if the entered information matches the placeholder
        //    if (dtbl.Rows.Count == 0)
        //    {
        //        //Access the partent form and enable the side navigation
        //        Form1 mainForm = (Form1)this.Parent;
        //        mainForm.Navigation(true);

        //        // Disable the visibility of the login groupbox
        //        gbLogin.Visible = false;
        //    }
        //    else
        //    {
        //        //show default login error message 
        //        MessageBox.Show("Incorrect Login Information");
        //    }
        ////}    
    //}
