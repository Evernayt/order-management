using System;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using Order_Management.Properties;
using Order_Management.Database;
using System.Collections.Generic;
using Guna.UI2.WinForms;
using Order_Management.View.SettingsForms;
using System.Threading.Tasks;
using System.Deployment.Application;

namespace Order_Management
{
    public partial class LoginForm : Form
    {
        private readonly Colors color = new Colors();

        List<(Guna2TextBox, Label, Label)> controls = new List<(Guna2TextBox, Label, Label)>();

        public LoginForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Свернуть/развернуть форму при нажатии на значок в панели задач
        /// </summary>
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style |= 0x20000;
                cp.ClassStyle |= 0x8;
                return cp;
            }
        }

        private async void State(string state, string fullState, Image image, bool confirm)
        {
            await Task.Run(() =>
            {
                ucUpdater1.lblState.Text = state;
                ucUpdater1.lblFullState.Text = fullState;
                ucUpdater1.pbxState.Image = image;
                ucUpdater1.btnConfirm.Visible = confirm;

                ucUpdater1.Visible = true;
                ucUpdater1.BringToFront();
            });
        }

        private async void CheckUpdate()
        {
            await Task.Run(() =>
            {
                if (ApplicationDeployment.IsNetworkDeployed)
                {
                    ApplicationDeployment ad = ApplicationDeployment.CurrentDeployment;

                    UpdateCheckInfo info;
                    try
                    {
                        info = ad.CheckForDetailedUpdate();

                    }
                    catch (DeploymentDownloadException dde)
                    {
                        State("Ошибка обновления",
                            "Новая версия приложения не может быть загружена в настоящее время." +
                            "\n\nПожалуйста, проверьте подключение к сети или повторите попытку позже. Ошибка: " + dde.Message,
                            Resources.warning_blink,
                            true);

                        return;
                    }
                    catch (InvalidDeploymentException ide)
                    {
                        State("Ошибка обновления",
                            "Невозможно проверить наличие новой версии приложения. Развертывание ClickOnce повреждено. " +
                            "Пожалуйста, повторно разверните приложение и попробуйте снова. Ошибка: " + ide.Message,
                            Resources.warning_blink,
                            true);

                        return;
                    }
                    catch (InvalidOperationException ioe)
                    {
                        State("Ошибка обновления",
                            "Это приложение не может быть обновлено. Скорее всего, это не приложение ClickOnce. Ошибка: " + ioe.Message,
                            Resources.warning_blink,
                            true);

                        return;
                    }

                    if (info.UpdateAvailable)
                    {
                        bool doUpdate = true;

                        if (!info.IsUpdateRequired)
                        {
                            State("Приложение обновляется",
                                "Новая версия загружается,\nпожалуйста подождите.",
                                Resources.installing_updates,
                                false);
                        }
                        else
                        {
                            // Display a message that the app MUST reboot. Display the minimum required version.
                            State("Приложение обновляется",
                                "Новая версия загружается,\nпожалуйста подождите.\n\n" +
                                "Это приложение обнаружило обязательное обновление вашей текущей " +
                                "версии до версии " + info.MinimumRequiredVersion.ToString(),
                                Resources.installing_updates,
                                false);
                        }

                        if (doUpdate)
                        {
                            try
                            {
                                ad.Update();

                                State("Обновление установлено",
                                    "Приложение было обновлено и теперь будет перезапущено.",
                                    Resources.check_circle,
                                    true);

                                ucUpdater1.restart = true;
                            }
                            catch (DeploymentDownloadException dde)
                            {
                                State("Ошибка обновления",
                                    "Не удается установить последнюю версию приложения. \n\nПожалуйста, проверьте подключение к сети или повторите попытку позже. " +
                                    "Ошибка: " + dde,
                                    Resources.warning_blink,
                                    true);

                                return;
                            }
                        }
                    }
                    //else if (!info.UpdateAvailable)
                    //{
                    //    MessageBox.Show("Нет доступных обновлений.", "Обновления", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //}
                }
            });
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            pbxAvatar.Image = LoadAvatar();
            
            CheckUpdate();

            #region Связываем текстовые окна с заголовками
            controls.Add((tbxLogin, lblLoginTitle, lblLoginError));
            controls.Add((tbxPass, lblPassTitle, lblPassError));
            
            foreach (var control in controls)
            {
                control.Item1.Enter += (s, a) =>
                {
                    CultureInfo en = new CultureInfo("en-us");
                    InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(en);
                    control.Item2.ForeColor = color.AccentBlue;
                };

                control.Item1.Leave += (s, a) =>
                {
                    control.Item2.ForeColor = color.BorderBlack;
                };
            }
            #endregion

            #region Указана ли основная директория
            if (Settings.Default.MainFolder == "")
            {
                DialogResult dr = MessageBox.Show("Необходимо указать основную директорию.\nНажмите ОК, чтобы указать.",
                    Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                if (dr == DialogResult.OK)
                    using (SystemForm systemForm = new SystemForm())
                        systemForm.ShowDialog();
                else
                    Close();

                return;
            }
            else
            {
                tbxPass.Focus();
                tbxLogin.Text = Settings.Default.LastLogin;
            }
            #endregion
        }

        private Image LoadAvatar()
        {
            string avatar_temp = $"{ Path.GetTempPath() }om_avatars\\{ Settings.Default.lastAvatarTemp }";

            if (File.Exists(avatar_temp))
                return Image.FromFile(avatar_temp);
            else
                return Resources.userIcon;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbxLogin.Text != "" && tbxPass.Text != "")
            {
                var loginState = Employees.Login(tbxLogin.Text, tbxPass.Text);

                if (loginState.Item1 == 1)
                {
                    new MainForm().Show();
                    Hide();

                    CultureInfo ru = new CultureInfo("ru");
                    InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ru);

                    ClearResources();
                }
                else if (loginState.Item1 == 2)
                {
                    ErrorState(1, "Неверный пароль");
                }
                else
                {
                    MessageBox.Show("Нет подключения с базой данных.\nПопробуйте презапустить программу чуть позже.\n\n" + loginState.Item2.Message,
                        Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (tbxLogin.Text == "")
            {
                ErrorState(0, "Введите логин");
            }
            else
            {
                ErrorState(1, "Введите пароль");
            }

        }

        /// <summary>
        /// Изменяет цвета TextBox и показывает сообщение об ошибке.
        /// </summary>
        /// <param name="id">0 - tbxLogin, 1 - tbxPass.</param>
        /// <param name="msg">Сообщение ошибки.</param>
        private void ErrorState(int id, string msg)
        {
            HideErrorState();

            controls[id].Item1.BorderColor = color.Red;
            controls[id].Item1.HoverState.BorderColor = color.Red;
            controls[id].Item1.FocusedState.BorderColor = color.Red;

            controls[id].Item3.Text = msg;
            controls[id].Item3.Visible = true;

            controls[id].Item1.Focus();
        }

        private void HideErrorState()
        {
            foreach ((Guna2TextBox textBox, _, Label labelError) in controls)
            {
                textBox.BorderColor = color.BorderGray;
                textBox.HoverState.BorderColor = color.BorderGray;
                textBox.FocusedState.BorderColor = color.BorderBlack;

                labelError.Visible = false;
            }
        }

        private void btnSystem_Click(object sender, EventArgs e)
        {
            using (SystemForm systemForm = new SystemForm())
                systemForm.ShowDialog();
        }

        private void ClearResources()
        {
            pbxAvatar.Image.Dispose();
            pbxAvatar.Dispose();
            btnSystem.Dispose();
            btnLogin.Dispose();
            tbxLogin.Dispose();
            tbxPass.Dispose();
            pMain.Dispose();
        }
    }
}
