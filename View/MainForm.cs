using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Order_Management.Database;
using Order_Management.Properties;

namespace Order_Management
{
    public partial class MainForm : Form
    {
        public int formTop, formLeft;

        private string notification;
        private Form lastForm;

        public DataGridViewComboBoxColumn id_status;
        public static MainForm mainForm = null;

        private readonly AccountForm accountForm = new AccountForm();
        private readonly OrdersForm ordersForm = new OrdersForm();
        private readonly ClientsForm clientsForm = new ClientsForm();
        private readonly SettingsForm settingsForm = new SettingsForm();
        private readonly ToDoForm toDoForm = new ToDoForm();

        public MainForm()
        {
            WindowState = Settings.Default.chbxWindowsMax == FormWindowState.Maximized ? 
                FormWindowState.Maximized : FormWindowState.Normal;

            MaximumSize = Screen.PrimaryScreen.WorkingArea.Size;

            mainForm = this;
            InitializeComponent();

            btnSidebar.LostFocus += new EventHandler(btnSidebar_LostFocus);
        }

        private void btnSidebar_LostFocus(object sender, EventArgs e)
        {
            int x = Cursor.Position.X - Location.X;

            if (x > 290)
                btnSidebar.Checked = false;
            else
                btnSidebar.Focus();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            #region Avatar
            string avatar_temp = $"{ Path.GetTempPath() }om_avatars\\{ Employees.currentUser.avatar_temp }";

            if (!Directory.Exists($"{ Path.GetTempPath() }om_avatars"))
                Directory.CreateDirectory($"{ Path.GetTempPath() }om_avatars");

            if (File.Exists(avatar_temp))
            {
                pbxAvatar.Image = Image.FromFile(avatar_temp);
            }
            else if (Employees.currentUser.avatar == "")
            {
                //---------------------------//
            }
            else
            {
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
                pbxAvatar.Load(Employees.currentUser.avatar);
                pbxAvatar.Image.Save(avatar_temp);
            }
            #endregion

            #region Current User
            lblName.Text = Employees.currentUser.name;
            lblPermission.Text = Employees.GetPermission();
            #endregion

            #region Узнаем текущий месяц и записываем путь к папке с ним
            string currentMonth = "";
            int[] num = { 12, 11, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            int monthNum = 0;

            try
            {
                currentMonth = GetNistTime().ToString("MMMM");
                monthNum = GetNistTime().Month - 1;
            }
            catch
            {
                currentMonth = DateTime.Now.ToString("MMMM");
                monthNum = DateTime.Now.Month - 1;
            }
            finally
            {
                Settings.Default.CurrentFolder = $"{ Settings.Default.MainFolder }\\{ num[monthNum] }. { currentMonth.ToUpper() }";
                Settings.Default.Save();
            }
            #endregion

            #region Создаем папки с услугами
            string pathCurrentFolder = Settings.Default.CurrentFolder;

            if (!Directory.Exists(pathCurrentFolder))
            {
                Directory.CreateDirectory(pathCurrentFolder);           // Создаем папку месяца
                Directory.CreateDirectory(pathCurrentFolder + @"\1. ВРЕМЕННО (ПО МЕЛОЧИ)");
                Directory.CreateDirectory(pathCurrentFolder + @"\2. СОСТАВНЫЕ ЗАКАЗЫ");
            }

            var foldersList = Categories.LoadFolders().Rows.OfType<DataRow>().Select(dr => dr.Field<string>("folder_name")).ToList();
            foldersList.ForEach((es) =>
            {
                DirectoryInfo dirinfo = new DirectoryInfo(pathCurrentFolder + "\\" + es);
                if (!dirinfo.Exists)
                    dirinfo.Create();
            });
            #endregion

            btnOrders.PerformClick();

            #region Запускаем автообновление таблицы заказов
            AutoRefresher.Start();
            #endregion
        }

        /// <summary>
        /// Свернуть/развернуть форму при нажатии на значок в панели задач.
        /// </summary>
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style |= 0x20000;
                cp.ClassStyle |= 0x8;
                return cp;
            }
        }

        /// <summary>
        /// Получаем дату и время из сети.
        /// </summary>
        /// <returns></returns>
        public static DateTime GetNistTime()
        {
            var myHttpWebRequest = (HttpWebRequest)WebRequest.Create("http://www.google.com");
            var response = myHttpWebRequest.GetResponse();
            string todaysDates = response.Headers["date"];
            return DateTime.ParseExact(todaysDates,
                                       "ddd, dd MMM yyyy HH:mm:ss 'GMT'",
                                       CultureInfo.InvariantCulture.DateTimeFormat,
                                       DateTimeStyles.AssumeUniversal);
        }

