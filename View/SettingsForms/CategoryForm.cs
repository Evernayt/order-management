using MySql.Data.MySqlClient;
using Order_Management.Database;
using Order_Management.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Order_Management.View.SettingsForms
{
    public partial class CategoryForm : Form
    {
        private MySqlDataAdapter dataAdapter;
        private DataTable dataTable;

        private readonly Colors color = new Colors();

        List<(Control, Label)> controls = new List<(Control, Label)>();

        public CategoryForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Загружает категории с БД.
        /// </summary>
        private void LoadData()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(Settings.Default.dbConnection))
                {
                    string mySqlExpression = "SELECT * FROM tbl_categories WHERE archive = 0";
                    dataAdapter = new MySqlDataAdapter(mySqlExpression, connection);
                    dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
            }
            catch { }
        }

        /// <summary>
        /// Перезагружает заказы с БД.
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
                if (Convert.ToInt32(row.Cells["archive_categories"].Value) == 1)
                {
                    row.DefaultCellStyle.ForeColor = Color.DarkGray;
                    row.DefaultCellStyle.SelectionForeColor = Color.DarkGray;
                }
            }
        }

        public void FormLoad()
        {
            #region Связываем текстовые окна с заголовками
            controls.Add((tbxCategory, lblCategoryTitle));
            controls.Add((tbxFolderName, lblFolderNameTitle));
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
            tbxCategory.BorderColor = color.BorderGray;
            tbxCategory.HoverState.BorderColor = color.BorderGray;
            tbxCategory.FocusedState.BorderColor = color.BorderBlack;

            tbxFolderName.BorderColor = color.BorderGray;
            tbxFolderName.HoverState.BorderColor = color.BorderGray;
            tbxFolderName.FocusedState.BorderColor = color.BorderBlack;
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            string regexSearch = Regex.Replace(tbxSearch.Text, @"[['%*]", "  ");
            dataTable.DefaultView.RowFilter = string.Format("category Like '%{0}%' OR folder_name Like '%{0}%'", regexSearch);
        }

        private void cbxShow_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string mySqlExpression = "";

            using (MySqlConnection connection = new MySqlConnection(Settings.Default.dbConnection))
            {
                switch (cbxShow.SelectedIndex)
                {
                    case 0: mySqlExpression = "SELECT * FROM tbl_categories WHERE archive = 0"; break;
                    case 1: mySqlExpression = "SELECT * FROM tbl_categories WHERE archive = 1"; break;
                    case 2: mySqlExpression = "SELECT * FROM tbl_categories"; break;
                }

                dataAdapter = new MySqlDataAdapter(mySqlExpression, connection);
                ReloadData(0);

                btnDelete.Text = RowsCountNotNull() && Convert.ToInt32(dataGridView1.CurrentRow.Cells["archive_categories"].Value) == 0 ?
                    "Удалить" : "Восстановить";
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
                btnDelete.Text = Convert.ToInt32(dataGridView1.CurrentRow.Cells["archive_categories"].Value) == 0 ?
                "Удалить" : "Восстановить";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            #region Меняет цвет обводки поля, если не введено значение
            if (tbxCategory.Text == "" || tbxFolderName.Text == "")
            {
                BorderColorReset();

                if (tbxCategory.Text == "")
                {
                    tbxCategory.BorderColor = color.Red;
                    tbxCategory.HoverState.BorderColor = color.Red;
                    tbxCategory.FocusedState.BorderColor = color.Red;
                }

                if (tbxFolderName.Text == "")
                {
                    tbxFolderName.BorderColor = color.Red;
                    tbxFolderName.HoverState.BorderColor = color.Red;
                    tbxFolderName.FocusedState.BorderColor = color.Red;
                }
            }
            #endregion
            else
            {
                using (MySqlConnection connection = new MySqlConnection(Settings.Default.dbConnection))
                {
                    string mySqlExpression = "INSERT INTO tbl_categories (category, folder_name) " +
                    "VALUES (@category, @folder_name)";

                    using (MySqlCommand command = new MySqlCommand(mySqlExpression, connection))
                    {
                        connection.Open();

                        command.Parameters.Add("@category", MySqlDbType.VarChar).Value = tbxCategory.Text;
                        command.Parameters.Add("@folder_name", MySqlDbType.Text).Value = tbxFolderName.Text;

                        command.ExecuteNonQuery();

                        tbxCategory.Text = null;
                        tbxFolderName.Text = null;

                        ReloadData(0);
                        BorderColorReset();
                    }
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            #region Меняет цвет обводки поля, если не введено значение
            if (tbxCategory.Text == "" && tbxFolderName.Text == "")
            {
                tbxCategory.BorderColor = color.Red;
                tbxCategory.HoverState.BorderColor = color.Red;
                tbxCategory.FocusedState.BorderColor = color.Red;

                tbxFolderName.BorderColor = color.Red;
                tbxFolderName.HoverState.BorderColor = color.Red;
                tbxFolderName.FocusedState.BorderColor = color.Red;
            }
            #endregion
            else
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id_categories"].Value);

                using (MySqlConnection connection = new MySqlConnection(Settings.Default.dbConnection))
                {
                    string mySqlExpression = "UPDATE tbl_categories " +
                        "SET category = @category, folder_name = @folder_name " +
                        $"WHERE id = '{ id }'";

                    using (MySqlCommand command = new MySqlCommand(mySqlExpression, connection))
                    {
                        connection.Open();

                        command.Parameters.Add("@category", MySqlDbType.VarChar).Value = tbxCategory.Text == "" ?
                            dataGridView1.CurrentRow.Cells["category_categories"].Value.ToString() :
                            tbxCategory.Text;

                        command.Parameters.Add("@folder_name", MySqlDbType.Text).Value = tbxFolderName.Text == "" ?
                            dataGridView1.CurrentRow.Cells["folder_name_categories"].Value.ToString() :
                            tbxFolderName.Text;

                        command.ExecuteNonQuery();

                        tbxCategory.Text = null;
                        tbxFolderName.Text = null;

                        ReloadData(dataGridView1.CurrentRow.Index);
                        BorderColorReset();
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(dataGridView1.CurrentRow.Cells["archive_categories"].Value) == 1)
            {
                Archive("Вы действительно хотите восстановить эту категорию?", 0);
                return;
            }

            DialogResult dr = MessageBox.Show("Вы действительно хотите удалить эту категорию?", "Категории",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (dr == DialogResult.Yes)
            {
                using (MySqlConnection connection = new MySqlConnection(Settings.Default.dbConnection))
                {
                    int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id_categories"].Value);
                    string mySqlExpression = $"DELETE FROM tbl_categories WHERE id = '{ id }'";

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
                            Archive("Эта категория где-то назначена, добавить ее в архив?", 1);
                        }
                    }
                }
            }
        }

        private void Archive(string message, byte archive)
        {
            DialogResult dr = MessageBox.Show(message, "Категории",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (dr == DialogResult.Yes)
            {
                string id = dataGridView1.CurrentRow.Cells["id_categories"].Value.ToString();

                using (MySqlConnection connection = new MySqlConnection(Settings.Default.dbConnection))
                {
                    string mySqlExpression = "UPDATE tbl_categories " +
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
