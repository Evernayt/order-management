using MySql.Data.MySqlClient;
using Order_Management.Properties;
using System;
using System.Data;

namespace Order_Management.Database
{
    class OrderData
    {
        public string ClientName { get; set; }
        public string ClientPhone { get; set; }
        public bool ClientWhatsApp { get; set; }
        public string ClientVk { get; set; }
        public string ClientInstagram { get; set; }
        public string ClientTelegram { get; set; }
        public string ClientMail { get; set; }

        public decimal Sum { get; set; }
        public decimal Prepayment { get; set; }

        public DateTime Deadline { get; set; }

        public int Status { get; set; }
    }

    static class Orders
    {
        private static MySqlDataAdapter dataAdapter;
        private static DataTable dataTable;

        //public static OrderData orderData;
        public static OrderData orderData = new OrderData();

        public static DataTable LoadOrders(string dateFrom, string dateTo)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(Settings.Default.dbConnection))
                {
                    string mySqlExpression = "SELECT tbl_orders.id, date_of_create, services, sum, tbl_statuses.status, " +
                        "tbl_shops.shop, date_of_deadline, tbl_clients.name, comment, prepayment, ready_date, pin " +
                        "FROM tbl_orders " +
                        "INNER JOIN tbl_statuses ON id_status = tbl_statuses.id " +
                        "INNER JOIN tbl_shops ON id_shop = tbl_shops.id " +
                        "INNER JOIN tbl_clients ON id_client = tbl_clients.id " +
                        $"WHERE date_of_create >= '{ dateFrom }' AND date_of_create <= '{ dateTo }'";

                    dataAdapter = new MySqlDataAdapter(mySqlExpression, connection);
                    dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    return dataTable;
                }
            }
            catch { return dataTable; }
        }

        public static DataTable ReloadOrders()
        {
            try
            {
                dataTable.Clear();
                dataAdapter.Fill(dataTable);
                
                return dataTable;
            }
            catch { return dataTable; }
        }

        public static void DeleteOrder(int id)
        {
            using (MySqlConnection connection = new MySqlConnection(Settings.Default.dbConnection))
            {
                connection.Open();

                string mySqlExpression = $"DELETE FROM tbl_orders WHERE id = '{ id }'";
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

        public static int GetNewOrderID()
        {
            using (MySqlConnection connection = new MySqlConnection(Settings.Default.dbConnection))
            {
                connection.Open();

                string mySqlExpression = "SELECT COALESCE(MAX(id), 0) FROM tbl_orders";
                using (MySqlCommand command = new MySqlCommand(mySqlExpression, connection))
                {
                    return Convert.ToInt32(command.ExecuteScalar()) + 1;
                }
            }
        }

        public static void PinOrder(int id_order, int pin)
        {
            using (MySqlConnection connection = new MySqlConnection(Settings.Default.dbConnection))
            {
                connection.Open();

                string mySqlExpression = $"UPDATE tbl_orders SET pin = @pin WHERE id = '{ id_order }'";

                using (MySqlCommand command = new MySqlCommand(mySqlExpression, connection))
                {
                    command.Parameters.Add("@pin", MySqlDbType.Byte).Value = pin;
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void UpdateOrderStatus(int id_order, string status)
        {
            using (MySqlConnection connection = new MySqlConnection(Settings.Default.dbConnection))
            {
                connection.Open();

                string mySqlExpression = "UPDATE tbl_orders SET id_status = @id_status, ready_date = @ready_date " +
                        $"WHERE id = '{ id_order }'";

                using (MySqlCommand command = new MySqlCommand(mySqlExpression, connection))
                {
                    command.Parameters.Add("@id_status", MySqlDbType.Int32).Value = Statuses.GetStatusID(status);
                    command.Parameters.Add("@ready_date", MySqlDbType.Date).Value = status == "Готов" ? DateTime.Now.AddDays(2) : DateTime.MaxValue;
                    command.ExecuteNonQuery();
                }
            }
        }

        public static int LoadOrderData(int id_order)
        {
            using (MySqlConnection connection = new MySqlConnection(Settings.Default.dbConnection))
            {
                string mySqlExpression = "SELECT sum, id_status, date_of_deadline, id_client, prepayment " +
                $"FROM tbl_orders WHERE id = '{ id_order }'";

                using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(mySqlExpression, connection))
                {
                    DataTable dtOrder = new DataTable();
                    DataTable dtClient = new DataTable();
                    dataAdapter.Fill(dtOrder);

                    orderData = new OrderData();
                    orderData.Sum = (int)dtOrder.Rows[0][0];
                    orderData.Prepayment = (int)dtOrder.Rows[0][4];

                    orderData.Deadline = Convert.ToDateTime(dtOrder.Rows[0][2]);

                    orderData.Status = (int)dtOrder.Rows[0][1];

                    int id_client = Convert.ToInt32(dtOrder.Rows[0][3]);

                    dtClient = Clients.GetClientData(id_client);

                    orderData.ClientName = dtClient.Rows[0][0].ToString();
                    orderData.ClientPhone = dtClient.Rows[0][1].ToString();
                    orderData.ClientWhatsApp = (bool)dtClient.Rows[0][2];
                    orderData.ClientVk = dtClient.Rows[0][3].ToString();
                    orderData.ClientInstagram = dtClient.Rows[0][4].ToString();
                    orderData.ClientTelegram = dtClient.Rows[0][5].ToString();
                    orderData.ClientMail = dtClient.Rows[0][6].ToString();

                    return id_client;
                }
            }
        }

        public static void ServerDelete(string id_order)
        {
            DataRow[] result = dataTable.Select($"id = '{ id_order }'");
            if (result.Length > 0)
            {
                result[0].Delete();
                OrdersForm.ordersForm.myDataGridView1.DataSource = dataTable;
                OrdersForm.ordersForm.RowsState();
            }
        }

        public static void AddOrder(int id_order, decimal sum, int id_status, DateTime date_of_deadline, int id_client, decimal prepayment)
        {
            using (MySqlConnection connection = new MySqlConnection(Settings.Default.dbConnection))
            {
                string mySqlExpression = "INSERT INTO tbl_orders (id, date_of_create, sum, id_status, " +
                    "date_of_deadline, id_client, prepayment, ready_date, id_shop) " +
                    "VALUES (@id, @date_of_create, @sum, @id_status, @date_of_deadline, " +
                    "@id_client, @prepayment, @ready_date, @id_shop)";

                using (MySqlCommand command = new MySqlCommand(mySqlExpression, connection))
                {
                    connection.Open();

                    command.Parameters.Add("@id", MySqlDbType.Int32).Value = id_order;
                    command.Parameters.Add("@date_of_create", MySqlDbType.DateTime).Value = DateTime.Now;
                    command.Parameters.Add("@sum", MySqlDbType.Int32).Value = sum;
                    command.Parameters.Add("@id_status", MySqlDbType.Int32).Value = id_status;
                    command.Parameters.Add("@date_of_deadline", MySqlDbType.DateTime).Value = date_of_deadline;
                    command.Parameters.Add("@id_client", MySqlDbType.Int32).Value = id_client;
                    command.Parameters.Add("@prepayment", MySqlDbType.Int32).Value = prepayment;
                    command.Parameters.Add("@ready_date", MySqlDbType.Date).Value = DateTime.MaxValue;
                    command.Parameters.Add("@id_shop", MySqlDbType.Byte).Value = Settings.Default.defaultShop;

                    command.ExecuteNonQuery();
                }
            }
        }

        public static void UpdateOrderServicesAndComments(int id_order, string serviceList, string commentList)
        {
            using (MySqlConnection connection = new MySqlConnection(Settings.Default.dbConnection))
            {
                string mySqlExpression = "UPDATE tbl_orders SET services = @services, comment = @comment " +
                $"WHERE id = '{ id_order }'";

                using (MySqlCommand command = new MySqlCommand(mySqlExpression, connection))
                {
                    connection.Open();

                    command.Parameters.Add("@services", MySqlDbType.Text).Value = serviceList;
                    command.Parameters.Add("@comment", MySqlDbType.Text).Value = commentList;

                    command.ExecuteNonQuery();
                }
            }
        }

        public static void UpdateOrder(int id_order, int id_client, decimal sum, decimal prepayment, DateTime date_of_deadline, int id_status)
        {
            using (MySqlConnection connection = new MySqlConnection(Settings.Default.dbConnection))
            {
                string mySqlExpression = "UPDATE tbl_orders SET sum = @sum, id_status = @id_status, date_of_deadline = @date_of_deadline, " +
                    $"id_client = @id_client, prepayment = @prepayment, ready_date = @ready_date WHERE id = '{ id_order }'";

                using (MySqlCommand command = new MySqlCommand(mySqlExpression, connection))
                {
                    connection.Open();

                    command.Parameters.Add("@id_client", MySqlDbType.Int32).Value = id_client;
                    command.Parameters.Add("@sum", MySqlDbType.Int32).Value = sum;
                    command.Parameters.Add("@prepayment", MySqlDbType.Int32).Value = prepayment;
                    command.Parameters.Add("@date_of_deadline", MySqlDbType.DateTime).Value = date_of_deadline;
                    command.Parameters.Add("@id_status", MySqlDbType.Int32).Value = id_status;

                    command.Parameters.Add("@ready_date", MySqlDbType.Date).Value = id_status == 4 ? DateTime.Now.AddDays(2) : DateTime.MaxValue;

                    command.ExecuteNonQuery();
                }
            }
        }

        public static void UpdateOrderShop(int id_order, string shop)
        {
            using (MySqlConnection connection = new MySqlConnection(Settings.Default.dbConnection))
            {
                connection.Open();

                string mySqlExpression = "UPDATE tbl_orders SET id_shop = @id_shop " +
                        $"WHERE id = '{ id_order }'";

                using (MySqlCommand command = new MySqlCommand(mySqlExpression, connection))
                {
                    command.Parameters.Add("@id_shop", MySqlDbType.Byte).Value = Shops.GetShopID(shop);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static DataTable GetOrdersForExport(string dateFrom, string dateTo)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(Settings.Default.dbConnection))
                {
                    string mySqlExpression = "SELECT tbl_orders.id, tbl_orders.date_of_create, tbl_orders.services, " +
                        "tbl_orders.sum, tbl_employees.name_employee " +
                        "FROM tbl_orders " +
                        "LEFT JOIN (tbl_info " +
                        "INNER JOIN tbl_employees " +
                        "ON tbl_employees.id = tbl_info.id_employee) " +
                        "ON tbl_info.id_order = tbl_orders.id " +
                        $"WHERE date_of_create >= '{ dateFrom }' " +
                        $"AND date_of_create <= '{ dateTo }' " +
                        "GROUP BY tbl_info.id_order";

                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(mySqlExpression, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    return dataTable;
                }
            }
            catch { return null; }
        }

        public static DataTable GetLastStatusesForExport(string dateFrom, string dateTo)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(Settings.Default.dbConnection))
                {
                    string mySqlExpression = "SELECT tbl_orders.id, tbl_statuses.status " +
                        "FROM tbl_orders " +
                        "INNER JOIN tbl_statuses  " +
                        "ON tbl_statuses.id = tbl_orders.id_status " +
                        $"WHERE date_of_create >= '{ dateFrom }' " +
                        $"AND date_of_create <= '{ dateTo }'";

                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(mySqlExpression, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    return dataTable;
                }
            }
            catch { return null; }
        }
    }
}
