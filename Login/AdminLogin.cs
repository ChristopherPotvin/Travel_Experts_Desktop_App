using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    class AdminLogin
    {
        //Properties for Agent
        public int AdminID { get; set; } // 2
        public string AdminName { get; set; } // Mo Sagnia
        public string AdminPassword { get; set; } // Chelsea Sucks

        // Constructor 
        public AdminLogin(int user, string name, string pass)
        {

            this.AdminID = user;
            this.AdminName = name;
            this.AdminPassword = GetHashCode(pass); // call the method and set it as the Agent Password
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

