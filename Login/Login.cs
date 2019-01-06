using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public class Login
    {
        //Properties 
        public string Username { get; set; }
        public int Userpassword { get; set; }

        // Constructor 
        public Login(string user, int pass)
        {
            this.Username = user;
            this.Userpassword = pass;
        }
       
        // Determine if entered login information is valid
        public bool EvaluateLogIn(string user, int pass)
        {
           //Check if username is correct
            if (Username != user)
            {
                return false;
            }      
            //check password is correct 
            else if (Userpassword != pass)
            {
                return false;
            }
            else
            {
                return true;
            }          
        }
    }
}

