using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.SqlClient;

namespace QueryDB
{

    public class SuppliersDB
    {

        public static List<Suppliers> GetSuppliers()
        {
            Suppliers supplier = null;

            SqlConnection conn = Connection.GetConnection();

            string query = "SELECT SupplierID, SupName" +
                    "FROM Suppliers " +
                    "ORDER BY SupplierID";

            SqlCommand cmd = new SqlCommand(query, conn);
            List<Suppliers> supplierList = new List<Suppliers>();

            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    supplier = new Suppliers((int)reader["SupplierID"], (string)reader["SupName"]);
                    supplierList.Add(supplier); // Add to return list
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }

            finally
            {
                conn.Close();
            }
            return supplierList;
        }
    }
}

