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
    public partial class ServiceForm : Form
    {
        private MySqlDataAdapter dataAdapter;
        private DataTable dataTable;

        private readonly Colors color = new Colors();

        List<(Control, Label)> controls = new List<(Control, Label)>();
        List<(int, int, string)> types = new List<(int, int, string)>();

        public ServiceForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Загружает услуги с БД.
        /// </summary>
        private void LoadData()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(Settings.Default.dbConnection))
                {
                    string mySqlExpression = "SELECT tbl_all_services.id, tbl_categories.category, tbl_types.type, service " +
                    "FROM tbl_all_services " +
                    "INNER JOIN tbl_categories ON id_category = tbl_categories.id " +
                    "INNER JOIN tbl_types ON id_type = tbl_types.id";

                    dataAdapter = new MySqlDataAdapter(mySqlExpression, connection);
                    dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
            }
            catch { }
        }

        /// <summary>
        /// Перезагружает услуги с БД.
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
            }
            catch { }
        }

        /// <summary>
        /// Загружает категории с БД для cbxCategories.
        /// </summary>
        private void LoadData_Categories()
        {
            try
            {
                string mySqlExpression = "SELECT id, category FROM tbl_categories WHERE archive = 0";
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

        /// <summary>
        /// Загружает типы с БД для cbxTypes.
        /// </summary>
        private void LoadData_Types()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(Settings.Default.dbConnection))
                {
                    connection.Open();

                    string mySqlExpression = "SELECT * FROM tbl_types WHERE archive = 0";

                    using (MySqlCommand command = new MySqlCommand(mySqlExpression, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                            while (reader.Read())
                                types.Add((Convert.ToInt32(reader["id"]), Convert.ToInt32(reader["id_category"]), reader["type"].ToString()));
                    }
                }
            }
            catch { }
        }

        public void FormLoad()
        {
            #region Связываем текстовые окна с заголовками
            controls.Add((tbxService, lblServiceTitle));
            controls.Add((cbxCategories, lblCategoriesTitle));
            controls.Add((cbxTypes, lblTypesTitle));
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
            LoadData_Types();
            LoadData_Categories();
            cbxCategories_SelectionChangeCommitted(null, null);
        }

        private void BorderColorReset()
        {
            tbxService.BorderColor = color.BorderGray;
            tbxService.HoverState.BorderColor = color.BorderGray;
            tbxService.FocusedState.BorderColor = color.BorderBlack;
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            string regexSearch = Regex.Replace(tbxSearch.Text, @"[['%*]", "  ");
            dataTable.DefaultView.RowFilter = string.Format("service Like '%{0}%' OR category Like '%{0}%' OR type Like '%{0}%'", regexSearch);
        }

        private void cbxShow_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void cbxCategories_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cbxTypes.Items.Clear();
            foreach ((_, int id_category, string type) in types)
                if (id_category == Convert.ToInt32(cbxCategories.SelectedValue))
                    cbxTypes.Items.Add(type);
            cbxTypes.StartIndex = 0;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            #region Меняет цвет обводки поля, если не введено значение
            if (tbxService.Text == "")
            {
                tbxService.BorderColor = color.Red;
                tbxService.HoverState.BorderColor = color.Red;
                tbxService.FocusedState.BorderColor = color.Red;
            }
            #endregion
            else
            {
                using (MySqlConnection connection = new MySqlConnection(Settings.Default.dbConnection))
                {
                    string mySqlExpression = "INSERT INTO tbl_all_services (id_category, id_type, service) " +
                    "VALUES (@id_category, @id_type, @service)";

                    using (MySqlCommand command = new MySqlCommand(mySqlExpression, connection))
                    {
                        connection.Open();

                        command.Parameters.Add("@id_category", MySqlDbType.Int32).Value = cbxCategories.SelectedValue;

                        foreach ((int id, _, string type) in types)
                            if (cbxTypes.Text == type)
                                command.Parameters.Add("@id_type", MySqlDbType.Int32).Value = id;

                        command.Parameters.Add("@service", MySqlDbType.Text).Value = tbxService.Text;

                        command.ExecuteNonQuery();
                        tbxService.Text = null;

                        ReloadData(0);
                        BorderColorReset();
                    }
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string id = dataGridView1.CurrentRow.Cells["id_services"].Value.ToString();

            using (MySqlConnection connection = new MySqlConnection(Settings.Default.dbConnection))
            {
                string mySqlExpression = "UPDATE tbl_all_services " +
                    "SET id_category = @id_category, id_type = @id_type, service = @service " +
                    $"WHERE id = '{ id }'";

                using (MySqlCommand command = new MySqlCommand(mySqlExpression, connection))
                {
                    connection.Open();

                    command.Parameters.Add("@id_category", MySqlDbType.Int32).Value = cbxCategories.SelectedValue;

                    foreach ((int id2, _, string type) in types)
                        if (cbxTypes.Text == type)
                            command.Parameters.Add("@id_type", MySqlDbType.Int32).Value = id2;

                    command.Parameters.Add("@service", MySqlDbType.Text).Value = tbxService.Text == "" ?
                        dataGridView1.CurrentRow.Cells["service_services"].Value.ToString() : tbxService.Text;

                    command.ExecuteNonQuery();
                    tbxService.Text = null;

                    ReloadData(dataGridView1.CurrentRow.Index);
                    BorderColorReset();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Вы действительно хотите удалить эту услугу?", "Услуги",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (dr == DialogResult.Yes)
            {
                using (MySqlConnection connection = new MySqlConnection(Settings.Default.dbConnection))
                {
                    int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id_services"].Value);
                    string mySqlExpression = $"DELETE FROM tbl_all_services WHERE id = '{ id }'";

                    using (MySqlCommand command = new MySqlCommand(mySqlExpression, connection))
                    {
                        connection.Open();

                        command.ExecuteNonQuery();
                        ReloadData(0);
                    }
                }
            }
        }
    }
}
