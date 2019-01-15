using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Query
{
    public class SQLforDataGrid
    {
        private static string query; //string to hold the query

        public static string SelQuery(string tableName, string colNames, string orderbyColName)
        {
            query = string.Format("SELECT {0} FROM {1} ORDER BY {2}", colNames, tableName, orderbyColName);
            return query;
        }
    }
}
