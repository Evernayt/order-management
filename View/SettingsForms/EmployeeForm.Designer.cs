
namespace Order_Management.View.SettingsForms
{
    partial class EmployeeForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblPermissionTitle = new System.Windows.Forms.Label();
            this.cbxPermission = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2Separator3 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.lblPassTitle = new System.Windows.Forms.Label();
            this.lblLoginTitle = new System.Windows.Forms.Label();
            this.lblNameTitle = new System.Windows.Forms.Label();
            this.tbxPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbxLogin = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbxName = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnEdit = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.cbxShow = new Guna.UI2.WinForms.Guna2ComboBox();
            this.tbxSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id_employee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_employee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.login_employee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pass_employee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.permission = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avatar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avatar_temp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.archive_employee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPermissionTitle
            // 
            this.lblPermissionTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPermissionTitle.AutoSize = true;
            this.lblPermissionTitle.BackColor = System.Drawing.Color.White;
            this.lblPermissionTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.lblPermissionTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(142)))), ((int)(((byte)(155)))));
            this.lblPermissionTitle.Location = new System.Drawing.Point(689, 490);
            this.lblPermissionTitle.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.lblPermissionTitle.Name = "lblPermissionTitle";
            this.lblPermissionTitle.Size = new System.Drawing.Size(42, 15);
            this.lblPermissionTitle.TabIndex = 164;
            this.lblPermissionTitle.Text = "Права";
            // 
            // cbxPermission
            // 
            this.cbxPermission.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbxPermission.BackColor = System.Drawing.Color.White;
            this.cbxPermission.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.cbxPermission.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxPermission.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPermission.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(142)))), ((int)(((byte)(155)))));
            this.cbxPermission.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(142)))), ((int)(((byte)(155)))));
            this.cbxPermission.FocusedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(156)))), ((int)(((byte)(241)))));
            this.cbxPermission.FocusedState.Parent = this.cbxPermission;
            this.cbxPermission.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbxPermission.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(207)))), ((int)(((byte)(224)))));
            this.cbxPermission.HoverState.Parent = this.cbxPermission;
            this.cbxPermission.ItemHeight = 30;
            this.cbxPermission.Items.AddRange(new object[] {
            "Сотрудник",
            "Администратор"});
            this.cbxPermission.ItemsAppearance.BackColor = System.Drawing.Color.White;
            this.cbxPermission.ItemsAppearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(112)))), ((int)(((byte)(126)))));
            this.cbxPermission.ItemsAppearance.Parent = this.cbxPermission;
            this.cbxPermission.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(156)))), ((int)(((byte)(241)))));
            this.cbxPermission.ItemsAppearance.SelectedForeColor = System.Drawing.Color.White;
            this.cbxPermission.Location = new System.Drawing.Point(692, 502);
            this.cbxPermission.Margin = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.cbxPermission.Name = "cbxPermission";
            this.cbxPermission.ShadowDecoration.Parent = this.cbxPermission;
            this.cbxPermission.Size = new System.Drawing.Size(189, 36);
            this.cbxPermission.StartIndex = 0;
            this.cbxPermission.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cbxPermission.TabIndex = 163;
            this.cbxPermission.TabStop = false;
            this.cbxPermission.TextOffset = new System.Drawing.Point(-8, 1);
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
            this.guna2Separator3.TabIndex = 162;
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
            this.guna2Separator1.TabIndex = 161;
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
            this.btnDelete.TabIndex = 159;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDelete.TextOffset = new System.Drawing.Point(-10, 0);
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblPassTitle
            // 
            this.lblPassTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPassTitle.AutoSize = true;
            this.lblPassTitle.BackColor = System.Drawing.Color.White;
            this.lblPassTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.lblPassTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(142)))), ((int)(((byte)(155)))));
            this.lblPassTitle.Location = new System.Drawing.Point(467, 490);
            this.lblPassTitle.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.lblPassTitle.Name = "lblPassTitle";
            this.lblPassTitle.Size = new System.Drawing.Size(49, 15);
            this.lblPassTitle.TabIndex = 158;
            this.lblPassTitle.Text = "Пароль";
            // 
            // lblLoginTitle
            // 
            this.lblLoginTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblLoginTitle.AutoSize = true;
            this.lblLoginTitle.BackColor = System.Drawing.Color.White;
            this.lblLoginTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.lblLoginTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(142)))), ((int)(((byte)(155)))));
            this.lblLoginTitle.Location = new System.Drawing.Point(244, 490);
            this.lblLoginTitle.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.lblLoginTitle.Name = "lblLoginTitle";
            this.lblLoginTitle.Size = new System.Drawing.Size(41, 15);
            this.lblLoginTitle.TabIndex = 156;
            this.lblLoginTitle.Text = "Логин";
            // 
            // lblNameTitle
            // 
            this.lblNameTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNameTitle.AutoSize = true;
            this.lblNameTitle.BackColor = System.Drawing.Color.White;
            this.lblNameTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.lblNameTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(142)))), ((int)(((byte)(155)))));
            this.lblNameTitle.Location = new System.Drawing.Point(21, 490);
            this.lblNameTitle.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.lblNameTitle.Name = "lblNameTitle";
            this.lblNameTitle.Size = new System.Drawing.Size(31, 15);
            this.lblNameTitle.TabIndex = 153;
            this.lblNameTitle.Text = "Имя";
            // 
            // tbxPass
            // 
            this.tbxPass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbxPass.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(216)))), ((int)(((byte)(221)))));
            this.tbxPass.BorderThickness = 0;
            this.tbxPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxPass.DefaultText = "";
            this.tbxPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(216)))), ((int)(((byte)(221)))));
            this.tbxPass.DisabledState.FillColor = System.Drawing.Color.White;
            this.tbxPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(216)))), ((int)(((byte)(221)))));
            this.tbxPass.DisabledState.Parent = this.tbxPass;
            this.tbxPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(216)))), ((int)(((byte)(221)))));
            this.tbxPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(142)))), ((int)(((byte)(155)))));
            this.tbxPass.FocusedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(62)))));
            this.tbxPass.FocusedState.Parent = this.tbxPass;
            this.tbxPass.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.tbxPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(71)))));
            this.tbxPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(216)))), ((int)(((byte)(221)))));
            this.tbxPass.HoverState.Parent = this.tbxPass;
            this.tbxPass.Location = new System.Drawing.Point(470, 502);
            this.tbxPass.Margin = new System.Windows.Forms.Padding(23, 0, 0, 0);
            this.tbxPass.MaxLength = 15;
            this.tbxPass.Name = "tbxPass";
            this.tbxPass.PasswordChar = '\0';
            this.tbxPass.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.tbxPass.PlaceholderText = "";
            this.tbxPass.SelectedText = "";
            this.tbxPass.ShadowDecoration.Parent = this.tbxPass;
            this.tbxPass.Size = new System.Drawing.Size(200, 36);
            this.tbxPass.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.tbxPass.TabIndex = 157;
            this.tbxPass.TextOffset = new System.Drawing.Point(-8, 0);
            // 
            // tbxLogin
            // 
            this.tbxLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbxLogin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(216)))), ((int)(((byte)(221)))));
            this.tbxLogin.BorderThickness = 0;
            this.tbxLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxLogin.DefaultText = "";
            this.tbxLogin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(216)))), ((int)(((byte)(221)))));
            this.tbxLogin.DisabledState.FillColor = System.Drawing.Color.White;
            this.tbxLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(216)))), ((int)(((byte)(221)))));
            this.tbxLogin.DisabledState.Parent = this.tbxLogin;
            this.tbxLogin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(216)))), ((int)(((byte)(221)))));
            this.tbxLogin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(142)))), ((int)(((byte)(155)))));
            this.tbxLogin.FocusedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(62)))));
            this.tbxLogin.FocusedState.Parent = this.tbxLogin;
            this.tbxLogin.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.tbxLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(71)))));
            this.tbxLogin.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(216)))), ((int)(((byte)(221)))));
            this.tbxLogin.HoverState.Parent = this.tbxLogin;
            this.tbxLogin.Location = new System.Drawing.Point(247, 502);
            this.tbxLogin.Margin = new System.Windows.Forms.Padding(23, 0, 0, 0);
            this.tbxLogin.MaxLength = 15;
            this.tbxLogin.Name = "tbxLogin";
            this.tbxLogin.PasswordChar = '\0';
            this.tbxLogin.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.tbxLogin.PlaceholderText = "";
            this.tbxLogin.SelectedText = "";
            this.tbxLogin.ShadowDecoration.Parent = this.tbxLogin;
            this.tbxLogin.Size = new System.Drawing.Size(200, 36);
            this.tbxLogin.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.tbxLogin.TabIndex = 155;
            this.tbxLogin.TextOffset = new System.Drawing.Point(-8, 0);
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
            this.tbxName.MaxLength = 15;
            this.tbxName.Name = "tbxName";
            this.tbxName.PasswordChar = '\0';
            this.tbxName.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.tbxName.PlaceholderText = "";
            this.tbxName.SelectedText = "";
            this.tbxName.ShadowDecoration.Parent = this.tbxName;
            this.tbxName.Size = new System.Drawing.Size(200, 36);
            this.tbxName.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.tbxName.TabIndex = 154;
            this.tbxName.TextOffset = new System.Drawing.Point(-8, 0);
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
            this.btnEdit.TabIndex = 152;
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
            this.btnAdd.TabIndex = 151;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAdd.TextOffset = new System.Drawing.Point(-10, 0);
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 148;
            this.label4.Text = "Сотрудники";
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
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(77)))), ((int)(((byte)(110)))));
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(77)))), ((int)(((byte)(110)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.ColumnHeadersHeight = 47;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_employee,
            this.name_employee,
            this.login_employee,
            this.pass_employee,
            this.permission,
            this.avatar,
            this.avatar_temp,
            this.archive_employee});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(118)))), ((int)(((byte)(131)))));
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(118)))), ((int)(((byte)(131)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.dataGridView1.Location = new System.Drawing.Point(0, 133);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(0, 24, 0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 53;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(905, 329);
            this.dataGridView1.TabIndex = 147;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // id_employee
            // 
            this.id_employee.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.id_employee.DataPropertyName = "id";
            this.id_employee.HeaderText = "№";
            this.id_employee.Name = "id_employee";
            this.id_employee.ReadOnly = true;
            this.id_employee.Visible = false;
            this.id_employee.Width = 69;
            // 
            // name_employee
            // 
            this.name_employee.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name_employee.DataPropertyName = "name_employee";
            this.name_employee.HeaderText = "Имя";
            this.name_employee.Name = "name_employee";
            this.name_employee.ReadOnly = true;
            // 
            // login_employee
            // 
            this.login_employee.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.login_employee.DataPropertyName = "login";
            this.login_employee.HeaderText = "Логин";
            this.login_employee.Name = "login_employee";
            this.login_employee.ReadOnly = true;
            // 
            // pass_employee
            // 
            this.pass_employee.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pass_employee.DataPropertyName = "pass";
            this.pass_employee.HeaderText = "Пароль";
            this.pass_employee.Name = "pass_employee";
            this.pass_employee.ReadOnly = true;
            // 
            // permission
            // 
            this.permission.DataPropertyName = "permission";
            this.permission.HeaderText = "Права";
            this.permission.Name = "permission";
            this.permission.ReadOnly = true;
            // 
            // avatar
            // 
            this.avatar.DataPropertyName = "avatar";
            this.avatar.HeaderText = "avatar";
            this.avatar.Name = "avatar";
            this.avatar.ReadOnly = true;
            this.avatar.Visible = false;
            // 
            // avatar_temp
            // 
            this.avatar_temp.DataPropertyName = "avatar_temp";
            this.avatar_temp.HeaderText = "avatar_temp";
            this.avatar_temp.Name = "avatar_temp";
            this.avatar_temp.ReadOnly = true;
            this.avatar_temp.Visible = false;
            // 
            // archive_employee
            // 
            this.archive_employee.DataPropertyName = "archive";
            this.archive_employee.HeaderText = "archive";
            this.archive_employee.Name = "archive_employee";
            this.archive_employee.ReadOnly = true;
            this.archive_employee.Visible = false;
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(905, 628);
            this.ControlBox = false;
            this.Controls.Add(this.lblPermissionTitle);
            this.Controls.Add(this.cbxPermission);
            this.Controls.Add(this.guna2Separator3);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.guna2Separator2);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblPassTitle);
            this.Controls.Add(this.lblLoginTitle);
            this.Controls.Add(this.lblNameTitle);
            this.Controls.Add(this.tbxPass);
            this.Controls.Add(this.tbxLogin);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbxShow);
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeeForm";
            this.Text = "EmployeeForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPermissionTitle;
        private Guna.UI2.WinForms.Guna2ComboBox cbxPermission;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator3;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private System.Windows.Forms.Label lblPassTitle;
        private System.Windows.Forms.Label lblLoginTitle;
        private System.Windows.Forms.Label lblNameTitle;
        private Guna.UI2.WinForms.Guna2TextBox tbxPass;
        private Guna.UI2.WinForms.Guna2TextBox tbxLogin;
        private Guna.UI2.WinForms.Guna2TextBox tbxName;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2ComboBox cbxShow;
        public Guna.UI2.WinForms.Guna2TextBox tbxSearch;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_employee;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_employee;
        private System.Windows.Forms.DataGridViewTextBoxColumn login_employee;
        private System.Windows.Forms.DataGridViewTextBoxColumn pass_employee;
        private System.Windows.Forms.DataGridViewTextBoxColumn permission;
        private System.Windows.Forms.DataGridViewTextBoxColumn avatar;
        private System.Windows.Forms.DataGridViewTextBoxColumn avatar_temp;
        private System.Windows.Forms.DataGridViewTextBoxColumn archive_employee;
    }
}