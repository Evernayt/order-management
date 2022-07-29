using System;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;
using Order_Management.Properties;
using Order_Management.Database;
using System.Collections.Generic;

namespace Order_Management.View.SettingsForms
{
    public partial class StatusesForm : Form
    {
        private MySqlDataAdapter dataAdapter;
        private DataTable dataTable;

        private readonly Colors color = new Colors();

        List<(Control, Label)> controls = new List<(Control, Label)>();

        public StatusesForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Загружает статусы с БД.
        /// </summary>
        private void LoadData()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(Settings.Default.dbConnection))
                {
                    string mySqlExpression = "SELECT * FROM tbl_statuses WHERE id != 1 AND archive = 0";
                    dataAdapter = new MySqlDataAdapter(mySqlExpression, connection);
                    dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
            }
            catch { }
        }

        /// <summary>
        /// Перезагружает статусы с БД.
        /// </summary>
        /// <param name="row">Индекс строки для выделения.</param>
        private void ReloadData(int row)
        {
            try
            {
                dataTable.Clear();
                dataAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
                if (dataGridView1.Rows.Count != 0)
                    dataGridView1.Rows[row].Selected = true;

                RowColor();
            }
            catch { }
        }

        private void RowColor()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (Convert.ToInt32(row.Cells["archive_statuses"].Value) == 1)
                {
                    row.DefaultCellStyle.ForeColor = Color.DarkGray;
                    row.DefaultCellStyle.SelectionForeColor = Color.DarkGray;
                }
            }
        }

        public void FormLoad()
        {
            #region Связываем текстовые окна с заголовками
            controls.Add((tbxName, lblNamesTitle));
            controls.Add((tbxColor, lblColorTitle));
            #endregion

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

            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 9.25F);
            dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 9.25F);

            LoadData();
        }

        private void BorderColorReset()
        {
            tbxName.BorderColor = color.BorderGray;
            tbxName.HoverState.BorderColor = color.BorderGray;
            tbxName.FocusedState.BorderColor = color.BorderBlack;

            tbxColor.BorderColor = color.BorderGray;
            tbxColor.HoverState.BorderColor = color.BorderGray;
            tbxColor.FocusedState.BorderColor = color.BorderBlack;
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            string regexSearch = Regex.Replace(tbxSearch.Text, @"[['%*]", "  ");
            dataTable.DefaultView.RowFilter = string.Format("status Like '%{0}%' OR color Like '%{0}%'", regexSearch);
        }

        private void cbxShow_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string mySqlExpression = "";

            using (MySqlConnection connection = new MySqlConnection(Settings.Default.dbConnection))
            {
                switch (cbxShow.SelectedIndex)
                {
                    case 0: mySqlExpression = "SELECT * FROM tbl_statuses WHERE id != 1 AND archive = 0"; break;
                    case 1: mySqlExpression = "SELECT * FROM tbl_statuses WHERE id != 1 AND archive = 1"; break;
                    case 2: mySqlExpression = "SELECT * FROM tbl_statuses WHERE id != 1"; break;
                }

                dataAdapter = new MySqlDataAdapter(mySqlExpression, connection);
                ReloadData(0);

                btnDelete.Text = RowsCountNotNull() && Convert.ToInt32(dataGridView1.CurrentRow.Cells["archive_statuses"].Value) == 0 ?
                    "Удалить" : "Восстановить";
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
                btnDelete.Text = Convert.ToInt32(dataGridView1.CurrentRow.Cells["archive_statuses"].Value) == 0 ?
               "Удалить" : "Восстановить";
        }

        private void tbxColor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'A' || e.KeyChar > 'F') && (e.KeyChar < 'a' || e.KeyChar > 'f') && (e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            #region Меняет цвет обводки поля, если не введено значение
            if (tbxName.Text == "" && tbxColor.Text == "")
            {
                tbxName.BorderColor = color.Red;
                tbxName.HoverState.BorderColor = color.Red;
                tbxName.FocusedState.BorderColor = color.Red;

                tbxColor.BorderColor = color.Red;
                tbxColor.HoverState.BorderColor = color.Red;
                tbxColor.FocusedState.BorderColor = color.Red;
            }
            #endregion
            else
            {
                using (MySqlConnection connection = new MySqlConnection(Settings.Default.dbConnection))
                {
                    string mySqlExpression = "INSERT INTO tbl_statuses (status, color) " +
                    "VALUES (@status, @color)";

                    using (MySqlCommand command = new MySqlCommand(mySqlExpression, connection))
                    {
                        connection.Open();

                        command.Parameters.Add("@status", MySqlDbType.VarChar).Value = tbxName.Text;
                        command.Parameters.Add("@color", MySqlDbType.VarChar).Value = tbxColor.Text;

                        command.ExecuteNonQuery();
                        tbxName.Text = null;
                        tbxColor.Text = null;

                        ReloadData(0);
                        BorderColorReset();
                    }
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            #region Меняет цвет обводки поля, если не введено значение
            if (tbxName.Text == "" && tbxColor.Text == "")
            {
                tbxName.BorderColor = color.Red;
                tbxName.HoverState.BorderColor = color.Red;
                tbxName.FocusedState.BorderColor = color.Red;

                tbxColor.BorderColor = color.Red;
                tbxColor.HoverState.BorderColor = color.Red;
                tbxColor.FocusedState.BorderColor = color.Red;
            }
            #endregion
            else if (dataGridView1.CurrentRow.Cells["status_statuses"].Value.ToString() == "Готов")
            {
                MessageBox.Show("Этот статус невозможно изменить.", "Статусы",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                string id = dataGridView1.CurrentRow.Cells["id_statuses"].Value.ToString();

                using (MySqlConnection connection = new MySqlConnection(Settings.Default.dbConnection))
                {
                    string mySqlExpression = "UPDATE tbl_statuses " +
                        "SET status = @status, color = @color " +
                        $"WHERE id = '{ id }'";

                    using (MySqlCommand command = new MySqlCommand(mySqlExpression, connection))
                    {
                        connection.Open();

                        command.Parameters.Add("@status", MySqlDbType.VarChar).Value = tbxName.Text == "" ?
                            dataGridView1.CurrentRow.Cells["status_statuses"].Value.ToString() : tbxName.Text;

                        command.Parameters.Add("@color", MySqlDbType.VarChar).Value = tbxColor.Text == "" ?
                            dataGridView1.CurrentRow.Cells["color_statuses"].Value.ToString() : tbxColor.Text;

                        command.ExecuteNonQuery();
                        tbxName.Text = null;
                        tbxColor.Text = null;

                        ReloadData(dataGridView1.CurrentRow.Index);
                        BorderColorReset();
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Cells["status_statuses"].Value.ToString() == "Готов")
            {
                MessageBox.Show("Этот статус невозможно удалить.", "Статусы",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (Convert.ToInt32(dataGridView1.CurrentRow.Cells["archive_statuses"].Value) == 1)
            {
                Archive("Вы действительно хотите восстановить этот статус?", 0);
                return;
            }

            DialogResult dr = MessageBox.Show("Вы действительно хотите удалить этот статус?", "Статусы",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (dr == DialogResult.Yes)
            {
                using (MySqlConnection connection = new MySqlConnection(Settings.Default.dbConnection))
                {
                    int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id_statuses"].Value);
                    string mySqlExpression = $"DELETE FROM tbl_statuses WHERE id = '{ id }'";

                    using (MySqlCommand command = new MySqlCommand(mySqlExpression, connection))
                    {
                        connection.Open();

                        try
                        {
                            command.ExecuteNonQuery();
                            ReloadData(0);
                        }
                        catch (MySqlException ex) when (ex.Number == 1451)
                        {
                            Archive("Этот статус где-то назначен, добавить его в архив?", 1);
                        }
                    }
                }
            }
        }

        private void Archive(string message, byte archive)
        {
            DialogResult dr = MessageBox.Show(message, "Статусы",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (dr == DialogResult.Yes)
            {
                string id = dataGridView1.CurrentRow.Cells["id_statuses"].Value.ToString();

                using (MySqlConnection connection = new MySqlConnection(Settings.Default.dbConnection))
                {
                    string mySqlExpression = "UPDATE tbl_statuses " +
                        "SET archive = @archive " +
                        $"WHERE id = '{ id }'";

                    using (MySqlCommand command = new MySqlCommand(mySqlExpression, connection))
                    {
                        connection.Open();

                        command.Parameters.Add("@archive", MySqlDbType.Byte).Value = archive;

                        command.ExecuteNonQuery();
                        cbxShow_SelectionChangeCommitted(null, null);
                    }
                }
            }
        }

        private bool RowsCountNotNull()
        {
            if (dataGridView1.Rows.Count > 0)
            {
                btnDelete.Visible = true;
                btnEdit.Visible = true;
                return true;
            }
            else
            {
                btnDelete.Visible = false;
                btnEdit.Visible = false;
                return false;
            }
        }
    }
}
