using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Travel_Experts
{
    public static class Database
    {
        //declare pertinent variables with respect to database
        private static SqlConnection sqlCon; //variable to hold the sql connection
        private static SqlDataAdapter sqlDa; //variable provides the communication between Dataset and sql database
        private static DataTable dtbl; //variable to create a new table from database
        private static SqlCommandBuilder commandBuilder;
        
        //create method to connect to database
        public static void Connection(string connString)
        {
            try
            {
                sqlCon = new SqlConnection(); 
                sqlCon.ConnectionString = connString;  //connString is the variable to hold the sql connection
                sqlCon.Open(); //open connection
            }
            catch (Exception ex)
            {
                //sqlCon.ConnectionString = null;
                MessageBox.Show(ex.Message, "Unable to connect to database");
            } 
        }

        //create method to get data from database based on query and display table in datagridview
        public static void GetData(string connString, string query,  DataGridView dgvName, BindingSource bsName)
        {
            try
            {
                Connection(connString);
                sqlDa = new SqlDataAdapter(query, sqlCon);
                dtbl = new DataTable(); 
                sqlDa.Fill(dtbl); //fill table with result from query

                bsName.DataSource = dtbl; //add table querried in datagrid view
                dgvName.Columns[0].ReadOnly = true; //prevent user from modifiying first column which is id
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Unable to create table");
            }
        }

        //create method to delete data from database
        public static void DeleteData(string dbtableName, string NameId, DataGridView dgvName)
        {
            DataGridViewRow row = dgvName.CurrentCell.OwningRow; //grab current row
            string value = row.Cells[NameId].Value.ToString(); //grab value from the id field of the selected record

            DialogResult result = MessageBox.Show("Do you really want to delete the record ", "Delete Record", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            string deleteStmt =String.Format( "Delete from {0} where {1} = {2}", dbtableName, NameId, value);

            if (result == DialogResult.Yes)
            {
                    try
                    {
                        SqlCommand comm = new SqlCommand(deleteStmt, sqlCon);
                        comm.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Unable to delete record");
                    }
            }
        }

        //create method to edit/add data to database
        public static void EditData(BindingSource bsName)
        {
            DialogResult result = MessageBox.Show("Do you really want to save new information? ", "Message", MessageBoxButtons.YesNo,
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
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Unable to update database");
                }
            }
        }       
    }
}
