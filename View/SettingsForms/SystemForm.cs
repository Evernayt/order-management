using MySql.Data.MySqlClient;
using Order_Management.Database;
using Order_Management.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace Order_Management.View.SettingsForms
{
    public partial class SystemForm : Form
    {
        private readonly Colors color = new Colors();

        List<(Control, Label)> controls = new List<(Control, Label)>();

        public SystemForm()
        {
            InitializeComponent();
        }

        private void SystemForm_Load(object sender, EventArgs e)
        {
            #region Связываем текстовые окна с заголовками
            controls.Add((tbxMainFolder, lblMainFolderTitle));
            controls.Add((tbxCurrentMonth, lblCurrentMonthTitle));
            controls.Add((tbxServer, lblServerTitle));
            controls.Add((tbxUser, lblUserTitle));
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

            tbxMainFolder.Text = Settings.Default.MainFolder;
            tbxCurrentMonth.Text = Settings.Default.CurrentFolder;

            ConState();
            tbxConString.Text = Settings.Default.dbConnection;
        }

        private void ConState()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(Settings.Default.dbConnection))
                {
                    connection.Open();
                    lblOrdersConState.Text = "Online";
                    lblOrdersIndicator.ForeColor = Color.LimeGreen;
                }
            }
            catch
            {
                lblOrdersConState.Text = "Offline";
                lblOrdersIndicator.ForeColor = Color.FromArgb(244, 78, 78);
            }
        }

        private void BorderColorReset()
        {
            tbxServer.BorderColor = Color.Silver;
            tbxServer.HoverState.BorderColor = Color.DarkGray;
            tbxServer.FocusedState.BorderColor = Color.DarkGray;

            tbxUser.BorderColor = Color.Silver;
            tbxUser.HoverState.BorderColor = Color.DarkGray;
            tbxUser.FocusedState.BorderColor = Color.DarkGray;

            tbxPass.BorderColor = Color.Silver;
            tbxPass.HoverState.BorderColor = Color.DarkGray;
            tbxPass.FocusedState.BorderColor = Color.DarkGray;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Settings.Default.MainFolder = tbxMainFolder.Text;
            Settings.Default.CurrentFolder = tbxCurrentMonth.Text;
            Settings.Default.Save();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            #region Меняет цвет обводки поля, если не введено значение
            if (tbxServer.Text == "" || tbxUser.Text == "" || tbxPass.Text == "")
            {
                BorderColorReset();

                if (tbxServer.Text == "")
                {
                    tbxServer.BorderColor = Color.FromArgb(244, 78, 78);
                    tbxServer.HoverState.BorderColor = Color.FromArgb(244, 78, 78);
                    tbxServer.FocusedState.BorderColor = Color.FromArgb(244, 78, 78);
                }

                if (tbxUser.Text == "")
                {
                    tbxUser.BorderColor = Color.FromArgb(244, 78, 78);
                    tbxUser.HoverState.BorderColor = Color.FromArgb(244, 78, 78);
                    tbxUser.FocusedState.BorderColor = Color.FromArgb(244, 78, 78);
                }

                if (tbxPass.Text == "")
                {
                    tbxPass.BorderColor = Color.FromArgb(244, 78, 78);
                    tbxPass.HoverState.BorderColor = Color.FromArgb(244, 78, 78);
                    tbxPass.FocusedState.BorderColor = Color.FromArgb(244, 78, 78);
                }
            }
            #endregion
            else
            {
                string con = $"server={ tbxServer.Text };user id={ tbxUser.Text };password={ tbxPass.Text };persistsecurityinfo=True;convert zero datetime=True;database=db_order_management;charset=utf8";
                using (MySqlConnection connection = new MySqlConnection(con))
                {
                    try
                    {
                        connection.Open();

                        Settings.Default.dbConnection = con;
                        lblOrdersConState.Text = "Online";
                        lblOrdersIndicator.ForeColor = Color.LimeGreen;

                        Settings.Default.Save();
                        tbxConString.Text = Settings.Default.dbConnection;

                        lblError.Visible = false;

                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex + "Test");
                        lblError.Text = "Подключение не установлено";
                        lblError.Visible = true;
                    }
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Вы действительно хотите сбросить настройки?", "Сброс настроек",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (dr == DialogResult.Yes)
            {
                Settings.Default.Reset();
                MessageBox.Show("Настройки успешно сброшены.", "Сброс настроек", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnUnlock_Click(object sender, EventArgs e)
        {
            if (tbxPassLock.Text == "default_password")
            {
                pAccess.Visible = false;
            }
            else if (tbxPassLock.Text == "")
            {
                lblErrorPassLock.Visible = true;
                lblErrorPassLock.Text = "Введите пароль";
                tbxPassLock.BorderColor = color.Red;
                tbxPassLock.HoverState.BorderColor = color.Red;
                tbxPassLock.FocusedState.BorderColor = color.Red;
                tbxPassLock.Focus();
            }
            else
            {
                lblErrorPassLock.Visible = true;
                lblErrorPassLock.Text = "Неверный пароль, попробуйте ещё раз";
                tbxPassLock.BorderColor = color.Red;
                tbxPassLock.HoverState.BorderColor = color.Red;
                tbxPassLock.FocusedState.BorderColor = color.Red;
                tbxPassLock.Focus();
            }
        }

        private void tbxPassLock_Enter(object sender, EventArgs e)
        {
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("en-us"));
            lblPassTitleLock.ForeColor = color.AccentBlue;
        }

        private void tbxPassLock_Leave(object sender, EventArgs e)
        {
            lblPassTitleLock.ForeColor = color.BorderBlack;
        }

        private void tbxPassLock_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnUnlock.PerformClick();
        }

        public void isUnlocked()
        {
            guna2ControlBox1.Hide();
            guna2DragControl1.TargetControl = null;
            pAccess.Hide();
            pMain.BorderThickness = 0;
        }
    }
}
