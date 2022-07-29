using GoogleDriveRestAPI_v3.Models;
using MySql.Data.MySqlClient;
using Order_Management.Properties;
using System;
using System.Data;
using System.Threading.Tasks;

namespace Order_Management.Database
{
    class Files
    {
        private static MySqlDataAdapter dataAdapter;

        public static DataTable LoadFiles(int id_service)
        {
            using (MySqlConnection connection = new MySqlConnection(Settings.Default.dbConnection))
            {
                string mySqlExpression = $"SELECT file_name, fileId FROM tbl_files WHERE id_service = '{ id_service }'";

                dataAdapter = new MySqlDataAdapter(mySqlExpression, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                return dataTable;
            }
        }

        public static void AddFile(string file_name, string fileId, int id_service)
        {
            using (MySqlConnection connection = new MySqlConnection(Settings.Default.dbConnection))
            {
                connection.Open();

                string mySqlExpression = "INSERT INTO tbl_files (file_name, fileId, id_service)" +
                "VALUES (@file_name, @fileId, @id_service)";

                using (MySqlCommand command = new MySqlCommand(mySqlExpression, connection))
                {
                    command.Parameters.Add("@file_name", MySqlDbType.Text).Value = file_name;
                    command.Parameters.Add("@fileId", MySqlDbType.Text).Value = fileId;
                    command.Parameters.Add("@id_service", MySqlDbType.Int32).Value = id_service;

                    command.ExecuteNonQuery();
                }
            }
        }

        public static void DeleteFileByFileID(string fileId)
        {
            using (MySqlConnection connection = new MySqlConnection(Settings.Default.dbConnection))
            {
                connection.Open();

                string mySqlExpression = $"DELETE FROM tbl_files WHERE fileId = '{ fileId }'";
                using (MySqlCommand command = new MySqlCommand(mySqlExpression, connection))
                    command.ExecuteNonQuery();
            }
        }

        public async static void DeleteFilesByServiceID(int serviceId)
        {
            await Task.Run(() =>
            {
                DataTable dtFiles = LoadFiles(serviceId);

                for (int i = 0; i < dtFiles.Rows.Count; i++)
                {
                    string fileId = dtFiles.Rows[i][1].ToString();

                    GoogleDriveFilesRepository.DeleteFile(fileId);
                    DeleteFileByFileID(fileId);
                }
            });
        }

        public async static void DeleteFilesByOrderID(int id_order)
        {
            await Task.Run(() =>
            {
                DataTable dtServices = Services.LoadServices(id_order);

                for (int i = 0; i < dtServices.Rows.Count; i++)
                {
                    int serviceId = Convert.ToInt32(dtServices.Rows[i][0]);
                    DataTable dtFiles = LoadFiles(serviceId);

                    for (int j = 0; j < dtFiles.Rows.Count; j++)
                    {
                        string fileId = dtFiles.Rows[j][1].ToString();

                        GoogleDriveFilesRepository.DeleteFile(fileId);
                        DeleteFileByFileID(fileId);
                    }
                }
            });
        }
    }
}
