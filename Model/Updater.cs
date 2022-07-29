using System;
using System.Deployment.Application;
using System.Windows.Forms;

namespace Order_Management
{
    class Updater
    {
        private string GetAppVersion()
        {
            if (ApplicationDeployment.IsNetworkDeployed)
                return ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString();
            return "";
        }

        public void Update()
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
                    MessageBox.Show("Новая версия приложения не может быть загружена в настоящее время." +
                        "\n\nПожалуйста, проверьте подключение к сети или повторите попытку позже. Ошибка: " + dde.Message, "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                catch (InvalidDeploymentException ide)
                {
                    MessageBox.Show("Невозможно проверить наличие новой версии приложения. Развертывание ClickOnce повреждено. " +
                        "Пожалуйста, повторно разверните приложение и попробуйте снова. Ошибка: " + ide.Message, "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                catch (InvalidOperationException ioe)
                {
                    MessageBox.Show("Это приложение не может быть обновлено. Скорее всего, это не приложение ClickOnce. Ошибка: " + ioe.Message, "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (info.UpdateAvailable)
                {
                    bool doUpdate = true;

                    if (!info.IsUpdateRequired)
                    {
                        //DialogResult dr = MessageBox.Show("Доступно обновление. Хотите обновить приложение сейчас?", "Доступно обновление",
                        //    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                        //if (!(DialogResult.OK == dr))
                        //{
                        //    doUpdate = false;
                        //}
                    }
                    else
                    {
                        // Display a message that the app MUST reboot. Display the minimum required version.
                        MessageBox.Show("Это приложение обнаружило обязательное обновление вашей текущей " +
                            "версии до версии " + info.MinimumRequiredVersion.ToString() +
                            ". Приложение теперь установит обновление и перезагрузится.",
                            "Доступно обновление", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }

                    if (doUpdate)
                    {
                        try
                        {
                            ad.Update();
                            MessageBox.Show("Приложение было обновлено и теперь будет перезапущено.");
                            Application.Restart();
                        }
                        catch (DeploymentDownloadException dde)
                        {
                            MessageBox.Show("Не удается установить последнюю версию приложения. \n\nПожалуйста, проверьте подключение к сети или повторите попытку позже. " +
                                "Ошибка: " + dde, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
                //else if (!info.UpdateAvailable)
                //{
                //    MessageBox.Show("Нет доступных обновлений.", "Обновления", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
            }
        }
    }
}
