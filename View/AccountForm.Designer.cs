
namespace Order_Management
{
    partial class AccountForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountForm));
            this.lblPermission = new System.Windows.Forms.Label();
            this.pMain = new Guna.UI2.WinForms.Guna2Panel();
            this.lblLoginError = new System.Windows.Forms.Label();
            this.lblNameError = new System.Windows.Forms.Label();
            this.lblNewPassError = new System.Windows.Forms.Label();
            this.lblConfirmNewPassError = new System.Windows.Forms.Label();
            this.lblPrevPassError = new System.Windows.Forms.Label();
            this.btnEditPass = new Guna.UI2.WinForms.Guna2Button();
            this.btnEdit = new Guna.UI2.WinForms.Guna2Button();
            this.lblConfirmNewPassTitle = new System.Windows.Forms.Label();
            this.tbxConfirmNewPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblNewPassTitle = new System.Windows.Forms.Label();
            this.tbxNewPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblPrevPassTitle = new System.Windows.Forms.Label();
            this.tbxPrevPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2VSeparator2 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.lblLoginTitle = new System.Windows.Forms.Label();
            this.tbxLogin = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblNameTitle = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxName = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2VSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.pbxAvatar = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.progressBar1 = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPermission
            // 
            this.lblPermission.BackColor = System.Drawing.Color.White;
            this.lblPermission.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblPermission.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(71)))));
            this.lblPermission.Location = new System.Drawing.Point(13, 146);
            this.lblPermission.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblPermission.Name = "lblPermission";
            this.lblPermission.Size = new System.Drawing.Size(136, 20);
            this.lblPermission.TabIndex = 64;
            this.lblPermission.Text = "Сотрудник";
            this.lblPermission.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pMain
            // 
            this.pMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pMain.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.pMain.BorderRadius = 4;
            this.pMain.BorderThickness = 1;
            this.pMain.Controls.Add(this.lblLoginError);
            this.pMain.Controls.Add(this.lblNameError);
            this.pMain.Controls.Add(this.lblNewPassError);
            this.pMain.Controls.Add(this.lblConfirmNewPassError);
            this.pMain.Controls.Add(this.lblPrevPassError);
            this.pMain.Controls.Add(this.btnEditPass);
            this.pMain.Controls.Add(this.btnEdit);
            this.pMain.Controls.Add(this.lblConfirmNewPassTitle);
            this.pMain.Controls.Add(this.tbxConfirmNewPass);
            this.pMain.Controls.Add(this.lblNewPassTitle);
            this.pMain.Controls.Add(this.tbxNewPass);
            this.pMain.Controls.Add(this.lblPrevPassTitle);
            this.pMain.Controls.Add(this.tbxPrevPass);
            this.pMain.Controls.Add(this.label3);
            this.pMain.Controls.Add(this.guna2VSeparator2);
            this.pMain.Controls.Add(this.lblLoginTitle);
            this.pMain.Controls.Add(this.tbxLogin);
            this.pMain.Controls.Add(this.lblNameTitle);
            this.pMain.Controls.Add(this.label5);
            this.pMain.Controls.Add(this.tbxName);
            this.pMain.Controls.Add(this.guna2VSeparator1);
            this.pMain.Controls.Add(this.pbxAvatar);
            this.pMain.Controls.Add(this.lblPermission);
            this.pMain.FillColor = System.Drawing.Color.White;
            this.pMain.Location = new System.Drawing.Point(35, 35);
            this.pMain.Margin = new System.Windows.Forms.Padding(26);
            this.pMain.Name = "pMain";
            this.pMain.ShadowDecoration.Parent = this.pMain;
            this.pMain.Size = new System.Drawing.Size(1196, 636);
            this.pMain.TabIndex = 65;
            // 
            // lblLoginError
            // 
            this.lblLoginError.BackColor = System.Drawing.Color.White;
            this.lblLoginError.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblLoginError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(104)))), ((int)(((byte)(91)))));
            this.lblLoginError.Location = new System.Drawing.Point(202, 205);
            this.lblLoginError.Name = "lblLoginError";
            this.lblLoginError.Size = new System.Drawing.Size(390, 13);
            this.lblLoginError.TabIndex = 126;
            this.lblLoginError.Text = "Введите логин";
            this.lblLoginError.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblLoginError.Visible = false;
            // 
            // lblNameError
            // 
            this.lblNameError.BackColor = System.Drawing.Color.White;
            this.lblNameError.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblNameError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(104)))), ((int)(((byte)(91)))));
            this.lblNameError.Location = new System.Drawing.Point(202, 131);
            this.lblNameError.Name = "lblNameError";
            this.lblNameError.Size = new System.Drawing.Size(390, 13);
            this.lblNameError.TabIndex = 125;
            this.lblNameError.Text = "Введите имя";
            this.lblNameError.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNameError.Visible = false;
            // 
            // lblNewPassError
            // 
            this.lblNewPassError.BackColor = System.Drawing.Color.White;
            this.lblNewPassError.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblNewPassError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(104)))), ((int)(((byte)(91)))));
            this.lblNewPassError.Location = new System.Drawing.Point(670, 205);
            this.lblNewPassError.Name = "lblNewPassError";
            this.lblNewPassError.Size = new System.Drawing.Size(390, 13);
            this.lblNewPassError.TabIndex = 124;
            this.lblNewPassError.Text = "Новый пароль не должен совпадать с предыдущим";
            this.lblNewPassError.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNewPassError.Visible = false;
            // 
            // lblConfirmNewPassError
            // 
            this.lblConfirmNewPassError.BackColor = System.Drawing.Color.White;
            this.lblConfirmNewPassError.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblConfirmNewPassError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(104)))), ((int)(((byte)(91)))));
            this.lblConfirmNewPassError.Location = new System.Drawing.Point(670, 279);
            this.lblConfirmNewPassError.Name = "lblConfirmNewPassError";
            this.lblConfirmNewPassError.Size = new System.Drawing.Size(390, 13);
            this.lblConfirmNewPassError.TabIndex = 123;
            this.lblConfirmNewPassError.Text = "Пароли не совпадают";
            this.lblConfirmNewPassError.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblConfirmNewPassError.Visible = false;
            // 
            // lblPrevPassError
            // 
            this.lblPrevPassError.BackColor = System.Drawing.Color.White;
            this.lblPrevPassError.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblPrevPassError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(104)))), ((int)(((byte)(91)))));
            this.lblPrevPassError.Location = new System.Drawing.Point(670, 131);
            this.lblPrevPassError.Name = "lblPrevPassError";
            this.lblPrevPassError.Size = new System.Drawing.Size(390, 13);
            this.lblPrevPassError.TabIndex = 122;
            this.lblPrevPassError.Text = "Предыдущий пароль введён не правильно";
            this.lblPrevPassError.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPrevPassError.Visible = false;
            // 
            // btnEditPass
            // 
            this.btnEditPass.BackColor = System.Drawing.Color.White;
            this.btnEditPass.CheckedState.Parent = this.btnEditPass;
            this.btnEditPass.CustomImages.Parent = this.btnEditPass;
            this.btnEditPass.DisabledState.Parent = this.btnEditPass;
            this.btnEditPass.FillColor = System.Drawing.Color.White;
            this.btnEditPass.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.btnEditPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(156)))), ((int)(((byte)(241)))));
            this.btnEditPass.HoverState.FillColor = System.Drawing.Color.White;
            this.btnEditPass.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(175)))), ((int)(((byte)(249)))));
            this.btnEditPass.HoverState.Parent = this.btnEditPass;
            this.btnEditPass.Location = new System.Drawing.Point(669, 317);
            this.btnEditPass.Margin = new System.Windows.Forms.Padding(0);
            this.btnEditPass.Name = "btnEditPass";
            this.btnEditPass.PressedColor = System.Drawing.Color.White;
            this.btnEditPass.ShadowDecoration.Parent = this.btnEditPass;
            this.btnEditPass.Size = new System.Drawing.Size(145, 30);
            this.btnEditPass.TabIndex = 121;
            this.btnEditPass.Text = "Изменить пароль";
            this.btnEditPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnEditPass.TextOffset = new System.Drawing.Point(-10, 0);
            this.btnEditPass.Click += new System.EventHandler(this.btnEditPass_Click);
            // 
            // btnEdit
            // 
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
            this.btnEdit.Location = new System.Drawing.Point(198, 243);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(0);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.PressedColor = System.Drawing.Color.White;
            this.btnEdit.ShadowDecoration.Parent = this.btnEdit;
            this.btnEdit.Size = new System.Drawing.Size(90, 30);
            this.btnEdit.TabIndex = 120;
            this.btnEdit.Text = "Изменить";
            this.btnEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnEdit.TextOffset = new System.Drawing.Point(-10, 0);
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lblConfirmNewPassTitle
            // 
            this.lblConfirmNewPassTitle.AutoSize = true;
            this.lblConfirmNewPassTitle.BackColor = System.Drawing.Color.White;
            this.lblConfirmNewPassTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.lblConfirmNewPassTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(142)))), ((int)(((byte)(155)))));
            this.lblConfirmNewPassTitle.Location = new System.Drawing.Point(670, 226);
            this.lblConfirmNewPassTitle.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.lblConfirmNewPassTitle.Name = "lblConfirmNewPassTitle";
            this.lblConfirmNewPassTitle.Size = new System.Drawing.Size(150, 15);
            this.lblConfirmNewPassTitle.TabIndex = 79;
            this.lblConfirmNewPassTitle.Text = "Повторите новый пароль";
            // 
            // tbxConfirmNewPass
            // 
            this.tbxConfirmNewPass.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(216)))), ((int)(((byte)(221)))));
            this.tbxConfirmNewPass.BorderThickness = 0;
            this.tbxConfirmNewPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxConfirmNewPass.DefaultText = "";
            this.tbxConfirmNewPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(216)))), ((int)(((byte)(221)))));
            this.tbxConfirmNewPass.DisabledState.FillColor = System.Drawing.Color.White;
            this.tbxConfirmNewPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(216)))), ((int)(((byte)(221)))));
            this.tbxConfirmNewPass.DisabledState.Parent = this.tbxConfirmNewPass;
            this.tbxConfirmNewPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(216)))), ((int)(((byte)(221)))));
            this.tbxConfirmNewPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(142)))), ((int)(((byte)(155)))));
            this.tbxConfirmNewPass.FocusedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(62)))));
            this.tbxConfirmNewPass.FocusedState.Parent = this.tbxConfirmNewPass;
            this.tbxConfirmNewPass.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.tbxConfirmNewPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(71)))));
            this.tbxConfirmNewPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(216)))), ((int)(((byte)(221)))));
            this.tbxConfirmNewPass.HoverState.Parent = this.tbxConfirmNewPass;
            this.tbxConfirmNewPass.Location = new System.Drawing.Point(673, 238);
            this.tbxConfirmNewPass.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.tbxConfirmNewPass.MaxLength = 15;
            this.tbxConfirmNewPass.Name = "tbxConfirmNewPass";
            this.tbxConfirmNewPass.PasswordChar = '\0';
            this.tbxConfirmNewPass.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.tbxConfirmNewPass.PlaceholderText = "";
            this.tbxConfirmNewPass.SelectedText = "";
            this.tbxConfirmNewPass.ShadowDecoration.Parent = this.tbxConfirmNewPass;
            this.tbxConfirmNewPass.Size = new System.Drawing.Size(390, 36);
            this.tbxConfirmNewPass.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.tbxConfirmNewPass.TabIndex = 80;
            this.tbxConfirmNewPass.TextOffset = new System.Drawing.Point(-8, 0);
            this.tbxConfirmNewPass.UseSystemPasswordChar = true;
            // 
            // lblNewPassTitle
            // 
            this.lblNewPassTitle.AutoSize = true;
            this.lblNewPassTitle.BackColor = System.Drawing.Color.White;
            this.lblNewPassTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.lblNewPassTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(142)))), ((int)(((byte)(155)))));
            this.lblNewPassTitle.Location = new System.Drawing.Point(670, 152);
            this.lblNewPassTitle.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.lblNewPassTitle.Name = "lblNewPassTitle";
            this.lblNewPassTitle.Size = new System.Drawing.Size(89, 15);
            this.lblNewPassTitle.TabIndex = 77;
            this.lblNewPassTitle.Text = "Новый пароль";
            // 
            // tbxNewPass
            // 
            this.tbxNewPass.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(216)))), ((int)(((byte)(221)))));
            this.tbxNewPass.BorderThickness = 0;
            this.tbxNewPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxNewPass.DefaultText = "";
            this.tbxNewPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(216)))), ((int)(((byte)(221)))));
            this.tbxNewPass.DisabledState.FillColor = System.Drawing.Color.White;
            this.tbxNewPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(216)))), ((int)(((byte)(221)))));
            this.tbxNewPass.DisabledState.Parent = this.tbxNewPass;
            this.tbxNewPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(216)))), ((int)(((byte)(221)))));
            this.tbxNewPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(142)))), ((int)(((byte)(155)))));
            this.tbxNewPass.FocusedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(62)))));
            this.tbxNewPass.FocusedState.Parent = this.tbxNewPass;
            this.tbxNewPass.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.tbxNewPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(71)))));
            this.tbxNewPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(216)))), ((int)(((byte)(221)))));
            this.tbxNewPass.HoverState.Parent = this.tbxNewPass;
            this.tbxNewPass.Location = new System.Drawing.Point(673, 164);
            this.tbxNewPass.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.tbxNewPass.MaxLength = 15;
            this.tbxNewPass.Name = "tbxNewPass";
            this.tbxNewPass.PasswordChar = '\0';
            this.tbxNewPass.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.tbxNewPass.PlaceholderText = "";
            this.tbxNewPass.SelectedText = "";
            this.tbxNewPass.ShadowDecoration.Parent = this.tbxNewPass;
            this.tbxNewPass.Size = new System.Drawing.Size(390, 36);
            this.tbxNewPass.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.tbxNewPass.TabIndex = 78;
            this.tbxNewPass.TextOffset = new System.Drawing.Point(-8, 0);
            this.tbxNewPass.UseSystemPasswordChar = true;
            // 
            // lblPrevPassTitle
            // 
            this.lblPrevPassTitle.AutoSize = true;
            this.lblPrevPassTitle.BackColor = System.Drawing.Color.White;
            this.lblPrevPassTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.lblPrevPassTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(142)))), ((int)(((byte)(155)))));
            this.lblPrevPassTitle.Location = new System.Drawing.Point(670, 78);
            this.lblPrevPassTitle.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.lblPrevPassTitle.Name = "lblPrevPassTitle";
            this.lblPrevPassTitle.Size = new System.Drawing.Size(125, 15);
            this.lblPrevPassTitle.TabIndex = 75;
            this.lblPrevPassTitle.Text = "Предыдущий пароль";
            // 
            // tbxPrevPass
            // 
            this.tbxPrevPass.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(216)))), ((int)(((byte)(221)))));
            this.tbxPrevPass.BorderThickness = 0;
            this.tbxPrevPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxPrevPass.DefaultText = "";
            this.tbxPrevPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(216)))), ((int)(((byte)(221)))));
            this.tbxPrevPass.DisabledState.FillColor = System.Drawing.Color.White;
            this.tbxPrevPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(216)))), ((int)(((byte)(221)))));
            this.tbxPrevPass.DisabledState.Parent = this.tbxPrevPass;
            this.tbxPrevPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(216)))), ((int)(((byte)(221)))));
            this.tbxPrevPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(142)))), ((int)(((byte)(155)))));
            this.tbxPrevPass.FocusedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(62)))));
            this.tbxPrevPass.FocusedState.Parent = this.tbxPrevPass;
            this.tbxPrevPass.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.tbxPrevPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(71)))));
            this.tbxPrevPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(216)))), ((int)(((byte)(221)))));
            this.tbxPrevPass.HoverState.Parent = this.tbxPrevPass;
            this.tbxPrevPass.Location = new System.Drawing.Point(673, 90);
            this.tbxPrevPass.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.tbxPrevPass.MaxLength = 15;
            this.tbxPrevPass.Name = "tbxPrevPass";
            this.tbxPrevPass.PasswordChar = '\0';
            this.tbxPrevPass.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.tbxPrevPass.PlaceholderText = "";
            this.tbxPrevPass.SelectedText = "";
            this.tbxPrevPass.ShadowDecoration.Parent = this.tbxPrevPass;
            this.tbxPrevPass.Size = new System.Drawing.Size(390, 36);
            this.tbxPrevPass.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.tbxPrevPass.TabIndex = 76;
            this.tbxPrevPass.TextOffset = new System.Drawing.Point(-8, 0);
            this.tbxPrevPass.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(71)))));
            this.label3.Location = new System.Drawing.Point(669, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 20);
            this.label3.TabIndex = 74;
            this.label3.Text = "Изменить пароль";
            // 
            // guna2VSeparator2
            // 
            this.guna2VSeparator2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.guna2VSeparator2.BackColor = System.Drawing.Color.White;
            this.guna2VSeparator2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.guna2VSeparator2.Location = new System.Drawing.Point(627, 31);
            this.guna2VSeparator2.Margin = new System.Windows.Forms.Padding(0, 31, 0, 31);
            this.guna2VSeparator2.Name = "guna2VSeparator2";
            this.guna2VSeparator2.Size = new System.Drawing.Size(10, 574);
            this.guna2VSeparator2.TabIndex = 73;
            // 
            // lblLoginTitle
            // 
            this.lblLoginTitle.AutoSize = true;
            this.lblLoginTitle.BackColor = System.Drawing.Color.White;
            this.lblLoginTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.lblLoginTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(142)))), ((int)(((byte)(155)))));
            this.lblLoginTitle.Location = new System.Drawing.Point(199, 152);
            this.lblLoginTitle.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.lblLoginTitle.Name = "lblLoginTitle";
            this.lblLoginTitle.Size = new System.Drawing.Size(41, 15);
            this.lblLoginTitle.TabIndex = 71;
            this.lblLoginTitle.Text = "Логин";
            // 
            // tbxLogin
            // 
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
            this.tbxLogin.Location = new System.Drawing.Point(202, 164);
            this.tbxLogin.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.tbxLogin.MaxLength = 15;
            this.tbxLogin.Name = "tbxLogin";
            this.tbxLogin.PasswordChar = '\0';
            this.tbxLogin.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.tbxLogin.PlaceholderText = "";
            this.tbxLogin.SelectedText = "";
            this.tbxLogin.ShadowDecoration.Parent = this.tbxLogin;
            this.tbxLogin.Size = new System.Drawing.Size(390, 36);
            this.tbxLogin.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.tbxLogin.TabIndex = 72;
            this.tbxLogin.TextOffset = new System.Drawing.Point(-8, 0);
            // 
            // lblNameTitle
            // 
            this.lblNameTitle.AutoSize = true;
            this.lblNameTitle.BackColor = System.Drawing.Color.White;
            this.lblNameTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.lblNameTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(142)))), ((int)(((byte)(155)))));
            this.lblNameTitle.Location = new System.Drawing.Point(199, 78);
            this.lblNameTitle.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.lblNameTitle.Name = "lblNameTitle";
            this.lblNameTitle.Size = new System.Drawing.Size(31, 15);
            this.lblNameTitle.TabIndex = 69;
            this.lblNameTitle.Text = "Имя";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(71)))));
            this.label5.Location = new System.Drawing.Point(198, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 20);
            this.label5.TabIndex = 66;
            this.label5.Text = "Основная информация";
            // 
            // tbxName
            // 
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
            this.tbxName.Location = new System.Drawing.Point(202, 90);
            this.tbxName.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.tbxName.MaxLength = 15;
            this.tbxName.Name = "tbxName";
            this.tbxName.PasswordChar = '\0';
            this.tbxName.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.tbxName.PlaceholderText = "";
            this.tbxName.SelectedText = "";
            this.tbxName.ShadowDecoration.Parent = this.tbxName;
            this.tbxName.Size = new System.Drawing.Size(390, 36);
            this.tbxName.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.tbxName.TabIndex = 70;
            this.tbxName.TextOffset = new System.Drawing.Point(-8, 0);
            // 
            // guna2VSeparator1
            // 
            this.guna2VSeparator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.guna2VSeparator1.BackColor = System.Drawing.Color.White;
            this.guna2VSeparator1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.guna2VSeparator1.Location = new System.Drawing.Point(156, 31);
            this.guna2VSeparator1.Margin = new System.Windows.Forms.Padding(0, 31, 0, 31);
            this.guna2VSeparator1.Name = "guna2VSeparator1";
            this.guna2VSeparator1.Size = new System.Drawing.Size(10, 574);
            this.guna2VSeparator1.TabIndex = 65;
            // 
            // pbxAvatar
            // 
            this.pbxAvatar.BackColor = System.Drawing.Color.White;
            this.pbxAvatar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxAvatar.Image = global::Order_Management.Properties.Resources.userIcon;
            this.pbxAvatar.ImageRotate = 0F;
            this.pbxAvatar.Location = new System.Drawing.Point(31, 31);
            this.pbxAvatar.Name = "pbxAvatar";
            this.pbxAvatar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pbxAvatar.ShadowDecoration.Parent = this.pbxAvatar;
            this.pbxAvatar.Size = new System.Drawing.Size(100, 100);
            this.pbxAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxAvatar.TabIndex = 0;
            this.pbxAvatar.TabStop = false;
            this.toolTip1.SetToolTip(this.pbxAvatar, "Изменить фото профиля");
            this.pbxAvatar.Click += new System.EventHandler(this.pbxAvatar_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.progressBar1.Location = new System.Drawing.Point(0, 0);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(156)))), ((int)(((byte)(241)))));
            this.progressBar1.ShadowDecoration.BorderRadius = 0;
            this.progressBar1.ShadowDecoration.Parent = this.progressBar1;
            this.progressBar1.Size = new System.Drawing.Size(1266, 3);
            this.progressBar1.TabIndex = 66;
            this.progressBar1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // toolTip1
            // 
            this.toolTip1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(62)))));
            // 
            // AccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1266, 706);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pMain);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AccountForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Аккаунт - Order Management";
            this.Load += new System.EventHandler(this.AccountForm_Load);
            this.pMain.ResumeLayout(false);
            this.pMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAvatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CirclePictureBox pbxAvatar;
        private System.Windows.Forms.Label lblPermission;
        private Guna.UI2.WinForms.Guna2Panel pMain;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblLoginTitle;
        private Guna.UI2.WinForms.Guna2TextBox tbxLogin;
        private System.Windows.Forms.Label lblNameTitle;
        private Guna.UI2.WinForms.Guna2TextBox tbxName;
        private System.Windows.Forms.Label lblConfirmNewPassTitle;
        private Guna.UI2.WinForms.Guna2TextBox tbxConfirmNewPass;
        private System.Windows.Forms.Label lblNewPassTitle;
        private Guna.UI2.WinForms.Guna2TextBox tbxNewPass;
        private System.Windows.Forms.Label lblPrevPassTitle;
        private Guna.UI2.WinForms.Guna2TextBox tbxPrevPass;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator2;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
        private Guna.UI2.WinForms.Guna2Button btnEditPass;
        private Guna.UI2.WinForms.Guna2ProgressBar progressBar1;
        private System.Windows.Forms.Label lblPrevPassError;
        private System.Windows.Forms.Label lblConfirmNewPassError;
        private System.Windows.Forms.Label lblNewPassError;
        private System.Windows.Forms.Label lblLoginError;
        private System.Windows.Forms.Label lblNameError;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}