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

        public static void Insert(Suppliers supplier)
        {
            SqlConnection con = Connection.GetConnection();
            con.Open();

            try
            {
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
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
                
            }            
        }

        public static void Update(Suppliers oldSupplier, Suppliers newSupplier)
        {
            SqlConnection con = Connection.GetConnection();
            con.Open();

            try
            {
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
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();

            }
        }


        public static void Delete(Suppliers supplier)
        {
            SqlConnection con = Connection.GetConnection();
            con.Open();

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                //cmd.CommandText = "INSERT INTO Suppliers (SupplierId, SupName) values (@id, @name)";

                cmd.CommandText = "DELETE FROM Suppliers WHERE SupplierId = @id";

                // ID Paramater
                SqlParameter idPar = new SqlParameter("@id", SqlDbType.Int);
                idPar.Value = supplier.SupplierId;
                cmd.Parameters.Add(idPar);

                // Name Paramater
                //SqlParameter namePar = new SqlParameter("@name", SqlDbType.NVarChar);
                //namePar.Value = supplier.SupName;
                //cmd.Parameters.Add(namePar);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();

            }          
        }
    }
}

