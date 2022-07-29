using MySql.Data.MySqlClient;
using Order_Management.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order_Management.Database
{
    static class ToDo
    {
        private static MySqlDataAdapter dataAdapter;
        private static DataTable dataTable;

        public static DataTable LoadToDo(string dateFrom)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(Settings.Default.dbConnection))
                {
                    string mySqlExpression = "SELECT tbl_todo.id, status, date_of_create, task, " +
                        "emp1.name_employee AS created, emp2.name_employee AS completed, tbl_shops.shop, urgently " +
                        "FROM tbl_todo " +
                        "INNER JOIN tbl_employees AS emp1 ON id_created = emp1.id " +
                        "INNER JOIN tbl_employees AS emp2 ON id_completed = emp2.id " +
                        "INNER JOIN tbl_shops ON id_shop = tbl_shops.id " +
                        $"WHERE date_of_create >= '{ dateFrom }'";

                    dataAdapter = new MySqlDataAdapter(mySqlExpression, connection);
                    dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    return dataTable;
                }
            }
            catch { return dataTable; }
        }

        public static DataTable ReloadToDo()
        {
            try
            {
                dataTable.Clear();
                dataAdapter.Fill(dataTable);
                return dataTable;
            }
            catch { return dataTable; }
        }

        public static void AddWork(string task)
        {
            using (MySqlConnection connection = new MySqlConnection(Settings.Default.dbConnection))
            {
                string mySqlExpression = "INSERT INTO tbl_todo (status, date_of_create, task, id_created, " +
                    "id_completed, id_shop, urgently) " +
                    "VALUES (@status, @date_of_create, @task, @id_created, " +
                    "@id_completed, @id_shop, @urgently)";

                using (MySqlCommand command = new MySqlCommand(mySqlExpression, connection))
                {
                    connection.Open();

                    command.Parameters.Add("@status", MySqlDbType.Byte).Value = 0;
                    command.Parameters.Add("@date_of_create", MySqlDbType.DateTime).Value = DateTime.Now;
                    command.Parameters.Add("@task", MySqlDbType.Text).Value = task;
                    command.Parameters.Add("@id_created", MySqlDbType.Int32).Value = Employees.currentUser.id;
                    command.Parameters.Add("@id_completed", MySqlDbType.Int32).Value = 3;
                    command.Parameters.Add("@id_shop", MySqlDbType.Byte).Value = Settings.Default.defaultShop;
                    command.Parameters.Add("@urgently", MySqlDbType.Int32).Value = 0;

                    command.ExecuteNonQuery();
                }
            }
        }

        public static void UpdateToDoStatus(int id, int status)
        {
            using (MySqlConnection connection = new MySqlConnection(Settings.Default.dbConnection))
            {
                connection.Open();

                string mySqlExpression = "UPDATE tbl_todo SET status = @status, id_completed = @id_completed " +
                        $"WHERE id = '{ id }'";

                using (MySqlCommand command = new MySqlCommand(mySqlExpression, connection))
                {
                    command.Parameters.Add("@status", MySqlDbType.Byte).Value = status;
                    command.Parameters.Add("@id_completed", MySqlDbType.Int32).Value = Employees.currentUser.id;
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void UpdateToDoWork(int id, string task)
        {
            using (MySqlConnection connection = new MySqlConnection(Settings.Default.dbConnection))
            {
                connection.Open();

                string mySqlExpression = "UPDATE tbl_todo SET task = @task " +
                        $"WHERE id = '{ id }'";

                using (MySqlCommand command = new MySqlCommand(mySqlExpression, connection))
                {
                    command.Parameters.Add("@task", MySqlDbType.Text).Value = task;
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void UrgentlyTask(int id, int urgently)
        {
            using (MySqlConnection connection = new MySqlConnection(Settings.Default.dbConnection))
            {
                connection.Open();

                string mySqlExpression = "UPDATE tbl_todo SET urgently = @urgently " +
                        $"WHERE id = '{ id }'";

                using (MySqlCommand command = new MySqlCommand(mySqlExpression, connection))
                {
                    command.Parameters.Add("@urgently", MySqlDbType.Byte).Value = urgently;
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void DeleteTask(int id)
        {
            using (MySqlConnection connection = new MySqlConnection(Settings.Default.dbConnection))
            {
                connection.Open();

                string mySqlExpression = $"DELETE FROM tbl_todo WHERE id = '{ id }'";
                using (MySqlCommand command = new MySqlCommand(mySqlExpression, connection))
                {
                    DataRow[] result = dataTable.Select($"id = '{ id }'");

                    if (result.Length > 0)
                    {
                        result[0].Delete();
                    }

                    command.ExecuteNonQuery();
                }
            }

        }
    }
}
