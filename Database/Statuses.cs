using MySql.Data.MySqlClient;
using Order_Management.Properties;
using System;
using System.Data;

namespace Order_Management.Database
{
    static class Statuses
    {
        private static MySqlDataAdapter dataAdapter;
        private static DataTable dataTable;

        public static DataTable LoadStatusesFilter()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(Settings.Default.dbConnection))
                {
                    string mySqlExpression = "SELECT * FROM tbl_statuses WHERE archive = 0";
                    dataAdapter = new MySqlDataAdapter(mySqlExpression, connection);
                    dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    return dataTable;
                }
            }
            catch { return dataTable; }
        }

        public static DataTable LoadStatuses()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(Settings.Default.dbConnection))
                {
                    string mySqlExpression = "SELECT * FROM tbl_statuses WHERE id != 1 AND archive = 0";
                    dataAdapter = new MySqlDataAdapter(mySqlExpression, connection);
                    dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    return dataTable;
                }
            }
            catch { return dataTable; }
        }

        public static int GetStatusID(string statusName)
        {
            DataRow[] rows = dataTable.Select($"status = '{ statusName }'");
            return Convert.ToInt32(rows[0][0]);
        }
    }
}
