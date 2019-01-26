using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// <summary>
///  Untested
/// </summary>

namespace Query
{
    public class Product_SuppliersDB
    {
        public static List<Products_Suppliers> GetSuppliers()
        {
            Products_Suppliers pSupplier = null;

            SqlConnection conn = Connection.GetConnection();

            string query = "SELECT ProductSupplierId, ProductId, SupplierId " +
                    "FROM Products_Suppliers;";

            SqlCommand cmd = new SqlCommand(query, conn);
            List<Products_Suppliers> psList = new List<Products_Suppliers>();

            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    pSupplier = new Products_Suppliers((int)reader["ProductId"], (int)reader["SupplierId"]);
                    psList.Add(pSupplier); // Add to return list
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
            return psList;
        }

        public static bool Insert(Products_Suppliers pSupplier)
        {
            bool result = false;
            SqlConnection con = Connection.GetConnection();

            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "INSERT INTO Products_Suppliers (ProductId, SupplierId) values (@pId, @sId)";

                // ProductSupplierId Paramater
                //SqlParameter psIdPar = new SqlParameter("@psId", SqlDbType.Int);
                //psIdPar.Value = pSupplier.ProductSupplierId;
                //cmd.Parameters.Add(psIdPar);

                // ProductId Paramater
                SqlParameter pIdPar = new SqlParameter("@pId", SqlDbType.Int);
                pIdPar.Value = pSupplier.ProductId;
                cmd.Parameters.Add(pIdPar);

                // SupplierId Paramater
                SqlParameter sIdPar = new SqlParameter("@sId", SqlDbType.Int);
                sIdPar.Value = pSupplier.SupplierId;
                cmd.Parameters.Add(sIdPar);

                cmd.ExecuteNonQuery();

                result = true;
            }
            catch (SqlException e)
            {
                switch (e.Number)
                {

                    case 2627:
                        throw new DuplicateKeyException(string.Format("Duplicate ID entry, please enter a different ID and try again {0}", pSupplier.SupplierId));
                    default:
                        throw;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return result;
        }

        public static bool Update(Products_Suppliers oldPsupplier, Products_Suppliers newPsupplier)
        {
            bool result = false;
            SqlConnection con = Connection.GetConnection();

            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandText = "UPDATE Products_Suppliers SET SupplierId = @newSid WHERE SupplierId = @oldSid AND ProductId = @oldPid";

                // New SupplierId Paramater
                SqlParameter newSidPar = new SqlParameter("@newSid", SqlDbType.Int);
                newSidPar.Value = newPsupplier.SupplierId;
                cmd.Parameters.Add(newSidPar);

                // New ProductId Paramater
                //SqlParameter newPidPar = new SqlParameter("@newPid", SqlDbType.Int);
                //newPidPar.Value = newPsupplier.ProductId;
                //cmd.Parameters.Add(newPidPar);

                // Old SupplierId Paramater
                SqlParameter oldSidPar = new SqlParameter("@oldSid", SqlDbType.Int);
                oldSidPar.Value = oldPsupplier.SupplierId;
                cmd.Parameters.Add(oldSidPar);

                // Old ProductID Paramater
                SqlParameter oldPIdPar = new SqlParameter("@oldPid", SqlDbType.Int);
                oldPIdPar.Value = oldPsupplier.ProductSupplierId;
                cmd.Parameters.Add(oldPIdPar);

                cmd.ExecuteNonQuery();

                result = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();

            }
            return result;
        }


        public static bool Delete(Products_Suppliers pSupplier)
        {
            bool result = false;
            SqlConnection con = Connection.GetConnection();

            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "DELETE FROM Products_Suppliers WHERE ProductSupplierId = @id";

                // Primary Key Paramater
                SqlParameter idPar = new SqlParameter("@id", SqlDbType.Int);
                //idPar.Value = pSupplier.ProductSupplierId;
                cmd.Parameters.Add(idPar);

                cmd.ExecuteNonQuery();

                result = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return result;
        }

        public static bool Delete(int prodId)
        {
            bool result = false;
            SqlConnection con = Connection.GetConnection();

            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "DELETE FROM Products_Suppliers WHERE ProductId = @id";

                // Primary Key Paramater
                SqlParameter idPar = new SqlParameter("@id", SqlDbType.Int);
                idPar.Value = prodId;
                cmd.Parameters.Add(idPar);

                cmd.ExecuteNonQuery();

                result = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return result;
        }

        public class DuplicateKeyException : Exception
        {
            public DuplicateKeyException(string message)
               : base(message)
            {
            }
        }


    }
}