        /// <summary>
        /// Показывает уведомление сверху формы.
        /// </summary>
        /// <param name="norifMessage">Сообщение которое нужно показать.</param>
        public void Notification(string notifMessage)
        {
            notification = notifMessage;
            btnNotification.Text = notifMessage;
            btnNotification.Checked = true;
            timerNotif.Start();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            string regexSearch = Regex.Replace(tbxSearch.Text, @"[['%*]", "  ");

            if (btnOrders.Checked)
                ordersForm.SearchController(regexSearch);
            else if (btnClients.Checked)
                clientsForm.SearchController(regexSearch);
            else if (btnToDo.Checked)
                toDoForm.SearchController(regexSearch);
        }

        private void timerNotif_Tick(object sender, EventArgs e)
        {
            btnNotification.Text = "";
            btnNotification.Checked = false;
            timerNotif.Stop();
        }

        private void btnNotification_CheckedChanged(object sender, EventArgs e)
        {
            if (btnNotification.Checked)
            {
                btnNotification.Text = notification;
                btnNotification.Location = new Point(695, 11);
                btnNotification.Size = new Size(345, 40);
            } 
            else
            {
                btnNotification.Text = "";
                btnNotification.Location = new Point(1008, 11);
                btnNotification.Size = new Size(32, 40);
            }

            timerNotif.Stop();
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            accountForm.Size = pMain.Size;
            ordersForm.Size = pMain.Size;
            clientsForm.Size = pMain.Size;
            settingsForm.Size = pMain.Size;
            toDoForm.Size = pMain.Size;
        }

        private void btnSidebar_CheckedChanged(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(btnSidebar.Checked))
            {
                pSidebar.Size = new Size(290, pSidebar.Height);
                vsepSidebar.Location = new Point(290, 1);
                pbxAvatar.Location = new Point(24, 85);
                btnOrders.Text = "Заказы";
                btnToDo.Text = "Задания";
                btnClients.Text = "Клиенты";
                btnSettings.Text = "Настройки";
                btnBugReport.Text = "Сообщить об ошибке";
            }
            else
            {
                pSidebar.Size = new Size(68, pSidebar.Height);
                vsepSidebar.Location = new Point(68, 1);
                pbxAvatar.Location = new Point(11, 85);
                btnOrders.Text = "";
                btnToDo.Text = "";
                btnClients.Text = "";
                btnSettings.Text = "";
                btnBugReport.Text = "";
            }
        }

        private void SidebarNavigation(Form form)
        {
            if (lastForm != form)
            {
                lastForm = form;
                form.TopLevel = false;
                pMain.Controls.Clear();
                pMain.Controls.Add(form);
                form.Show();
            }
        }

        private void pbxAvatar_Click(object sender, EventArgs e)
        {
            btnAvatar.PerformClick();
        }

        private void btnAvatar_Click(object sender, EventArgs e)
        {
            SidebarNavigation(accountForm);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            SidebarNavigation(ordersForm);
            ordersForm.RowsState();
            ordersForm.myDataGridView1.Select();
        }

        private void btnToDo_Click(object sender, EventArgs e)
        {
            SidebarNavigation(toDoForm);
            toDoForm.RowsState();
            toDoForm.myDataGridView1.Select();
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            SidebarNavigation(clientsForm);
        }

        private void pTop_Click(object sender, EventArgs e)
        {
            if (lastForm == ordersForm)
                ordersForm.myDataGridView1.Select();
            else if (lastForm == toDoForm)
                toDoForm.myDataGridView1.Select();
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == (Keys.Control | Keys.F))
                tbxSearch.Focus();
            else if (e.KeyData == (Keys.Control | Keys.N))
                ordersForm.btnNewOrder.PerformClick();
            else if (e.KeyCode == Keys.F5)
                btnRefresh.PerformClick();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            btnRefresh.Enabled = false;
            //timerRefresh.Start();

            if (btnOrders.Checked)
                ordersForm.ReloadData();
            else if (btnClients.Checked)
                clientsForm.ReloadData();
            else if (btnToDo.Checked)
                toDoForm.ReloadData();

            btnRefresh.Enabled = true;
        }

        private void timerRefresh_Tick(object sender, EventArgs e)
        {
            btnRefresh.Enabled = true;
            timerRefresh.Stop();
        }

        private void btnBugReport_Click(object sender, EventArgs e)
        {
            Process.Start("https://docs.google.com/spreadsheets/d/15bdtZD2GVu9CQYs6ztgj05ph55fIPxdaik4Hcd3S-NA/edit#gid=0");
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            SidebarNavigation(settingsForm);
            settingsForm.SettingsForm_Resize(null, null);
        }
    }
}
