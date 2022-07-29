namespace Order_Management
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTypes = new System.Windows.Forms.Label();
            this.btnTypes = new Guna.UI2.WinForms.Guna2Button();
            this.lblCategories = new System.Windows.Forms.Label();
            this.btnCategories = new Guna.UI2.WinForms.Guna2Button();
            this.lblServices = new System.Windows.Forms.Label();
            this.btnServices = new Guna.UI2.WinForms.Guna2Button();
            this.lblStatuses = new System.Windows.Forms.Label();
            this.btnStatuses = new Guna.UI2.WinForms.Guna2Button();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.btnEmployee = new Guna.UI2.WinForms.Guna2Button();
            this.lblSystem = new System.Windows.Forms.Label();
            this.btnSystem = new Guna.UI2.WinForms.Guna2Button();
            this.lblInterface = new System.Windows.Forms.Label();
            this.btnInterface = new Guna.UI2.WinForms.Guna2Button();
            this.pSeparator = new System.Windows.Forms.Panel();
            this.pBorder = new Guna.UI2.WinForms.Guna2Panel();
            this.pMain = new System.Windows.Forms.Panel();
            this.guna2Panel2.SuspendLayout();
            this.pBorder.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.ContainerControl = this;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.guna2Panel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.guna2Panel2.BorderRadius = 4;
            this.guna2Panel2.BorderThickness = 1;
            this.guna2Panel2.Controls.Add(this.lblTypes);
            this.guna2Panel2.Controls.Add(this.btnTypes);
            this.guna2Panel2.Controls.Add(this.lblCategories);
            this.guna2Panel2.Controls.Add(this.btnCategories);
            this.guna2Panel2.Controls.Add(this.lblServices);
            this.guna2Panel2.Controls.Add(this.btnServices);
            this.guna2Panel2.Controls.Add(this.lblStatuses);
            this.guna2Panel2.Controls.Add(this.btnStatuses);
            this.guna2Panel2.Controls.Add(this.lblEmployee);
            this.guna2Panel2.Controls.Add(this.btnEmployee);
            this.guna2Panel2.Controls.Add(this.lblSystem);
            this.guna2Panel2.Controls.Add(this.btnSystem);
            this.guna2Panel2.Controls.Add(this.lblInterface);
            this.guna2Panel2.Controls.Add(this.btnInterface);
            this.guna2Panel2.Controls.Add(this.pSeparator);
            this.guna2Panel2.FillColor = System.Drawing.Color.White;
            this.guna2Panel2.Location = new System.Drawing.Point(35, 35);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(260, 636);
            this.guna2Panel2.TabIndex = 32;
            // 
            // lblTypes
            // 
            this.lblTypes.BackColor = System.Drawing.Color.White;
            this.lblTypes.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.lblTypes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(160)))), ((int)(((byte)(183)))));
            this.lblTypes.Location = new System.Drawing.Point(51, 462);
            this.lblTypes.Name = "lblTypes";
            this.lblTypes.Size = new System.Drawing.Size(185, 15);
            this.lblTypes.TabIndex = 130;
            this.lblTypes.Text = "Типы услуг";
            this.lblTypes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTypes.Visible = false;
            // 
            // btnTypes
            // 
            this.btnTypes.BackColor = System.Drawing.Color.White;
            this.btnTypes.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnTypes.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(156)))), ((int)(((byte)(241)))));
            this.btnTypes.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnTypes.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(156)))), ((int)(((byte)(241)))));
            this.btnTypes.CheckedState.Image = global::Order_Management.Properties.Resources.typesIconOn;
            this.btnTypes.CheckedState.Parent = this.btnTypes;
            this.btnTypes.CustomBorderColor = System.Drawing.Color.White;
            this.btnTypes.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.btnTypes.CustomImages.Parent = this.btnTypes;
            this.btnTypes.DisabledState.Parent = this.btnTypes;
            this.btnTypes.FillColor = System.Drawing.Color.White;
            this.btnTypes.Font = new System.Drawing.Font("Segoe UI Semibold", 9.25F);
            this.btnTypes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(77)))), ((int)(((byte)(110)))));
            this.btnTypes.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.btnTypes.HoverState.FillColor = System.Drawing.Color.White;
            this.btnTypes.HoverState.Parent = this.btnTypes;
            this.btnTypes.Image = global::Order_Management.Properties.Resources.typesIconOff;
            this.btnTypes.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTypes.ImageOffset = new System.Drawing.Point(10, -5);
            this.btnTypes.Location = new System.Drawing.Point(1, 430);
            this.btnTypes.Margin = new System.Windows.Forms.Padding(1, 1, 0, 0);
            this.btnTypes.Name = "btnTypes";
            this.btnTypes.PressedColor = System.Drawing.Color.White;
            this.btnTypes.ShadowDecoration.Parent = this.btnTypes;
            this.btnTypes.Size = new System.Drawing.Size(258, 70);
            this.btnTypes.TabIndex = 129;
            this.btnTypes.Text = "Типы";
            this.btnTypes.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTypes.TextOffset = new System.Drawing.Point(14, -12);
            this.btnTypes.Visible = false;
            // 
            // lblCategories
            // 
            this.lblCategories.BackColor = System.Drawing.Color.White;
            this.lblCategories.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.lblCategories.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(160)))), ((int)(((byte)(183)))));
            this.lblCategories.Location = new System.Drawing.Point(51, 391);
            this.lblCategories.Name = "lblCategories";
            this.lblCategories.Size = new System.Drawing.Size(185, 15);
            this.lblCategories.TabIndex = 128;
            this.lblCategories.Text = "Категория услуги";
            this.lblCategories.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCategories.Visible = false;
            // 
            // btnCategories
            // 
            this.btnCategories.BackColor = System.Drawing.Color.White;
            this.btnCategories.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnCategories.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(156)))), ((int)(((byte)(241)))));
            this.btnCategories.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnCategories.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(156)))), ((int)(((byte)(241)))));
            this.btnCategories.CheckedState.Image = global::Order_Management.Properties.Resources.categoriesIconOn;
            this.btnCategories.CheckedState.Parent = this.btnCategories;
            this.btnCategories.CustomBorderColor = System.Drawing.Color.White;
            this.btnCategories.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.btnCategories.CustomImages.Parent = this.btnCategories;
            this.btnCategories.DisabledState.Parent = this.btnCategories;
            this.btnCategories.FillColor = System.Drawing.Color.White;
            this.btnCategories.Font = new System.Drawing.Font("Segoe UI Semibold", 9.25F);
            this.btnCategories.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(77)))), ((int)(((byte)(110)))));
            this.btnCategories.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.btnCategories.HoverState.FillColor = System.Drawing.Color.White;
            this.btnCategories.HoverState.Parent = this.btnCategories;
            this.btnCategories.Image = global::Order_Management.Properties.Resources.categoriesIconOff;
            this.btnCategories.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCategories.ImageOffset = new System.Drawing.Point(10, -5);
            this.btnCategories.Location = new System.Drawing.Point(1, 359);
            this.btnCategories.Margin = new System.Windows.Forms.Padding(1, 1, 0, 0);
            this.btnCategories.Name = "btnCategories";
            this.btnCategories.PressedColor = System.Drawing.Color.White;
            this.btnCategories.ShadowDecoration.Parent = this.btnCategories;
            this.btnCategories.Size = new System.Drawing.Size(258, 70);
            this.btnCategories.TabIndex = 127;
            this.btnCategories.Text = "Категории";
            this.btnCategories.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCategories.TextOffset = new System.Drawing.Point(14, -12);
            this.btnCategories.Visible = false;
            // 
            // lblServices
            // 
            this.lblServices.BackColor = System.Drawing.Color.White;
            this.lblServices.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.lblServices.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(160)))), ((int)(((byte)(183)))));
            this.lblServices.Location = new System.Drawing.Point(51, 320);
            this.lblServices.Name = "lblServices";
            this.lblServices.Size = new System.Drawing.Size(185, 15);
            this.lblServices.TabIndex = 126;
            this.lblServices.Text = "Добавить или удалить услугу";
            this.lblServices.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblServices.Visible = false;
            // 
            // btnServices
            // 
            this.btnServices.BackColor = System.Drawing.Color.White;
            this.btnServices.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnServices.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(156)))), ((int)(((byte)(241)))));
            this.btnServices.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnServices.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(156)))), ((int)(((byte)(241)))));
            this.btnServices.CheckedState.Image = global::Order_Management.Properties.Resources.serviceIconOn;
            this.btnServices.CheckedState.Parent = this.btnServices;
            this.btnServices.CustomBorderColor = System.Drawing.Color.White;
            this.btnServices.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.btnServices.CustomImages.Parent = this.btnServices;
            this.btnServices.DisabledState.Parent = this.btnServices;
            this.btnServices.FillColor = System.Drawing.Color.White;
            this.btnServices.Font = new System.Drawing.Font("Segoe UI Semibold", 9.25F);
            this.btnServices.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(77)))), ((int)(((byte)(110)))));
            this.btnServices.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.btnServices.HoverState.FillColor = System.Drawing.Color.White;
            this.btnServices.HoverState.Parent = this.btnServices;
            this.btnServices.Image = global::Order_Management.Properties.Resources.serviceIconOff;
            this.btnServices.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnServices.ImageOffset = new System.Drawing.Point(11, -5);
            this.btnServices.ImageSize = new System.Drawing.Size(18, 20);
            this.btnServices.Location = new System.Drawing.Point(1, 288);
            this.btnServices.Margin = new System.Windows.Forms.Padding(1, 1, 0, 0);
            this.btnServices.Name = "btnServices";
            this.btnServices.PressedColor = System.Drawing.Color.White;
            this.btnServices.ShadowDecoration.Parent = this.btnServices;
            this.btnServices.Size = new System.Drawing.Size(258, 70);
            this.btnServices.TabIndex = 125;
            this.btnServices.Text = "Услуги";
            this.btnServices.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnServices.TextOffset = new System.Drawing.Point(16, -12);
            this.btnServices.Visible = false;
            // 
            // lblStatuses
            // 
            this.lblStatuses.BackColor = System.Drawing.Color.White;
            this.lblStatuses.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.lblStatuses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(160)))), ((int)(((byte)(183)))));
            this.lblStatuses.Location = new System.Drawing.Point(51, 249);
            this.lblStatuses.Name = "lblStatuses";
            this.lblStatuses.Size = new System.Drawing.Size(185, 15);
            this.lblStatuses.TabIndex = 124;
            this.lblStatuses.Text = "Редактирование статусов";
            this.lblStatuses.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblStatuses.Visible = false;
            // 
            // btnStatuses
            // 
            this.btnStatuses.BackColor = System.Drawing.Color.White;
            this.btnStatuses.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnStatuses.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(156)))), ((int)(((byte)(241)))));
            this.btnStatuses.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnStatuses.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(156)))), ((int)(((byte)(241)))));
            this.btnStatuses.CheckedState.Image = global::Order_Management.Properties.Resources.statusIconOn;
            this.btnStatuses.CheckedState.Parent = this.btnStatuses;
            this.btnStatuses.CustomBorderColor = System.Drawing.Color.White;
            this.btnStatuses.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.btnStatuses.CustomImages.Parent = this.btnStatuses;
            this.btnStatuses.DisabledState.Parent = this.btnStatuses;
            this.btnStatuses.FillColor = System.Drawing.Color.White;
            this.btnStatuses.Font = new System.Drawing.Font("Segoe UI Semibold", 9.25F);
            this.btnStatuses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(77)))), ((int)(((byte)(110)))));
            this.btnStatuses.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.btnStatuses.HoverState.FillColor = System.Drawing.Color.White;
            this.btnStatuses.HoverState.Parent = this.btnStatuses;
            this.btnStatuses.Image = global::Order_Management.Properties.Resources.statusIconOff;
            this.btnStatuses.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnStatuses.ImageOffset = new System.Drawing.Point(10, -5);
            this.btnStatuses.Location = new System.Drawing.Point(1, 217);
            this.btnStatuses.Margin = new System.Windows.Forms.Padding(1, 1, 0, 0);
            this.btnStatuses.Name = "btnStatuses";
            this.btnStatuses.PressedColor = System.Drawing.Color.White;
            this.btnStatuses.ShadowDecoration.Parent = this.btnStatuses;
            this.btnStatuses.Size = new System.Drawing.Size(258, 70);
            this.btnStatuses.TabIndex = 123;
            this.btnStatuses.Text = "Статусы";
            this.btnStatuses.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnStatuses.TextOffset = new System.Drawing.Point(14, -12);
            this.btnStatuses.Visible = false;
            // 
            // lblEmployee
            // 
            this.lblEmployee.BackColor = System.Drawing.Color.White;
            this.lblEmployee.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.lblEmployee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(160)))), ((int)(((byte)(183)))));
            this.lblEmployee.Location = new System.Drawing.Point(51, 178);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(185, 15);
            this.lblEmployee.TabIndex = 122;
            this.lblEmployee.Text = "Регистрация сотрудников";
            this.lblEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblEmployee.Visible = false;
            // 
            // btnEmployee
            // 
            this.btnEmployee.BackColor = System.Drawing.Color.White;
            this.btnEmployee.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnEmployee.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(156)))), ((int)(((byte)(241)))));
            this.btnEmployee.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnEmployee.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(156)))), ((int)(((byte)(241)))));
            this.btnEmployee.CheckedState.Image = global::Order_Management.Properties.Resources.employeeIconOn;
            this.btnEmployee.CheckedState.Parent = this.btnEmployee;
            this.btnEmployee.CustomBorderColor = System.Drawing.Color.White;
            this.btnEmployee.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.btnEmployee.CustomImages.Parent = this.btnEmployee;
            this.btnEmployee.DisabledState.Parent = this.btnEmployee;
            this.btnEmployee.FillColor = System.Drawing.Color.White;
            this.btnEmployee.Font = new System.Drawing.Font("Segoe UI Semibold", 9.25F);
            this.btnEmployee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(77)))), ((int)(((byte)(110)))));
            this.btnEmployee.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.btnEmployee.HoverState.FillColor = System.Drawing.Color.White;
            this.btnEmployee.HoverState.Parent = this.btnEmployee;
            this.btnEmployee.Image = global::Order_Management.Properties.Resources.employeeIconOff;
            this.btnEmployee.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnEmployee.ImageOffset = new System.Drawing.Point(10, -5);
            this.btnEmployee.Location = new System.Drawing.Point(1, 146);
            this.btnEmployee.Margin = new System.Windows.Forms.Padding(1, 1, 0, 0);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.PressedColor = System.Drawing.Color.White;
            this.btnEmployee.ShadowDecoration.Parent = this.btnEmployee;
            this.btnEmployee.Size = new System.Drawing.Size(258, 70);
            this.btnEmployee.TabIndex = 121;
            this.btnEmployee.Text = "Сотрудники";
            this.btnEmployee.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnEmployee.TextOffset = new System.Drawing.Point(14, -12);
            this.btnEmployee.Visible = false;
            // 
            // lblSystem
            // 
            this.lblSystem.BackColor = System.Drawing.Color.White;
            this.lblSystem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.lblSystem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(160)))), ((int)(((byte)(183)))));
            this.lblSystem.Location = new System.Drawing.Point(51, 107);
            this.lblSystem.Name = "lblSystem";
            this.lblSystem.Size = new System.Drawing.Size(185, 15);
            this.lblSystem.TabIndex = 120;
            this.lblSystem.Text = "Общие настройки программы";
            this.lblSystem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSystem.Visible = false;
            // 
            // btnSystem
            // 
            this.btnSystem.BackColor = System.Drawing.Color.White;
            this.btnSystem.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnSystem.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(156)))), ((int)(((byte)(241)))));
            this.btnSystem.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnSystem.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(156)))), ((int)(((byte)(241)))));
            this.btnSystem.CheckedState.Image = global::Order_Management.Properties.Resources.systemIconOn;
            this.btnSystem.CheckedState.Parent = this.btnSystem;
            this.btnSystem.CustomBorderColor = System.Drawing.Color.White;
            this.btnSystem.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.btnSystem.CustomImages.Parent = this.btnSystem;
            this.btnSystem.DisabledState.Parent = this.btnSystem;
            this.btnSystem.FillColor = System.Drawing.Color.White;
            this.btnSystem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.25F);
            this.btnSystem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(77)))), ((int)(((byte)(110)))));
            this.btnSystem.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.btnSystem.HoverState.FillColor = System.Drawing.Color.White;
            this.btnSystem.HoverState.Parent = this.btnSystem;
            this.btnSystem.Image = global::Order_Management.Properties.Resources.systemIconOff;
            this.btnSystem.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSystem.ImageOffset = new System.Drawing.Point(10, -5);
            this.btnSystem.Location = new System.Drawing.Point(1, 75);
            this.btnSystem.Margin = new System.Windows.Forms.Padding(1, 1, 0, 0);
            this.btnSystem.Name = "btnSystem";
            this.btnSystem.PressedColor = System.Drawing.Color.White;
            this.btnSystem.ShadowDecoration.Parent = this.btnSystem;
            this.btnSystem.Size = new System.Drawing.Size(258, 70);
            this.btnSystem.TabIndex = 119;
            this.btnSystem.Text = "Система";
            this.btnSystem.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSystem.TextOffset = new System.Drawing.Point(14, -12);
            this.btnSystem.Visible = false;
            // 
            // lblInterface
            // 
            this.lblInterface.BackColor = System.Drawing.Color.White;
            this.lblInterface.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.lblInterface.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(109)))), ((int)(((byte)(118)))));
            this.lblInterface.Location = new System.Drawing.Point(51, 36);
            this.lblInterface.Name = "lblInterface";
            this.lblInterface.Size = new System.Drawing.Size(185, 15);
            this.lblInterface.TabIndex = 115;
            this.lblInterface.Text = "Внешний вид программы";
            this.lblInterface.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnInterface
            // 
            this.btnInterface.BackColor = System.Drawing.Color.White;
            this.btnInterface.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnInterface.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(156)))), ((int)(((byte)(241)))));
            this.btnInterface.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnInterface.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(156)))), ((int)(((byte)(241)))));
            this.btnInterface.CheckedState.Image = global::Order_Management.Properties.Resources.interfaceIconOn;
            this.btnInterface.CheckedState.Parent = this.btnInterface;
            this.btnInterface.CustomBorderColor = System.Drawing.Color.White;
            this.btnInterface.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.btnInterface.CustomImages.Parent = this.btnInterface;
            this.btnInterface.DisabledState.Parent = this.btnInterface;
            this.btnInterface.FillColor = System.Drawing.Color.White;
            this.btnInterface.Font = new System.Drawing.Font("Segoe UI Semibold", 9.25F);
            this.btnInterface.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(77)))), ((int)(((byte)(110)))));
            this.btnInterface.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.btnInterface.HoverState.FillColor = System.Drawing.Color.White;
            this.btnInterface.HoverState.Parent = this.btnInterface;
            this.btnInterface.Image = global::Order_Management.Properties.Resources.interfaceIconOff;
            this.btnInterface.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnInterface.ImageOffset = new System.Drawing.Point(10, -5);
            this.btnInterface.Location = new System.Drawing.Point(1, 4);
            this.btnInterface.Margin = new System.Windows.Forms.Padding(1, 1, 0, 0);
            this.btnInterface.Name = "btnInterface";
            this.btnInterface.PressedColor = System.Drawing.Color.White;
            this.btnInterface.ShadowDecoration.Parent = this.btnInterface;
            this.btnInterface.Size = new System.Drawing.Size(258, 70);
            this.btnInterface.TabIndex = 0;
            this.btnInterface.Text = "Интерфейс";
            this.btnInterface.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnInterface.TextOffset = new System.Drawing.Point(14, -12);
            // 
            // pSeparator
            // 
            this.pSeparator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.pSeparator.Location = new System.Drawing.Point(1, 74);
            this.pSeparator.Name = "pSeparator";
            this.pSeparator.Size = new System.Drawing.Size(258, 1);
            this.pSeparator.TabIndex = 33;
            // 
            // pBorder
            // 
            this.pBorder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.pBorder.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.pBorder.BorderRadius = 4;
            this.pBorder.BorderThickness = 1;
            this.pBorder.Controls.Add(this.pMain);
            this.pBorder.FillColor = System.Drawing.Color.White;
            this.pBorder.Location = new System.Drawing.Point(324, 35);
            this.pBorder.Margin = new System.Windows.Forms.Padding(30, 35, 35, 0);
            this.pBorder.Name = "pBorder";
            this.pBorder.ShadowDecoration.Parent = this.pBorder;
            this.pBorder.Size = new System.Drawing.Size(907, 636);
            this.pBorder.TabIndex = 33;
            // 
            // pMain
            // 
            this.pMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pMain.BackColor = System.Drawing.Color.White;
            this.pMain.Location = new System.Drawing.Point(1, 4);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(905, 628);
            this.pMain.TabIndex = 0;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1266, 706);
            this.Controls.Add(this.pBorder);
            this.Controls.Add(this.guna2Panel2);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройки - Order Management";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsForm_FormClosing);
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SettingsForm_KeyPress);
            this.Resize += new System.EventHandler(this.SettingsForm_Resize);
            this.guna2Panel2.ResumeLayout(false);
            this.pBorder.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button btnInterface;
        private System.Windows.Forms.Label lblInterface;
        private System.Windows.Forms.Label lblServices;
        private Guna.UI2.WinForms.Guna2Button btnServices;
        private System.Windows.Forms.Label lblStatuses;
        private Guna.UI2.WinForms.Guna2Button btnStatuses;
        private System.Windows.Forms.Label lblEmployee;
        private Guna.UI2.WinForms.Guna2Button btnEmployee;
        private System.Windows.Forms.Label lblSystem;
        private Guna.UI2.WinForms.Guna2Button btnSystem;
        private System.Windows.Forms.Label lblTypes;
        private Guna.UI2.WinForms.Guna2Button btnTypes;
        private System.Windows.Forms.Label lblCategories;
        private Guna.UI2.WinForms.Guna2Button btnCategories;
        private System.Windows.Forms.Panel pSeparator;
        private Guna.UI2.WinForms.Guna2Panel pBorder;
        private System.Windows.Forms.Panel pMain;
    }
}