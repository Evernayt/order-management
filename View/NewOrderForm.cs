using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Order_Management.Properties;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using Order_Management.Database;
using GoogleDriveRestAPI_v3.Models;
using System.Text;
using System.Threading.Tasks;

namespace Order_Management
{
    public partial class NewOrderForm : Form
    {
        public int id_order;
        public string serviceList, commentList, notification;
        public DateTime deadlineMin = DateTime.Now;
        public int serviceId;

        private DateTime deadlineMax;
        private int id_client = 1;
        private decimal balance;
        private bool newClient = false;
        private string[] services;
        private int socialCurrent, lbServiceY, lbServiceYMin, lbServiceYMax;

        private readonly Colors color = new Colors();
        private readonly List<(Control, Label)> controls = new List<(Control, Label)>();
        private readonly List<(LinkLabel, byte)> social = new List<(LinkLabel, byte)>();
        private readonly List<string> socialUrl = new List<string>();

        // синглтон
        public static NewOrderForm newOrderForm = null;

        public NewOrderForm()
        {
            MaximumSize = Screen.PrimaryScreen.WorkingArea.Size;

            newOrderForm = this;
            InitializeComponent();

            lbServiceYMin = lbService.Location.Y;

            #region Отступ для столбцов dataGridView1 и dataGridView2
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Columns["Quantity"].HeaderCell.Style.Padding = new Padding(5, 0, 0, 0);
            dataGridView1.Columns["Comment"].HeaderCell.Style.Padding = new Padding(5, 0, 0, 0);
            dataGridView2.Columns["file_name"].HeaderCell.Style.Padding = new Padding(30, 0, 0, 0);
            #endregion

            WindowPosition();
            LoadStatuses();

            for (int i = 0; i < 4; i++)
                socialUrl.Add("");

            linkVk.TabStop = false;
            linkInstagram.TabStop = false;
            linkTelegram.TabStop = false;
            linkMail.TabStop = false;

            calendar.MinDate = DateTime.Now;

            btnDate.LostFocus += new EventHandler(btnDate_LostFocus);
            pFiles.LostFocus += new EventHandler(pFiles_LostFocus);
        }

        private void WindowPosition()
        {
            if (MainForm.mainForm.WindowState == FormWindowState.Normal)
                Location = new Point(MainForm.mainForm.Location.X + 30, MainForm.mainForm.Location.Y + 30);
            else
                StartPosition = FormStartPosition.CenterScreen;
        }

        private void LoadStatuses()
        {
            cbxStatus.DataSource = Statuses.LoadStatuses();
            cbxStatus.DisplayMember = "status";
            cbxStatus.ValueMember = "id";
        }

        private void btnDate_LostFocus(object sender, EventArgs e)
        {
            var xy = PointToClient(Cursor.Position);

            if (xy.X <= 50 || xy.Y <= 530 || xy.X >= 235 || xy.Y >= 725)
                btnDate.Checked = false;
            else
                btnDate.Focus();
        }

        private void NewOrderForm_Load(object sender, EventArgs e)
        {
            #region Связываем текстовые окна с заголовками
            controls.Add((tbxClientName, lblNameTitle));
            controls.Add((cbxStatus, lblStatusTitle));
            controls.Add((tbxServiceSearch, lblServiceSearchTitle));
            controls.Add((tbxComment, lblCommentTitle));

            foreach (var control in controls)
            {
                control.Item1.Enter += (s, a) =>
                {
                    control.Item2.ForeColor = color.AccentBlue;
                };

                control.Item1.Leave += (s, a) =>
                {
                    control.Item2.ForeColor = color.BorderBlack;
                };
            }
            #endregion

            SocialNetworkLogics();
            GetBalance();
            services = AllServices.LoadAllServices().Rows.OfType<DataRow>().Select(dr => dr.Field<string>("service")).ToArray();

            RowsState();
        }

