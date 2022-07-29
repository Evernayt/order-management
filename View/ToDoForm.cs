using Order_Management.Database;
using Order_Management.Properties;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Order_Management
{
    public partial class ToDoForm : Form
    {
        private DataTable dtTasks;
        private string direction = "DESC";
        private readonly Colors color = new Colors();

        public static ToDoForm toDoForm = null;

        public ToDoForm()
        {
            toDoForm = this;
            InitializeComponent();
            ((DataGridViewImageColumn)myDataGridView1.Columns["urgentlyPic_todo"]).DefaultCellStyle.NullValue = null;

            #region Отступ для столбцов myDataGridView1
            myDataGridView1.EnableHeadersVisualStyles = false;
            myDataGridView1.Columns["date_of_create_todo"].HeaderCell.Style.Padding = new Padding(12, 0, 0, 0);
            myDataGridView1.Columns["task_todo"].HeaderCell.Style.Padding = new Padding(5, 0, 0, 0);
            myDataGridView1.Columns["created_todo"].HeaderCell.Style.Padding = new Padding(20, 0, 0, 0);
            myDataGridView1.Columns["completed_todo"].HeaderCell.Style.Padding = new Padding(5, 0, 0, 0);
            myDataGridView1.Columns["shop_todo"].HeaderCell.Style.Padding = new Padding(5, 0, 0, 0);
            #endregion

            btnDate.LostFocus += new EventHandler(btnDate_LostFocus);
        }

        private void btnDate_LostFocus(object sender, EventArgs e)
        {
            var xy = PointToClient(Cursor.Position);

            if (xy.X <= 30 || xy.Y <= 35 || xy.X >= 194 || xy.Y >= 243)
                btnDate.Checked = false;
            else
                btnDate.Focus();
        }

        private void ToDoForm_Load(object sender, EventArgs e)
        {
            cbxShopFilter.DataSource = Shops.LoadShopsFilter();
            cbxShopFilter.DisplayMember = "shop";
            cbxShopFilter.ValueMember = "id";
            cbxShopFilter.SelectedValue = Settings.Default.defaultShop;

            calendar.SelectionStart = DateTime.Now.AddMonths(-2);
            FilterController();
        }

        public void ReloadData()
        {
            int row = myDataGridView1.Rows.Count != 0 ?
                myDataGridView1.FirstDisplayedScrollingRowIndex : 0;

            dtTasks = ToDo.ReloadToDo();
            myDataGridView1.DataSource = dtTasks;

            if (myDataGridView1.Rows.Count != 0)
                myDataGridView1.FirstDisplayedScrollingRowIndex = row;

            RowsState();
            myDataGridView1.Select();
        }

        public void RowsState()
        {
            foreach (DataGridViewRow row in myDataGridView1.Rows)
            {
                if (Convert.ToInt32(row.Cells["urgently_todo"].Value) == 1)
                    row.Cells["urgentlyPic_todo"].Value = Resources.urgentlyIcon;
                else
                    row.Cells["urgentlyPic_todo"].Value = null;
            }
        }

        private void SortByMultiColumns(string column, string direction)
        {
            DataView view = dtTasks.DefaultView;
            view.Sort = $"urgently DESC, { column } { direction }";
            myDataGridView1.DataSource = view;
            RowsState();
        }

        private void calendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            btnDate.Text = calendar.SelectionStart.ToString("D");
            string dateFrom = calendar.SelectionStart.ToString("yyyy-MM-dd");

            dtTasks = ToDo.LoadToDo(dateFrom);
            myDataGridView1.DataSource = dtTasks;

            SortByMultiColumns("id", direction);
            FilterController();
        }

        private void btnDate_CheckedChanged(object sender, EventArgs e)
        {
            calendar.Visible = btnDate.Checked;
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            if(tbxTask.Text != "")
            {
                ToDo.AddWork(tbxTask.Text);
                ReloadData();
                tbxTask.Text = "";
                tbxTask.Focus();
                MainForm.mainForm.Notification("Задание создано");
            }
        }

        private void myDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                int id = Convert.ToInt32(myDataGridView1.Rows[e.RowIndex].Cells["id_todo"].Value);
                int status = Convert.ToInt32(myDataGridView1.Rows[e.RowIndex].Cells["status_todo"].Value) == 0 ? 1 : 0;

                if (status == 1)
                    ToDo.UrgentlyTask(id, 0);

                ToDo.UpdateToDoStatus(id, status);
                ReloadData();
                FilterController();
            }
            else if (e.ColumnIndex == 1)
            {
                int id = Convert.ToInt32(myDataGridView1.Rows[e.RowIndex].Cells["id_todo"].Value);
                DialogResult dr = MessageBox.Show($"Вы действительно хотите удалить это задание?",
                    Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (dr == DialogResult.Yes)
                {
                    ToDo.DeleteTask(id);
                    MainForm.mainForm.Notification($"Задание № { id } удалено");
                }
            }
        }

        private void myDataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                int id = Convert.ToInt32(myDataGridView1.Rows[e.RowIndex].Cells["id_todo"].Value);
                string task = myDataGridView1.Rows[e.RowIndex].Cells["task_todo"].Value.ToString();

                ToDo.UpdateToDoWork(id, task);
            }

        }

        private void myDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex == 5)
            {
                myDataGridView1.BeginEdit(true);
            }
            else if (e.RowIndex == -1 && e.ColumnIndex != 0 && e.ColumnIndex != 1 && e.ColumnIndex != 3)
            {
                direction = direction == "DESC" ? "ASC" : "DESC";
                SortByMultiColumns(myDataGridView1.Columns[e.ColumnIndex].DataPropertyName, direction);
            }
        }

        private void myDataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void myDataGridView1_Click(object sender, EventArgs e)
        {
            //myDataGridView1.EndEdit();
        }

        private void tsmiUrgently_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(myDataGridView1.CurrentRow.Cells["id_todo"].Value);
            int urgently = Convert.ToInt32(myDataGridView1.CurrentRow.Cells["urgently_todo"].Value) == 0 ? 1 : 0;

            ToDo.UrgentlyTask(id, urgently);

            ReloadData();
        }

        private void myDataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.ColumnIndex != 1 && e.ColumnIndex != 3 && e.RowIndex != -1)
            {
                myDataGridView1.CurrentCell = myDataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
                tsmiUrgently.Text = Convert.ToInt32(myDataGridView1.CurrentRow.Cells["urgently_todo"].Value) == 1 ? "Не срочно" : "Срочно";
                cmsTask.Show(Cursor.Position);
            }
        }

        private void ToDoForm_Resize(object sender, EventArgs e)
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

        private void tbxTask_Enter(object sender, EventArgs e)
        {
            lblTaskTitle.ForeColor = color.AccentBlue;
        }

        private void tbxTask_Leave(object sender, EventArgs e)
        {
            lblTaskTitle.ForeColor = color.BorderBlack;
        }

        private void ToDoForm_Click(object sender, EventArgs e)
        {
            myDataGridView1.Select();
        }

        private void cbxStatusFilter_SelectionChangeCommitted(object sender, EventArgs e)
        {
            FilterController();
        }

        private void cbxShopFilter_SelectionChangeCommitted(object sender, EventArgs e)
        {
            FilterController();
        }

        private void FilterController()
        {
            MainForm.mainForm.tbxSearch.Text = "";

            string filter, shop;

            int status = cbxStatusFilter.SelectedIndex - 1;
            shop = cbxShopFilter.Text;

            if (status < 0 && shop == "Все филиалы")
                filter = string.Empty;
            else if (status < 0)
                filter = string.Format($"shop Like '{ shop }'");
            else if (shop == "Все филиалы")
                filter = string.Format($"Convert([status], 'System.Int32') = '{ status }'");
            else
                filter = string.Format($"Convert([status], 'System.Int32') = '{ status }' AND shop Like '{ shop }'");

            dtTasks.DefaultView.RowFilter = filter;

            RowsState();
            myDataGridView1.Focus();
        }

        private void tbxTask_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                btnAddTask.PerformClick();
        }

        public void SearchController(string regexSearch)
        {
            dtTasks.DefaultView.RowFilter = string.Format("task Like '%{0}%' OR created Like '%{0}%' OR completed Like '%{0}%'", regexSearch);
            RowsState();

            if (regexSearch == "")
            {
                FilterController();
                MainForm.mainForm.tbxSearch.Focus();
            }
        }
    }
}
