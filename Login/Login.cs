using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public class Login
    {
        //Properties 
        public int AgentID { get; set; } // 1
        public string AgentName { get; set; } // Miley Cyrus
        public string AgentPassword { get; set; } // Travel123

        // Constructor 
        public Login(int user, string name, string pass)
        {

            this.AgentID = user;
            this.AgentName = name;
            this.AgentPassword = GetHashCode(pass); // call the method and set it as the Agent Password
        }

        private string GetHashCode(string pass) // Method for retrieving the hashed password
        {
            var sha1 = System.Security.Cryptography.SHA1.Create();
            var inputBytes = Encoding.ASCII.GetBytes(pass);
            var hash = sha1.ComputeHash(inputBytes);

            var sb = new StringBuilder();
            for (var i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2")); // Append the stringbuilder to hash the password
            }
            return sb.ToString();
        }
    }
}

