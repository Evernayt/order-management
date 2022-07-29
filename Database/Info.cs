using MySql.Data.MySqlClient;
using Order_Management.Properties;
using System;
using System.Data;

namespace Order_Management.Database
{
    static class Info
    {
        public static DataTable LoadInfo(int id_order)
        {
            using (MySqlConnection connection = new MySqlConnection(Settings.Default.dbConnection))
            {
                string mySqlExpression = "SELECT date, tbl_statuses.status, tbl_employees.name_employee, reason " +
                    "FROM tbl_info " +
                    "INNER JOIN tbl_statuses ON id_status = tbl_statuses.id " +
                    "INNER JOIN tbl_employees ON id_employee = tbl_employees.id  " +
                    $"WHERE id_order = '{ id_order }' " +
                    "ORDER BY date DESC";

                using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(mySqlExpression, connection))
                {
                    using (DataTable dataTable = new DataTable())
                    {
                        dataAdapter.Fill(dataTable);
                        return dataTable;
                    }
                }
            }
        }

        public static void AddInfo(int id_order, string status, string reason)
        {
            using (MySqlConnection connection = new MySqlConnection(Settings.Default.dbConnection))
            {
                connection.Open();

                string mySqlExpression = $"INSERT INTO tbl_info (id_order, date, id_employee, id_status, reason)" +
                "VALUES (@id_order, @date, @id_employee, @id_status, @reason)";

                using (MySqlCommand command = new MySqlCommand(mySqlExpression, connection))
                {
                    command.Parameters.Add("@id_order", MySqlDbType.Int32).Value = id_order;
                    command.Parameters.Add("@date", MySqlDbType.DateTime).Value = DateTime.Now;
                    command.Parameters.Add("@id_employee", MySqlDbType.Int32).Value = Employees.currentUser.id;
                    command.Parameters.Add("@id_status", MySqlDbType.Int32).Value = Statuses.GetStatusID(status);
                    command.Parameters.Add("@reason", MySqlDbType.VarChar).Value = reason;

                    command.ExecuteNonQuery();
                }
            }
        }

        public static void DeleteInfo(int id)
        {
            using (MySqlConnection connection = new MySqlConnection(Settings.Default.dbConnection))
            {
                connection.Open();

                string mySqlExpression = $"DELETE FROM tbl_info WHERE id_order = '{ id }'";
                using (MySqlCommand command = new MySqlCommand(mySqlExpression, connection))
                    command.ExecuteNonQuery();
            }
            
        }
    }
}
