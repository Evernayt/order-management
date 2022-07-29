
namespace Order_Management.View.SettingsForms
{
    partial class ServiceForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnEdit = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.lblTypesTitle = new System.Windows.Forms.Label();
            this.lblCategoriesTitle = new System.Windows.Forms.Label();
            this.lblServiceTitle = new System.Windows.Forms.Label();
            this.cbxTypes = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbxCategories = new Guna.UI2.WinForms.Guna2ComboBox();
            this.tbxService = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Separator3 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.cbxShow = new Guna.UI2.WinForms.Guna2ComboBox();
            this.tbxSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id_services = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.service_services = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category_services = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type_services = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.CheckedState.Parent = this.btnDelete;
            this.btnDelete.CustomImages.Parent = this.btnDelete;
            this.btnDelete.DisabledState.Parent = this.btnDelete;
            this.btnDelete.FillColor = System.Drawing.Color.White;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(104)))), ((int)(((byte)(91)))));
            this.btnDelete.HoverState.FillColor = System.Drawing.Color.White;
            this.btnDelete.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(121)))), ((int)(((byte)(109)))));
            this.btnDelete.HoverState.Parent = this.btnDelete;
            this.btnDelete.Location = new System.Drawing.Point(219, 581);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.PressedColor = System.Drawing.Color.White;
            this.btnDelete.ShadowDecoration.Parent = this.btnDelete;
            this.btnDelete.Size = new System.Drawing.Size(115, 30);
            this.btnDelete.TabIndex = 164;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDelete.TextOffset = new System.Drawing.Point(-10, 0);
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEdit.BackColor = System.Drawing.Color.White;
            this.btnEdit.CheckedState.Parent = this.btnEdit;
            this.btnEdit.CustomImages.Parent = this.btnEdit;
            this.btnEdit.DisabledState.Parent = this.btnEdit;
            this.btnEdit.FillColor = System.Drawing.Color.White;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.btnEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(156)))), ((int)(((byte)(241)))));
            this.btnEdit.HoverState.FillColor = System.Drawing.Color.White;
            this.btnEdit.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(175)))), ((int)(((byte)(249)))));
            this.btnEdit.HoverState.Parent = this.btnEdit;
            this.btnEdit.Location = new System.Drawing.Point(132, 581);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(0);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.PressedColor = System.Drawing.Color.White;
            this.btnEdit.ShadowDecoration.Parent = this.btnEdit;
            this.btnEdit.Size = new System.Drawing.Size(90, 30);
            this.btnEdit.TabIndex = 163;
            this.btnEdit.Text = "Изменить";
            this.btnEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnEdit.TextOffset = new System.Drawing.Point(-10, 0);
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.CheckedState.Parent = this.btnAdd;
            this.btnAdd.CustomImages.Parent = this.btnAdd;
            this.btnAdd.DisabledState.Parent = this.btnAdd;
            this.btnAdd.FillColor = System.Drawing.Color.White;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(156)))), ((int)(((byte)(241)))));
            this.btnAdd.HoverState.FillColor = System.Drawing.Color.White;
            this.btnAdd.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(175)))), ((int)(((byte)(249)))));
            this.btnAdd.HoverState.Parent = this.btnAdd;
            this.btnAdd.Image = global::Order_Management.Properties.Resources.addIconOn;
            this.btnAdd.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnAdd.ImageSize = new System.Drawing.Size(16, 16);
            this.btnAdd.Location = new System.Drawing.Point(21, 581);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.btnAdd.ShadowDecoration.Parent = this.btnAdd;
            this.btnAdd.Size = new System.Drawing.Size(100, 30);
            this.btnAdd.TabIndex = 162;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAdd.TextOffset = new System.Drawing.Point(-10, 0);
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblTypesTitle
            // 
            this.lblTypesTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTypesTitle.AutoSize = true;
            this.lblTypesTitle.BackColor = System.Drawing.Color.White;
            this.lblTypesTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.lblTypesTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(142)))), ((int)(((byte)(155)))));
            this.lblTypesTitle.Location = new System.Drawing.Point(608, 490);
            this.lblTypesTitle.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.lblTypesTitle.Name = "lblTypesTitle";
            this.lblTypesTitle.Size = new System.Drawing.Size(28, 15);
            this.lblTypesTitle.TabIndex = 161;
            this.lblTypesTitle.Text = "Тип";
            // 
            // lblCategoriesTitle
            // 
            this.lblCategoriesTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCategoriesTitle.AutoSize = true;
            this.lblCategoriesTitle.BackColor = System.Drawing.Color.White;
            this.lblCategoriesTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.lblCategoriesTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(142)))), ((int)(((byte)(155)))));
            this.lblCategoriesTitle.Location = new System.Drawing.Point(315, 490);
            this.lblCategoriesTitle.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.lblCategoriesTitle.Name = "lblCategoriesTitle";
            this.lblCategoriesTitle.Size = new System.Drawing.Size(63, 15);
            this.lblCategoriesTitle.TabIndex = 160;
            this.lblCategoriesTitle.Text = "Категория";
            // 
            // lblServiceTitle
            // 
            this.lblServiceTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblServiceTitle.AutoSize = true;
            this.lblServiceTitle.BackColor = System.Drawing.Color.White;
            this.lblServiceTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.lblServiceTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(142)))), ((int)(((byte)(155)))));
            this.lblServiceTitle.Location = new System.Drawing.Point(21, 490);
            this.lblServiceTitle.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.lblServiceTitle.Name = "lblServiceTitle";
            this.lblServiceTitle.Size = new System.Drawing.Size(101, 15);
            this.lblServiceTitle.TabIndex = 159;
            this.lblServiceTitle.Text = "Название услуги";
            // 
            // cbxTypes
            // 
            this.cbxTypes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbxTypes.BackColor = System.Drawing.Color.White;
            this.cbxTypes.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.cbxTypes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTypes.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(142)))), ((int)(((byte)(155)))));
            this.cbxTypes.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(142)))), ((int)(((byte)(155)))));
            this.cbxTypes.FocusedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(156)))), ((int)(((byte)(241)))));
            this.cbxTypes.FocusedState.Parent = this.cbxTypes;
            this.cbxTypes.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbxTypes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(207)))), ((int)(((byte)(224)))));
            this.cbxTypes.HoverState.Parent = this.cbxTypes;
            this.cbxTypes.ItemHeight = 30;
            this.cbxTypes.ItemsAppearance.BackColor = System.Drawing.Color.White;
            this.cbxTypes.ItemsAppearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(112)))), ((int)(((byte)(126)))));
            this.cbxTypes.ItemsAppearance.Parent = this.cbxTypes;
            this.cbxTypes.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(156)))), ((int)(((byte)(241)))));
            this.cbxTypes.ItemsAppearance.SelectedForeColor = System.Drawing.Color.White;
            this.cbxTypes.Location = new System.Drawing.Point(611, 502);
            this.cbxTypes.Margin = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.cbxTypes.Name = "cbxTypes";
            this.cbxTypes.ShadowDecoration.Parent = this.cbxTypes;
            this.cbxTypes.Size = new System.Drawing.Size(271, 36);
            this.cbxTypes.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cbxTypes.TabIndex = 158;
            this.cbxTypes.TabStop = false;
            this.cbxTypes.TextOffset = new System.Drawing.Point(-8, 1);
            // 
            // cbxCategories
            // 
            this.cbxCategories.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbxCategories.BackColor = System.Drawing.Color.White;
            this.cbxCategories.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.cbxCategories.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategories.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(142)))), ((int)(((byte)(155)))));
            this.cbxCategories.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(142)))), ((int)(((byte)(155)))));
            this.cbxCategories.FocusedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(156)))), ((int)(((byte)(241)))));
            this.cbxCategories.FocusedState.Parent = this.cbxCategories;
            this.cbxCategories.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbxCategories.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(207)))), ((int)(((byte)(224)))));
            this.cbxCategories.HoverState.Parent = this.cbxCategories;
            this.cbxCategories.ItemHeight = 30;
            this.cbxCategories.ItemsAppearance.BackColor = System.Drawing.Color.White;
            this.cbxCategories.ItemsAppearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(112)))), ((int)(((byte)(126)))));
            this.cbxCategories.ItemsAppearance.Parent = this.cbxCategories;
            this.cbxCategories.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(156)))), ((int)(((byte)(241)))));
            this.cbxCategories.ItemsAppearance.SelectedForeColor = System.Drawing.Color.White;
            this.cbxCategories.Location = new System.Drawing.Point(318, 502);
            this.cbxCategories.Margin = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.cbxCategories.Name = "cbxCategories";
            this.cbxCategories.ShadowDecoration.Parent = this.cbxCategories;
            this.cbxCategories.Size = new System.Drawing.Size(271, 36);
            this.cbxCategories.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cbxCategories.TabIndex = 157;
            this.cbxCategories.TabStop = false;
            this.cbxCategories.TextOffset = new System.Drawing.Point(-8, 1);
            this.cbxCategories.SelectionChangeCommitted += new System.EventHandler(this.cbxCategories_SelectionChangeCommitted);
            // 
            // tbxService
            // 
            this.tbxService.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbxService.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(216)))), ((int)(((byte)(221)))));
            this.tbxService.BorderThickness = 0;
            this.tbxService.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxService.DefaultText = "";
            this.tbxService.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(216)))), ((int)(((byte)(221)))));
            this.tbxService.DisabledState.FillColor = System.Drawing.Color.White;
            this.tbxService.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(216)))), ((int)(((byte)(221)))));
            this.tbxService.DisabledState.Parent = this.tbxService;
            this.tbxService.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(216)))), ((int)(((byte)(221)))));
            this.tbxService.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(142)))), ((int)(((byte)(155)))));
            this.tbxService.FocusedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(62)))));
            this.tbxService.FocusedState.Parent = this.tbxService;
            this.tbxService.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.tbxService.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(71)))));
            this.tbxService.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(216)))), ((int)(((byte)(221)))));
            this.tbxService.HoverState.Parent = this.tbxService;
            this.tbxService.Location = new System.Drawing.Point(24, 502);
            this.tbxService.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.tbxService.Name = "tbxService";
            this.tbxService.PasswordChar = '\0';
            this.tbxService.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.tbxService.PlaceholderText = "";
            this.tbxService.SelectedText = "";
            this.tbxService.ShadowDecoration.Parent = this.tbxService;
            this.tbxService.Size = new System.Drawing.Size(271, 36);
            this.tbxService.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.tbxService.TabIndex = 156;
            this.tbxService.TextOffset = new System.Drawing.Point(-8, 0);
            // 
            // guna2Separator3
            // 
            this.guna2Separator3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Separator3.BackColor = System.Drawing.Color.White;
            this.guna2Separator3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.guna2Separator3.Location = new System.Drawing.Point(0, 461);
            this.guna2Separator3.Name = "guna2Separator3";
            this.guna2Separator3.Size = new System.Drawing.Size(905, 1);
            this.guna2Separator3.TabIndex = 155;
            // 
            // guna2Separator2
            // 
            this.guna2Separator2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Separator2.BackColor = System.Drawing.Color.White;
            this.guna2Separator2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.guna2Separator2.Location = new System.Drawing.Point(0, 180);
            this.guna2Separator2.Name = "guna2Separator2";
            this.guna2Separator2.Size = new System.Drawing.Size(889, 1);
            this.guna2Separator2.TabIndex = 154;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Separator1.BackColor = System.Drawing.Color.White;
            this.guna2Separator1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.guna2Separator1.Location = new System.Drawing.Point(0, 133);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(905, 1);
            this.guna2Separator1.TabIndex = 153;
            // 
            // cbxShow
            // 
            this.cbxShow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxShow.BackColor = System.Drawing.Color.Transparent;
            this.cbxShow.BorderThickness = 0;
            this.cbxShow.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxShow.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxShow.FocusedColor = System.Drawing.Color.Empty;
            this.cbxShow.FocusedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(156)))), ((int)(((byte)(241)))));
            this.cbxShow.FocusedState.Parent = this.cbxShow;
            this.cbxShow.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbxShow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(112)))), ((int)(((byte)(126)))));
            this.cbxShow.HoverState.Parent = this.cbxShow;
            this.cbxShow.ItemHeight = 24;
            this.cbxShow.Items.AddRange(new object[] {
            "Только обычные",
            "Только архивные",
            "Все"});
            this.cbxShow.ItemsAppearance.BackColor = System.Drawing.Color.White;
            this.cbxShow.ItemsAppearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(112)))), ((int)(((byte)(126)))));
            this.cbxShow.ItemsAppearance.Parent = this.cbxShow;
            this.cbxShow.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(156)))), ((int)(((byte)(241)))));
            this.cbxShow.ItemsAppearance.SelectedForeColor = System.Drawing.Color.White;
            this.cbxShow.Location = new System.Drawing.Point(731, 25);
            this.cbxShow.Margin = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.cbxShow.Name = "cbxShow";
            this.cbxShow.ShadowDecoration.Parent = this.cbxShow;
            this.cbxShow.Size = new System.Drawing.Size(160, 30);
            this.cbxShow.StartIndex = 0;
            this.cbxShow.TabIndex = 152;
            this.cbxShow.TabStop = false;
            this.cbxShow.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.cbxShow.TextOffset = new System.Drawing.Point(5, 0);
            this.cbxShow.SelectionChangeCommitted += new System.EventHandler(this.cbxShow_SelectionChangeCommitted);
            // 
            // tbxSearch
            // 
            this.tbxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxSearch.BackColor = System.Drawing.Color.White;
            this.tbxSearch.BorderRadius = 4;
            this.tbxSearch.BorderThickness = 0;
            this.tbxSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxSearch.DefaultText = "";
            this.tbxSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbxSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbxSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxSearch.DisabledState.Parent = this.tbxSearch;
            this.tbxSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.tbxSearch.FocusedState.BorderColor = System.Drawing.Color.DarkGray;
            this.tbxSearch.FocusedState.Parent = this.tbxSearch;
            this.tbxSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbxSearch.HoverState.BorderColor = System.Drawing.Color.DarkGray;
            this.tbxSearch.HoverState.Parent = this.tbxSearch;
            this.tbxSearch.IconLeft = global::Order_Management.Properties.Resources.searchIconOff;
            this.tbxSearch.IconLeftOffset = new System.Drawing.Point(13, 0);
            this.tbxSearch.IconLeftSize = new System.Drawing.Size(16, 16);
            this.tbxSearch.Location = new System.Drawing.Point(24, 69);
            this.tbxSearch.Margin = new System.Windows.Forms.Padding(24, 24, 24, 16);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.PasswordChar = '\0';
            this.tbxSearch.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(160)))), ((int)(((byte)(183)))));
            this.tbxSearch.PlaceholderText = "Поиск";
            this.tbxSearch.SelectedText = "";
            this.tbxSearch.ShadowDecoration.Parent = this.tbxSearch;
            this.tbxSearch.Size = new System.Drawing.Size(857, 40);
            this.tbxSearch.TabIndex = 151;
            this.tbxSearch.TabStop = false;
            this.tbxSearch.TextOffset = new System.Drawing.Point(10, 0);
            this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(71)))));
            this.label4.Location = new System.Drawing.Point(20, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 150;
            this.label4.Text = "Услуги";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(77)))), ((int)(((byte)(110)))));
            dataGridViewCellStyle10.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(77)))), ((int)(((byte)(110)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView1.ColumnHeadersHeight = 47;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_services,
            this.service_services,
            this.category_services,
            this.type_services});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(118)))), ((int)(((byte)(131)))));
            dataGridViewCellStyle11.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(118)))), ((int)(((byte)(131)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.dataGridView1.Location = new System.Drawing.Point(0, 133);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 53;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(905, 329);
            this.dataGridView1.TabIndex = 149;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // id_services
            // 
            this.id_services.DataPropertyName = "id";
            this.id_services.HeaderText = "id";
            this.id_services.Name = "id_services";
            this.id_services.ReadOnly = true;
            this.id_services.Visible = false;
            this.id_services.Width = 73;
            // 
            // service_services
            // 
            this.service_services.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.service_services.DataPropertyName = "service";
            this.service_services.HeaderText = "Услуга";
            this.service_services.Name = "service_services";
            this.service_services.ReadOnly = true;
            // 
            // category_services
            // 
            this.category_services.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.category_services.DataPropertyName = "category";
            this.category_services.HeaderText = "Категория";
            this.category_services.MinimumWidth = 135;
            this.category_services.Name = "category_services";
            this.category_services.ReadOnly = true;
            this.category_services.Width = 135;
            // 
            // type_services
            // 
            this.type_services.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.type_services.DataPropertyName = "type";
            this.type_services.HeaderText = "Тип";
            this.type_services.MinimumWidth = 150;
            this.type_services.Name = "type_services";
            this.type_services.ReadOnly = true;
            this.type_services.Width = 150;
            // 
            // ServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(905, 628);
            this.ControlBox = false;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblTypesTitle);
            this.Controls.Add(this.lblCategoriesTitle);
            this.Controls.Add(this.lblServiceTitle);
            this.Controls.Add(this.cbxTypes);
            this.Controls.Add(this.cbxCategories);
            this.Controls.Add(this.tbxService);
            this.Controls.Add(this.guna2Separator3);
            this.Controls.Add(this.guna2Separator2);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.cbxShow);
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ServiceForm";
            this.Text = "ServiceForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private System.Windows.Forms.Label lblTypesTitle;
        private System.Windows.Forms.Label lblCategoriesTitle;
        private System.Windows.Forms.Label lblServiceTitle;
        private Guna.UI2.WinForms.Guna2ComboBox cbxTypes;
        private Guna.UI2.WinForms.Guna2ComboBox cbxCategories;
        private Guna.UI2.WinForms.Guna2TextBox tbxService;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator3;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2ComboBox cbxShow;
        public Guna.UI2.WinForms.Guna2TextBox tbxSearch;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_services;
        private System.Windows.Forms.DataGridViewTextBoxColumn service_services;
        private System.Windows.Forms.DataGridViewTextBoxColumn category_services;
        private System.Windows.Forms.DataGridViewTextBoxColumn type_services;
    }
}