using MySql.Data.MySqlClient;
using Order_Management.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Order_Management
{
    public partial class ServicesTreeForm : Form
    {
        List<(string, string)> services = new List<(string, string)>();
        List<(string, string)> types = new List<(string, string)>();

        public ServicesTreeForm()
        {
            InitializeComponent();

            myDataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 9.25F);
            myDataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 9.25F);
        }

        private void ServicesTreeForm_Load(object sender, EventArgs e)
        {
            myDataGridView1.Columns["Service"].HeaderCell.Style.Padding = new Padding(30, 0, 0, 0);

            LoadServices();
            LoadCategories();
        }

        private void LoadServices()
        {
            using (MySqlConnection connection = new MySqlConnection(Settings.Default.dbConnection))
            {
                connection.Open();

                string mySqlExpression = "SELECT tbl_types.type, service " +
                    "FROM tbl_all_services " +
                    "INNER JOIN tbl_types ON id_type = tbl_types.id";

                using (MySqlCommand command = new MySqlCommand(mySqlExpression, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                        while (reader.Read())
                            services.Add((reader["type"].ToString(), reader["service"].ToString()));
                }
            }
        }

        private void LoadCategories()
        {
            using (MySqlConnection connection = new MySqlConnection(Settings.Default.dbConnection))
            {
                connection.Open();

                string mySqlExpression = "SELECT tbl_categories.category, type " +
                    "FROM tbl_types " +
                    "INNER JOIN tbl_categories ON id_category = tbl_categories.id " +
                    "WHERE tbl_types.archive = 0";

                using (MySqlCommand command = new MySqlCommand(mySqlExpression, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                        while (reader.Read())
                            types.Add((reader["category"].ToString(), reader["type"].ToString()));
                }
            }

            // Удаляем дублирующиеся категории из таблицы tbl_types
            string[] categories = types.Select(x => x.Item1).Distinct().ToArray();

            // Создаем категории (Фотопечать, Сублимация...)
            for (int i = 0; i < categories.Length; i++)
            {
                tvServices.Nodes.Add(categories[i]);
                tvServices.Nodes[i].Tag = "category";
            }

            // Добавляем подкатегории, т.е. типы из таблицы tbl_types (10х15, 30х40...)
            for (int i = 0; i < types.Count; i++)
                foreach (TreeNode node in tvServices.Nodes)
                    if (node.Text == types[i].Item1)
                        node.Nodes.Add(types[i].Item2);
        }

        private void tvServices_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Tag == null)
            {
                myDataGridView1.Rows.Clear();

                foreach ((string type, string service) in services)
                    if (type == e.Node.Text)
                        myDataGridView1.Rows.Add(service);
            }
            else
            {
                //e.Node.Expand();
                myDataGridView1.Rows.Clear();
            }
        }

        private void ServicesTreeForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
                Close();
        }

        private void myDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex != -1)
            {
                NewOrderForm.newOrderForm.tbxServiceSearch.Text = myDataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                NewOrderForm.newOrderForm.ServiceSelected();
                Close();
            }
        }
    }
}
