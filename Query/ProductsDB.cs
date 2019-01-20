using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Query
{
    public class ProductsDB
    {
        public static Products GetProductID(int productID)
        {
            Products product = null;

            SqlConnection connection = Connection.GetConnection(); // instantiate the sql connection

            string query = "SELECT ProductID, ProdName " +
                           "FROM Products " +
                           "WHERE ProductID = @ProductID"; // sql statment to get productID

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ProductID", productID); // value comes from the method's argument
                   
            try

            {
                connection.Open(); // Open the connection
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                if (reader.Read())
                {

                    product = new Products();
                    product.ProductId = (int)reader["ProductID"];
                    product.ProductName = reader["ProdName"].ToString();
                    
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }

            return product;
        }

        public static int InsertProduct(Products product) // method for adding a new product to the DB
        {
            SqlConnection connection = Connection.GetConnection();
            string insertStatement = "INSERT INTO Products (ProdName) " +
                                    "VALUES(@ProdName)";
            SqlCommand command = new SqlCommand(insertStatement, connection);
            command.Parameters.AddWithValue("@ProdName", product.ProductName);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();

                string selectQuery = "SELECT IDENT_CURRENT('Products') FROM Products";
                SqlCommand selectCommand = new SqlCommand(selectQuery, connection);
                int productID = Convert.ToInt32(selectCommand.ExecuteScalar());

                return productID;
            }
            catch (SqlException ex)
            {

                throw ex;
            }
            finally
            {
                connection.Close();
            }

        }

        public static bool DeleteProduct(Products product)
        {
            SqlConnection connection = Connection.GetConnection();
            string deleteStatement = "DELETE FROM Products " +
                                     "WHERE ProductID = @ProductID " +
                                     "AND ProdName = @ProdName";

            SqlCommand command = new SqlCommand(deleteStatement, connection);
            command.Parameters.AddWithValue("@ProductID", product.ProductId);
            command.Parameters.AddWithValue("@ProdName", product.ProductName);

            try
            {
                connection.Open();
                int count = command.ExecuteNonQuery();
                if (count > 0) return true;
                else return false;
            }
            catch (SqlException ex)
            {

                throw ex;
            }
            finally
            {
                connection.Close();
            }

        }

        public static bool UpdateProduct (Products oldProduct, Products newProduct)
        {
            SqlConnection connection = Connection.GetConnection();
            string updateStatement = "UPDATE Products " +
                                     "SET Name = @NewProdName " +
                                     "WHERE ProductID = @OldProductID " + // this identifies which record needs to be updated
                                     "AND Name = @OldProdName ";

            SqlCommand command = new SqlCommand(updateStatement, connection);
            command.Parameters.AddWithValue("@NewProdName", newProduct.ProductName);
            command.Parameters.AddWithValue("@OldProdName", oldProduct.ProductName);
            command.Parameters.AddWithValue("@OldProductID", oldProduct.ProductId);

            try
            {
                connection.Open();
                int count = command.ExecuteNonQuery();
                if (count > 0) return true;
                else return false;

            }
            catch (SqlException ex)
            {

                throw ex;
            }
            finally
            {
                connection.Close();
            }
                   
        }
    }
}
//public static List<Products> GetProducts() // method for retrieving products to a list
//{
//    Products product = null;

//    SqlConnection connection = Connection.GetConnection(); // instantiate the sql connection

//    string query = "SELECT ProductID, ProdName " +
//                   "FROM Products " +
//                   "ORDER BY ProductID"; // sql statment to get products

//    SqlCommand command = new SqlCommand(query, connection);

//    List<Products> productList = new List<Products>(); // start with an empty list

//    try
//    {
//        connection.Open(); // Open the connection
//        SqlDataReader reader = command.ExecuteReader();

//        if (reader.Read())
//        {
//            product = new Products((int) reader ["ProductID"], (string) reader ["ProdName"]);
//            productList.Add(product); // return the list of products
//        }
//    }
//    catch (SqlException ex)
//    {
//        throw ex;
//    }
//    finally
//    {
//        connection.Close();
//    }

//    return productList;
//}
