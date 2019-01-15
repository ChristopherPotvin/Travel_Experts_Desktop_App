using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{

    public class TravelExpertsDB
    {
            static string GetConnectionStringByName(string name)
            {
                // Assume failure.

                string returnValue = null;
            
                // Look for the name in the connectionStrings section.

                ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings[name];
            
                // If found, return the connection string.

                if (settings != null)

                returnValue = settings.ConnectionString;
                
                return returnValue;

            }
        
        public static SqlConnection GetConnection()

        {
            string connectionString = GetConnectionStringByName(@"Data Source=projectteamno7.database.windows.net;Initial Catalog=travelexperts;User ID=Runner;Password=Travel123");
            return new SqlConnection(connectionString);
        }

    }
}
