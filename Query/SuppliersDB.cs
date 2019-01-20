using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.SqlClient;
using System.Data;

namespace Query
{

    public class SuppliersDB
    {

        public static List<Suppliers> GetSuppliers()
        {
            Suppliers supplier = null;

            SqlConnection conn = Connection.GetConnection();

            string query = "SELECT SupplierID, SupName " +
                    "FROM Suppliers " +
                    "ORDER BY SupplierID;";

            SqlCommand cmd = new SqlCommand(query, conn);
            List<Suppliers> supplierList = new List<Suppliers>();

            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string var1 = reader["SupplierID"].ToString();

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

        public static bool Insert(Suppliers supplier)
        {
            bool result = false ;
            SqlConnection con = Connection.GetConnection();
            
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "INSERT INTO Suppliers (SupplierId, SupName) values (@id, @name)";

                // ID Paramater
                SqlParameter idPar = new SqlParameter("@id", SqlDbType.Int);
                idPar.Value = supplier.SupplierId; 
                cmd.Parameters.Add(idPar);

                // Name Paramater
                SqlParameter namePar = new SqlParameter("@name", SqlDbType.NVarChar);
                namePar.Value = supplier.SupName;
                cmd.Parameters.Add(namePar);
                cmd.ExecuteNonQuery();

                result = true;
            }
            catch (SqlException e)
            {
                switch (e.Number)
                {
                    case 2627:
                        throw new DuplicateKeyException(string.Format("Duplicate ID entry, please enter a different ID and try again {0}", supplier.SupplierId));
                        break;
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

        public static bool Update(Suppliers oldSupplier, Suppliers newSupplier)
        {
            bool result = false;
            SqlConnection con = Connection.GetConnection();
            
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandText = "UPDATE Suppliers SET SupplierId = @newId, SupName = @newName Where SupplierId = @oldID and SupName = @oldName";

                // newId Paramater
                SqlParameter newIdPar = new SqlParameter("@newId", SqlDbType.Int);
                newIdPar.Value = newSupplier.SupplierId;
                cmd.Parameters.Add(newIdPar);

                // newName Paramater
                SqlParameter newNamePar = new SqlParameter("@newName", SqlDbType.NVarChar);
                newNamePar.Value = newSupplier.SupName;
                cmd.Parameters.Add(newNamePar);

                // oldId Paramater
                SqlParameter oldIdPar = new SqlParameter("@oldId", SqlDbType.Int);
                oldIdPar.Value = oldSupplier.SupplierId;
                cmd.Parameters.Add(oldIdPar);

                // oldName Paramater
                SqlParameter oldNamePar = new SqlParameter("@oldName", SqlDbType.NVarChar);
                oldNamePar.Value = oldSupplier.SupName;
                cmd.Parameters.Add(oldNamePar);

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


        public static bool Delete(Suppliers supplier)
        {
            bool result = false;

            SqlConnection con = Connection.GetConnection();

            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "DELETE FROM Suppliers WHERE SupplierId = @id";

                // ID Paramater
                SqlParameter idPar = new SqlParameter("@id", SqlDbType.Int);
                idPar.Value = supplier.SupplierId;
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

