using System;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;
using Order_Management.Properties;
using System.Collections.Generic;
using Order_Management.Database;

namespace Order_Management.View.SettingsForms
{
    public partial class TypeForm : Form
    {
        private MySqlDataAdapter dataAdapter;
        private DataTable dataTable;

        private readonly Colors color = new Colors();

        List<(Control, Label)> controls = new List<(Control, Label)>();

        public TypeForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Загружает типы с БД.
        /// </summary>
        private void LoadData()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(Settings.Default.dbConnection))
                {
                    string mySqlExpression = "SELECT tbl_types.id, tbl_categories.category, type, tbl_types.archive " +
                    "FROM tbl_types " +
                    "INNER JOIN tbl_categories ON id_category = tbl_categories.id " +
                    "WHERE tbl_types.archive = 0";

                    dataAdapter = new MySqlDataAdapter(mySqlExpression, connection);
                    dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
            }
            catch { }
        }

        /// <summary>
        /// Перезагружает типы с БД.
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
                if (Convert.ToInt32(row.Cells["archive_types"].Value) == 1)
                {
                    row.DefaultCellStyle.ForeColor = Color.DarkGray;
                    row.DefaultCellStyle.SelectionForeColor = Color.DarkGray;
                }
            }
        }

        /// <summary>
        /// Загружает категории с БД для cbxCategories.
        /// </summary>
        private void LoadData_Categories()
        {
            try
            {
                string mySqlExpression = "SELECT id, category FROM tbl_categories";
                using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(mySqlExpression, Settings.Default.dbConnection))
                {
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    cbxCategories.DataSource = dataTable;
                    cbxCategories.DisplayMember = "category";
                    cbxCategories.ValueMember = "id";
                }
            }
            catch { }
        }

        public void FormLoad()
        {
            #region Связываем текстовые окна с заголовками
            controls.Add((tbxType, lblTypeTitle));
            controls.Add((cbxCategories, lblCategoriesTitle));
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
            LoadData_Categories();
        }

        private void BorderColorReset()
        {
            tbxType.BorderColor = color.BorderGray;
            tbxType.HoverState.BorderColor = color.BorderGray;
            tbxType.FocusedState.BorderColor = color.BorderBlack;
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            string regexSearch = Regex.Replace(tbxSearch.Text, @"[['%*]", "  ");
            dataTable.DefaultView.RowFilter = string.Format("type Like '%{0}%' OR category Like '%{0}%'", regexSearch);
        }

        private void cbxShow_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string mode = "";

            using (MySqlConnection connection = new MySqlConnection(Settings.Default.dbConnection))
            {
                switch (cbxShow.SelectedIndex)
                {
                    case 0: mode = "WHERE tbl_types.archive = 0"; break;
                    case 1: mode = "WHERE tbl_types.archive = 1"; break;
                    case 2: mode = ""; break;
                }

                string mySqlExpression = "SELECT tbl_types.id, tbl_categories.category, type, tbl_types.archive " +
                    "FROM tbl_types " +
                    $"INNER JOIN tbl_categories ON id_category = tbl_categories.id { mode }";

                dataAdapter = new MySqlDataAdapter(mySqlExpression, connection);
                ReloadData(0);

                btnDelete.Text = RowsCountNotNull() && Convert.ToInt32(dataGridView1.CurrentRow.Cells["archive_types"].Value) == 0 ?
                    "Удалить" : "Восстановить";
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
                btnDelete.Text = Convert.ToInt32(dataGridView1.CurrentRow.Cells["archive_types"].Value) == 0 ?
                "Удалить" : "Восстановить";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            #region Меняет цвет обводки поля, если не введено значение
            if (tbxType.Text == "")
            {
                tbxType.BorderColor = color.Red;
                tbxType.HoverState.BorderColor = color.Red;
                tbxType.FocusedState.BorderColor = color.Red;
            }
            #endregion
            else
            {
                using (MySqlConnection connection = new MySqlConnection(Settings.Default.dbConnection))
                {
                    string mySqlExpression = "INSERT INTO tbl_types (id_category, type) " +
                    "VALUES (@id_category, @type)";

                    using (MySqlCommand command = new MySqlCommand(mySqlExpression, connection))
                    {
                        connection.Open();

                        command.Parameters.Add("@id_category", MySqlDbType.Int32).Value = cbxCategories.SelectedValue;
                        command.Parameters.Add("@type", MySqlDbType.VarChar).Value = tbxType.Text;

                        command.ExecuteNonQuery();
                        tbxType.Text = null;

                        ReloadData(0);
                        BorderColorReset();
                    }
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string id = dataGridView1.CurrentRow.Cells["id_types"].Value.ToString();

            using (MySqlConnection connection = new MySqlConnection(Settings.Default.dbConnection))
            {
                string mySqlExpression = "UPDATE tbl_types " +
                    "SET id_category = @id_category, type = @type " +
                    $"WHERE id = '{ id }'";

                using (MySqlCommand command = new MySqlCommand(mySqlExpression, connection))
                {
                    connection.Open();

                    command.Parameters.Add("@id_category", MySqlDbType.Int32).Value = cbxCategories.SelectedValue;
                    command.Parameters.Add("@type", MySqlDbType.VarChar).Value = tbxType.Text == "" ?
                        dataGridView1.CurrentRow.Cells["type_types"].Value.ToString() : tbxType.Text;

                    command.ExecuteNonQuery();
                    tbxType.Text = null;

                    ReloadData(dataGridView1.CurrentRow.Index);
                    BorderColorReset();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(dataGridView1.CurrentRow.Cells["archive_types"].Value) == 1)
            {
                Archive("Вы действительно хотите восстановить этот тип?", 0);
                return;
            }

            DialogResult dr = MessageBox.Show("Вы действительно хотите удалить этот тип?", "Типы",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (dr == DialogResult.Yes)
            {
                using (MySqlConnection connection = new MySqlConnection(Settings.Default.dbConnection))
                {
                    int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id_types"].Value);
                    string mySqlExpression = $"DELETE FROM tbl_types WHERE id = '{ id }'";

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
                            Archive("Этот тип где-то назначен, добавить его в архив?", 1);
                        }
                    }
                }
            }
        }

        private void Archive(string message, byte archive)
        {
            DialogResult dr = MessageBox.Show(message, "Типы",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (dr == DialogResult.Yes)
            {
                string id = dataGridView1.CurrentRow.Cells["id_types"].Value.ToString();

                using (MySqlConnection connection = new MySqlConnection(Settings.Default.dbConnection))
                {
                    string mySqlExpression = "UPDATE tbl_types " +
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
