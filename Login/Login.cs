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
        public int AgentID { get; set; }
        public string AgentName { get; set; }
        public string AgentPassword { get; set; }

        // Constructor 
        public Login(int user, string name, string password)
        {
            this.AgentID = user;
            this.AgentName = name;
            this.AgentPassword = password;
        }
       
        // Determine if entered login information is valid
        //public bool EvaluateLogIn(int user, string name, string password)
        //{
        //   //Check if username is correct
        //    if (AgentID != user)
        //    {
        //        return false;
        //    }      
        //    //check password is correct 
        //    else if (AgentPassword != password)
        //    {
        //        return false;
        //    }

        //    else if(AgentName != name)
        //    {
        //        return false;
        //    }

        //    else
        //    {
        //        return true;
        //    }          
        //}
    }
}

