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


    }
}
