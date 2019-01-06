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


namespace Travel_Experts
{
    public partial class HomeControl : UserControl
    {
        public HomeControl()
        {
            InitializeComponent();
        }

        //Instantiate login object with the correct login information (placeholder)
        Login.Login login = new Login.Login("mileycyrus", 12345);

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (ErrorProvider.ValidProvided(txtUname,"User Name",errorProvider1) && ErrorProvider.ValidProvided(txtPword,"Password",errorProvider1) && ErrorProvider.ValidInt(txtPword, "Password", errorProvider1))
            {
                //define local variables from the user inputs 
                string user = txtUname.Text;
                int pass = Convert.ToInt32(txtPword.Text);

                //check if the entered information matches the placeholder
                if (login.EvaluateLogIn(user, pass))
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
            }    
        }
    }
}