        private void SocialNetworkLogics()
        {
            social.Add((linkVk, 0));
            social.Add((linkInstagram, 1));
            social.Add((linkTelegram, 2));
            social.Add((linkMail, 3));

            foreach (var link in social)
            {
                link.Item1.Click += (s, a) =>
                {
                    if (link.Item1.LinkBehavior != LinkBehavior.NeverUnderline)
                    {
                        foreach (var link2 in social)
                        {
                            link2.Item1.LinkBehavior = LinkBehavior.SystemDefault;
                            link2.Item1.LinkColor = socialUrl[link2.Item2].Length == 0 ? color.IconGray : color.BorderBlack;
                        }

                        link.Item1.LinkBehavior = LinkBehavior.NeverUnderline;

                        socialCurrent = link.Item2;
                        tbxSocialNetwork.Text = socialUrl[link.Item2];
                    }

                    tbxSocialNetwork.SelectionStart = tbxSocialNetwork.Text.Length;
                    tbxSocialNetwork.Focus();
                };
            }

            linkVk.LinkBehavior = LinkBehavior.NeverUnderline;
            tbxSocialNetwork.Text = socialUrl[0];

            foreach (var link2 in social)
            {
                link2.Item1.LinkColor = socialUrl[link2.Item2].Length == 0 ? color.IconGray : color.BorderBlack;
            }
        }

        private void LoadData()
        {
            dataGridView1.DataSource = Services.LoadServices(id_order);
        }

        public void RowsState()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Folder"].Value.ToString() == "")
                    row.Cells["folderPic"].Value = Resources.folderAddIconOn;
                else
                    row.Cells["folderPic"].Value = Resources.folderIconOn;
                
