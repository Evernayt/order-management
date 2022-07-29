using MySql.Data.MySqlClient;
using Order_Management.Properties;
using System.Data;

namespace Order_Management.Database
{
    static class Categories
    {
        public static DataTable LoadFolders()
        {
            using (MySqlConnection connection = new MySqlConnection(Settings.Default.dbConnection))
            {
                string mySqlExpression = "SELECT folder_name FROM tbl_categories WHERE archive = 0";
                using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(mySqlExpression, connection))
                {
                    using (DataTable dataTable = new DataTable("tbl_categories"))
                    {
                        dataAdapter.Fill(dataTable);
                        return dataTable;
                    }
                }
            }
        }
    }
}
