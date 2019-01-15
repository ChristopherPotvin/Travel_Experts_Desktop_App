using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Query
{
    public class DataGridDB
    {
        //declare pertinent variables with respect to database
        private static SqlDataAdapter sqlDa; //variable provides the communication between Dataset and sql database
        private static DataTable dtbl; //variable to create a new table from database
        private static SqlCommandBuilder commandBuilder;

        private static SqlConnection con = Connection.GetConnection();

        //create method to display data in datagridview
        public static void GetDGData(string query, DataGridView dgvName, BindingSource bsName)
        {
            try
            {
                con.Open();
                sqlDa = new SqlDataAdapter(query, con);
                dtbl = new DataTable();
                sqlDa.Fill(dtbl); //fill table with result from query

                bsName.DataSource = dtbl; //add table querried in datagrid view
                dgvName.Columns[0].ReadOnly = true; //prevent user from modifiying first column which is id
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //create method to delete data in database from datagridview
        public static void DeleteData(string dbTableName, string NameId, DataGridView dgvName)
        {
            DataGridViewRow row = dgvName.CurrentCell.OwningRow; //grab current row
            string value = row.Cells[NameId].Value.ToString(); //grab value from the id field of the selected record

            DialogResult result = MessageBox.Show("Do you really want to delete the record ", "Delete Record", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            string deleteStmt = String.Format("Delete from {0} where {1} = {2}", dbTableName, NameId, value);

            if (result == DialogResult.Yes)
            {
                try
                {
                    //sqlCon.Open();
                    SqlCommand comm = new SqlCommand(deleteStmt, con);
                    comm.ExecuteNonQuery();
                }
                catch(DBConcurrencyException)
                {
                    MessageBox.Show("Another user has updated or deleted the record. Please refresh the table", "Unable to perform command", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                } 
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        //create method to edit data in database from datagridview
        public static void EditData(BindingSource bsName)
        {
            DialogResult result = MessageBox.Show("Do you really want to update database? ", "Message", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    commandBuilder = new SqlCommandBuilder(sqlDa);
                    bsName.EndEdit();
                    sqlDa.Update(dtbl);
                    MessageBox.Show("Update successful");
                }
                catch (DBConcurrencyException)
                {
                    MessageBox.Show("Another user has updated or deleted the record. Please refresh the table", "Unable to perform command", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

    }
}
