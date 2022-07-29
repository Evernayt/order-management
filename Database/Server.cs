using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Order_Management.Database
{
    static class Server
    {
        static int remotePort; // Порт для отправки сообщений
        static IPAddress ipAddress; // IP адрес сервера
        static Socket listeningSocket; // Сокет
        static EndPoint remotePoint;

        public static void Start()
        {
            ipAddress = IPAddress.Parse("188.120.241.168"); //"192.168.1.68"
            remotePort = 8301;

            try
            {
                listeningSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp); // Создание сокета
                Task listeningTask = new Task(Listen); // Создание потока
                listeningTask.Start(); // Запуск потока
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void Connect(int id)
        {
            byte[] data = Encoding.Unicode.GetBytes("connect." + id);
            EndPoint remotePoint = new IPEndPoint(ipAddress, remotePort);
            listeningSocket.SendTo(data, remotePoint);
        }

        public static void Disconnect(int id)
        {
            byte[] data = Encoding.Unicode.GetBytes("disconnect." + id);

            remotePoint = new IPEndPoint(ipAddress, remotePort);
            listeningSocket.SendTo(data, remotePoint);
            Close();
        }

        // Поток для приема подключений
        private static void Listen()
        {
            try
            {
                IPEndPoint localIP = new IPEndPoint(IPAddress.Parse("0.0.0.0"), 0); // Прослушиваем по адресу
                listeningSocket.Bind(localIP);

                while (true)
                {
                    StringBuilder builder = new StringBuilder();
                    int bytes = 0;
                    byte[] data = new byte[256];

                    EndPoint remoteIp = new IPEndPoint(IPAddress.Any, 0);

                    do
                    {
                        try
                        {
                            bytes = listeningSocket.ReceiveFrom(data, ref remoteIp);
                            builder.Append(Encoding.Unicode.GetString(data, 0, bytes));
                        }
                        catch
                        {
                            Close();
                            Start();
                        }
                    }
                    while (listeningSocket.Available > 0);

                    IPEndPoint remoteFullIp = remoteIp as IPEndPoint;

                    OperatorCallBackAsync(builder.ToString());
                }
            }
            catch/* (Exception ex)*/
            {
                //MessageBox.Show(ex.Message);
            }
        }

        // закрытие сокета
        private static void Close()
        {
            if (listeningSocket != null)
            {
                listeningSocket.Shutdown(SocketShutdown.Both);
                listeningSocket.Close();
                listeningSocket = null;
            }
        }

        /// <summary>
        /// Отправляет на сервер данные, которые нужно обновить у других пользователей.
        /// </summary>
        /// <param name="id_table">ID таблицы.</param>
        /// <param name="id_row">ID строки.</param>
        /// <param name="id_operator">ID оператора (0 - INSERT, 1 - UPDATE, 2 - DELETE)</param>
        public static void SendUpdateData(byte id_table, int id_row, byte id_operator)
        {
            string message = $"{ id_table }.{ id_row }.{ id_operator }";
            byte[] data = Encoding.Unicode.GetBytes(message);

            remotePoint = new IPEndPoint(ipAddress, remotePort);
            listeningSocket.SendTo(data, remotePoint);
        }

        private static void OperatorCallBackAsync(string message)
        {
            string[] data = message.Split(new char[] { '.' });

            ///data[0] - id_table
            ///data[1] - id_row
            ///data[2] - id_operator

            /// id_table
            /// 0 - tbl_orders
            /// 1 - tbl_clients
            /// 2 - tbl_todo

            /// id_operator
            /// 0 - insert
            /// 1 - update
            /// 2 - delete

            if (data[0] == "0")
            {
                if (data[2] == "0")
                {
                    OrdersForm.ordersForm.ReloadData();
                }
                else if (data[2] == "1")
                {
                    OrdersForm.ordersForm.ReloadData();
                }
                else
                {
                    Orders.ServerDelete(data[1]);
                }
            }
            else if (data[0] == "1")
            {
                if (data[2] == "0")
                {
                    ClientsForm.clientsForm.ReloadData();
                }
                else if (data[2] == "1")
                {
                    ClientsForm.clientsForm.ReloadData();
                }
                else
                {
                    Clients.ServerDelete(data[1]);
                }
            }
            else
            {
                ToDoForm.toDoForm.ReloadData();
            }
        }
    }
}
