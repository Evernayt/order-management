
namespace Order_Management.View.SettingsForms
{
    partial class StatusesForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            this.lblColorTitle = new System.Windows.Forms.Label();
            this.lblNamesTitle = new System.Windows.Forms.Label();
            this.tbxColor = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbxName = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnEdit = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Separator3 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.cbxShow = new Guna.UI2.WinForms.Guna2ComboBox();
            this.tbxSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id_statuses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status_statuses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.color_statuses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.archive_statuses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.guna2Separator2.TabIndex = 160;
            // 
            // lblColorTitle
            // 
            this.lblColorTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblColorTitle.AutoSize = true;
            this.lblColorTitle.BackColor = System.Drawing.Color.White;
            this.lblColorTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.lblColorTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(142)))), ((int)(((byte)(155)))));
            this.lblColorTitle.Location = new System.Drawing.Point(608, 490);
            this.lblColorTitle.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.lblColorTitle.Name = "lblColorTitle";
            this.lblColorTitle.Size = new System.Drawing.Size(77, 15);
            this.lblColorTitle.TabIndex = 159;
            this.lblColorTitle.Text = "Цвет статуса";
            // 
            // lblNamesTitle
            // 
            this.lblNamesTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNamesTitle.AutoSize = true;
            this.lblNamesTitle.BackColor = System.Drawing.Color.White;
            this.lblNamesTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.lblNamesTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(142)))), ((int)(((byte)(155)))));
            this.lblNamesTitle.Location = new System.Drawing.Point(21, 490);
            this.lblNamesTitle.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.lblNamesTitle.Name = "lblNamesTitle";
            this.lblNamesTitle.Size = new System.Drawing.Size(104, 15);
            this.lblNamesTitle.TabIndex = 158;
            this.lblNamesTitle.Text = "Название статуса";
            // 
            // tbxColor
            // 
            this.tbxColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbxColor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(216)))), ((int)(((byte)(221)))));
            this.tbxColor.BorderThickness = 0;
            this.tbxColor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxColor.DefaultText = "";
            this.tbxColor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(216)))), ((int)(((byte)(221)))));
            this.tbxColor.DisabledState.FillColor = System.Drawing.Color.White;
            this.tbxColor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(216)))), ((int)(((byte)(221)))));
            this.tbxColor.DisabledState.Parent = this.tbxColor;
            this.tbxColor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(216)))), ((int)(((byte)(221)))));
            this.tbxColor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(142)))), ((int)(((byte)(155)))));
            this.tbxColor.FocusedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(62)))));
            this.tbxColor.FocusedState.Parent = this.tbxColor;
            this.tbxColor.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.tbxColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(71)))));
            this.tbxColor.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(216)))), ((int)(((byte)(221)))));
            this.tbxColor.HoverState.Parent = this.tbxColor;
            this.tbxColor.Location = new System.Drawing.Point(611, 502);
            this.tbxColor.Margin = new System.Windows.Forms.Padding(23, 0, 0, 0);
            this.tbxColor.MaxLength = 6;
            this.tbxColor.Name = "tbxColor";
            this.tbxColor.PasswordChar = '\0';
            this.tbxColor.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.tbxColor.PlaceholderText = "";
            this.tbxColor.SelectedText = "";
            this.tbxColor.ShadowDecoration.Parent = this.tbxColor;
            this.tbxColor.Size = new System.Drawing.Size(271, 36);
            this.tbxColor.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.tbxColor.TabIndex = 157;
            this.tbxColor.TextOffset = new System.Drawing.Point(-8, 0);
            this.tbxColor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxColor_KeyPress);
            // 
            // tbxName
            // 
            this.tbxName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbxName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(216)))), ((int)(((byte)(221)))));
            this.tbxName.BorderThickness = 0;
            this.tbxName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxName.DefaultText = "";
            this.tbxName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(216)))), ((int)(((byte)(221)))));
            this.tbxName.DisabledState.FillColor = System.Drawing.Color.White;
            this.tbxName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(216)))), ((int)(((byte)(221)))));
            this.tbxName.DisabledState.Parent = this.tbxName;
            this.tbxName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(216)))), ((int)(((byte)(221)))));
            this.tbxName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(142)))), ((int)(((byte)(155)))));
            this.tbxName.FocusedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(62)))));
            this.tbxName.FocusedState.Parent = this.tbxName;
            this.tbxName.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.tbxName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(71)))));
            this.tbxName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(216)))), ((int)(((byte)(221)))));
            this.tbxName.HoverState.Parent = this.tbxName;
            this.tbxName.Location = new System.Drawing.Point(24, 502);
            this.tbxName.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.tbxName.MaxLength = 11;
            this.tbxName.Name = "tbxName";
            this.tbxName.PasswordChar = '\0';
            this.tbxName.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.tbxName.PlaceholderText = "";
            this.tbxName.SelectedText = "";
            this.tbxName.ShadowDecoration.Parent = this.tbxName;
            this.tbxName.Size = new System.Drawing.Size(564, 36);
            this.tbxName.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.tbxName.TabIndex = 156;
            this.tbxName.TextOffset = new System.Drawing.Point(-8, 0);
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
            this.btnDelete.TabIndex = 155;
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
            this.btnEdit.TabIndex = 154;
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
            this.btnAdd.TabIndex = 153;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAdd.TextOffset = new System.Drawing.Point(-10, 0);
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.guna2Separator3.TabIndex = 152;
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
            this.guna2Separator1.TabIndex = 151;
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
            this.cbxShow.TabIndex = 150;
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
            this.tbxSearch.TabIndex = 149;
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
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 148;
            this.label4.Text = "Статусы";
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
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(77)))), ((int)(((byte)(110)))));
            dataGridViewCellStyle13.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(77)))), ((int)(((byte)(110)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridView1.ColumnHeadersHeight = 47;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_statuses,
            this.status_statuses,
            this.color_statuses,
            this.archive_statuses});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(118)))), ((int)(((byte)(131)))));
            dataGridViewCellStyle14.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(118)))), ((int)(((byte)(131)))));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.dataGridView1.Location = new System.Drawing.Point(0, 133);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 53;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(905, 329);
            this.dataGridView1.TabIndex = 147;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // id_statuses
            // 
            this.id_statuses.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.id_statuses.DataPropertyName = "id";
            this.id_statuses.HeaderText = "№";
            this.id_statuses.Name = "id_statuses";
            this.id_statuses.ReadOnly = true;
            this.id_statuses.Visible = false;
            this.id_statuses.Width = 69;
            // 
            // status_statuses
            // 
            this.status_statuses.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.status_statuses.DataPropertyName = "status";
            this.status_statuses.HeaderText = "Название";
            this.status_statuses.Name = "status_statuses";
            this.status_statuses.ReadOnly = true;
            // 
            // color_statuses
            // 
            this.color_statuses.DataPropertyName = "color";
            this.color_statuses.HeaderText = "Цвет (HEX)";
            this.color_statuses.Name = "color_statuses";
            this.color_statuses.ReadOnly = true;
            this.color_statuses.Width = 130;
            // 
            // archive_statuses
            // 
            this.archive_statuses.DataPropertyName = "archive";
            this.archive_statuses.HeaderText = "archive_statuses";
            this.archive_statuses.Name = "archive_statuses";
            this.archive_statuses.ReadOnly = true;
            this.archive_statuses.Visible = false;
            // 
            // StatusesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(905, 628);
            this.ControlBox = false;
            this.Controls.Add(this.guna2Separator2);
            this.Controls.Add(this.lblColorTitle);
            this.Controls.Add(this.lblNamesTitle);
            this.Controls.Add(this.tbxColor);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.guna2Separator3);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.cbxShow);
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StatusesForm";
            this.Text = "StatusesForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
        private System.Windows.Forms.Label lblColorTitle;
        private System.Windows.Forms.Label lblNamesTitle;
        private Guna.UI2.WinForms.Guna2TextBox tbxColor;
        private Guna.UI2.WinForms.Guna2TextBox tbxName;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator3;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2ComboBox cbxShow;
        public Guna.UI2.WinForms.Guna2TextBox tbxSearch;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_statuses;
        private System.Windows.Forms.DataGridViewTextBoxColumn status_statuses;
        private System.Windows.Forms.DataGridViewTextBoxColumn color_statuses;
        private System.Windows.Forms.DataGridViewTextBoxColumn archive_statuses;
    }
}