using Guna.UI2.WinForms;
using Order_Management.Database;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace Order_Management
{
    public partial class AccountForm : Form
    {
        private readonly Colors color = new Colors();

        List<(Guna2TextBox, Label, Label)> controls = new List<(Guna2TextBox, Label, Label)>();

        public AccountForm()
        {
            InitializeComponent();
        }

        private void AccountForm_Load(object sender, EventArgs e)
        {
            pbxAvatar.Image = MainForm.mainForm.pbxAvatar.Image;
            lblPermission.Text = Employees.GetPermission();

            tbxName.Text = Employees.currentUser.name;
            tbxLogin.Text = Employees.currentUser.login;

            #region Связываем текстовые окна с заголовками
            controls.Add((tbxName, lblNameTitle, lblNameError));
            controls.Add((tbxLogin, lblLoginTitle, lblLoginError));
            controls.Add((tbxPrevPass, lblPrevPassTitle, lblPrevPassError));
            controls.Add((tbxNewPass, lblNewPassTitle, lblNewPassError));
            controls.Add((tbxConfirmNewPass, lblConfirmNewPassTitle, lblConfirmNewPassError));

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
            #endregion
        }

        public class Root
        {
            public Data data { get; set; }
        }
        public class Data
        {
            public Thumb thumb { get; set; }
        }
        public class Thumb
        {
            public string filename { get; set; }
            public string name { get; set; }
            public string mime { get; set; }
            public string extension { get; set; }
            public string url { get; set; }
        }

        private void pbxAvatar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Изображения (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog.FileName;
                long length = new FileInfo(path).Length;

                if (length > 2097152)
                {
                    MessageBox.Show("Размер изображения не должен превышать 2 МБ.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                try
                {
                    using (WebClient client = new WebClient())
                    {
                        NameValueCollection param = new NameValueCollection
                        {
                            { "key", "b14be3a195dd836b84479daf8a6a8a57" },
                            { "image", ImageToBase64(path) }
                        };
                        
                        client.UploadProgressChanged += (s, e2) =>
                        {
                            int realProgress = e2.ProgressPercentage < 0 ? 100 : e2.ProgressPercentage;
                            progressBar1.Value = realProgress;
                        };

                        client.UploadValuesAsync(new Uri("https://api.imgbb.com/1/upload"), "POST", param);

                        client.UploadValuesCompleted += (s, e2) =>
                        {
                            string json = Encoding.UTF8.GetString(e2.Result);

                            JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();
                            var root = javaScriptSerializer.Deserialize<Root>(json);
                            var thumb = root.data.thumb;

                            MainForm.mainForm.pbxAvatar.Load(thumb.url);
                            pbxAvatar.Image = MainForm.mainForm.pbxAvatar.Image;

                            Directory.CreateDirectory($"{ Path.GetTempPath() }om_avatars");
                            pbxAvatar.Image.Save($"{ Path.GetTempPath() }om_avatars\\{ thumb.filename }");

                            Employees.UpdateAvatar(thumb.url, thumb.filename);
                        };
                    }
                }
                catch
                {
                    MainForm.mainForm.Notification("Не удалось загрузить изображение");
                }
            }
            else
            {
                return;
            } 
        }

        public static string ImageToBase64(string path)
        {
            using (Image image = Image.FromFile(path))
            {
                using (MemoryStream m = new MemoryStream())
                {
                    image.Save(m, image.RawFormat);
                    byte[] imageBytes = m.ToArray();
                    var base64String = Convert.ToBase64String(imageBytes);
                    return base64String;
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (tbxName.Text == Employees.currentUser.name && tbxLogin.Text == Employees.currentUser.login)
            {
                return;
            }
            else if (tbxName.Text == "")
            {
                ErrorState(0, "Введите имя");
            }
            else if (tbxLogin.Text == "")
            {
                ErrorState(1, "Введите логин");
            }
            else
            {
                HideErrorState();

                MainForm.mainForm.Notification(Employees.UpdateName(tbxName.Text, tbxLogin.Text));
            }
        }

        private void btnEditPass_Click(object sender, EventArgs e)
        {
            if (tbxPrevPass.Text == "")
            {
                ErrorState(2, "Введите предыдущий пароль");
            }
            else if (tbxPrevPass.Text != Employees.currentUser.pass)
            {
                ErrorState(2, "Предыдущий пароль введён не правильно");
            }
            else if (tbxNewPass.Text == "")
            {
                ErrorState(3, "Введите новый пароль");
            }
            else if (tbxNewPass.Text == tbxPrevPass.Text)
            {
                ErrorState(3, "Новый пароль не должен совпадать с предыдущим");
            }
            else if (tbxConfirmNewPass.Text != tbxNewPass.Text)
            {
                ErrorState(4, "Пароли не совпадают");
            }
            else
            {
                HideErrorState();

                MainForm.mainForm.Notification(Employees.ChangePass(tbxNewPass.Text));

                tbxPrevPass.Text = "";
                tbxNewPass.Text = "";
                tbxConfirmNewPass.Text = "";
            }
        }

        /// <summary>
        /// Изменяет цвета TextBox и показывает сообщение об ошибке.
        /// </summary>
        /// <param name="id">0 - tbxName, 1 - tbxLogin, 2 - tbxPrevPass, 3 - tbxNewPass, 4 - tbxConfirmNewPass.</param>
        /// <param name="msg">Сообщение ошибки.</param>
        private void ErrorState(int id, string msg)
        {
            HideErrorState();

            controls[id].Item1.BorderColor = color.Red;
            controls[id].Item1.HoverState.BorderColor = color.Red;
            controls[id].Item1.FocusedState.BorderColor = color.Red;

            controls[id].Item3.Text = msg;
            controls[id].Item3.Visible = true;
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
    }
}
