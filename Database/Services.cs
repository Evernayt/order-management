using MySql.Data.MySqlClient;
using Order_Management.Properties;
using System;
using System.Data;

namespace Order_Management.Database
{
    static class Services
    {
        private static MySqlDataAdapter dataAdapter;
        private static DataTable dataTable;

        public static DataTable LoadServices(int id_order)
        {
            using (MySqlConnection connection = new MySqlConnection(Settings.Default.dbConnection))
            {
                string mySqlExpression = "SELECT tbl_services.id, tbl_all_services.service, quantity, comment, folder, id_order " +
                    "FROM tbl_services " +
                    "INNER JOIN tbl_all_services ON id_service = tbl_all_services.id " +
                    $"WHERE id_order = '{ id_order }'";

                dataAdapter = new MySqlDataAdapter(mySqlExpression, connection);
                dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                return dataTable;
            }
        }

        public static DataTable ReloadServices()
        {
            try
            {
                dataTable.Clear();
                dataAdapter.Fill(dataTable);
                return dataTable;
            }
            catch { return dataTable; }
        }

        public static void DeleteServices(int id_order)
        {
            using (MySqlConnection connection = new MySqlConnection(Settings.Default.dbConnection))
            {
                connection.Open();

                string mySqlExpression = $"DELETE FROM tbl_services WHERE id_order = '{ id_order }'";
                using (MySqlCommand command = new MySqlCommand(mySqlExpression, connection))
                    command.ExecuteNonQuery();
            }
        }

        public static void DeleteServiceByID(int id_service)
        {
            using (MySqlConnection connection = new MySqlConnection(Settings.Default.dbConnection))
            {
                connection.Open();

                string mySqlExpression = $"DELETE FROM tbl_services WHERE id = '{ id_service }'";
                using (MySqlCommand command = new MySqlCommand(mySqlExpression, connection))
                    command.ExecuteNonQuery();
            }
        }

        public static void UpdateService(int id_service, int quantity, string comment)
        {
            using (MySqlConnection connection = new MySqlConnection(Settings.Default.dbConnection))
            {
                connection.Open();

                string mySqlExpression = "UPDATE tbl_services SET quantity = @quantity, comment = @comment " +
                    $"WHERE id = '{ id_service }'";

                using (MySqlCommand command = new MySqlCommand(mySqlExpression, connection))
                {
                    command.Parameters.Add("@quantity", MySqlDbType.Int32).Value = quantity;
                    command.Parameters.Add("@comment", MySqlDbType.Text).Value = comment;

                    command.ExecuteNonQuery();
                }
            }
        }

        public static void AddService(int id_service, decimal quantity, string comment, int id_order)
        {
            using (MySqlConnection connection = new MySqlConnection(Settings.Default.dbConnection))
            {
                connection.Open();

                string mySqlExpression = "INSERT INTO tbl_services (id_service, quantity, comment, id_order)" +
                "VALUES (@id_service, @quantity, @comment, @id_order)";

                using (MySqlCommand command = new MySqlCommand(mySqlExpression, connection))
                {
                    command.Parameters.Add("@id_service", MySqlDbType.Int32).Value = id_service;
                    command.Parameters.Add("@quantity", MySqlDbType.Int32).Value = quantity;
                    command.Parameters.Add("@comment", MySqlDbType.Text).Value = comment;
                    command.Parameters.Add("@id_order", MySqlDbType.Int32).Value = id_order;

                    command.ExecuteNonQuery();
                }
            }
        }

        public static DataTable LoadServicesComments(int id_order)
        {
            using (MySqlConnection connection = new MySqlConnection(Settings.Default.dbConnection))
            {
                string mySqlExpression = $"SELECT comment FROM tbl_services WHERE id_order = '{ id_order }' AND comment != ''";
                using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(mySqlExpression, connection))
                {
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    return dataTable;
                }
            }
        }

        public static int GetServiceID(int id_service, int id_order)
        {
            using (MySqlConnection connection = new MySqlConnection(Settings.Default.dbConnection))
            {
                string mySqlExpression = "SELECT id " +
                    "FROM tbl_services " +
                    $"WHERE id_service = '{ id_service }' AND id_order = '{ id_order }'";

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

        public static void AddServiceFolder(int id_service, string folder)
        {
            using (MySqlConnection connection = new MySqlConnection(Settings.Default.dbConnection))
            {
                connection.Open();

                string mySqlExpression = "UPDATE tbl_services SET folder = @folder " +
                    $"WHERE id = '{ id_service }'";

                using (MySqlCommand command = new MySqlCommand(mySqlExpression, connection))
                {
                    command.Parameters.Add("@folder", MySqlDbType.Text).Value = folder;

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
