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
    public partial class EmployeeForm : Form
    {
        private MySqlDataAdapter dataAdapter;
        private DataTable dataTable;

        private readonly Colors color = new Colors();

        List<(Control, Label)> controls = new List<(Control, Label)>();

        public EmployeeForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Загружает список сотрудников с БД.
        /// </summary>
        private void LoadData()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(Settings.Default.dbConnection))
                {
                    string mySqlExpression = "SELECT * FROM tbl_employees WHERE id != 1 AND id != 3 AND archive = 0";
                    dataAdapter = new MySqlDataAdapter(mySqlExpression, connection);
                    dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
            }
            catch { }
        }

        /// <summary>
        /// Перезагружает список сотрудников с БД.
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
                if (Convert.ToInt32(row.Cells["archive_employee"].Value) == 1)
                {
                    row.DefaultCellStyle.ForeColor = Color.DarkGray;
                    row.DefaultCellStyle.SelectionForeColor = Color.DarkGray;
                }
            }
        }

        public void FormLoad()
        {
            #region Связываем текстовые окна с заголовками
            controls.Add((tbxName, lblNameTitle));
            controls.Add((tbxLogin, lblLoginTitle));
            controls.Add((tbxPass, lblPassTitle));
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

            tbxPass.BorderColor = color.BorderGray;
            tbxPass.HoverState.BorderColor = color.BorderGray;
            tbxPass.FocusedState.BorderColor = color.BorderBlack;

            tbxLogin.BorderColor = color.BorderGray;
            tbxLogin.HoverState.BorderColor = color.BorderGray;
            tbxLogin.FocusedState.BorderColor = color.BorderBlack;
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            string regexSearch = Regex.Replace(tbxSearch.Text, @"[['%*]", "  ");
            dataTable.DefaultView.RowFilter = string.Format("name_employee Like '%{0}%' OR login Like '%{0}%' OR pass Like '%{0}%'", regexSearch);
        }

        private void cbxShow_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string mySqlExpression = "";

            using (MySqlConnection connection = new MySqlConnection(Settings.Default.dbConnection))
            {
                switch (cbxShow.SelectedIndex)
                {
                    case 0: mySqlExpression = "SELECT * FROM tbl_employees WHERE id != 1 AND id != 3 AND archive = 0"; break;
                    case 1: mySqlExpression = "SELECT * FROM tbl_employees WHERE id != 1 AND id != 3 AND archive = 1"; break;
                    case 2: mySqlExpression = "SELECT * FROM tbl_employees WHERE id != 1 AND id != 3"; break;
                }

                dataAdapter = new MySqlDataAdapter(mySqlExpression, connection);
                ReloadData(0);

                btnDelete.Text = RowsCountNotNull() && Convert.ToInt32(dataGridView1.CurrentRow.Cells["archive_employee"].Value) == 0 ?
                    "Удалить" : "Восстановить";
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
                btnDelete.Text = Convert.ToInt32(dataGridView1.CurrentRow.Cells["archive_employee"].Value) == 0 ?
                "Удалить" : "Восстановить";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            #region Меняет цвет обводки поля, если не введено значение
            if (tbxName.Text == "" || tbxLogin.Text == "" || tbxPass.Text == "")
            {
                BorderColorReset();

                if (tbxName.Text == "")
                {
                    tbxName.BorderColor = color.Red;
                    tbxName.HoverState.BorderColor = color.Red;
                    tbxName.FocusedState.BorderColor = color.Red;
                }

                if (tbxLogin.Text == "")
                {
                    tbxLogin.BorderColor = color.Red;
                    tbxLogin.HoverState.BorderColor = color.Red;
                    tbxLogin.FocusedState.BorderColor = color.Red;
                }

                if (tbxPass.Text == "")
                {
                    tbxPass.BorderColor = color.Red;
                    tbxPass.HoverState.BorderColor = color.Red;
                    tbxPass.FocusedState.BorderColor = color.Red;
                }
            }
            #endregion
            else
            {
                using (MySqlConnection connection = new MySqlConnection(Settings.Default.dbConnection))
                {
                    string mySqlExpression = "INSERT INTO tbl_employees (name_employee, login, pass, permission) " +
                        "VALUES (@name_employee, @login, @pass, @permission)";

                    using (MySqlCommand command = new MySqlCommand(mySqlExpression, connection))
                    {
                        connection.Open();

                        command.Parameters.Add("@name_employee", MySqlDbType.VarChar).Value = tbxName.Text;
                        command.Parameters.Add("@login", MySqlDbType.VarChar).Value = tbxLogin.Text;
                        command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = tbxPass.Text;
                        command.Parameters.Add("@permission", MySqlDbType.Byte).Value = cbxPermission.SelectedIndex;

                        try
                        {
                            command.ExecuteNonQuery();
                            ReloadData(0);
                            tbxName.Text = null;
                            tbxLogin.Text = null;
                            tbxPass.Text = null;
                            BorderColorReset();
                        }
                        catch (MySqlException ex) when (ex.Number == 1062)
                        {
                            MessageBox.Show("Имя или логин уже используются.\nПожалуйста, укажите другой.",
                                "Сотрудники", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            #region Меняет цвет обводки поля, если не введено значение
            if (tbxName.Text == "" && tbxLogin.Text == "" && tbxPass.Text == "")
            {
                tbxName.BorderColor = color.Red;
                tbxName.HoverState.BorderColor = color.Red;
                tbxName.FocusedState.BorderColor = color.Red;

                tbxLogin.BorderColor = color.Red;
                tbxLogin.HoverState.BorderColor = color.Red;
                tbxLogin.FocusedState.BorderColor = color.Red;

                tbxPass.BorderColor = color.Red;
                tbxPass.HoverState.BorderColor = color.Red;
                tbxPass.FocusedState.BorderColor = color.Red;
            }
            #endregion
            else
            {
                string id = dataGridView1.CurrentRow.Cells["id_employee"].Value.ToString();

                using (MySqlConnection connection = new MySqlConnection(Settings.Default.dbConnection))
                {
                    string mySqlExpression = "UPDATE tbl_employees SET name_employee = @name_employee, login = @login, pass = @pass, permission = @permission " +
                     $"WHERE id = '{ id }'";

                    using (MySqlCommand command = new MySqlCommand(mySqlExpression, connection))
                    {
                        connection.Open();

                        command.Parameters.Add("@name_employee", MySqlDbType.VarChar).Value = tbxName.Text == "" ?
                            dataGridView1.SelectedRows[0].Cells["name_employee"].Value.ToString() : tbxName.Text;

                        command.Parameters.Add("@login", MySqlDbType.VarChar).Value = tbxLogin.Text == "" ?
                            dataGridView1.SelectedRows[0].Cells["login_employee"].Value.ToString() : tbxLogin.Text;

                        command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = tbxPass.Text == "" ?
                            dataGridView1.SelectedRows[0].Cells["pass_employee"].Value.ToString() : tbxPass.Text;

                        command.Parameters.Add("@permission", MySqlDbType.Byte).Value = cbxPermission.SelectedIndex;

                        try
                        {
                            command.ExecuteNonQuery();
                            ReloadData(dataGridView1.CurrentRow.Index);
                            tbxName.Text = null;
                            tbxLogin.Text = null;
                            tbxPass.Text = null;

                            BorderColorReset();
                        }
                        catch (MySqlException ex) when (ex.Number == 1062)
                        {
                            MessageBox.Show("Имя или логин уже используются.\nПожалуйста, укажите другой.",
                                "Сотрудники", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(dataGridView1.CurrentRow.Cells["archive_employee"].Value) == 1)
            {
                Archive("Вы действительно хотите восстановить этого сотрудника?", 0);
                return;
            }
            else if (Convert.ToInt32(dataGridView1.CurrentRow.Cells["id_employee"].Value) == 2)
            {
                MessageBox.Show("Данного сотрудника нельзя удалить,\nтак как он системный.",
                    "Сотрудники", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dr = MessageBox.Show($"Вы действительно хотите удалить этого сотрудника?", "Сотрудники",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (dr == DialogResult.Yes)
            {
                using (MySqlConnection connection = new MySqlConnection(Settings.Default.dbConnection))
                {
                    int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id_employee"].Value);
                    string mySqlExpression = $"DELETE FROM tbl_employees WHERE id = '{ id }'";

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
                            Archive("Этот сотрудник где-то назначен, добавить его в архив?", 1);
                        }
                    }
                }
            }
        }

        private void Archive(string message, byte archive)
        {
            DialogResult dr = MessageBox.Show(message, "Сотрудники",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (dr == DialogResult.Yes)
            {
                string id = dataGridView1.CurrentRow.Cells["id_employee"].Value.ToString();

                using (MySqlConnection connection = new MySqlConnection(Settings.Default.dbConnection))
                {
                    string mySqlExpression = "UPDATE tbl_employees " +
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
