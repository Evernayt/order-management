using Google.Apis.Auth.OAuth2;
using Google.Apis.Download;
using Google.Apis.Drive.v3;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using Order_Management;
using Order_Management.Database;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace GoogleDriveRestAPI_v3.Models
{
    public class GoogleDriveFilesRepository 
    {
        public static string[] Scopes = { DriveService.Scope.Drive };
        Semaphore semaphore;

        public static DriveService GetService()
        {
            UserCredential credential;
            using (var stream = new FileStream("GoogleDrive\\client_secret.json", FileMode.Open, FileAccess.Read))
            {
                string filePath = "GoogleDrive\\DriveServiceCredentials.json";

                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.FromStream(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(filePath, true)).Result;
            }

            //Create Drive API service.
            DriveService service = new DriveService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = "OrderManagement",
            });

            return service;
        }

        public static List<GoogleDriveFiles> GetDriveFiles()
        {
            DriveService service = GetService();
            
            // Define parameters of request.
            FilesResource.ListRequest fileListRequest = service.Files.List();

            //listRequest.PageSize = 10;
            //listRequest.PageToken = 10;
            fileListRequest.Fields = "nextPageToken, files(id, name, size, version, trashed, createdTime)";

            // List files.
            IList<Google.Apis.Drive.v3.Data.File> files = fileListRequest.Execute().Files;
            List<GoogleDriveFiles> fileList = new List<GoogleDriveFiles>();

            if (files != null && files.Count > 0)
            {
                foreach (var file in files)
                {
                    GoogleDriveFiles googleDriveFiles = new GoogleDriveFiles {
                        Id = file.Id,
                        Name = file.Name,
                        Size = file.Size,
                        Version = file.Version,
                        CreatedTime = file.CreatedTime
                    };
                    fileList.Add(googleDriveFiles);
                }
            }
            return fileList;
        }

        public async Task FilesUpload(string[] files, int serviceId)
        {
            semaphore = new Semaphore(1, 1);

            foreach (string file in files)
            {
                if (file != null && file.Length > 0)
                {
                    semaphore.WaitOne();

                    string fileName = Path.GetFileName(file);
                    long totalSize = new FileInfo(file).Length;
                    long progress;

                    DriveService service = GetService();

                    var FileMetaData = new Google.Apis.Drive.v3.Data.File
                    {
                        Name = fileName,
                        MimeType = MimeMapping.GetMimeMapping(file)
                    };

                    FilesResource.CreateMediaUpload request;

                    using (var stream = new FileStream(file, FileMode.Open))
                    {
                        request = service.Files.Create(FileMetaData, stream, FileMetaData.MimeType);

                        request.ProgressChanged += (Google.Apis.Upload.IUploadProgress obj) =>
                        {
                            progress = (obj.BytesSent * 100 / totalSize);

                            if (NewOrderForm.newOrderForm.serviceId == serviceId)
                            {
                                NewOrderForm.newOrderForm.pbFile.Value = Convert.ToInt32(progress);
                            }
                        };

                        request.ResponseReceived += (Google.Apis.Drive.v3.Data.File obj) =>
                        {
                            if (obj != null)
                            {
                                Files.AddFile(fileName, obj.Id, serviceId);

                                if (NewOrderForm.newOrderForm.serviceId == serviceId)
                                {
                                    NewOrderForm.newOrderForm.pbFile.Value = 100;
                                    NewOrderForm.newOrderForm.LoadFilesData();
                                }
                            }
                        };
                        request.Fields = "id";
                        await request.ResumeAsync();

                        semaphore.Release();
                    }
                }
            }
        }

        public async Task DownloadGoogleFile(string fileId, int row, string downloadsFolder, int serviceId)
        {
            DriveService service = GetService();

            FilesResource.GetRequest request = service.Files.Get(fileId);
            request.Fields = "name, size";
            string fileName = "";
            try
            {
                fileName = request.Execute().Name;
            }
            catch
            {
                NewOrderForm.newOrderForm.Notification("Файл не найден");
                Files.DeleteFileByFileID(fileId);
                NewOrderForm.newOrderForm.LoadFilesData();
                return;
            }

            string filePath = Path.Combine(downloadsFolder.Trim(), fileName);
            
            if (File.Exists(filePath))
            {
                Process.Start(new ProcessStartInfo("explorer", " /select, " + '"' + filePath + '"'));
                return;
            }

            long? Size = request.Execute().Size;

            using (MemoryStream stream1 = new MemoryStream())
            {
                NewOrderForm.newOrderForm.dataGridView2.Rows[row].Cells["progress"].Value = "0%";

                request.MediaDownloader.ProgressChanged += (IDownloadProgress progress) =>
                {
                    switch (progress.Status)
                    {
                        case DownloadStatus.Downloading:
                            {
                                if (NewOrderForm.newOrderForm.dataGridView2.Rows.Count > 0 &&
                                NewOrderForm.newOrderForm.serviceId == serviceId)
                                    NewOrderForm.newOrderForm.dataGridView2.Rows[row].Cells["progress"].Value = 
                                    (progress.BytesDownloaded * 100 / Size).ToString() + "%";

                                break;
                            }
                        case DownloadStatus.Completed:
                            {
                                if (NewOrderForm.newOrderForm.dataGridView2.Rows.Count > 0 &&
                                NewOrderForm.newOrderForm.serviceId == serviceId)
                                {
                                    NewOrderForm.newOrderForm.dataGridView2.Rows[row].Cells["progress"].Value = "100%";
                                    NewOrderForm.newOrderForm.Notification("Файл загружен");
                                }

                                SaveStream(stream1, filePath);
                                break;
                            }
                        case DownloadStatus.Failed:
                            {
                                if (NewOrderForm.newOrderForm.dataGridView2.Rows.Count > 0 && 
                                NewOrderForm.newOrderForm.serviceId == serviceId)
                                {
                                    NewOrderForm.newOrderForm.dataGridView2.Rows[row].Cells["progress"].Value = "";
                                    NewOrderForm.newOrderForm.Notification("Не удалось загрузить файл");
                                }

                                break;
                            }
                    }
                };
                await request.DownloadAsync(stream1);
            }
        }

        private static void SaveStream(MemoryStream stream, string FilePath)
        {
            using (FileStream file = new FileStream(FilePath, FileMode.Create, FileAccess.ReadWrite))
            {
                stream.WriteTo(file);
            }
        }

        public static string GetFileName(string fileId)
        {
            DriveService service = GetService();
            FilesResource.GetRequest request = service.Files.Get(fileId);
            request.Fields = "name";
            return request.Execute().Name;
        }

        public static void DeleteFile(string fileId)
        {
            DriveService service = GetService();
            service.Files.Delete(fileId).Execute();
        }
    }
}