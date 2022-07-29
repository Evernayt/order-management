using MySql.Data.MySqlClient;
using Order_Management.Properties;
using System;
using System.Data;

namespace Order_Management.Database
{
    class User
    {
        public int id { get; set; }
        public string name { get; set; }
        public string login { get; set; }
        public string pass { get; set; }
        public byte permission { get; set; }
        public string avatar { get; set; }
        public string avatar_temp { get; set; }
    }

    static class Employees
    {
        public static User currentUser = new User();

        public static string GetPermission()
        {
            return currentUser.permission == 0 ? "Сотрудник" : "Администратор";
        }

        public static void UpdateAvatar(string url, string filename)
        {
            using (MySqlConnection connection = new MySqlConnection(Settings.Default.dbConnection))
            {
                connection.Open();

                string mySqlExpression = "UPDATE tbl_employees SET avatar = @avatar, avatar_temp = @avatar_temp " +
                    $"WHERE id = { currentUser.id }";

                using (MySqlCommand command = new MySqlCommand(mySqlExpression, connection))
                {
                    command.Parameters.Add("@avatar", MySqlDbType.Text).Value = url;
                    command.Parameters.Add("@avatar_temp", MySqlDbType.Text).Value = filename;
                    command.ExecuteNonQuery();
                }
            }

            currentUser.avatar = url;
            currentUser.avatar_temp = filename;
        }

        public static string UpdateName(string name, string login)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(Settings.Default.dbConnection))
                {
                    connection.Open();

                    string mySqlExpression = "UPDATE tbl_employees SET name_employee = @name_employee, login = @login " +
                        $"WHERE id = { currentUser.id }";

                    using (MySqlCommand command = new MySqlCommand(mySqlExpression, connection))
                    {
                        command.Parameters.Add("@name_employee", MySqlDbType.Text).Value = name;
                        command.Parameters.Add("@login", MySqlDbType.Text).Value = login;
                        command.ExecuteNonQuery();
                    }
                }

                currentUser.name = name;
                currentUser.login = login;

                return "Имя и пароль успешно изменены";
            }
            catch (MySqlException ex) when (ex.Number == 1062)
            {
                return "Имя или логин уже используются";
            }
        }

        public static string ChangePass(string pass)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(Settings.Default.dbConnection))
                {
                    connection.Open();

                    string mySqlExpression = "UPDATE tbl_employees SET pass = @pass " +
                        $"WHERE id = { currentUser.id }";

                    using (MySqlCommand command = new MySqlCommand(mySqlExpression, connection))
                    {
                        command.Parameters.Add("@pass", MySqlDbType.Text).Value = pass;
                        command.ExecuteNonQuery();
                    }
                }

                currentUser.pass = pass;

                return "Пароль успешно изменен";
            }
            catch
            {
                return "Не удалось изменить пароль";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="login"></param>
        /// <param name="pass"></param>
        /// <returns>1 - Авторизован, 2 - Неверный пароль, 0 - Ошибка</returns>
        public static (byte, Exception) Login(string login, string pass)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(Settings.Default.dbConnection))
                {
                    connection.Open();

                    string mySqlExpression = "SELECT * FROM tbl_employees WHERE login = @login AND pass = @pass AND archive = 0";
                    using (MySqlCommand command = new MySqlCommand(mySqlExpression, connection))
                    {
                        command.Parameters.Add("@login", MySqlDbType.VarChar).Value = login;
                        command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = pass;

                        using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter())
                        {
                            dataAdapter.SelectCommand = command;
                            using (DataTable dataTable = new DataTable())
                            {
                                dataAdapter.Fill(dataTable);

                                if (dataTable.Rows.Count > 0)
                                {
                                    currentUser.id = (Convert.ToInt32(dataTable.Rows[0][0]));
                                    currentUser.name = dataTable.Rows[0][1].ToString();
                                    currentUser.login = dataTable.Rows[0][2].ToString();
                                    currentUser.pass = dataTable.Rows[0][3].ToString();
                                    currentUser.permission = Convert.ToByte(dataTable.Rows[0][4]);
                                    currentUser.avatar = dataTable.Rows[0][5].ToString();
                                    currentUser.avatar_temp = dataTable.Rows[0][6].ToString();

                                    Settings.Default.lastAvatarTemp = dataTable.Rows[0][6].ToString();
                                    Settings.Default.LastLogin = login;
                                    Settings.Default.Save();

                                    return (1, null);
                                }
                                else
                                {
                                    return (2, null);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return (0, ex);
            }
        }
    }
}
