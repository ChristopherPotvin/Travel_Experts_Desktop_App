using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;


namespace Query
{
    public class Connection
    {
        // Retrieves a connection string by name.
        // Returns null if the name is not found.
        static string GetConnectionStringByName(string name)
        {
            // Assume failure.
            string returnValue = null;

            // Look for the name in the connectionStrings section.
            ConnectionStringSettings settings =
                ConfigurationManager.ConnectionStrings[name];

            // If found, return the connection string.
            if (settings != null)
                returnValue = settings.ConnectionString;

            return returnValue;
        }

        public static SqlConnection GetConnection()
        {
            string connectionString = GetConnectionStringByName("AzureConnection");
            SqlConnection con = new SqlConnection(connectionString);
            return con;
        }
    }
}
