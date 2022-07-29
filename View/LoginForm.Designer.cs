namespace Order_Management
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.pMain = new Guna.UI2.WinForms.Guna2Panel();
            this.pbxAvatar = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lblLoginError = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSystem = new Guna.UI2.WinForms.Guna2Button();
            this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.lblPassTitle = new System.Windows.Forms.Label();
            this.tbxPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblLoginTitle = new System.Windows.Forms.Label();
            this.tbxLogin = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.lblPassError = new System.Windows.Forms.Label();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.ucUpdater1 = new Order_Management.UserControls.ucUpdater();
            this.pMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // pMain
            // 
            this.pMain.BackColor = System.Drawing.Color.White;
            this.pMain.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.pMain.BorderThickness = 1;
            this.pMain.Controls.Add(this.pbxAvatar);
            this.pMain.Controls.Add(this.lblLoginError);
            this.pMain.Controls.Add(this.label2);
            this.pMain.Controls.Add(this.btnSystem);
            this.pMain.Controls.Add(this.btnLogin);
            this.pMain.Controls.Add(this.lblPassTitle);
            this.pMain.Controls.Add(this.tbxPass);
            this.pMain.Controls.Add(this.lblLoginTitle);
            this.pMain.Controls.Add(this.tbxLogin);
            this.pMain.Controls.Add(this.guna2ControlBox1);
            this.pMain.Controls.Add(this.lblPassError);
            this.pMain.Location = new System.Drawing.Point(0, 0);
            this.pMain.Name = "pMain";
            this.pMain.ShadowDecoration.Parent = this.pMain;
            this.pMain.Size = new System.Drawing.Size(375, 495);
            this.pMain.TabIndex = 101;
            // 
            // pbxAvatar
            // 
            this.pbxAvatar.Image = global::Order_Management.Properties.Resources.userIcon;
            this.pbxAvatar.ImageRotate = 0F;
            this.pbxAvatar.Location = new System.Drawing.Point(132, 77);
            this.pbxAvatar.Name = "pbxAvatar";
            this.pbxAvatar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pbxAvatar.ShadowDecoration.Parent = this.pbxAvatar;
            this.pbxAvatar.Size = new System.Drawing.Size(110, 110);
            this.pbxAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxAvatar.TabIndex = 121;
            this.pbxAvatar.TabStop = false;
            // 
            // lblLoginError
            // 
            this.lblLoginError.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblLoginError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(104)))), ((int)(((byte)(91)))));
            this.lblLoginError.Location = new System.Drawing.Point(42, 308);
            this.lblLoginError.Name = "lblLoginError";
            this.lblLoginError.Size = new System.Drawing.Size(291, 13);
            this.lblLoginError.TabIndex = 119;
            this.lblLoginError.Text = "Введите логин";
            this.lblLoginError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLoginError.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(71)))));
            this.label2.Location = new System.Drawing.Point(134, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 118;
            this.label2.Text = "Авторизация";
            // 
            // btnSystem
            // 
            this.btnSystem.BackColor = System.Drawing.Color.White;
            this.btnSystem.CheckedState.Parent = this.btnSystem;
            this.btnSystem.CustomImages.Parent = this.btnSystem;
            this.btnSystem.DisabledState.Parent = this.btnSystem;
            this.btnSystem.FillColor = System.Drawing.Color.White;
            this.btnSystem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSystem.ForeColor = System.Drawing.Color.White;
            this.btnSystem.HoverState.FillColor = System.Drawing.Color.White;
            this.btnSystem.HoverState.Image = global::Order_Management.Properties.Resources.systemIconOn;
            this.btnSystem.HoverState.Parent = this.btnSystem;
            this.btnSystem.Image = global::Order_Management.Properties.Resources.systemIconOff;
            this.btnSystem.ImageSize = new System.Drawing.Size(16, 16);
            this.btnSystem.Location = new System.Drawing.Point(1, 1);
            this.btnSystem.Margin = new System.Windows.Forms.Padding(0);
            this.btnSystem.Name = "btnSystem";
            this.btnSystem.PressedColor = System.Drawing.Color.White;
            this.btnSystem.ShadowDecoration.Parent = this.btnSystem;
            this.btnSystem.Size = new System.Drawing.Size(40, 40);
            this.btnSystem.TabIndex = 117;
            this.btnSystem.TabStop = false;
            this.btnSystem.Click += new System.EventHandler(this.btnSystem_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(156)))), ((int)(((byte)(241)))));
            this.btnLogin.BorderRadius = 4;
            this.btnLogin.BorderThickness = 1;
            this.btnLogin.CheckedState.Parent = this.btnLogin;
            this.btnLogin.CustomImages.Parent = this.btnLogin;
            this.btnLogin.DisabledState.Parent = this.btnLogin;
            this.btnLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(156)))), ((int)(((byte)(241)))));
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(175)))), ((int)(((byte)(249)))));
            this.btnLogin.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(175)))), ((int)(((byte)(249)))));
            this.btnLogin.HoverState.Parent = this.btnLogin;
            this.btnLogin.Location = new System.Drawing.Point(97, 402);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(0);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.PressedDepth = 20;
            this.btnLogin.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(156)))), ((int)(((byte)(241)))));
            this.btnLogin.ShadowDecoration.Parent = this.btnLogin;
            this.btnLogin.Size = new System.Drawing.Size(180, 42);
            this.btnLogin.TabIndex = 113;
            this.btnLogin.TabStop = false;
            this.btnLogin.Text = "Войти";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblPassTitle
            // 
            this.lblPassTitle.AutoSize = true;
            this.lblPassTitle.BackColor = System.Drawing.Color.White;
            this.lblPassTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.lblPassTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(142)))), ((int)(((byte)(155)))));
            this.lblPassTitle.Location = new System.Drawing.Point(93, 322);
            this.lblPassTitle.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.lblPassTitle.Name = "lblPassTitle";
            this.lblPassTitle.Size = new System.Drawing.Size(49, 15);
            this.lblPassTitle.TabIndex = 105;
            this.lblPassTitle.Text = "Пароль";
            // 
            // tbxPass
            // 
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
            this.tbxPass.Location = new System.Drawing.Point(97, 334);
            this.tbxPass.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.tbxPass.MaxLength = 15;
            this.tbxPass.Name = "tbxPass";
            this.tbxPass.PasswordChar = '\0';
            this.tbxPass.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.tbxPass.PlaceholderText = "";
            this.tbxPass.SelectedText = "";
            this.tbxPass.ShadowDecoration.Parent = this.tbxPass;
            this.tbxPass.Size = new System.Drawing.Size(180, 36);
            this.tbxPass.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.tbxPass.TabIndex = 0;
            this.tbxPass.TextOffset = new System.Drawing.Point(-8, 0);
            this.tbxPass.UseSystemPasswordChar = true;
            // 
            // lblLoginTitle
            // 
            this.lblLoginTitle.AutoSize = true;
            this.lblLoginTitle.BackColor = System.Drawing.Color.White;
            this.lblLoginTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.lblLoginTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(142)))), ((int)(((byte)(155)))));
            this.lblLoginTitle.Location = new System.Drawing.Point(94, 254);
            this.lblLoginTitle.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.lblLoginTitle.Name = "lblLoginTitle";
            this.lblLoginTitle.Size = new System.Drawing.Size(41, 15);
            this.lblLoginTitle.TabIndex = 103;
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
            this.tbxLogin.Location = new System.Drawing.Point(97, 266);
            this.tbxLogin.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.tbxLogin.MaxLength = 15;
            this.tbxLogin.Name = "tbxLogin";
            this.tbxLogin.PasswordChar = '\0';
            this.tbxLogin.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.tbxLogin.PlaceholderText = "";
            this.tbxLogin.SelectedText = "";
            this.tbxLogin.ShadowDecoration.Parent = this.tbxLogin;
            this.tbxLogin.Size = new System.Drawing.Size(180, 36);
            this.tbxLogin.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.tbxLogin.TabIndex = 1;
            this.tbxLogin.TextOffset = new System.Drawing.Point(-8, 0);
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.White;
            this.guna2ControlBox1.HoverState.BorderColor = System.Drawing.Color.White;
            this.guna2ControlBox1.HoverState.FillColor = System.Drawing.Color.White;
            this.guna2ControlBox1.HoverState.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(104)))), ((int)(((byte)(91)))));
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(207)))), ((int)(((byte)(224)))));
            this.guna2ControlBox1.Location = new System.Drawing.Point(334, 1);
            this.guna2ControlBox1.Margin = new System.Windows.Forms.Padding(0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.PressedColor = System.Drawing.Color.White;
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(40, 40);
            this.guna2ControlBox1.TabIndex = 101;
            this.guna2ControlBox1.TabStop = false;
            // 
            // lblPassError
            // 
            this.lblPassError.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblPassError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(104)))), ((int)(((byte)(91)))));
            this.lblPassError.Location = new System.Drawing.Point(42, 376);
            this.lblPassError.Name = "lblPassError";
            this.lblPassError.Size = new System.Drawing.Size(291, 13);
            this.lblPassError.TabIndex = 99;
            this.lblPassError.Text = "Введите пароль";
            this.lblPassError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPassError.Visible = false;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.ContainerControl = this;
            this.guna2DragControl1.TargetControl = this.pMain;
            // 
            // guna2AnimateWindow1
            // 
            this.guna2AnimateWindow1.Interval = 150;
            this.guna2AnimateWindow1.TargetForm = this;
            // 
            // ucUpdater1
            // 
            this.ucUpdater1.BackColor = System.Drawing.Color.White;
            this.ucUpdater1.Location = new System.Drawing.Point(0, 0);
            this.ucUpdater1.Name = "ucUpdater1";
            this.ucUpdater1.Size = new System.Drawing.Size(375, 495);
            this.ucUpdater1.TabIndex = 102;
            this.ucUpdater1.Visible = false;
            // 
            // LoginForm
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(375, 495);
            this.ControlBox = false;
            this.Controls.Add(this.pMain);
            this.Controls.Add(this.ucUpdater1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация - Order Management";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.pMain.ResumeLayout(false);
            this.pMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAvatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel pMain;
        private System.Windows.Forms.Label lblPassError;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2TextBox tbxLogin;
        private Guna.UI2.WinForms.Guna2TextBox tbxPass;
        private System.Windows.Forms.Label lblLoginTitle;
        private System.Windows.Forms.Label lblPassTitle;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private Guna.UI2.WinForms.Guna2Button btnSystem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblLoginError;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pbxAvatar;
        private UserControls.ucUpdater ucUpdater1;
    }
}