                //if (row.Cells["fileId"].Value.ToString() == "")
                //    row.Cells["filePic"].Value = Resources.fileUploadIconOn;
                //else
                //    row.Cells["filePic"].Value = Resources.fileOpenIconOn;
            }
        }

        /// <summary>
        /// Перезагружает услуги с БД.
        /// </summary>
        /// <param name="row">Индекс строки для выделения.</param>
        public void ReloadData()
        {
            dataGridView1.DataSource = Services.ReloadServices();

            //if (dataGridView1.Rows.Count != 0)
            //{
            //    dataGridView1.FirstDisplayedScrollingRowIndex = row;
            //    dataGridView1.Rows[row].Selected = true;
            //}

            //RowsState();
        }

        /// <summary>
        /// Загружает информацию о заказе при нажатии на строку со страницы Заказов.
        /// </summary>
        public void LoadOrderData()
        {
            calendar.MinDate = deadlineMin;

            LoadData();

            id_client = Orders.LoadOrderData(id_order);

            mtbxClientPhone.Text = Orders.orderData.ClientPhone.ToString();
            btnWhatsApp.Checked = Orders.orderData.ClientWhatsApp;
            tbxClientName.Text = Orders.orderData.ClientName;
            socialUrl[0] = Orders.orderData.ClientVk;
            socialUrl[1] = Orders.orderData.ClientInstagram;
            socialUrl[2] = Orders.orderData.ClientTelegram;
            socialUrl[3] = Orders.orderData.ClientMail;

            nudSum.Value = Orders.orderData.Sum;
            nudPrepayment.Value = Orders.orderData.Prepayment;

            deadlineMax = Convert.ToDateTime(Orders.orderData.Deadline);
            calendar.SelectionStart = deadlineMax;
            nudHours.Value = deadlineMax.Hour;
            nudMinutes.Value = deadlineMax.Minute;

            cbxStatus.SelectedValue = Orders.orderData.Status;

            chbxPaid.Checked = nudPrepayment.Value == nudSum.Value;
        }

        /// <summary>
        /// Возвращает номер телефона без маски.
        /// </summary>
        /// <returns></returns>
        private string GetPhoneNonMask()
        {
            mtbxClientPhone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            string phoneNonMask = mtbxClientPhone.Text;
            mtbxClientPhone.TextMaskFormat = MaskFormat.IncludeLiterals;
            return phoneNonMask;
        }

        /// <summary>
        /// Возвращает дату и время приведенный в формат БД.
        /// </summary>
        /// <returns></returns>
        private DateTime OrderDateTime()
        {
            return Convert.ToDateTime(calendar.SelectionStart.ToString("yyyy-MM-dd") + " " + nudHours.Value + ":" + nudMinutes.Value);
        }

        /// <summary>
        /// Получает список услуг и комментариев для отображения в таблице "Заказы"
        /// </summary>
        private void ServiceAndCommentList()
        {
            serviceList = string.Join(", ", Services.LoadServices(id_order).Rows.OfType<DataRow>().Select(dr => dr.Field<string>("service")).ToList());
            commentList = string.Join(", ", Services.LoadServicesComments(id_order).Rows.OfType<DataRow>().Select(dr => dr.Field<string>("comment")).ToList());
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

        /// <summary>
        /// Задает значения по умолчанию при создании нового заказа.
        /// </summary>
        public void NewOrderStartValues()
        {
            nudHours.Value = Convert.ToInt32(DateTime.Now.ToString("HH"));
            nudMinutes.Value = Convert.ToInt32(DateTime.Now.ToString("mm"));
            deadlineMax = DateTime.Now;
            calendar.SelectionStart = DateTime.Now.AddDays(1);
            cbxStatus.Visible = false;
            lblStatusTitle.Visible = false;
        }

        /// <summary>
        /// Обновляет заказ после добавления одной услуги.
        /// </summary>
        private void UpdateOrder()
        {
            ServiceAndCommentList();
            Orders.UpdateOrderServicesAndComments(id_order, serviceList, commentList);
            AutoRefresher.UpdateDate();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Узнать индекс колонки и строки
            //MessageBox.Show("Индекс колонки: " + e.ColumnIndex.ToString() + "\nИндекс строки: " + e.RowIndex.ToString());
            
            // Папка
            if (e.ColumnIndex == 0 && e.RowIndex != -1)
            {
                if (dataGridView1.Rows[e.RowIndex].Cells["Folder"].Value.ToString() != "")
                {
                    string serviceFolder = dataGridView1.Rows[e.RowIndex].Cells["Folder"].Value.ToString();

                    if (!Directory.Exists(serviceFolder))
                    {
                        DialogResult dr = MessageBox.Show("Данная папка больше не существует!\nНажмите ОК, чтобы открыть текущую директорию.",
                            Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

                        if (dr == DialogResult.OK)
                            Process.Start(Settings.Default.CurrentFolder);
                    }
                    else
                        Process.Start(new ProcessStartInfo("explorer", '"' + serviceFolder + '"'));
                }
                else
                {
                    string service = dataGridView1.Rows[e.RowIndex].Cells["Service"].Value.ToString();
                    CreateServiceFolder(service);
                }
            }
            // Файлы
            else if (e.ColumnIndex == 1)
            {
                pbFile.Value = 0;

                serviceId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id"].Value);
                LoadFilesData();

                pFiles.Size = new Size(465, pFiles.Height);
                pFiles.Focus();
            }
            // Удалить
            else if (e.ColumnIndex == 2)
            {
                DialogResult dr = MessageBox.Show("Вы действительно хотите удалить эту услугу?",
                    Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (dr == DialogResult.Yes)
                {
                    int serviceId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id"].Value);

                    Services.DeleteServiceByID(serviceId);
                    Files.DeleteFilesByServiceID(serviceId);

                    ReloadData();
                    RowsState();
                    UpdateOrder();
                }
            }
        }

        public void LoadFilesData()
        {
            dataGridView2.DataSource = Files.LoadFiles(serviceId);
        }

        /// <summary>
        /// Получает остаток от суммы заказа.
        /// </summary>
        private void GetBalance()
        {
            balance = nudSum.Value - nudPrepayment.Value;
            lblBalance.Text = $"Остаток: { balance }";
            chbxPaid.Checked = nudPrepayment.Value == nudSum.Value && nudSum.Value != 0;
        }

        private void nudPrepayment_ValueChanged(object sender, EventArgs e)
        {
            GetBalance();
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int quantity = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Quantity"].Value);
            string comment = dataGridView1.Rows[e.RowIndex].Cells["Comment"].Value.ToString();
            int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id"].Value);
            Services.UpdateService(id, quantity, comment);

            // Индекс столбца "Количество"
            if (e.ColumnIndex != 5)
                UpdateOrder();
        }

        private void dataGridView1_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex == 5 || e.RowIndex != -1 && e.ColumnIndex == 6)
            {
                dataGridView1.ClearSelection();
                dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.FromArgb(242, 249, 255);
            }
        }

        private void dataGridView1_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex == 5 || e.RowIndex != -1 && e.ColumnIndex == 6)
            {
                dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Empty;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex == 6)
            {
                int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id"].Value);
                int quantity = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Quantity"].Value);
                string comment = dataGridView1.Rows[e.RowIndex].Cells["Comment"].Value.ToString();

                using (SecondaryForm secondaryForm = new SecondaryForm())
                {
                    secondaryForm.lblTitle.Text = "Комментарий";
                    secondaryForm.tbxArea.Text = comment;
                    secondaryForm.isComment = true;
                    secondaryForm.id = id;
                    secondaryForm.quantity = quantity;
                    secondaryForm.ShowDialog();
                }

                btnRefresh.PerformClick();
                UpdateOrder();
            }
            else if (e.RowIndex != -1 && e.ColumnIndex != 6)
            {
                dataGridView1.BeginEdit(true);
            }

        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void nudSum_ValueChanged(object sender, EventArgs e)
        {
            GetBalance();
        }

        private void CreateServiceFolder(string service)
        {
            string folderName = AllServices.GetServiceFolder(service);

            string servicePath = Settings.Default.CurrentFolder + "\\" + folderName; // Папка категории услуги - ...\ФОТОЛЮКС_Текущее\ЯНВАРЬ\2. ПЕЧАТЬ ФОТО;

            if (dataGridView1.Rows.Count > 1)
            {
                string clientName = tbxClientName.Text != "" ? $"({ tbxClientName.Text })" : "";
                servicePath = $"{ Settings.Default.CurrentFolder }\\2. СОСТАВНЫЕ ЗАКАЗЫ\\Заказ № { id_order } { clientName }".Trim();
                if (!Directory.Exists(servicePath))
                    Directory.CreateDirectory(servicePath);

                if (!Directory.Exists(servicePath))
                    Directory.CreateDirectory(servicePath);
            }

            int folderNum = Directory.GetDirectories(servicePath).Length + 1; // Номер папки
            string serviceName = string.Join("_", service.Split(Path.GetInvalidFileNameChars()));
            string serviceFolderName = $"{ folderNum }. { serviceName } "; // Название папки - 1.Фотопечать 10х15 глянец

            string path = $"{ servicePath }\\{ serviceFolderName }"; // Путь до услуги - ...\ФОТОЛЮКС_Текущее\ЯНВАРЬ\2. ПЕЧАТЬ ФОТО\1.Фотопечать 10х15 глянец
            string fullPath = tbxClientName.Text != "" ? $"{ path }({ tbxClientName.Text })" : path; // Полный путь с именем клиента

            Directory.CreateDirectory(fullPath);

            int id_serviceInAll = AllServices.GetServiceID(service);
            int id_service = Services.GetServiceID(id_serviceInAll, id_order);
            Services.AddServiceFolder(id_service, fullPath);

            ReloadData();
            RowsState();
        }

        private void btnCreateAllFolder_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Folder"].Value.ToString() == "")
                {
                    string service = row.Cells["Service"].Value.ToString();
                    CreateServiceFolder(service);
                }
            }

            RowsState();
        }

        /// <summary>
        /// Добавляет услугу.
        /// </summary>
        private void AddService(int id_serviceInAll)
        {
            Services.AddService(id_serviceInAll, nudQuantity.Value, tbxComment.Text, id_order);

            nudQuantity.Value = 1;
            tbxComment.Text = null;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string service = tbxServiceSearch.Text.Trim(' ');
            int id_service = AllServices.GetServiceID(service);

            // Есть ли услуга в БД
            if (id_service > 0)
            {
                // Услуга уже добавлена
                if (lblOrderID.Text != "Новый заказ")
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (row.Cells["Service"].Value.ToString() == service)
                        {
                            Notification("Услуга уже существует");
                            return;
                        }
                    }

                    AddService(id_service);
                    ReloadData();
                    UpdateOrder();
                }
                // Услуги не добавлены
                else
                {
                    id_order = Orders.GetNewOrderID();
                    lblOrderID.Text = $"Заказ № {id_order}";

                    Orders.AddOrder(id_order, nudSum.Value, Convert.ToInt32(cbxStatus.SelectedValue),
                        OrderDateTime(), id_client, nudPrepayment.Value);

                    Info.AddInfo(id_order, cbxStatus.Text, null);

                    Notification($"Заказ № {id_order} создан");
                    AddService(id_service);
                    LoadData();
                    UpdateOrder();
                }

                tbxServiceSearch.Text = "";
                SaveOrderData();
                RowsState();

                AutoRefresher.UpdateDate();
            }
            else
            {
                Notification("Услуга не найдена");
            }
        }

        public void ServiceSelected()
        {
            lbService.Items.Clear();
            tbxServiceSearch.Focus();
            tbxServiceSearch.SelectionStart = tbxServiceSearch.Text.Length;
            lbService.Visible = false;
        }

        private void lbService_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbService.SelectedItem != null)
            {
                tbxServiceSearch.Text = lbService.SelectedItem.ToString();
                ServiceSelected();
            }
        }

        private void tbxServiceSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxServiceSearch.Text))
            {
                lbService.Items.Clear();
                lbService.Visible = false;
                return;
            }

            lbService.Visible = true;
            string[] result = { };
            string[] keywords = new Regex("\\s+").Replace(tbxServiceSearch.Text.ToLower(), " ").Trim().Split(' ');

            result = services;
            foreach (string keyword in keywords)
            {
                result = (from i in result
                          where i.ToLower().Contains(keyword)
                          select i).ToArray();
            }

            lbService.Items.Clear();

            lbService.Items.AddRange(result);

            int itemsCount = lbService.Items.Count < 9 ? lbService.Items.Count : 9;
            lbService.Location = new Point(20, lbServiceY - (itemsCount * 17));
            lbService.Size = new Size(lbService.Size.Width, 21 + (itemsCount * 17));
        }

        private void tbxServiceSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && lbService.Items.Count != 0)
            {
                tbxServiceSearch.Text = lbService.Items[0].ToString();
                ServiceSelected();
            }
        }

        private void btnAllServices_Click(object sender, EventArgs e)
        {
            using (ServicesTreeForm servicesTreeForm = new ServicesTreeForm())
                servicesTreeForm.ShowDialog();

            tbxServiceSearch.Select();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            dataGridView1.EndEdit();
        }

        private void nudQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                btnAdd.PerformClick();
        }

        private void tbxComment_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                btnAdd.PerformClick();
        }

        private void chbxPaid_CheckedChanged(object sender, EventArgs e)
        {
            if (nudSum.Value > 0)
            {
                nudPrepayment.Value = chbxPaid.Checked ? nudSum.Value : nudPrepayment.Value;
            }
            else
            {
                chbxPaid.Checked = false;
                Notification("Сумма заказа не указана");
            }
        }

        #region Service Info Leave and Enter

        /// <summary>
        /// После нажатия на поле ввода телефона, перемещает курсор после скобки.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mtbxClientPhone_Enter(object sender, EventArgs e)
        {
            string clipboard = Clipboard.GetText();
            string result = Regex.Replace(clipboard, @"[^\d]", "");
            Clipboard.Clear();

            if (result != "")
                Clipboard.SetText(result);

            int maskLength = mtbxClientPhone.MaskCompleted ? 17 : 0;
            BeginInvoke((MethodInvoker)delegate () { mtbxClientPhone.Select(maskLength, 0); });

            lblPhoneTitle.ForeColor = color.AccentBlue;
            mtbxClientPhone.ForeColor = color.Black;
            sepPhone.FillThickness = 2;
            sepPhone.FillColor = color.BorderBlack;
        }

        private void mtbxClientPhone_Leave(object sender, EventArgs e)
        {
            lblPhoneTitle.ForeColor = color.BorderBlack;
            mtbxClientPhone.ForeColor = color.TableBlack;
            sepPhone.FillThickness = 1;
            sepPhone.FillColor = color.BorderGray;

            string phone = GetPhoneNonMask();

            if (mtbxClientPhone.MaskCompleted)
            {
                DataTable dataTable = Clients.GetClientDataByPhone(phone);

                if (dataTable.Rows.Count > 0)
                {
                    id_client = Convert.ToInt32(dataTable.Rows[0][0]);
                    tbxClientName.Text = dataTable.Rows[0][1].ToString();
                    btnWhatsApp.Checked = (bool)dataTable.Rows[0][2];
                    socialUrl[0] = dataTable.Rows[0][3].ToString();
                    socialUrl[1] = dataTable.Rows[0][4].ToString();
                    socialUrl[2] = dataTable.Rows[0][5].ToString();
                    socialUrl[3] = dataTable.Rows[0][6].ToString();

                    tbxSocialNetwork.Text = socialUrl[socialCurrent];

                    newClient = false;
                }
                else
                {
                    tbxClientName.Text = "";
                    btnWhatsApp.Checked = false;
                    socialUrl[0] = "";
                    socialUrl[1] = "";
                    socialUrl[2] = "";
                    socialUrl[3] = "";

                    tbxSocialNetwork.Text = "";

                    newClient = true;
                }
            }
            else if (mtbxClientPhone.Text == "  (   )    -  -")
            {
                id_client = 1;
                tbxClientName.Text = "";
                btnWhatsApp.Checked = false;
                socialUrl[0] = "";
                socialUrl[1] = "";
                socialUrl[2] = "";
                socialUrl[3] = "";

                tbxSocialNetwork.Text = "";
            }
        }

        private void nudSum_Enter(object sender, EventArgs e)
        {
            lblSumTitle.ForeColor = color.AccentBlue;
            sepSum.FillThickness = 2;
            sepSum.FillColor = color.BorderBlack;
        }

        private void nudSum_Leave(object sender, EventArgs e)
        {
            lblSumTitle.ForeColor = color.BorderBlack;
            sepSum.FillThickness = 1;
            sepSum.FillColor = color.BorderGray;
        }

        private void nudPrepayment_Enter(object sender, EventArgs e)
        {
            lblPrepaymentTitle.ForeColor = color.AccentBlue;
            sepPrepayment.FillThickness = 2;
            sepPrepayment.FillColor = color.BorderBlack;
        }

        private void nudPrepayment_Leave(object sender, EventArgs e)
        {
            lblPrepaymentTitle.ForeColor = color.BorderBlack;
            sepPrepayment.FillThickness = 1;
            sepPrepayment.FillColor = color.BorderGray;
        }

        private void btnDate_CheckedChanged(object sender, EventArgs e)
        {
            if (btnDate.Checked)
            {
                lblDateTitle.ForeColor = color.AccentBlue;
                sepDate.FillThickness = 2;
                sepDate.FillColor = color.BorderBlack;
                calendar.Visible = true;
            }
            else
            {
                lblDateTitle.ForeColor = color.BorderBlack;
                sepDate.FillThickness = 1;
                sepDate.FillColor = color.BorderGray;
                calendar.Visible = false;
            }
        }

        #endregion

        #region Service Table Leave and Enter

        private void nudQuantity_Enter(object sender, EventArgs e)
        {
            lblQuantityTitle.ForeColor = color.AccentBlue;
            sepQuantity.FillThickness = 2;
            sepQuantity.FillColor = color.BorderBlack;
        }

        private void nudQuantity_Leave(object sender, EventArgs e)
        {
            lblQuantityTitle.ForeColor = color.BorderBlack;
            sepQuantity.FillThickness = 1;
            sepQuantity.FillColor = color.BorderGray;
        }

        #endregion

        private void btnNotification_CheckedChanged(object sender, EventArgs e)
        {
            if (btnNotification.Checked)
            {
                btnNotification.Text = notification;
                btnNotification.Location = new Point(763, 11);
                btnNotification.Size = new Size(345, 40);
            }
            else
            {
                btnNotification.Text = "";
                btnNotification.Location = new Point(1076, 11);
                btnNotification.Size = new Size(32, 40);
            }

            timerNotif.Stop();
        }

        private void calendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            btnDate.Text = calendar.SelectionStart.ToString("d");

            if (calendar.SelectionStart.Date <= deadlineMin.Date)
            {
                nudHours.Minimum = deadlineMin.Hour;
                nudMinutes.Minimum = deadlineMin.Minute;
            }
            else
            {
                nudHours.Minimum = 0;
                nudMinutes.Minimum = 0;
            }
        }

        private void NewOrderForm_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 9.25F);
                dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 10F);
                dataGridView2.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 9.25F);
                dataGridView2.DefaultCellStyle.Font = new Font("Segoe UI", 10F);

                if (lbServiceYMax == 0)
                {
                    if (tbxServiceSearch.Text.Length > 0)
                    {
                        lbService.Location = new Point(20, lbService.Location.Y + 153);
                        tbxServiceSearch.Text = null;
                    }

                    lbServiceYMax = lbService.Location.Y;
                }
                lbServiceY = lbServiceYMax;
            }
            else
            {
                dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 9.25F);
                dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 9.25F);
                dataGridView2.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 9.25F);
                dataGridView2.DefaultCellStyle.Font = new Font("Segoe UI", 9.25F);

                lbServiceY = lbServiceYMin;
            }
        }

        private void NewOrderForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
                Close();
            else if (e.KeyChar == (char)Keys.Tab)
                MessageBox.Show(e.GetType().ToString());
        }

        /// <summary>
        /// Проверяет были ли изменения данных заказа.
        /// </summary>
        /// <returns>Возвращает true, если нужно сохранить.</returns>
        private bool NeedSave()
        {
            string phone = GetPhoneNonMask();

            if (Orders.orderData.ClientPhone != phone & phone == "" ||
                    Orders.orderData.ClientWhatsApp != btnWhatsApp.Checked ||
                    Orders.orderData.ClientName != tbxClientName.Text ||
                    Orders.orderData.ClientVk != socialUrl[0] ||
                    Orders.orderData.ClientInstagram != socialUrl[1] ||
                    Orders.orderData.ClientTelegram != socialUrl[2] ||
                    Orders.orderData.ClientMail != socialUrl[3] ||

                    Orders.orderData.Sum != nudSum.Value ||
                    Orders.orderData.Prepayment != nudPrepayment.Value ||

                    Orders.orderData.Deadline != OrderDateTime() ||

                    Orders.orderData.Status != (int)cbxStatus.SelectedValue)
            {
                return true;
            }
            else if (Orders.orderData.ClientPhone != phone & mtbxClientPhone.MaskCompleted)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void SaveTest()
        {
            List<string> lbTest = new List<string>
            {
                $"clientPhone: { Orders.orderData.ClientPhone } | GetPhoneNonMask(): { GetPhoneNonMask() }",
                $"clientWhatsApp: { Orders.orderData.ClientWhatsApp } | btnWhatsApp: { btnWhatsApp.Checked }",
                $"clientName: { Orders.orderData.ClientName } | tbxClientName: { tbxClientName.Text }",
                $"clientVk: { Orders.orderData.ClientVk } | socialUrlVk: { socialUrl[0] }",
                $"clientVk: { Orders.orderData.ClientInstagram } | socialUrlInstagram: { socialUrl[1] }",
                $"clientVk: { Orders.orderData.ClientTelegram } | socialUrlTelegram: { socialUrl[2] }",
                $"clientVk: { Orders.orderData.ClientMail } | socialUrlMail: { socialUrl[3] }",
                "______________________________________________",
                $"sum: { Orders.orderData.Sum } | nudSum: { nudSum.Value }",
                $"prepayment: { Orders.orderData.Prepayment } | nudPrepayment: { nudPrepayment.Value }",
                "______________________________________________",
                $"date: { Orders.orderData.Deadline } | OrderDateTime(): { OrderDateTime() }"
            };

            MessageBox.Show(string.Join(Environment.NewLine, lbTest));
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                if (NeedSave())
                {
                    SaveOrderData();
                    Notification("Сохранено");
                }
                else
                {
                    Notification("Нет изменений");
                }
            }
            else
            {
                Notification("Чтобы сохранить данные — добавьте услугу");
            }
        }

        private void NewOrderForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                if (NeedSave())
                {
                    DialogResult dr = MessageBox.Show("Данные были изменены.\nСохранить изменения?",
                        Text, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                    if (dr == DialogResult.Yes)
                    {
                        SaveOrderData();
                    }
                    else if (dr == DialogResult.Cancel)
                        e.Cancel = true;
                }

                OrdersForm.ordersForm.ReloadData();
            }
        }

        private void btnOpenLink_Click(object sender, EventArgs e)
        {
            if (tbxSocialNetwork.Text != "")
            {
                if (linkMail.LinkBehavior == LinkBehavior.NeverUnderline)
                {
                    Process.Start("https://mail.google.com/mail/?view=cm&fs=1&tf=1&to=" + tbxSocialNetwork.Text);
                }
                else
                {
                    Process.Start("https://" + tbxSocialNetwork.Text.Replace("https://", "").Replace("http://", ""));
                }
            }
        }

        private void dataGridView1_Sorted(object sender, EventArgs e)
        {
            RowsState();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            btnRefresh.Enabled = false;
            ReloadData();
            RowsState();
            btnRefresh.Enabled = true;
            btnRefresh.Focus();
        }

        private void NewOrderForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
                btnRefresh.PerformClick();
        }

        /// <summary>
        /// Сохраняет данные о заказе.
        /// </summary>
        private void SaveOrderData()
        {
            string phone = GetPhoneNonMask();

            if (newClient)
            {
                id_client = Clients.GetClientMaxID() + 1;
                Clients.AddClient(tbxClientName.Text, phone, btnWhatsApp.Checked,
                    socialUrl[0], socialUrl[1], socialUrl[2], socialUrl[3]);

                newClient = false;
            }
            else if (!newClient && mtbxClientPhone.MaskCompleted)
            {
                Clients.EditClient(id_client, tbxClientName.Text, phone, btnWhatsApp.Checked,
                    socialUrl[0], socialUrl[1], socialUrl[2], socialUrl[3]);
            }

            ClientsForm.clientsForm.ReloadData();

            Orders.UpdateOrder(id_order, id_client, nudSum.Value, nudPrepayment.Value, 
                OrderDateTime(), Convert.ToInt32(cbxStatus.SelectedValue));

            AutoRefresher.UpdateDate();

            #region Добавляем сотрудника и дату в InfoForm, если изменили статус
            if (Orders.orderData.Status != (int)cbxStatus.SelectedValue)
            {
                if (cbxStatus.Text == "Отменен")
                {
                    using (SecondaryForm secondaryForm = new SecondaryForm())
                    {
                        secondaryForm.id_order = id_order;
                        secondaryForm.status = cbxStatus.Text;
                        secondaryForm.ShowDialog();
                    }
                }
                else
                {
                    Info.AddInfo(id_order, cbxStatus.Text, null);
                }
            }
            #endregion

            #region Reset Temp Values
            Orders.orderData.ClientPhone = phone;
            Orders.orderData.ClientWhatsApp = btnWhatsApp.Checked;
            Orders.orderData.ClientName = tbxClientName.Text;
            Orders.orderData.ClientVk = socialUrl[0];
            Orders.orderData.ClientInstagram = socialUrl[1];
            Orders.orderData.ClientTelegram = socialUrl[2];
            Orders.orderData.ClientMail = socialUrl[3];

            Orders.orderData.Sum = nudSum.Value;
            Orders.orderData.Prepayment = nudPrepayment.Value;

            Orders.orderData.Deadline = OrderDateTime();

            Orders.orderData.Status = (int)cbxStatus.SelectedValue;
            #endregion
        }

        private void timerNotif_Tick(object sender, EventArgs e)
        {
            btnNotification.Text = "";
            btnNotification.Checked = false;
            timerNotif.Stop();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Узнать индекс колонки и строки
            //MessageBox.Show("Индекс колонки: " + e.ColumnIndex.ToString() + "\nИндекс строки: " + e.RowIndex.ToString());

            // Файлы
            if (e.RowIndex != -1 && e.ColumnIndex == 1)
            {
                string fileId = dataGridView2.Rows[e.RowIndex].Cells["fileId"].Value.ToString();

                string serviceFolder = dataGridView1.CurrentRow.Cells["Folder"].Value.ToString();
                string downloadsFolder = serviceFolder == "" ? DownloadFolderPath.GetPath() : serviceFolder;

                _ = new GoogleDriveFilesRepository().DownloadGoogleFile(fileId, e.RowIndex, downloadsFolder, serviceId);
            }
            // Удалить
            else if (e.ColumnIndex == 2)
            {
                DialogResult dr = MessageBox.Show("Вы действительно хотите удалить этот файл?",
                    Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (dr == DialogResult.Yes)
                {
                    string fileId = dataGridView2.Rows[e.RowIndex].Cells["fileId"].Value.ToString();
                    GoogleDriveFilesRepository.DeleteFile(fileId);
                    Files.DeleteFileByFileID(fileId);
                    LoadFilesData();
                }
            }
        }

        private void tbxSocialNetwork_Enter(object sender, EventArgs e)
        {
            social[socialCurrent].Item1.LinkColor = color.AccentBlue;
        }

        private void tbxSocialNetwork_Leave(object sender, EventArgs e)
        {
            social[socialCurrent].Item1.LinkColor = socialUrl[socialCurrent].Length == 0 ? color.IconGray : color.BorderBlack;
        }

        private void tbxSocialNetwork_TextChanged(object sender, EventArgs e)
        {
            //StringBuilder stringBuilder = new StringBuilder(tbxSocialNetwork.Text);
            //stringBuilder.Replace("https://", "");
            //stringBuilder.Replace("vk.com/", "");
            //stringBuilder.Replace("www.instagram.com/", "");
            //stringBuilder.Replace("t.me/", "");
            //stringBuilder.Replace("/", "");

            //tbxSocialNetwork.Text = stringBuilder.ToString();
            //socialUrl[socialCurrent] = stringBuilder.ToString();
            socialUrl[socialCurrent] = tbxSocialNetwork.Text;
        }

        private void pFiles_LostFocus(object sender, EventArgs e)
        {
            int x = Cursor.Position.X - Location.X;
            int y = Cursor.Position.Y - Location.Y;

            if (x > 465 && y > 60)
                pFiles.Size = new Size(0, pFiles.Height);
            else
                pFiles.Focus();
        }

        private void btnUploadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Multiselect = true
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                _ = new GoogleDriveFilesRepository().FilesUpload(openFileDialog.FileNames, serviceId);
            }
        }
    }
}
