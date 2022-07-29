using Guna.UI2.WinForms;
using Order_Management.Database;
using Order_Management.View.SettingsForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Order_Management
{
    public partial class SettingsForm : Form
    {
        public static SettingsForm settingsForm = null;

        private CategoryForm categoryForm = new CategoryForm();
        private EmployeeForm employeeForm = new EmployeeForm();
        private InterfaceForm interfaceForm = new InterfaceForm();
        private ServiceForm serviceForm = new ServiceForm();
        private StatusesForm statusesForm = new StatusesForm();
        private SystemForm systemForm = new SystemForm();
        private TypeForm typeForm = new TypeForm();

        private Form lastForm;

        public bool needReload = false;

        List<(Form, Guna2Button, Label)> forms = new List<(Form, Guna2Button, Label)>();

        public SettingsForm()
        {
            InitializeComponent();
            settingsForm = this;
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            #region Связываем кнопки с формами
            forms.Add((categoryForm, btnCategories, lblCategories));
            forms.Add((employeeForm, btnEmployee, lblEmployee));
            forms.Add((interfaceForm, btnInterface, lblInterface));
            forms.Add((serviceForm, btnServices, lblServices));
            forms.Add((statusesForm, btnStatuses, lblStatuses));
            forms.Add((systemForm, btnSystem, lblSystem));
            forms.Add((typeForm, btnTypes, lblTypes));

            foreach (var form in forms)
            {
                form.Item2.Click += (s, a) =>
                {
                    if (lastForm != form.Item1)
                    {
                        lastForm = form.Item1;
                        form.Item1.TopLevel = false;
                        pMain.Controls.Clear();
                        pMain.Controls.Add(form.Item1);
                        form.Item1.Show();
                    }

                    ButtonLabelColorReset();
                    form.Item3.ForeColor = Color.FromArgb(98, 109, 118);
                };

                form.Item3.Click += (s, a) =>
                {
                    form.Item2.PerformClick();
                };
            }
            #endregion

            btnInterface.PerformClick();

            if (Employees.currentUser.permission == 1)
                OpenAccess();
        }

        private void ButtonLabelColorReset()
        {
            foreach (var form in forms)
                form.Item3.ForeColor = Color.FromArgb(144, 160, 183);
        }

        public void OpenAccess()
        {
            foreach (var form in forms)
            {
                if (!form.Item2.Visible)
                {
                    form.Item3.Visible = true;
                    form.Item2.Visible = true;
                } 
            }

            categoryForm.FormLoad();
            employeeForm.FormLoad();
            serviceForm.FormLoad();
            statusesForm.FormLoad();
            systemForm.isUnlocked();
            typeForm.FormLoad();

            pSeparator.Size = new Size(258, 427);
        }

        private void SettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (needReload)
            {
                Application.Restart();
                Environment.Exit(1);
            }
        }

        private void SettingsForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
                Close();
        }

        public void SettingsForm_Resize(object sender, EventArgs e)
        {
            foreach (var form in forms)
                form.Item1.Size = pMain.Size;
        }
    }
}
