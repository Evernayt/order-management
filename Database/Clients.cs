using MySql.Data.MySqlClient;
using Order_Management.Properties;
using System;
using System.Data;

namespace Order_Management.Database
{
    static class Clients
    {
        private static MySqlDataAdapter dataAdapter;
        private static DataTable dataTable;

        public static DataTable LoadClients()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(Settings.Default.dbConnection))
                {
                    string mySqlExpression = "SELECT * FROM tbl_clients WHERE id != 1";
                    dataAdapter = new MySqlDataAdapter(mySqlExpression, connection)
                    {
                        MissingSchemaAction = MissingSchemaAction.AddWithKey
                    };
                    dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    return dataTable;
                }
            }
            catch { return dataTable; }
        }

        public static DataTable ReloadClients()
        {
            try
            {
                dataAdapter.Fill(dataTable);
                return dataTable;
            }
            catch { return dataTable; }
        }

        public static string AddClient(string name, string phone, bool whatsapp, string vk, string instagram, string telegram, string mail)
        {
            using (MySqlConnection connection = new MySqlConnection(Settings.Default.dbConnection))
            {
                connection.Open();

                string mySqlExpression = "INSERT INTO tbl_clients (id, name, phone, whatsapp, vk, instagram, telegram, mail) " +
                "VALUES (@id, @name, @phone, @whatsapp, @vk, @instagram, @telegram, @mail)";

                using (MySqlCommand command = new MySqlCommand(mySqlExpression, connection))
                {
                    command.Parameters.Add("@id", MySqlDbType.Int32).Value = GetClientMaxID() + 1;
                    command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
                    command.Parameters.Add("@phone", MySqlDbType.Decimal).Value = phone;

                    command.Parameters.Add("@whatsapp", MySqlDbType.Byte).Value = whatsapp ? 1 : 0;

                    command.Parameters.Add("@vk", MySqlDbType.Text).Value = vk.Replace("https://", "").Replace("http://", ""); ;
                    command.Parameters.Add("@instagram", MySqlDbType.Text).Value = instagram.Replace("https://", "").Replace("http://", ""); ;
                    command.Parameters.Add("@telegram", MySqlDbType.Text).Value = telegram.Replace("https://", "").Replace("http://", ""); ;
                    command.Parameters.Add("@mail", MySqlDbType.Text).Value = mail;

                    try
                    {
                        command.ExecuteNonQuery();
                        return "Клиент добавлен";
                    }
                    catch (MySqlException ex) when (ex.Number == 1062)
                    {
                        return "Указанный номер телефона уже есть в базе данных";
                    }
                }
            }
        }

        public static string EditClient(int id_client, string name, string phone, bool whatsapp, string vk, string instagram, string telegram, string mail)
        {
            using (MySqlConnection connection = new MySqlConnection(Settings.Default.dbConnection))
            {
                connection.Open();

                string mySqlExpression = "UPDATE tbl_clients " +
                    "SET name = @name, phone = @phone, whatsapp = @whatsapp, vk = @vk, instagram = @instagram, telegram = @telegram, mail = @mail " +
                    $"WHERE id = '{ id_client }'";

                using (MySqlCommand command = new MySqlCommand(mySqlExpression, connection))
                {
                    DataRow[] rows = dataTable.Select($"id = '{ id_client }'");

                    command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name == "" ? rows[0][1] : name;
                    command.Parameters.Add("@phone", MySqlDbType.Decimal).Value = phone == "" ? rows[0][2] : phone;
                    command.Parameters.Add("@whatsapp", MySqlDbType.Byte).Value = whatsapp ? 1 : 0;
                    command.Parameters.Add("@vk", MySqlDbType.Text).Value = vk == "" ? rows[0][4] : vk;
                    command.Parameters.Add("@instagram", MySqlDbType.Text).Value = instagram == "" ? rows[0][5] : instagram;
                    command.Parameters.Add("@telegram", MySqlDbType.Text).Value = telegram == "" ? rows[0][6] : telegram;
                    command.Parameters.Add("@mail", MySqlDbType.Text).Value = mail == "" ? rows[0][7] : mail;

                    try
                    {
                        command.ExecuteNonQuery();
                        return "Клиент изменен";
                    }
                    catch (MySqlException ex) when (ex.Number == 1062)
                    {
                        return "Указанный номер телефона уже есть в базе данных";
                    }
                }
            }
        }

        public static string DeleteClient(int id)
        {
            using (MySqlConnection connection = new MySqlConnection(Settings.Default.dbConnection))
            {
                connection.Open();

                string mySqlExpression = $"DELETE FROM tbl_clients WHERE id = '{ id }'";

                using (MySqlCommand command = new MySqlCommand(mySqlExpression, connection))
                {
                    try
                    {
                        DataRow[] result = dataTable.Select($"id = '{ id }'");

                        command.ExecuteNonQuery();

                        if (result.Length > 0)
                            result[0].Delete();

                        return "Клиент удален";
                    }
                    catch (MySqlException ex) when (ex.Number == 1451)
                    {
                        return "1451";
                    }
                }
            }
        }

        public static string ClientArchive(int id, byte archive)
        {
            using (MySqlConnection connection = new MySqlConnection(Settings.Default.dbConnection))
            {
                connection.Open();

                string mySqlExpression = "UPDATE tbl_clients " +
                    "SET archive = @archive " +
                    $"WHERE id = '{ id }'";

                using (MySqlCommand command = new MySqlCommand(mySqlExpression, connection))
                {
                    command.Parameters.Add("@archive", MySqlDbType.Byte).Value = archive;

                    try
                    {
                        command.ExecuteNonQuery();
                        return archive == 1 ? "Клиент добавлен в архив" : "Клиент восстановлен из архива";
                    }
                    catch
                    {
                        return archive == 1 ? "Не удалось добавить клиента в архив" : "Не удалось восстановить клиента из архива";
                    }
                }
            }
        }

        public static DataTable GetClientData(int id_client)
        {
            using (MySqlConnection connection = new MySqlConnection(Settings.Default.dbConnection))
            {
                string mySqlExpression = "SELECT name, phone, whatsapp, vk, instagram, telegram, mail " +
               $"FROM tbl_clients WHERE id = '{ id_client }'";

                using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(mySqlExpression, connection))
                {
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    return dataTable;
                }
            }
        }

        public static void ServerDelete(string id_client)
        {
            DataRow[] result = dataTable.Select($"id = '{ id_client }'");
            if (result.Length > 0)
            {
                result[0].Delete();
                ClientsForm.clientsForm.dataGridView1.DataSource = dataTable;
                ClientsForm.clientsForm.RowColor();
            }
        }

        public static DataTable GetClientDataByPhone(string phone)
        {
            using (MySqlConnection connection = new MySqlConnection(Settings.Default.dbConnection))
            {
                string mySqlExpression = "SELECT id, name, whatsapp, vk, instagram, telegram, mail FROM tbl_clients " +
                    $"WHERE phone = '{ phone }' AND archive = 0";

                using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(mySqlExpression, connection))
                {
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    return dataTable;
                }
            }
        }

        public static int GetClientMaxID()
        {
            using (MySqlConnection connection = new MySqlConnection(Settings.Default.dbConnection))
            {
                connection.Open();

                string mySqlExpression = "SELECT COALESCE(MAX(id), 0) FROM tbl_clients";
                using (MySqlCommand command = new MySqlCommand(mySqlExpression, connection))
                {
                    return Convert.ToInt32(command.ExecuteScalar());
                }
            }
        }
    }
}
