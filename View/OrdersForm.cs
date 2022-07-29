using ClosedXML.Excel;
using GoogleDriveRestAPI_v3.Models;
using Order_Management.Database;
using Order_Management.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Order_Management
{
    public partial class OrdersForm : Form
    {
        private DataTable dtOrders;
        private DataTable dtStatuses;
        private DataTable dtShops;

        private string direction = "DESC";
        private string dateFrom, dateTo;
        private const string adjacent = "Смежный";

        public int formTop, formLeft;

        public DataGridViewComboBoxColumn id_status;
        public static OrdersForm ordersForm = null;

        public OrdersForm()
        {
            ordersForm = this;
            InitializeComponent();

            ((DataGridViewImageColumn)myDataGridView1.Columns["pinPic"]).DefaultCellStyle.NullValue = null;

            #region Отступ для столбцов myDataGridView1
            myDataGridView1.EnableHeadersVisualStyles = false;
            myDataGridView1.Columns["id"].HeaderCell.Style.Padding = new Padding(30, 0, 0, 0);
            myDataGridView1.Columns["date_of_create"].HeaderCell.Style.Padding = new Padding(5, 0, 0, 0);
            myDataGridView1.Columns["services"].HeaderCell.Style.Padding = new Padding(5, 0, 0, 0);
            myDataGridView1.Columns["sum"].HeaderCell.Style.Padding = new Padding(20, 0, 0, 0);
            myDataGridView1.Columns["status"].HeaderCell.Style.Padding = new Padding(5, 0, 0, 0);
            myDataGridView1.Columns["shop_orders"].HeaderCell.Style.Padding = new Padding(5, 0, 0, 0);
            myDataGridView1.Columns["date_of_deadline"].HeaderCell.Style.Padding = new Padding(5, 0, 0, 0);
            myDataGridView1.Columns["name"].HeaderCell.Style.Padding = new Padding(5, 0, 0, 0);
            myDataGridView1.Columns["comment"].HeaderCell.Style.Padding = new Padding(5, 0, 0, 0);
            #endregion

            btnDateFrom.LostFocus += new EventHandler(btnDateFrom_LostFocus);
            btnDateTo.LostFocus += new EventHandler(btnDateTo_LostFocus);
        }

        private void btnDateFrom_LostFocus(object sender, EventArgs e)
        {
            var xy = PointToClient(Cursor.Position);

            // 30 - до начала календаря слева, 35 - до начала кнопки сверху
            // 194 - до конца календаря слева, 243 - до конца календаря сверху

            if (xy.X <= 30 || xy.Y <= 35 || xy.X >= 194 || xy.Y >= 243)
                btnDateFrom.Checked = false;
            else
                btnDateFrom.Focus();
        }

        private void btnDateTo_LostFocus(object sender, EventArgs e)
        {
            var xy = PointToClient(Cursor.Position);

            if (xy.X <= 211 || xy.Y <= 35 || xy.X >= 375 || xy.Y >= 243)
                btnDateTo.Checked = false;
            else
                btnDateTo.Focus();
        }

        private void OrdersForm_Load(object sender, EventArgs e)
        {
            dtStatuses = Statuses.LoadStatusesFilter();
            cbxStatusFilter.DataSource = dtStatuses;
            cbxStatusFilter.DisplayMember = "status";
            cbxStatusFilter.ValueMember = "id";
            StatusesInContextMenu();

            dtShops = Shops.LoadShopsFilter();
            cbxShopFilter.DataSource = dtShops;
            cbxShopFilter.DisplayMember = "shop";
            cbxShopFilter.ValueMember = "id";
            cbxShopFilter.SelectedValue = Settings.Default.defaultShop;
            ShopsInContextMenu();

            calendarFrom.SelectionStart = DateTime.Now.AddMonths(-2);
            calendarTo.SelectionStart = DateTime.Now;
            FilterController();
            myDataGridView1.Select();
        }

        public void RowsState()
        {
            foreach (DataGridViewRow row in myDataGridView1.Rows)
            {
                string status = row.Cells["status"].Value.ToString();

                for (int i = 1; i < dtStatuses.Rows.Count; i++)
                    if (status == dtStatuses.Rows[i][1].ToString())
                        row.Cells["status"].Style.ForeColor = ColorTranslator.FromHtml("#" + dtStatuses.Rows[i][2]);

                if (Convert.ToInt32(row.Cells["pin_orders"].Value) == 1)
                    row.Cells["pinPic"].Value = Resources.pinIcon;
                else
                    row.Cells["pinPic"].Value = null;

                if (Convert.ToDateTime(row.Cells["date_of_deadline"].Value) < DateTime.Now && status != "Отдан" & status != "Отменен")
                    row.Cells["date_of_deadline"].Style.ForeColor = Color.FromArgb(255, 153, 0);
                else
                    row.Cells["date_of_deadline"].Style.ForeColor = Color.FromArgb(112, 118, 131);
            }
        }

        public void ReloadData()
        {
            int row = myDataGridView1.Rows.Count != 0 ? 
                myDataGridView1.FirstDisplayedScrollingRowIndex : 0;

            dtOrders = Orders.ReloadOrders();
            myDataGridView1.DataSource = dtOrders;

            if (myDataGridView1.Rows.Count != 0)
                myDataGridView1.FirstDisplayedScrollingRowIndex = row;

            RowsState();
            myDataGridView1.Select();

            AutoRefresher.oldDate = DateTime.Now;
        }

        /// <summary>
        /// Заполняет контекстное меню статусами.
        /// </summary>
        private void StatusesInContextMenu()
        {
            for (int i = 1; i < dtStatuses.Rows.Count; i++)
            {
                ToolStripMenuItem tsmiStatus = new ToolStripMenuItem(dtStatuses.Rows[i][1].ToString())
                {
                    AutoSize = false,
                    Size = new Size(180, 25),
                    Font = new Font("Segoe UI", 9.75F),
                    ForeColor = Color.FromArgb(50, 60, 71)
                };
                cmsStatuses.Items.Add(tsmiStatus);
            }

            foreach (ToolStripMenuItem item in cmsStatuses.Items)
            {
                item.Click += (s, a) =>
                {
                    int id_order = Convert.ToInt32(myDataGridView1.CurrentRow.Cells["id"].Value);

                    if (item.Text == "Отменен")
                    {
                        using (SecondaryForm secondaryForm = new SecondaryForm())
                        {
                            secondaryForm.id_order = id_order;
                            secondaryForm.status = item.Text;
                            secondaryForm.ShowDialog();
                        }
                    }
                    else
                    {
                        Info.AddInfo(id_order, item.Text, null);
                    }

                    Orders.UpdateOrderStatus(id_order, item.Text);

                    myDataGridView1.CurrentRow.Cells["status"].Value = item.Text;
                    RowsState();
                    myDataGridView1.CurrentCell = myDataGridView1.CurrentRow.Cells[0];
                    myDataGridView1.Focus();
                };
            }
        }

        private void ShopsInContextMenu()
        {
            for (int i = 1; i < dtShops.Rows.Count; i++)
            {
                ToolStripMenuItem tsmiShop = new ToolStripMenuItem(dtShops.Rows[i][1].ToString())
                {
                    AutoSize = false,
                    Size = new Size(180, 25),
                    Font = new Font("Segoe UI", 9.75F),
                    ForeColor = Color.FromArgb(50, 60, 71)
                };
                cmsShops.Items.Add(tsmiShop);
            }

            foreach (ToolStripMenuItem item in cmsShops.Items)
            {
                item.Click += (s, a) =>
                {
                    int id_order = Convert.ToInt32(myDataGridView1.CurrentRow.Cells["id"].Value);

                    Orders.UpdateOrderShop(id_order, item.Text);

                    myDataGridView1.CurrentRow.Cells["shop_orders"].Value = item.Text;
                    ReloadData();
                };
            }
        }

        /// <summary>
        /// Сортирует по двум столбцам.
        /// </summary>
        /// <param name="column">DataPropertyName столбца который нужно отсортировать.</param>
        /// <param name="direction">Направление.</param>
        private void SortByMultiColumns(string column, string direction)
        {
            DataView view = dtOrders.DefaultView;
            view.Sort = $"pin DESC, { column } { direction }";
            myDataGridView1.DataSource = view;
            RowsState();
        }

        private void myDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 1 && e.ColumnIndex != 6 && e.RowIndex != -1)
            {
                using (NewOrderForm newOrderForm = new NewOrderForm())
                {
                    newOrderForm.id_order = Convert.ToInt32(myDataGridView1.Rows[e.RowIndex].Cells["id"].Value);
                    newOrderForm.lblOrderID.Text = "Заказ № " + myDataGridView1.Rows[e.RowIndex].Cells["id"].Value;
                    newOrderForm.deadlineMin = Convert.ToDateTime(myDataGridView1.Rows[e.RowIndex].Cells["date_of_create"].Value);

                    newOrderForm.LoadOrderData();
                    newOrderForm.ShowDialog();
                }
            }
            else if (e.RowIndex == -1 && e.ColumnIndex != 0 && e.ColumnIndex != 1)
            {
                direction = direction == "DESC" ? "ASC" : "DESC";
                SortByMultiColumns(myDataGridView1.Columns[e.ColumnIndex].DataPropertyName, direction);
            }

            // Узнать индекс колонки и строки
            //MessageBox.Show("Индекс колонки: " + e.ColumnIndex.ToString() + "\nИндекс строки: " + e.RowIndex.ToString());
        }

        private void myDataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex != -1)
            {
                myDataGridView1.CurrentCell = myDataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];

                if (e.ColumnIndex == 6)
                {
                    cmsStatuses.Show(Cursor.Position);
                }
                else if (e.ColumnIndex == 7)
                {
                    cmsShops.Show(Cursor.Position);
                }
                else if (e.ColumnIndex != 1)
                {
                    tsmiPin.Text = Convert.ToInt32(myDataGridView1.CurrentRow.Cells["pin_orders"].Value) == 1 ? "Открепить" : "Закрепить";
                    cmsOrder.Show(Cursor.Position);
                }
            }
        }

        private void myDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                int id_order = Convert.ToInt32(myDataGridView1.Rows[e.RowIndex].Cells["id"].Value);

                DialogResult dr = MessageBox.Show($"Вы действительно хотите удалить заказ № { id_order }?",
                    Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (dr == DialogResult.Yes)
                {
                    #region Сохраняем удаляемый заказ в таблице удаленных заказов
                    //string mySqlExpression = "INSERT INTO tbl_deleted_orders (id, date_of_create, services, sum, id_status, " +
                    //"employee, date_of_deadline, id_client, comment, prepayment, ready_date, pin) " +
                    //"SELECT * FROM tbl_orders " +
                    //$"WHERE tbl_orders.id = '{ id }'";

                    //using (MySqlCommand command = new MySqlCommand(mySqlExpression, connection))
                    //{
                    //    
                    //    command.ExecuteNonQuery();
                    //}
                    #endregion

                    #region Удаляем файлы этого заказа
                    Files.DeleteFilesByOrderID(id_order);
                    #endregion

                    #region Удаляем услуги этого заказа
                    Services.DeleteServices(id_order);
                    #endregion

                    #region Удаляем информацию этого заказа
                    Info.DeleteInfo(id_order);
                    #endregion

                    #region Удаляем заказ
                    Orders.DeleteOrder(id_order);
                    #endregion

                    MainForm.mainForm.Notification($"Заказ № { id_order } удален");
                }
            }
        }

        private void cbxShopFilter_SelectionChangeCommitted(object sender, EventArgs e)
        {
            FilterController();
        }

        private void cbxStatusFilter_SelectionChangeCommitted(object sender, EventArgs e)
        {
            FilterController();
        }

        public void FilterController()
        {
            chbxOrderNotGiven.Checked = false;
            MainForm.mainForm.tbxSearch.Text = "";

            string filter = "";
            string status = cbxStatusFilter.Text;
            string shop = cbxShopFilter.Text;

            List<string> ts = new List<string>
            {
                status == "Все статусы" ? "" : $"status Like '{status}'",
                shop == "Все филиалы" ? "" : $"shop Like '{shop}' OR shop Like '{adjacent}'"
            };

            filter = string.Join(" AND ", ts.Where(x => x != ""));

            dtOrders.DefaultView.RowFilter = filter;

            RowsState();
            myDataGridView1.Focus();
        }

        private void btnNewOrder_Click(object sender, EventArgs e)
        {
            using (NewOrderForm newOrderForm = new NewOrderForm())
            {
                newOrderForm.NewOrderStartValues();
                newOrderForm.ShowDialog();
            }
        }

        private void btnTemporarilyFolder_Click(object sender, EventArgs e)
        {
            string pathCurrentFolder = Settings.Default.CurrentFolder;
            ProcessStartInfo pathTempFolder = new ProcessStartInfo("explorer", $"{ pathCurrentFolder }\\1. ВРЕМЕННО (ПО МЕЛОЧИ)");

            if (!Directory.Exists(pathCurrentFolder + @"\1. ВРЕМЕННО (ПО МЕЛОЧИ)"))
            {
                DialogResult dr = MessageBox.Show("Данная папка больше не существует!\nНажмите ОК, чтобы открыть текущую директорию.",
                    Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

                if (dr == DialogResult.OK)
                    Process.Start(pathCurrentFolder);
            }
            else
                Process.Start(pathTempFolder);
        }

        private void OrdersForm_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                myDataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 9.25F);
                myDataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 10F);
            }
            else
            {
                myDataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 9.25F);
                myDataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 9.25F);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ReloadData();
        }

        private void chbxOrderNotGiven_CheckedChanged(object sender, EventArgs e)
        {
            string shop = cbxShopFilter.Text;

            if (shop != "Все филиалы")
            {
                dtOrders.DefaultView.RowFilter = chbxOrderNotGiven.Checked ?
                $"ready_date < '{ DateTime.Now }' AND status = 'Готов' AND shop Like '{ shop }' OR shop Like '{adjacent}'" : null;
            }
            else // Все филиалы
            {
                dtOrders.DefaultView.RowFilter = chbxOrderNotGiven.Checked ?
                $"ready_date < '{ DateTime.Now }' AND status = 'Готов'" : null;
            }

            if (!chbxOrderNotGiven.Checked)
                FilterController();

            RowsState();
        }

        private void tsmiAboutOrder_Click(object sender, EventArgs e)
        {
            using (InfoForm infoForm = new InfoForm())
            {
                infoForm.LoadData(Convert.ToInt32(myDataGridView1.CurrentRow.Cells["id"].Value));
                infoForm.ShowDialog();
            }
        }

        private void tsmiPin_Click(object sender, EventArgs e)
        {
            int id_order = Convert.ToInt32(myDataGridView1.CurrentRow.Cells["id"].Value);
            int pin = Convert.ToInt32(myDataGridView1.CurrentRow.Cells["pin_orders"].Value) == 0 ? 1 : 0;

            Orders.PinOrder(id_order, pin);

            ReloadData();
        }

        private void tsmiAdjacent_Click(object sender, EventArgs e)
        {
            int id_order = Convert.ToInt32(myDataGridView1.CurrentRow.Cells["id"].Value);
        }

        private void OrdersForm_Click(object sender, EventArgs e)
        {
            myDataGridView1.Select();
        }

        private void myDataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void btnDateFrom_CheckedChanged(object sender, EventArgs e)
        {
            calendarFrom.Visible = btnDateFrom.Checked;
        }

        private void btnDateTo_CheckedChanged(object sender, EventArgs e)
        {
            calendarTo.Visible = btnDateTo.Checked;
        }

        private void calendarFrom_DateChanged(object sender, DateRangeEventArgs e)
        {
            btnDateFrom.Text = calendarFrom.SelectionStart.ToString("D");
            dateFrom = calendarFrom.SelectionStart.ToString("yyyy-MM-dd");

            dtOrders = Orders.LoadOrders(dateFrom, dateTo);
            myDataGridView1.DataSource = dtOrders;

            SortByMultiColumns("id", direction);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            dateTo = calendarTo.SelectionStart.ToString("yyyy-MM-dd");

            DataTable dtOrders = Orders.GetOrdersForExport(dateFrom, dateTo);
            DataTable dtStatuses = Orders.GetLastStatusesForExport(dateFrom, dateTo);

            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Заказы");

                worksheet.Cell("A1").Value = "№";
                worksheet.Cell("B1").Value = "Дата заказа";
                worksheet.Cell("C1").Value = "Услуги";
                worksheet.Cell("D1").Value = "Сумма";
                worksheet.Cell("E1").Value = "Кто создал(а)";
                worksheet.Cell("F1").Value = "Конечный статус";

                List<string> employees = new List<string>();

                for (int i = 0; i < dtOrders.Rows.Count; i++)
                {
                    string employee = dtOrders.Rows[i][4].ToString();

                    if (!employees.Contains(employee))
                    {
                        employees.Add(employee);
                    }

                    worksheet.Cell(i + 2, 1).Value = dtOrders.Rows[i][0].ToString();
                    worksheet.Cell(i + 2, 2).Value = dtOrders.Rows[i][1].ToString();
                    worksheet.Cell(i + 2, 3).Value = dtOrders.Rows[i][2].ToString();
                    worksheet.Cell(i + 2, 4).Value = dtOrders.Rows[i][3].ToString();
                    worksheet.Cell(i + 2, 5).Value = employee;
                    worksheet.Cell(i + 2, 6).Value = dtStatuses.Rows[i][1].ToString();
                }

                int totalRow = dtOrders.Rows.Count + 3;
                worksheet.Cell(totalRow, 2).Value = "ИТОГО";
                worksheet.Cell(totalRow, 2).Style.Font.Bold = true;

                for (int i = 0; i < employees.Count; i++)
                {
                    worksheet.Cell(totalRow + i, 4).FormulaR1C1 = $"=SUMIF(E2:E{dtOrders.Rows.Count + 2},E{totalRow + i},D2:D{dtOrders.Rows.Count + 2})";
                    worksheet.Cell(totalRow + i, 5).Value = employees[i];
                }

                string path = $"{Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)}\\Заказы с {dateFrom} по {dateTo}.xlsx";
                workbook.SaveAs(path);

                DialogResult dr = MessageBox.Show("Экспорт завершен.\nПоказать в папке?",
                    Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                if (dr == DialogResult.Yes)
                {
                    Process.Start(new ProcessStartInfo { FileName = "explorer", Arguments = $"/n,/select,{path}"});
                }
            }
        }

        private void calendarTo_DateChanged(object sender, DateRangeEventArgs e)
        {
            btnDateTo.Text = calendarTo.SelectionStart.ToString("D");
            dateTo = calendarTo.SelectionStart.ToString("yyyy-MM-dd 23:59:59");

            dtOrders = Orders.LoadOrders(dateFrom, dateTo);
            myDataGridView1.DataSource = dtOrders;

            SortByMultiColumns("id", direction);
        }

        public void SearchController(string regexSearch)
        {
            dtOrders.DefaultView.RowFilter = string.Format("Convert([id], 'System.String') Like '%{0}%' OR services Like '%{0}%' " +
                "OR name Like '%{0}%' OR comment Like '%{0}%'", regexSearch);
            RowsState();

            if (regexSearch == "")
            {
                FilterController();
                MainForm.mainForm.tbxSearch.Focus();
            }
        }
    }
}
