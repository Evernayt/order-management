namespace Order_Management
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lblName = new System.Windows.Forms.Label();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.pTop = new Guna.UI2.WinForms.Guna2Panel();
            this.btnRefresh = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnNotification = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.tbxSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.pMain = new Guna.UI2.WinForms.Guna2Panel();
            this.pSidebar = new Guna.UI2.WinForms.Guna2Panel();
            this.btnBugReport = new Guna.UI2.WinForms.Guna2Button();
            this.btnToDo = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            this.btnSidebar = new Guna.UI2.WinForms.Guna2Button();
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.btnClients = new Guna.UI2.WinForms.Guna2Button();
            this.lblPermission = new System.Windows.Forms.Label();
            this.btnSettings = new Guna.UI2.WinForms.Guna2Button();
            this.btnOrders = new Guna.UI2.WinForms.Guna2Button();
            this.pbxAvatar = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.btnAvatar = new Guna.UI2.WinForms.Guna2Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.timerNotif = new System.Windows.Forms.Timer(this.components);
            this.vsepSidebar = new Guna.UI2.WinForms.Guna2VSeparator();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.timerRefresh = new System.Windows.Forms.Timer(this.components);
            this.pTop.SuspendLayout();
            this.pSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.White;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(62)))));
            this.lblName.Location = new System.Drawing.Point(86, 85);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(140, 24);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Имя";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.ContainerControl = this;
            this.guna2DragControl1.TargetControl = this.pTop;
            // 
            // pTop
            // 
            this.pTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pTop.BackColor = System.Drawing.Color.White;
            this.pTop.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.pTop.BorderThickness = 1;
            this.pTop.Controls.Add(this.btnRefresh);
            this.pTop.Controls.Add(this.btnNotification);
            this.pTop.Controls.Add(this.guna2ControlBox1);
            this.pTop.Controls.Add(this.guna2ControlBox2);
            this.pTop.Controls.Add(this.guna2ControlBox3);
            this.pTop.Controls.Add(this.tbxSearch);
            this.pTop.Location = new System.Drawing.Point(67, 0);
            this.pTop.Name = "pTop";
            this.pTop.ShadowDecoration.Parent = this.pTop;
            this.pTop.Size = new System.Drawing.Size(1269, 61);
            this.pTop.TabIndex = 110;
            this.pTop.Click += new System.EventHandler(this.pTop_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.btnRefresh.BorderThickness = 1;
            this.btnRefresh.CheckedState.Parent = this.btnRefresh;
            this.btnRefresh.CustomImages.Parent = this.btnRefresh;
            this.btnRefresh.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.btnRefresh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.btnRefresh.DisabledState.Parent = this.btnRefresh;
            this.btnRefresh.FillColor = System.Drawing.Color.White;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.btnRefresh.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.btnRefresh.HoverState.Image = global::Order_Management.Properties.Resources.refreshIconOff;
            this.btnRefresh.HoverState.Parent = this.btnRefresh;
            this.btnRefresh.Image = global::Order_Management.Properties.Resources.refreshIconOff;
            this.btnRefresh.ImageSize = new System.Drawing.Size(16, 16);
            this.btnRefresh.Location = new System.Drawing.Point(1050, 7);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.btnRefresh.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnRefresh.ShadowDecoration.Parent = this.btnRefresh;
            this.btnRefresh.Size = new System.Drawing.Size(47, 47);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnNotification
            // 
            this.btnNotification.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNotification.BackColor = System.Drawing.Color.White;
            this.btnNotification.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.btnNotification.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnNotification.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.btnNotification.CheckedState.Image = global::Order_Management.Properties.Resources.notificationIconOn;
            this.btnNotification.CheckedState.Parent = this.btnNotification;
            this.btnNotification.CustomImages.Parent = this.btnNotification;
            this.btnNotification.DisabledState.Parent = this.btnNotification;
            this.btnNotification.FillColor = System.Drawing.Color.White;
            this.btnNotification.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNotification.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.btnNotification.HoverState.FillColor = System.Drawing.Color.White;
            this.btnNotification.HoverState.Parent = this.btnNotification;
            this.btnNotification.Image = global::Order_Management.Properties.Resources.notificationIconOff;
            this.btnNotification.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnNotification.ImageSize = new System.Drawing.Size(14, 16);
            this.btnNotification.Location = new System.Drawing.Point(1008, 11);
            this.btnNotification.Margin = new System.Windows.Forms.Padding(0);
            this.btnNotification.Name = "btnNotification";
            this.btnNotification.PressedColor = System.Drawing.Color.White;
            this.btnNotification.ShadowDecoration.Parent = this.btnNotification;
            this.btnNotification.Size = new System.Drawing.Size(32, 40);
            this.btnNotification.TabIndex = 115;
            this.btnNotification.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnNotification.TextOffset = new System.Drawing.Point(-3, -1);
            this.btnNotification.CheckedChanged += new System.EventHandler(this.btnNotification_CheckedChanged);
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
            this.guna2ControlBox1.Location = new System.Drawing.Point(1193, 11);
            this.guna2ControlBox1.Margin = new System.Windows.Forms.Padding(0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.PressedColor = System.Drawing.Color.White;
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(40, 40);
            this.guna2ControlBox1.TabIndex = 29;
            this.guna2ControlBox1.TabStop = false;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.White;
            this.guna2ControlBox2.HoverState.BorderColor = System.Drawing.Color.White;
            this.guna2ControlBox2.HoverState.FillColor = System.Drawing.Color.White;
            this.guna2ControlBox2.HoverState.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(156)))), ((int)(((byte)(241)))));
            this.guna2ControlBox2.HoverState.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(207)))), ((int)(((byte)(224)))));
            this.guna2ControlBox2.Location = new System.Drawing.Point(1153, 11);
            this.guna2ControlBox2.Margin = new System.Windows.Forms.Padding(0);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.PressedColor = System.Drawing.Color.White;
            this.guna2ControlBox2.ShadowDecoration.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.Size = new System.Drawing.Size(40, 40);
            this.guna2ControlBox2.TabIndex = 30;
            this.guna2ControlBox2.TabStop = false;
            // 
            // guna2ControlBox3
            // 
            this.guna2ControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox3.FillColor = System.Drawing.Color.White;
            this.guna2ControlBox3.HoverState.BorderColor = System.Drawing.Color.White;
            this.guna2ControlBox3.HoverState.FillColor = System.Drawing.Color.White;
            this.guna2ControlBox3.HoverState.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(156)))), ((int)(((byte)(241)))));
            this.guna2ControlBox3.HoverState.Parent = this.guna2ControlBox3;
            this.guna2ControlBox3.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(207)))), ((int)(((byte)(224)))));
            this.guna2ControlBox3.Location = new System.Drawing.Point(1113, 11);
            this.guna2ControlBox3.Margin = new System.Windows.Forms.Padding(0);
            this.guna2ControlBox3.Name = "guna2ControlBox3";
            this.guna2ControlBox3.PressedColor = System.Drawing.Color.White;
            this.guna2ControlBox3.ShadowDecoration.Parent = this.guna2ControlBox3;
            this.guna2ControlBox3.Size = new System.Drawing.Size(40, 40);
            this.guna2ControlBox3.TabIndex = 31;
            this.guna2ControlBox3.TabStop = false;
            // 
            // tbxSearch
            // 
            this.tbxSearch.BorderThickness = 0;
            this.tbxSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxSearch.DefaultText = "";
            this.tbxSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbxSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbxSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxSearch.DisabledState.Parent = this.tbxSearch;
            this.tbxSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxSearch.FocusedState.Parent = this.tbxSearch;
            this.tbxSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbxSearch.HoverState.Parent = this.tbxSearch;
            this.tbxSearch.IconLeft = global::Order_Management.Properties.Resources.searchIconOff;
            this.tbxSearch.IconLeftOffset = new System.Drawing.Point(32, 0);
            this.tbxSearch.IconLeftSize = new System.Drawing.Size(16, 16);
            this.tbxSearch.Location = new System.Drawing.Point(0, 13);
            this.tbxSearch.Margin = new System.Windows.Forms.Padding(3, 5, 11, 5);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.PasswordChar = '\0';
            this.tbxSearch.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(160)))), ((int)(((byte)(183)))));
            this.tbxSearch.PlaceholderText = "Поиск (Ctrl+F)";
            this.tbxSearch.SelectedText = "";
            this.tbxSearch.ShadowDecoration.Parent = this.tbxSearch;
            this.tbxSearch.Size = new System.Drawing.Size(529, 36);
            this.tbxSearch.TabIndex = 24;
            this.tbxSearch.TabStop = false;
            this.tbxSearch.TextOffset = new System.Drawing.Point(10, 0);
            this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            // 
            // pMain
            // 
            this.pMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.pMain.Location = new System.Drawing.Point(69, 61);
            this.pMain.Name = "pMain";
            this.pMain.ShadowDecoration.Parent = this.pMain;
            this.pMain.Size = new System.Drawing.Size(1266, 706);
            this.pMain.TabIndex = 21;
            // 
            // pSidebar
            // 
            this.pSidebar.BackColor = System.Drawing.Color.White;
            this.pSidebar.Controls.Add(this.btnBugReport);
            this.pSidebar.Controls.Add(this.btnToDo);
            this.pSidebar.Controls.Add(this.guna2Separator2);
            this.pSidebar.Controls.Add(this.btnSidebar);
            this.pSidebar.Controls.Add(this.btnLogout);
            this.pSidebar.Controls.Add(this.btnClients);
            this.pSidebar.Controls.Add(this.lblPermission);
            this.pSidebar.Controls.Add(this.btnSettings);
            this.pSidebar.Controls.Add(this.btnOrders);
            this.pSidebar.Controls.Add(this.pbxAvatar);
            this.pSidebar.Controls.Add(this.guna2Separator1);
            this.pSidebar.Controls.Add(this.lblName);
            this.pSidebar.Controls.Add(this.btnAvatar);
            this.pSidebar.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.pSidebar.CustomBorderThickness = new System.Windows.Forms.Padding(1, 1, 0, 1);
            this.pSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pSidebar.Location = new System.Drawing.Point(0, 0);
            this.pSidebar.Margin = new System.Windows.Forms.Padding(0);
            this.pSidebar.Name = "pSidebar";
            this.pSidebar.ShadowDecoration.Parent = this.pSidebar;
            this.pSidebar.Size = new System.Drawing.Size(68, 768);
            this.pSidebar.TabIndex = 110;
            // 
            // btnBugReport
            // 
            this.btnBugReport.BackColor = System.Drawing.Color.White;
            this.btnBugReport.CheckedState.Parent = this.btnBugReport;
            this.btnBugReport.CustomImages.Parent = this.btnBugReport;
            this.btnBugReport.DisabledState.Parent = this.btnBugReport;
            this.btnBugReport.FillColor = System.Drawing.Color.White;
            this.btnBugReport.Font = new System.Drawing.Font("Segoe UI Semibold", 9.25F);
            this.btnBugReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(77)))), ((int)(((byte)(110)))));
            this.btnBugReport.HoverState.FillColor = System.Drawing.Color.White;
            this.btnBugReport.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(175)))), ((int)(((byte)(249)))));
            this.btnBugReport.HoverState.Image = global::Order_Management.Properties.Resources.bugIconOn;
            this.btnBugReport.HoverState.Parent = this.btnBugReport;
            this.btnBugReport.Image = global::Order_Management.Properties.Resources.bugIconOff;
            this.btnBugReport.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnBugReport.ImageOffset = new System.Drawing.Point(0, 2);
            this.btnBugReport.ImageSize = new System.Drawing.Size(16, 14);
            this.btnBugReport.Location = new System.Drawing.Point(17, 350);
            this.btnBugReport.Margin = new System.Windows.Forms.Padding(0);
            this.btnBugReport.Name = "btnBugReport";
            this.btnBugReport.PressedColor = System.Drawing.Color.White;
            this.btnBugReport.ShadowDecoration.Parent = this.btnBugReport;
            this.btnBugReport.Size = new System.Drawing.Size(220, 40);
            this.btnBugReport.TabIndex = 122;
            this.btnBugReport.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnBugReport.TextOffset = new System.Drawing.Point(8, 0);
            this.btnBugReport.Click += new System.EventHandler(this.btnBugReport_Click);
            // 
            // btnToDo
            // 
            this.btnToDo.BackColor = System.Drawing.Color.White;
            this.btnToDo.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnToDo.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnToDo.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(156)))), ((int)(((byte)(241)))));
            this.btnToDo.CheckedState.Image = global::Order_Management.Properties.Resources.todoIconOn;
            this.btnToDo.CheckedState.Parent = this.btnToDo;
            this.btnToDo.CustomImages.Parent = this.btnToDo;
            this.btnToDo.DisabledState.Parent = this.btnToDo;
            this.btnToDo.FillColor = System.Drawing.Color.White;
            this.btnToDo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.25F);
            this.btnToDo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(77)))), ((int)(((byte)(110)))));
            this.btnToDo.HoverState.FillColor = System.Drawing.Color.White;
            this.btnToDo.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(175)))), ((int)(((byte)(249)))));
            this.btnToDo.HoverState.Image = global::Order_Management.Properties.Resources.todoIconOn;
            this.btnToDo.HoverState.Parent = this.btnToDo;
            this.btnToDo.Image = global::Order_Management.Properties.Resources.todoIconOff;
            this.btnToDo.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnToDo.ImageOffset = new System.Drawing.Point(0, 2);
            this.btnToDo.ImageSize = new System.Drawing.Size(16, 16);
            this.btnToDo.Location = new System.Drawing.Point(17, 200);
            this.btnToDo.Margin = new System.Windows.Forms.Padding(0);
            this.btnToDo.Name = "btnToDo";
            this.btnToDo.PressedColor = System.Drawing.Color.White;
            this.btnToDo.ShadowDecoration.Parent = this.btnToDo;
            this.btnToDo.Size = new System.Drawing.Size(220, 40);
            this.btnToDo.TabIndex = 121;
            this.btnToDo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnToDo.TextOffset = new System.Drawing.Point(8, 0);
            this.btnToDo.Click += new System.EventHandler(this.btnToDo_Click);
            // 
            // guna2Separator2
            // 
            this.guna2Separator2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Separator2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.guna2Separator2.Location = new System.Drawing.Point(1, 291);
            this.guna2Separator2.Name = "guna2Separator2";
            this.guna2Separator2.Size = new System.Drawing.Size(67, 10);
            this.guna2Separator2.TabIndex = 120;
            // 
            // btnSidebar
            // 
            this.btnSidebar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSidebar.BackColor = System.Drawing.Color.White;
            this.btnSidebar.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.btnSidebar.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnSidebar.CheckedState.Image = global::Order_Management.Properties.Resources.sidebarRightIconOn;
            this.btnSidebar.CheckedState.Parent = this.btnSidebar;
            this.btnSidebar.CustomImages.Parent = this.btnSidebar;
            this.btnSidebar.DisabledState.Parent = this.btnSidebar;
            this.btnSidebar.FillColor = System.Drawing.Color.White;
            this.btnSidebar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSidebar.ForeColor = System.Drawing.Color.White;
            this.btnSidebar.HoverState.FillColor = System.Drawing.Color.White;
            this.btnSidebar.HoverState.Parent = this.btnSidebar;
            this.btnSidebar.Image = global::Order_Management.Properties.Resources.sidebarIconOff;
            this.btnSidebar.ImageSize = new System.Drawing.Size(16, 16);
            this.btnSidebar.Location = new System.Drawing.Point(19, 709);
            this.btnSidebar.Margin = new System.Windows.Forms.Padding(0);
            this.btnSidebar.Name = "btnSidebar";
            this.btnSidebar.PressedColor = System.Drawing.Color.White;
            this.btnSidebar.ShadowDecoration.Parent = this.btnSidebar;
            this.btnSidebar.Size = new System.Drawing.Size(30, 30);
            this.btnSidebar.TabIndex = 119;
            this.btnSidebar.CheckedChanged += new System.EventHandler(this.btnSidebar_CheckedChanged);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.White;
            this.btnLogout.CheckedState.Parent = this.btnLogout;
            this.btnLogout.CustomImages.Parent = this.btnLogout;
            this.btnLogout.DisabledState.Parent = this.btnLogout;
            this.btnLogout.FillColor = System.Drawing.Color.White;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.HoverState.FillColor = System.Drawing.Color.White;
            this.btnLogout.HoverState.Image = global::Order_Management.Properties.Resources.logoutIconOn;
            this.btnLogout.HoverState.Parent = this.btnLogout;
            this.btnLogout.Image = global::Order_Management.Properties.Resources.logoutIconOff;
            this.btnLogout.ImageSize = new System.Drawing.Size(16, 14);
            this.btnLogout.Location = new System.Drawing.Point(239, 88);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.PressedColor = System.Drawing.Color.White;
            this.btnLogout.ShadowDecoration.Parent = this.btnLogout;
            this.btnLogout.Size = new System.Drawing.Size(40, 40);
            this.btnLogout.TabIndex = 118;
            this.toolTip1.SetToolTip(this.btnLogout, "Выйти из аккаунта");
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnClients
            // 
            this.btnClients.BackColor = System.Drawing.Color.White;
            this.btnClients.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnClients.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnClients.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(156)))), ((int)(((byte)(241)))));
            this.btnClients.CheckedState.Image = global::Order_Management.Properties.Resources.clientsIconOn;
            this.btnClients.CheckedState.Parent = this.btnClients;
            this.btnClients.CustomImages.Parent = this.btnClients;
            this.btnClients.DisabledState.Parent = this.btnClients;
            this.btnClients.FillColor = System.Drawing.Color.White;
            this.btnClients.Font = new System.Drawing.Font("Segoe UI Semibold", 9.25F);
            this.btnClients.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(77)))), ((int)(((byte)(110)))));
            this.btnClients.HoverState.FillColor = System.Drawing.Color.White;
            this.btnClients.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(175)))), ((int)(((byte)(249)))));
            this.btnClients.HoverState.Image = global::Order_Management.Properties.Resources.clientsIconOn;
            this.btnClients.HoverState.Parent = this.btnClients;
            this.btnClients.Image = global::Order_Management.Properties.Resources.clientsIconOff;
            this.btnClients.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnClients.ImageOffset = new System.Drawing.Point(0, 2);
            this.btnClients.ImageSize = new System.Drawing.Size(16, 16);
            this.btnClients.Location = new System.Drawing.Point(17, 240);
            this.btnClients.Margin = new System.Windows.Forms.Padding(0);
            this.btnClients.Name = "btnClients";
            this.btnClients.PressedColor = System.Drawing.Color.White;
            this.btnClients.ShadowDecoration.Parent = this.btnClients;
            this.btnClients.Size = new System.Drawing.Size(220, 40);
            this.btnClients.TabIndex = 115;
            this.btnClients.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnClients.TextOffset = new System.Drawing.Point(8, 0);
            this.btnClients.Click += new System.EventHandler(this.btnClients_Click);
            // 
            // lblPermission
            // 
            this.lblPermission.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.lblPermission.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(160)))), ((int)(((byte)(183)))));
            this.lblPermission.Location = new System.Drawing.Point(87, 109);
            this.lblPermission.Name = "lblPermission";
            this.lblPermission.Size = new System.Drawing.Size(139, 19);
            this.lblPermission.TabIndex = 114;
            this.lblPermission.Text = "Сотрудник";
            this.lblPermission.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.White;
            this.btnSettings.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnSettings.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnSettings.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(156)))), ((int)(((byte)(241)))));
            this.btnSettings.CheckedState.Image = global::Order_Management.Properties.Resources.settingsIconOn;
            this.btnSettings.CheckedState.Parent = this.btnSettings;
            this.btnSettings.CustomImages.Parent = this.btnSettings;
            this.btnSettings.DisabledState.Parent = this.btnSettings;
            this.btnSettings.FillColor = System.Drawing.Color.White;
            this.btnSettings.Font = new System.Drawing.Font("Segoe UI Semibold", 9.25F);
            this.btnSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(77)))), ((int)(((byte)(110)))));
            this.btnSettings.HoverState.FillColor = System.Drawing.Color.White;
            this.btnSettings.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(175)))), ((int)(((byte)(249)))));
            this.btnSettings.HoverState.Image = global::Order_Management.Properties.Resources.settingsIconOn;
            this.btnSettings.HoverState.Parent = this.btnSettings;
            this.btnSettings.Image = global::Order_Management.Properties.Resources.settingsIconOff;
            this.btnSettings.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSettings.ImageOffset = new System.Drawing.Point(0, 2);
            this.btnSettings.ImageSize = new System.Drawing.Size(16, 16);
            this.btnSettings.Location = new System.Drawing.Point(17, 310);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(0);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.PressedColor = System.Drawing.Color.White;
            this.btnSettings.ShadowDecoration.Parent = this.btnSettings;
            this.btnSettings.Size = new System.Drawing.Size(220, 40);
            this.btnSettings.TabIndex = 113;
            this.btnSettings.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSettings.TextOffset = new System.Drawing.Point(8, 0);
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnOrders
            // 
            this.btnOrders.BackColor = System.Drawing.Color.White;
            this.btnOrders.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnOrders.Checked = true;
            this.btnOrders.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnOrders.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(156)))), ((int)(((byte)(241)))));
            this.btnOrders.CheckedState.Image = global::Order_Management.Properties.Resources.ordersIconOn;
            this.btnOrders.CheckedState.Parent = this.btnOrders;
            this.btnOrders.CustomImages.Parent = this.btnOrders;
            this.btnOrders.DisabledState.Parent = this.btnOrders;
            this.btnOrders.FillColor = System.Drawing.Color.White;
            this.btnOrders.Font = new System.Drawing.Font("Segoe UI Semibold", 9.25F);
            this.btnOrders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(77)))), ((int)(((byte)(110)))));
            this.btnOrders.HoverState.FillColor = System.Drawing.Color.White;
            this.btnOrders.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(175)))), ((int)(((byte)(249)))));
            this.btnOrders.HoverState.Image = global::Order_Management.Properties.Resources.ordersIconOn;
            this.btnOrders.HoverState.Parent = this.btnOrders;
            this.btnOrders.Image = global::Order_Management.Properties.Resources.ordersIconOff;
            this.btnOrders.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnOrders.ImageSize = new System.Drawing.Size(16, 14);
            this.btnOrders.Location = new System.Drawing.Point(17, 160);
            this.btnOrders.Margin = new System.Windows.Forms.Padding(0);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.PressedColor = System.Drawing.Color.White;
            this.btnOrders.ShadowDecoration.Parent = this.btnOrders;
            this.btnOrders.Size = new System.Drawing.Size(220, 40);
            this.btnOrders.TabIndex = 112;
            this.btnOrders.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnOrders.TextOffset = new System.Drawing.Point(8, 0);
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // pbxAvatar
            // 
            this.pbxAvatar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxAvatar.Image = global::Order_Management.Properties.Resources.userIcon;
            this.pbxAvatar.ImageRotate = 0F;
            this.pbxAvatar.Location = new System.Drawing.Point(11, 85);
            this.pbxAvatar.Name = "pbxAvatar";
            this.pbxAvatar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pbxAvatar.ShadowDecoration.Parent = this.pbxAvatar;
            this.pbxAvatar.Size = new System.Drawing.Size(46, 46);
            this.pbxAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxAvatar.TabIndex = 111;
            this.pbxAvatar.TabStop = false;
            this.pbxAvatar.Click += new System.EventHandler(this.pbxAvatar_Click);
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Separator1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.guna2Separator1.Location = new System.Drawing.Point(1, 55);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(67, 10);
            this.guna2Separator1.TabIndex = 32;
            // 
            // btnAvatar
            // 
            this.btnAvatar.BackColor = System.Drawing.Color.White;
            this.btnAvatar.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnAvatar.CheckedState.Parent = this.btnAvatar;
            this.btnAvatar.CustomImages.Parent = this.btnAvatar;
            this.btnAvatar.DisabledState.Parent = this.btnAvatar;
            this.btnAvatar.FillColor = System.Drawing.Color.White;
            this.btnAvatar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAvatar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(77)))), ((int)(((byte)(110)))));
            this.btnAvatar.HoverState.Parent = this.btnAvatar;
            this.btnAvatar.Location = new System.Drawing.Point(26, 100);
            this.btnAvatar.Margin = new System.Windows.Forms.Padding(0);
            this.btnAvatar.Name = "btnAvatar";
            this.btnAvatar.PressedColor = System.Drawing.Color.White;
            this.btnAvatar.ShadowDecoration.Parent = this.btnAvatar;
            this.btnAvatar.Size = new System.Drawing.Size(17, 17);
            this.btnAvatar.TabIndex = 116;
            this.btnAvatar.TabStop = false;
            this.btnAvatar.Click += new System.EventHandler(this.btnAvatar_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 900;
            // 
            // timerNotif
            // 
            this.timerNotif.Interval = 10000;
            this.timerNotif.Tick += new System.EventHandler(this.timerNotif_Tick);
            // 
            // vsepSidebar
            // 
            this.vsepSidebar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.vsepSidebar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.vsepSidebar.Location = new System.Drawing.Point(68, 1);
            this.vsepSidebar.Name = "vsepSidebar";
            this.vsepSidebar.Size = new System.Drawing.Size(1, 768);
            this.vsepSidebar.TabIndex = 112;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // timerRefresh
            // 
            this.timerRefresh.Interval = 1000;
            this.timerRefresh.Tick += new System.EventHandler(this.timerRefresh_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1336, 768);
            this.ControlBox = false;
            this.Controls.Add(this.pSidebar);
            this.Controls.Add(this.vsepSidebar);
            this.Controls.Add(this.pMain);
            this.Controls.Add(this.pTop);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(1336, 768);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order Management";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.pTop.ResumeLayout(false);
            this.pSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        public System.Windows.Forms.Label lblName;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.Windows.Forms.ToolTip toolTip1;
        private Guna.UI2.WinForms.Guna2Panel pMain;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private System.Windows.Forms.Timer timerNotif;
        private Guna.UI2.WinForms.Guna2Panel pSidebar;
        private Guna.UI2.WinForms.Guna2Panel pTop;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2Button btnOrders;
        private System.Windows.Forms.Label lblPermission;
        private Guna.UI2.WinForms.Guna2Button btnSettings;
        private Guna.UI2.WinForms.Guna2VSeparator vsepSidebar;
        private Guna.UI2.WinForms.Guna2Button btnNotification;
        public Guna.UI2.WinForms.Guna2TextBox tbxSearch;
        private Guna.UI2.WinForms.Guna2Button btnClients;
        private Guna.UI2.WinForms.Guna2Button btnAvatar;
        public Guna.UI2.WinForms.Guna2CirclePictureBox pbxAvatar;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
        private Guna.UI2.WinForms.Guna2Button btnSidebar;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
        private Guna.UI2.WinForms.Guna2Button btnToDo;
        private Guna.UI2.WinForms.Guna2CircleButton btnRefresh;
        private System.Windows.Forms.Timer timerRefresh;
        private Guna.UI2.WinForms.Guna2Button btnBugReport;
    }
}