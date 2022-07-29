using Order_Management.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Order_Management
{
    public partial class ClientsForm : Form
    {
        private DataTable dataTable;

        private int socialCurrent;

        private readonly Colors color = new Colors();
        List<(LinkLabel, byte)> social = new List<(LinkLabel, byte)>();
        List<string> socialUrl = new List<string>();

        public static ClientsForm clientsForm = null;

        public ClientsForm()
        {
            clientsForm = this;
            InitializeComponent();

            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 9.25F);
            dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 9.25F);

            dataTable = Clients.LoadClients();
            dataGridView1.DataSource = dataTable;

            cbxShow_SelectionChangeCommitted(null, null);

            #region Social Networks
            for (int i = 0; i < 4; i++)
                socialUrl.Add("");

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
                            link2.Item1.LinkColor = color.BorderBlack;
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
            #endregion
        }

        /// <summary>
        /// Перезагружает данные клиентов с БД.
        /// </summary>
        /// <param name="row">Индекс строки для выделения.</param>
        public void ReloadData()
        {
            dataTable = Clients.ReloadClients();
            dataGridView1.DataSource = dataTable;

            //if (dataGridView1.Rows.Count != 0)
            //{
            //    dataGridView1.FirstDisplayedScrollingRowIndex = row;
            //    dataGridView1.Rows[row].Selected = true;
            //}

            RowColor();
        }

        public void RowColor()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (Convert.ToInt32(row.Cells["archive_clients"].Value) == 1)
                {
                    row.DefaultCellStyle.ForeColor = Color.DarkGray;
                    row.DefaultCellStyle.SelectionForeColor = Color.DarkGray;
                }
            }
        }

        private void HideErrorState()
        {
            sepPhone.FillColor = color.BorderGray;

            tbxName.BorderColor = color.BorderGray;
            tbxName.HoverState.BorderColor = color.BorderGray;
            tbxName.FocusedState.BorderColor = color.BorderBlack;
        }

        private string GetPhoneNonMask()
        {
            mtbxClientPhone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            string phoneNonMask = mtbxClientPhone.Text;
            mtbxClientPhone.TextMaskFormat = MaskFormat.IncludeLiterals;
            return phoneNonMask;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!mtbxClientPhone.MaskCompleted)
            {
                sepPhone.FillColor = color.Red;
            }
            else if (tbxName.Text == "")
            {
                HideErrorState();

                tbxName.BorderColor = color.Red;
                tbxName.HoverState.BorderColor = color.Red;
                tbxName.FocusedState.BorderColor = color.Red;
            }
            else
            {
                Clients.AddClient(tbxName.Text, GetPhoneNonMask(), btnWhatsApp.Checked, socialUrl[0], socialUrl[1], socialUrl[2], socialUrl[3]);

                tbxName.Text = null;
                mtbxClientPhone.Text = null;
                btnWhatsApp.Checked = false;
                socialUrl[0] = "";
                socialUrl[1] = "";
                socialUrl[2] = "";
                socialUrl[3] = "";
                tbxSocialNetwork.Text = null;

                ReloadData();
                HideErrorState();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (tbxName.Text == "" && !mtbxClientPhone.MaskCompleted && !btnWhatsApp.Checked && socialUrl[0] == "" && socialUrl[1] == "" && socialUrl[2] == "" && socialUrl[3] == "")
            {
                return;
            }
            else
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id_clients"].Value);
                string phone = mtbxClientPhone.MaskCompleted ? GetPhoneNonMask() : "";

                Clients.EditClient(id, tbxName.Text, phone, btnWhatsApp.Checked, socialUrl[0], socialUrl[1], socialUrl[2], socialUrl[3]);

                tbxName.Text = null;
                mtbxClientPhone.Text = null;
                btnWhatsApp.Checked = false;
                socialUrl[0] = "";
                socialUrl[1] = "";
                socialUrl[2] = "";
                socialUrl[3] = "";
                tbxSocialNetwork.Text = null;

                ReloadData();
                HideErrorState();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(dataGridView1.CurrentRow.Cells["archive_clients"].Value) == 1)
            {
                Archive("Вы действительно хотите восстановить этого клиента?", 0);
                return;
            }

            DialogResult dr = MessageBox.Show("Вы действительно хотите удалить этого клиента?", "Клиенты",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (dr == DialogResult.Yes)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id_clients"].Value);

                if (Clients.DeleteClient(id) == "1451")
                {
                    Archive("Этот клиент где-то назначен, добавить его в архив?", 1);
                }
                else
                {
                    ReloadData();
                }
            }
        }

        private void Archive(string message, byte archive)
        {
            DialogResult dr = MessageBox.Show(message, "Клиенты",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (dr == DialogResult.Yes)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id_clients"].Value);

                MainForm.mainForm.Notification(Clients.ClientArchive(id, archive));
                ReloadData();
                cbxShow_SelectionChangeCommitted(null, null);
            }
        }

        private void mtbxClientPhone_Enter(object sender, EventArgs e)
        {
            BeginInvoke((MethodInvoker)delegate () { mtbxClientPhone.Select(0, 0); });
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
        }

        private void tbxName_Enter(object sender, EventArgs e)
        {
            tbxName.ForeColor = color.AccentBlue;
        }

        private void tbxName_Leave(object sender, EventArgs e)
        {
            tbxName.ForeColor = color.BorderBlack;
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                if (e.Value is bool value)
                {
                    e.Value = (value) ? "Да" : "Нет";
                    e.FormattingApplied = true;
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

        private void cbxShow_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string archiveFilter = "";

            switch (cbxShow.SelectedIndex)
            {
                case 0: archiveFilter = string.Format("archive = 0"); break;
                case 1: archiveFilter = string.Format("archive = 1"); break;
                case 2: archiveFilter = string.Empty; break;
            }

            dataTable.DefaultView.RowFilter = archiveFilter;

            btnDelete.Text = RowsCountNotNull() && Convert.ToInt32(dataGridView1.CurrentRow.Cells["archive_clients"].Value) == 0 ?
                    "Удалить" : "Восстановить";

            RowColor();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
                btnDelete.Text = Convert.ToInt32(dataGridView1.CurrentRow.Cells["archive_clients"].Value) == 0 ?
                "Удалить" : "Восстановить";
        }

        public void SearchController(string regexSearch)
        {
            dataTable.DefaultView.RowFilter = string.Format("name Like '%{0}%' OR Convert([phone], 'System.String') Like '%{0}%' " +
                "OR Convert([vk], 'System.String') Like '%{0}%' OR Convert([instagram], 'System.String') Like '%{0}%' " +
                "OR Convert([telegram], 'System.String') Like '%{0}%' OR Convert([mail], 'System.String') Like '%{0}%'", regexSearch);
        }

        private void tbxSocialNetwork_Enter(object sender, EventArgs e)
        {
            social[socialCurrent].Item1.LinkColor = color.AccentBlue;
        }

        private void tbxSocialNetwork_Leave(object sender, EventArgs e)
        {
            social[socialCurrent].Item1.LinkColor = color.BorderBlack;
        }

        private void tbxSocialNetwork_TextChanged(object sender, EventArgs e)
        {
            socialUrl[socialCurrent] = tbxSocialNetwork.Text;
        }
    }
}
