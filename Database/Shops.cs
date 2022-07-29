using MySql.Data.MySqlClient;
using Order_Management.Properties;
using System;
using System.Data;

namespace Order_Management.Database
{
    static class Shops
    {
        private static MySqlDataAdapter dataAdapter;
        private static DataTable dataTable;

        public static DataTable LoadShopsFilter()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(Settings.Default.dbConnection))
                {
                    string mySqlExpression = "SELECT * FROM tbl_shops WHERE archive = 0";
                    dataAdapter = new MySqlDataAdapter(mySqlExpression, connection);
                    dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    return dataTable;
                }
            }
            catch { return dataTable; }
        }

        public static DataTable LoadShops()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(Settings.Default.dbConnection))
                {
                    string mySqlExpression = "SELECT * FROM tbl_shops WHERE id != 1 AND archive = 0 AND id != 2";
                    dataAdapter = new MySqlDataAdapter(mySqlExpression, connection);
                    dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    return dataTable;
                }
            }
            catch { return dataTable; }
        }

        public static int GetShopID(string shop)
        {
            DataRow[] rows = dataTable.Select($"shop = '{ shop }'");
            return Convert.ToInt32(rows[0][0]);
        }
    }
}
