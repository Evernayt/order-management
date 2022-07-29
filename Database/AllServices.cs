using MySql.Data.MySqlClient;
using Order_Management.Properties;
using System;
using System.Data;

namespace Order_Management.Database
{
    static class AllServices
    {
        private static MySqlDataAdapter dataAdapter;
        private static DataTable dataTable;

        public static DataTable LoadAllServices()
        {
            using (MySqlConnection connection = new MySqlConnection(Settings.Default.dbConnection))
            {
                string mySqlExpression = "SELECT service FROM tbl_all_services";
                dataAdapter = new MySqlDataAdapter(mySqlExpression, connection);
                dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                return dataTable;
            }
        }

        public static string GetServiceFolder(string service)
        {
            using (MySqlConnection connection = new MySqlConnection(Settings.Default.dbConnection))
            {
                string mySqlExpression = "SELECT tbl_categories.folder_name " +
                    "FROM tbl_all_services " +
                    "INNER JOIN tbl_categories ON id_category = tbl_categories.id " +
                    $"WHERE service = '{ service }'";

                using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(mySqlExpression, connection))
                {
                    using (DataTable dataTable = new DataTable())
                    {
                        dataAdapter.Fill(dataTable);

                        if (dataTable.Rows.Count > 0)
                            return dataTable.Rows[0][0].ToString();
                        else
                            return "";
                    }
                }
            }
        }

        public static int GetServiceID(string service)
        {
            using (MySqlConnection connection = new MySqlConnection(Settings.Default.dbConnection))
            {
                string mySqlExpression = "SELECT id " +
                                        "FROM tbl_all_services " +
                                        $"WHERE service = '{ service }'";

                using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(mySqlExpression, connection))
                {
                    using (DataTable dataTable = new DataTable())
                    {
                        dataAdapter.Fill(dataTable);

                        if (dataTable.Rows.Count > 0)
                            return Convert.ToInt32(dataTable.Rows[0][0]);
                        else
                            return 0;
                    }
                }
            }
        }
    }
}
