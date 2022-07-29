using MySql.Data.MySqlClient;
using Order_Management.Properties;
using System;
using System.Threading.Tasks;

namespace Order_Management
{
    static class AutoRefresher
    {
        public static DateTime oldDate;
        private static DateTime newDate;

        private static async void ChangeController()
        {
            while (true)
            {
                await Task.Delay(60000); // 1мин

                using (MySqlConnection connection = new MySqlConnection(Settings.Default.dbConnection))
                {
                    connection.Open();

                    string mySqlExpression = "SELECT date_of_change FROM tbl_last_changes";
                    using (MySqlCommand command = new MySqlCommand(mySqlExpression, connection))
                    {
                        newDate = Convert.ToDateTime(command.ExecuteScalar());
                    }
                }

                if (oldDate < newDate)
                {
                    OrdersForm.ordersForm.ReloadData();
                    oldDate = newDate;
                }
            }
        }

        public static void UpdateDate()
        {
            oldDate = DateTime.Now;
            
            using (MySqlConnection connection = new MySqlConnection(Settings.Default.dbConnection))
            {
                connection.Open();

                string mySqlExpression = "UPDATE tbl_last_changes SET date_of_change = @date_of_change WHERE id = '0'";

                using (MySqlCommand command = new MySqlCommand(mySqlExpression, connection))
                {
                    command.Parameters.Add("@date_of_change", MySqlDbType.DateTime).Value = oldDate;
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void Start()
        {
            oldDate = DateTime.Now;
            ChangeController();
        }
    }
}
