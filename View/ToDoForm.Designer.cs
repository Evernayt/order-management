
namespace Order_Management
{
    partial class ToDoForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToDoForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pDataGrid = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            this.myDataGridView1 = new Order_Management.MyDataGridView();
            this.id_todo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status_todo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.date_of_create_todo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.task_todo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.created_todo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.completed_todo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shop_todo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urgentlyPic_todo = new System.Windows.Forms.DataGridViewImageColumn();
            this.delete_todo = new System.Windows.Forms.DataGridViewLinkColumn();
            this.urgently_todo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calendar = new System.Windows.Forms.MonthCalendar();
            this.cbxStatusFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnAddTask = new Guna.UI2.WinForms.Guna2Button();
            this.cbxShopFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.tbxTask = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmsTask = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.tsmiUrgently = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTaskTitle = new System.Windows.Forms.Label();
            this.btnDate = new Guna.UI2.WinForms.Guna2Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myDataGridView1)).BeginInit();
            this.cmsTask.SuspendLayout();
            this.SuspendLayout();
            // 
            // pDataGrid
            // 
            this.pDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pDataGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.pDataGrid.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.pDataGrid.BorderRadius = 4;
            this.pDataGrid.BorderThickness = 1;
            this.pDataGrid.Controls.Add(this.guna2Separator2);
            this.pDataGrid.Controls.Add(this.myDataGridView1);
            this.pDataGrid.FillColor = System.Drawing.Color.White;
            this.pDataGrid.Location = new System.Drawing.Point(35, 101);
            this.pDataGrid.Name = "pDataGrid";
            this.pDataGrid.ShadowDecoration.Parent = this.pDataGrid;
            this.pDataGrid.Size = new System.Drawing.Size(1196, 570);
            this.pDataGrid.TabIndex = 112;
            // 
            // guna2Separator2
            // 
            this.guna2Separator2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Separator2.BackColor = System.Drawing.Color.White;
            this.guna2Separator2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.guna2Separator2.Location = new System.Drawing.Point(1, 50);
            this.guna2Separator2.Name = "guna2Separator2";
            this.guna2Separator2.Size = new System.Drawing.Size(1178, 1);
            this.guna2Separator2.TabIndex = 115;
            // 
            // myDataGridView1
            // 
            this.myDataGridView1.AllowUserToAddRows = false;
            this.myDataGridView1.AllowUserToDeleteRows = false;
            this.myDataGridView1.AllowUserToResizeColumns = false;
            this.myDataGridView1.AllowUserToResizeRows = false;
            this.myDataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myDataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.myDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.myDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.myDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(77)))), ((int)(((byte)(110)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(77)))), ((int)(((byte)(110)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.myDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.myDataGridView1.ColumnHeadersHeight = 47;
            this.myDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.myDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_todo,
            this.status_todo,
            this.date_of_create_todo,
            this.task_todo,
            this.created_todo,
            this.completed_todo,
            this.shop_todo,
            this.urgentlyPic_todo,
            this.delete_todo,
            this.urgently_todo});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(118)))), ((int)(((byte)(131)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(118)))), ((int)(((byte)(131)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.myDataGridView1.DefaultCellStyle = dataGridViewCellStyle11;
            this.myDataGridView1.EnableHeadersVisualStyles = false;
            this.myDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.myDataGridView1.Location = new System.Drawing.Point(1, 4);
            this.myDataGridView1.MultiSelect = false;
            this.myDataGridView1.Name = "myDataGridView1";
            this.myDataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.myDataGridView1.RowHeadersVisible = false;
            this.myDataGridView1.RowHeadersWidth = 51;
            this.myDataGridView1.RowTemplate.Height = 53;
            this.myDataGridView1.Size = new System.Drawing.Size(1194, 562);
            this.myDataGridView1.StandardTab = true;
            this.myDataGridView1.TabIndex = 0;
            this.myDataGridView1.TabStop = false;
            this.myDataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.myDataGridView1_CellClick);
            this.myDataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.myDataGridView1_CellContentClick);
            this.myDataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.myDataGridView1_CellEndEdit);
            this.myDataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.myDataGridView1_CellMouseClick);
            this.myDataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.myDataGridView1_DataError);
            this.myDataGridView1.Click += new System.EventHandler(this.myDataGridView1_Click);
            // 
            // id_todo
            // 
            this.id_todo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.id_todo.DataPropertyName = "id";
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.id_todo.DefaultCellStyle = dataGridViewCellStyle2;
            this.id_todo.HeaderText = "№";
            this.id_todo.MinimumWidth = 6;
            this.id_todo.Name = "id_todo";
            this.id_todo.ReadOnly = true;
            this.id_todo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.id_todo.Visible = false;
            this.id_todo.Width = 26;
            // 
            // status_todo
            // 
            this.status_todo.DataPropertyName = "status";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.NullValue = false;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.status_todo.DefaultCellStyle = dataGridViewCellStyle3;
            this.status_todo.HeaderText = "";
            this.status_todo.Name = "status_todo";
            this.status_todo.Width = 50;
            // 
            // date_of_create_todo
            // 
            this.date_of_create_todo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.date_of_create_todo.DataPropertyName = "date_of_create";
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.date_of_create_todo.DefaultCellStyle = dataGridViewCellStyle4;
            this.date_of_create_todo.HeaderText = "Дата создания";
            this.date_of_create_todo.MinimumWidth = 115;
            this.date_of_create_todo.Name = "date_of_create_todo";
            this.date_of_create_todo.ReadOnly = true;
            this.date_of_create_todo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.date_of_create_todo.Width = 115;
            // 
            // task_todo
            // 
            this.task_todo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.task_todo.DataPropertyName = "task";
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.task_todo.DefaultCellStyle = dataGridViewCellStyle5;
            this.task_todo.HeaderText = "Задание";
            this.task_todo.MinimumWidth = 6;
            this.task_todo.Name = "task_todo";
            this.task_todo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // created_todo
            // 
            this.created_todo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.created_todo.DataPropertyName = "created";
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.created_todo.DefaultCellStyle = dataGridViewCellStyle6;
            this.created_todo.HeaderText = "Создал(а)";
            this.created_todo.Name = "created_todo";
            this.created_todo.ReadOnly = true;
            this.created_todo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.created_todo.Width = 64;
            // 
            // completed_todo
            // 
            this.completed_todo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.completed_todo.DataPropertyName = "completed";
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.completed_todo.DefaultCellStyle = dataGridViewCellStyle7;
            this.completed_todo.HeaderText = "Завершил(а)";
            this.completed_todo.MinimumWidth = 6;
            this.completed_todo.Name = "completed_todo";
            this.completed_todo.ReadOnly = true;
            this.completed_todo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.completed_todo.Width = 82;
            // 
            // shop_todo
            // 
            this.shop_todo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.shop_todo.DataPropertyName = "shop";
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.shop_todo.DefaultCellStyle = dataGridViewCellStyle8;
            this.shop_todo.HeaderText = "Филиал";
            this.shop_todo.Name = "shop_todo";
            this.shop_todo.ReadOnly = true;
            this.shop_todo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.shop_todo.Width = 54;
            // 
            // urgentlyPic_todo
            // 
            this.urgentlyPic_todo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle9.NullValue")));
            dataGridViewCellStyle9.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.urgentlyPic_todo.DefaultCellStyle = dataGridViewCellStyle9;
            this.urgentlyPic_todo.HeaderText = "";
            this.urgentlyPic_todo.MinimumWidth = 6;
            this.urgentlyPic_todo.Name = "urgentlyPic_todo";
            this.urgentlyPic_todo.ReadOnly = true;
            this.urgentlyPic_todo.Width = 6;
            // 
            // delete_todo
            // 
            this.delete_todo.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(156)))), ((int)(((byte)(241)))));
            this.delete_todo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.delete_todo.DataPropertyName = "delete_row";
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F);
            dataGridViewCellStyle10.Padding = new System.Windows.Forms.Padding(10, 0, 15, 0);
            this.delete_todo.DefaultCellStyle = dataGridViewCellStyle10;
            this.delete_todo.HeaderText = "";
            this.delete_todo.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.delete_todo.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(118)))), ((int)(((byte)(131)))));
            this.delete_todo.MinimumWidth = 6;
            this.delete_todo.Name = "delete_todo";
            this.delete_todo.ReadOnly = true;
            this.delete_todo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.delete_todo.Text = "✕";
            this.delete_todo.TrackVisitedState = false;
            this.delete_todo.UseColumnTextForLinkValue = true;
            this.delete_todo.Width = 6;
            // 
            // urgently_todo
            // 
            this.urgently_todo.DataPropertyName = "urgently";
            this.urgently_todo.HeaderText = "urgently_todo";
            this.urgently_todo.MinimumWidth = 6;
            this.urgently_todo.Name = "urgently_todo";
            this.urgently_todo.Visible = false;
            this.urgently_todo.Width = 125;
            // 
            // calendar
            // 
            this.calendar.BackColor = System.Drawing.Color.White;
            this.calendar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(71)))));
            this.calendar.Location = new System.Drawing.Point(30, 81);
            this.calendar.MaxSelectionCount = 1;
            this.calendar.Name = "calendar";
            this.calendar.ShowTodayCircle = false;
            this.calendar.TabIndex = 133;
            this.calendar.TabStop = false;
            this.calendar.TitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.calendar.Visible = false;
            this.calendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calendar_DateChanged);
            // 
            // cbxStatusFilter
            // 
            this.cbxStatusFilter.BackColor = System.Drawing.Color.Transparent;
            this.cbxStatusFilter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.cbxStatusFilter.BorderRadius = 4;
            this.cbxStatusFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxStatusFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxStatusFilter.FocusedColor = System.Drawing.Color.Empty;
            this.cbxStatusFilter.FocusedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(156)))), ((int)(((byte)(241)))));
            this.cbxStatusFilter.FocusedState.Parent = this.cbxStatusFilter;
            this.cbxStatusFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbxStatusFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(112)))), ((int)(((byte)(126)))));
            this.cbxStatusFilter.HoverState.Parent = this.cbxStatusFilter;
            this.cbxStatusFilter.ItemHeight = 36;
            this.cbxStatusFilter.Items.AddRange(new object[] {
            "Все задания",
            "Открытые",
            "Завершенные"});
            this.cbxStatusFilter.ItemsAppearance.BackColor = System.Drawing.Color.White;
            this.cbxStatusFilter.ItemsAppearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(112)))), ((int)(((byte)(126)))));
            this.cbxStatusFilter.ItemsAppearance.Parent = this.cbxStatusFilter;
            this.cbxStatusFilter.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(156)))), ((int)(((byte)(241)))));
            this.cbxStatusFilter.ItemsAppearance.SelectedForeColor = System.Drawing.Color.White;
            this.cbxStatusFilter.Location = new System.Drawing.Point(216, 35);
            this.cbxStatusFilter.Margin = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.cbxStatusFilter.Name = "cbxStatusFilter";
            this.cbxStatusFilter.ShadowDecoration.Parent = this.cbxStatusFilter;
            this.cbxStatusFilter.Size = new System.Drawing.Size(160, 42);
            this.cbxStatusFilter.StartIndex = 1;
            this.cbxStatusFilter.TabIndex = 134;
            this.cbxStatusFilter.TabStop = false;
            this.cbxStatusFilter.TextOffset = new System.Drawing.Point(5, 0);
            this.cbxStatusFilter.SelectionChangeCommitted += new System.EventHandler(this.cbxStatusFilter_SelectionChangeCommitted);
            // 
            // btnAddTask
            // 
            this.btnAddTask.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddTask.BackColor = System.Drawing.Color.Transparent;
            this.btnAddTask.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(156)))), ((int)(((byte)(241)))));
            this.btnAddTask.BorderRadius = 4;
            this.btnAddTask.BorderThickness = 1;
            this.btnAddTask.CheckedState.Parent = this.btnAddTask;
            this.btnAddTask.CustomImages.Parent = this.btnAddTask;
            this.btnAddTask.DisabledState.Parent = this.btnAddTask;
            this.btnAddTask.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(156)))), ((int)(((byte)(241)))));
            this.btnAddTask.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.btnAddTask.ForeColor = System.Drawing.Color.White;
            this.btnAddTask.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(175)))), ((int)(((byte)(249)))));
            this.btnAddTask.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(175)))), ((int)(((byte)(249)))));
            this.btnAddTask.HoverState.Parent = this.btnAddTask;
            this.btnAddTask.Location = new System.Drawing.Point(1071, 35);
            this.btnAddTask.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.PressedDepth = 20;
            this.btnAddTask.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(156)))), ((int)(((byte)(241)))));
            this.btnAddTask.ShadowDecoration.Parent = this.btnAddTask;
            this.btnAddTask.Size = new System.Drawing.Size(160, 42);
            this.btnAddTask.TabIndex = 135;
            this.btnAddTask.Text = "Добавить задание";
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // cbxShopFilter
            // 
            this.cbxShopFilter.BackColor = System.Drawing.Color.Transparent;
            this.cbxShopFilter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.cbxShopFilter.BorderRadius = 4;
            this.cbxShopFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxShopFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxShopFilter.FocusedColor = System.Drawing.Color.Empty;
            this.cbxShopFilter.FocusedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(156)))), ((int)(((byte)(241)))));
            this.cbxShopFilter.FocusedState.Parent = this.cbxShopFilter;
            this.cbxShopFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbxShopFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(112)))), ((int)(((byte)(126)))));
            this.cbxShopFilter.HoverState.Parent = this.cbxShopFilter;
            this.cbxShopFilter.ItemHeight = 36;
            this.cbxShopFilter.ItemsAppearance.BackColor = System.Drawing.Color.White;
            this.cbxShopFilter.ItemsAppearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(112)))), ((int)(((byte)(126)))));
            this.cbxShopFilter.ItemsAppearance.Parent = this.cbxShopFilter;
            this.cbxShopFilter.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(156)))), ((int)(((byte)(241)))));
            this.cbxShopFilter.ItemsAppearance.SelectedForeColor = System.Drawing.Color.White;
            this.cbxShopFilter.Location = new System.Drawing.Point(398, 35);
            this.cbxShopFilter.Margin = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.cbxShopFilter.Name = "cbxShopFilter";
            this.cbxShopFilter.ShadowDecoration.Parent = this.cbxShopFilter;
            this.cbxShopFilter.Size = new System.Drawing.Size(160, 42);
            this.cbxShopFilter.TabIndex = 136;
            this.cbxShopFilter.TabStop = false;
            this.cbxShopFilter.TextOffset = new System.Drawing.Point(5, 0);
            this.cbxShopFilter.SelectionChangeCommitted += new System.EventHandler(this.cbxShopFilter_SelectionChangeCommitted);
            // 
            // tbxTask
            // 
            this.tbxTask.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.tbxTask.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(216)))), ((int)(((byte)(221)))));
            this.tbxTask.BorderRadius = 4;
            this.tbxTask.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxTask.DefaultText = "";
            this.tbxTask.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbxTask.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbxTask.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxTask.DisabledState.Parent = this.tbxTask;
            this.tbxTask.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxTask.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.tbxTask.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(142)))), ((int)(((byte)(155)))));
            this.tbxTask.FocusedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(62)))));
            this.tbxTask.FocusedState.Parent = this.tbxTask;
            this.tbxTask.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.tbxTask.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(71)))));
            this.tbxTask.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(216)))), ((int)(((byte)(221)))));
            this.tbxTask.HoverState.Parent = this.tbxTask;
            this.tbxTask.Location = new System.Drawing.Point(580, 41);
            this.tbxTask.Margin = new System.Windows.Forms.Padding(22, 0, 22, 0);
            this.tbxTask.Name = "tbxTask";
            this.tbxTask.PasswordChar = '\0';
            this.tbxTask.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(160)))), ((int)(((byte)(183)))));
            this.tbxTask.PlaceholderText = "";
            this.tbxTask.SelectedText = "";
            this.tbxTask.ShadowDecoration.Parent = this.tbxTask;
            this.tbxTask.Size = new System.Drawing.Size(469, 36);
            this.tbxTask.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.tbxTask.TabIndex = 137;
            this.tbxTask.TextOffset = new System.Drawing.Point(-8, 0);
            this.tbxTask.Enter += new System.EventHandler(this.tbxTask_Enter);
            this.tbxTask.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxTask_KeyPress);
            this.tbxTask.Leave += new System.EventHandler(this.tbxTask_Leave);
            // 
            // cmsTask
            // 
            this.cmsTask.BackColor = System.Drawing.Color.White;
            this.cmsTask.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsTask.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiUrgently});
            this.cmsTask.Name = "cmsStatuses";
            this.cmsTask.RenderStyle.ArrowColor = System.Drawing.Color.Black;
            this.cmsTask.RenderStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.cmsTask.RenderStyle.ColorTable = null;
            this.cmsTask.RenderStyle.RoundedEdges = true;
            this.cmsTask.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.cmsTask.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(156)))), ((int)(((byte)(241)))));
            this.cmsTask.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.cmsTask.RenderStyle.SeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.cmsTask.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.cmsTask.Size = new System.Drawing.Size(122, 29);
            // 
            // tsmiUrgently
            // 
            this.tsmiUrgently.AutoSize = false;
            this.tsmiUrgently.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tsmiUrgently.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(71)))));
            this.tsmiUrgently.Name = "tsmiUrgently";
            this.tsmiUrgently.Size = new System.Drawing.Size(180, 25);
            this.tsmiUrgently.Text = "Срочно";
            this.tsmiUrgently.Click += new System.EventHandler(this.tsmiUrgently_Click);
            // 
            // lblTaskTitle
            // 
            this.lblTaskTitle.AutoSize = true;
            this.lblTaskTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.lblTaskTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.lblTaskTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(142)))), ((int)(((byte)(155)))));
            this.lblTaskTitle.Location = new System.Drawing.Point(577, 29);
            this.lblTaskTitle.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.lblTaskTitle.Name = "lblTaskTitle";
            this.lblTaskTitle.Size = new System.Drawing.Size(53, 15);
            this.lblTaskTitle.TabIndex = 139;
            this.lblTaskTitle.Text = "Задание";
            // 
            // btnDate
            // 
            this.btnDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.btnDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.btnDate.BorderRadius = 4;
            this.btnDate.BorderThickness = 1;
            this.btnDate.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.btnDate.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.btnDate.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnDate.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(156)))), ((int)(((byte)(241)))));
            this.btnDate.CheckedState.Image = global::Order_Management.Properties.Resources.calendarIconOn;
            this.btnDate.CheckedState.Parent = this.btnDate;
            this.btnDate.CustomImages.Parent = this.btnDate;
            this.btnDate.DisabledState.Parent = this.btnDate;
            this.btnDate.FillColor = System.Drawing.Color.White;
            this.btnDate.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(112)))), ((int)(((byte)(126)))));
            this.btnDate.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.btnDate.HoverState.FillColor = System.Drawing.Color.White;
            this.btnDate.HoverState.Parent = this.btnDate;
            this.btnDate.Image = global::Order_Management.Properties.Resources.calendarIconOff;
            this.btnDate.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnDate.ImageSize = new System.Drawing.Size(14, 16);
            this.btnDate.Location = new System.Drawing.Point(35, 35);
            this.btnDate.Margin = new System.Windows.Forms.Padding(0);
            this.btnDate.Name = "btnDate";
            this.btnDate.PressedColor = System.Drawing.Color.White;
            this.btnDate.ShadowDecoration.Parent = this.btnDate;
            this.btnDate.Size = new System.Drawing.Size(159, 42);
            this.btnDate.TabIndex = 132;
            this.btnDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDate.TextOffset = new System.Drawing.Point(0, -2);
            this.toolTip1.SetToolTip(this.btnDate, "Показать задания с указанной даты");
            this.btnDate.CheckedChanged += new System.EventHandler(this.btnDate_CheckedChanged);
            // 
            // ToDoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1266, 706);
            this.ControlBox = false;
            this.Controls.Add(this.lblTaskTitle);
            this.Controls.Add(this.tbxTask);
            this.Controls.Add(this.cbxShopFilter);
            this.Controls.Add(this.btnAddTask);
            this.Controls.Add(this.cbxStatusFilter);
            this.Controls.Add(this.calendar);
            this.Controls.Add(this.btnDate);
            this.Controls.Add(this.pDataGrid);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ToDoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Задания - Order Management";
            this.Load += new System.EventHandler(this.ToDoForm_Load);
            this.Click += new System.EventHandler(this.ToDoForm_Click);
            this.Resize += new System.EventHandler(this.ToDoForm_Resize);
            this.pDataGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.myDataGridView1)).EndInit();
            this.cmsTask.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pDataGrid;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
        public MyDataGridView myDataGridView1;
        private System.Windows.Forms.MonthCalendar calendar;
        private Guna.UI2.WinForms.Guna2Button btnDate;
        private Guna.UI2.WinForms.Guna2ComboBox cbxStatusFilter;
        public Guna.UI2.WinForms.Guna2Button btnAddTask;
        private Guna.UI2.WinForms.Guna2ComboBox cbxShopFilter;
        private Guna.UI2.WinForms.Guna2TextBox tbxTask;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip cmsTask;
        private System.Windows.Forms.ToolStripMenuItem tsmiUrgently;
        private System.Windows.Forms.Label lblTaskTitle;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_todo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn status_todo;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_of_create_todo;
        private System.Windows.Forms.DataGridViewTextBoxColumn task_todo;
        private System.Windows.Forms.DataGridViewTextBoxColumn created_todo;
        private System.Windows.Forms.DataGridViewTextBoxColumn completed_todo;
        private System.Windows.Forms.DataGridViewTextBoxColumn shop_todo;
        private System.Windows.Forms.DataGridViewImageColumn urgentlyPic_todo;
        private System.Windows.Forms.DataGridViewLinkColumn delete_todo;
        private System.Windows.Forms.DataGridViewTextBoxColumn urgently_todo;
    }
}