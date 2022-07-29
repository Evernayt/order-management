
namespace Order_Management
{
    partial class OrdersForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrdersForm));
            this.calendarFrom = new System.Windows.Forms.MonthCalendar();
            this.chbxOrderNotGiven = new Guna.UI2.WinForms.Guna2CheckBox();
            this.cbxStatusFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnNewOrder = new Guna.UI2.WinForms.Guna2Button();
            this.pDataGrid = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            this.myDataGridView1 = new Order_Management.MyDataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_of_create = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.services = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shop_orders = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_of_deadline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pinPic = new System.Windows.Forms.DataGridViewImageColumn();
            this.delete_row = new System.Windows.Forms.DataGridViewLinkColumn();
            this.prepayment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ready_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pin_orders = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbxShopFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmsOrder = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.tsmiAboutOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPin = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsStatuses = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.calendarTo = new System.Windows.Forms.MonthCalendar();
            this.cmsShops = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.btnDateTo = new Guna.UI2.WinForms.Guna2Button();
            this.btnExport = new Guna.UI2.WinForms.Guna2Button();
            this.btnTemporarilyFolder = new Guna.UI2.WinForms.Guna2Button();
            this.btnDateFrom = new Guna.UI2.WinForms.Guna2Button();
            this.pDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myDataGridView1)).BeginInit();
            this.cmsOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // calendarFrom
            // 
            this.calendarFrom.BackColor = System.Drawing.Color.White;
            this.calendarFrom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(71)))));
            this.calendarFrom.Location = new System.Drawing.Point(30, 81);
            this.calendarFrom.MaxSelectionCount = 1;
            this.calendarFrom.Name = "calendarFrom";
            this.calendarFrom.ShowTodayCircle = false;
            this.calendarFrom.TabIndex = 131;
            this.calendarFrom.TabStop = false;
            this.calendarFrom.TitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.calendarFrom.Visible = false;
            this.calendarFrom.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calendarFrom_DateChanged);
            // 
            // chbxOrderNotGiven
            // 
            this.chbxOrderNotGiven.AutoSize = true;
            this.chbxOrderNotGiven.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.chbxOrderNotGiven.CheckedState.BorderRadius = 4;
            this.chbxOrderNotGiven.CheckedState.BorderThickness = 0;
            this.chbxOrderNotGiven.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(156)))), ((int)(((byte)(241)))));
            this.chbxOrderNotGiven.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(112)))), ((int)(((byte)(126)))));
            this.chbxOrderNotGiven.Location = new System.Drawing.Point(762, 47);
            this.chbxOrderNotGiven.Margin = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.chbxOrderNotGiven.Name = "chbxOrderNotGiven";
            this.chbxOrderNotGiven.Size = new System.Drawing.Size(112, 19);
            this.chbxOrderNotGiven.TabIndex = 101;
            this.chbxOrderNotGiven.TabStop = false;
            this.chbxOrderNotGiven.Text = "  Заказ не отдан";
            this.chbxOrderNotGiven.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.toolTip1.SetToolTip(this.chbxOrderNotGiven, "Заказ готов и не отдан (более 2х дней)");
            this.chbxOrderNotGiven.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.chbxOrderNotGiven.UncheckedState.BorderRadius = 4;
            this.chbxOrderNotGiven.UncheckedState.BorderThickness = 1;
            this.chbxOrderNotGiven.UncheckedState.FillColor = System.Drawing.Color.White;
            this.chbxOrderNotGiven.UseVisualStyleBackColor = false;
            this.chbxOrderNotGiven.CheckedChanged += new System.EventHandler(this.chbxOrderNotGiven_CheckedChanged);
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
            this.cbxStatusFilter.ItemsAppearance.BackColor = System.Drawing.Color.White;
            this.cbxStatusFilter.ItemsAppearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(112)))), ((int)(((byte)(126)))));
            this.cbxStatusFilter.ItemsAppearance.Parent = this.cbxStatusFilter;
            this.cbxStatusFilter.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(156)))), ((int)(((byte)(241)))));
            this.cbxStatusFilter.ItemsAppearance.SelectedForeColor = System.Drawing.Color.White;
            this.cbxStatusFilter.Location = new System.Drawing.Point(398, 35);
            this.cbxStatusFilter.Margin = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.cbxStatusFilter.Name = "cbxStatusFilter";
            this.cbxStatusFilter.ShadowDecoration.Parent = this.cbxStatusFilter;
            this.cbxStatusFilter.Size = new System.Drawing.Size(160, 42);
            this.cbxStatusFilter.TabIndex = 113;
            this.cbxStatusFilter.TabStop = false;
            this.cbxStatusFilter.TextOffset = new System.Drawing.Point(5, 0);
            this.cbxStatusFilter.SelectionChangeCommitted += new System.EventHandler(this.cbxStatusFilter_SelectionChangeCommitted);
            // 
            // btnNewOrder
            // 
            this.btnNewOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewOrder.BackColor = System.Drawing.Color.Transparent;
            this.btnNewOrder.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(156)))), ((int)(((byte)(241)))));
            this.btnNewOrder.BorderRadius = 4;
            this.btnNewOrder.BorderThickness = 1;
            this.btnNewOrder.CheckedState.Parent = this.btnNewOrder;
            this.btnNewOrder.CustomImages.Parent = this.btnNewOrder;
            this.btnNewOrder.DisabledState.Parent = this.btnNewOrder;
            this.btnNewOrder.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(156)))), ((int)(((byte)(241)))));
            this.btnNewOrder.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.btnNewOrder.ForeColor = System.Drawing.Color.White;
            this.btnNewOrder.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(175)))), ((int)(((byte)(249)))));
            this.btnNewOrder.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(175)))), ((int)(((byte)(249)))));
            this.btnNewOrder.HoverState.Parent = this.btnNewOrder;
            this.btnNewOrder.Location = new System.Drawing.Point(1071, 35);
            this.btnNewOrder.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.btnNewOrder.Name = "btnNewOrder";
            this.btnNewOrder.PressedDepth = 20;
            this.btnNewOrder.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(156)))), ((int)(((byte)(241)))));
            this.btnNewOrder.ShadowDecoration.Parent = this.btnNewOrder;
            this.btnNewOrder.Size = new System.Drawing.Size(160, 42);
            this.btnNewOrder.TabIndex = 112;
            this.btnNewOrder.Text = "Новый заказ";
            this.btnNewOrder.Click += new System.EventHandler(this.btnNewOrder_Click);
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
            this.pDataGrid.Controls.Add(this.btnExport);
            this.pDataGrid.Controls.Add(this.guna2Separator2);
            this.pDataGrid.Controls.Add(this.myDataGridView1);
            this.pDataGrid.FillColor = System.Drawing.Color.White;
            this.pDataGrid.Location = new System.Drawing.Point(35, 101);
            this.pDataGrid.Name = "pDataGrid";
            this.pDataGrid.ShadowDecoration.Parent = this.pDataGrid;
            this.pDataGrid.Size = new System.Drawing.Size(1196, 570);
            this.pDataGrid.TabIndex = 111;
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
            this.id,
            this.date_of_create,
            this.services,
            this.sum,
            this.status,
            this.shop_orders,
            this.date_of_deadline,
            this.name,
            this.comment,
            this.pinPic,
            this.delete_row,
            this.prepayment,
            this.ready_date,
            this.pin_orders});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(118)))), ((int)(((byte)(131)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(118)))), ((int)(((byte)(131)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.myDataGridView1.DefaultCellStyle = dataGridViewCellStyle12;
            this.myDataGridView1.EnableHeadersVisualStyles = false;
            this.myDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.myDataGridView1.Location = new System.Drawing.Point(1, 4);
            this.myDataGridView1.MultiSelect = false;
            this.myDataGridView1.Name = "myDataGridView1";
            this.myDataGridView1.ReadOnly = true;
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
            this.myDataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.myDataGridView1_CellMouseClick);
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.id.DataPropertyName = "id";
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.id.DefaultCellStyle = dataGridViewCellStyle2;
            this.id.HeaderText = "№";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.id.Width = 24;
            // 
            // date_of_create
            // 
            this.date_of_create.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.date_of_create.DataPropertyName = "date_of_create";
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.date_of_create.DefaultCellStyle = dataGridViewCellStyle3;
            this.date_of_create.HeaderText = "Дата создания";
            this.date_of_create.MinimumWidth = 115;
            this.date_of_create.Name = "date_of_create";
            this.date_of_create.ReadOnly = true;
            this.date_of_create.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.date_of_create.Width = 115;
            // 
            // services
            // 
            this.services.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.services.DataPropertyName = "services";
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.services.DefaultCellStyle = dataGridViewCellStyle4;
            this.services.HeaderText = "Услуги";
            this.services.MinimumWidth = 6;
            this.services.Name = "services";
            this.services.ReadOnly = true;
            this.services.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // sum
            // 
            this.sum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.sum.DataPropertyName = "sum";
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.sum.DefaultCellStyle = dataGridViewCellStyle5;
            this.sum.HeaderText = "Сумма";
            this.sum.MinimumWidth = 6;
            this.sum.Name = "sum";
            this.sum.ReadOnly = true;
            this.sum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.sum.Width = 49;
            // 
            // status
            // 
            this.status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.status.DataPropertyName = "status";
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.status.DefaultCellStyle = dataGridViewCellStyle6;
            this.status.HeaderText = "Статус";
            this.status.MinimumWidth = 6;
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.status.Width = 47;
            // 
            // shop_orders
            // 
            this.shop_orders.DataPropertyName = "shop";
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.shop_orders.DefaultCellStyle = dataGridViewCellStyle7;
            this.shop_orders.HeaderText = "Филиал";
            this.shop_orders.Name = "shop_orders";
            this.shop_orders.ReadOnly = true;
            this.shop_orders.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // date_of_deadline
            // 
            this.date_of_deadline.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.date_of_deadline.DataPropertyName = "date_of_deadline";
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.date_of_deadline.DefaultCellStyle = dataGridViewCellStyle8;
            this.date_of_deadline.HeaderText = "Срок";
            this.date_of_deadline.MinimumWidth = 6;
            this.date_of_deadline.Name = "date_of_deadline";
            this.date_of_deadline.ReadOnly = true;
            this.date_of_deadline.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.date_of_deadline.Width = 39;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            dataGridViewCellStyle9.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.name.DefaultCellStyle = dataGridViewCellStyle9;
            this.name.HeaderText = "Имя клиента";
            this.name.MinimumWidth = 120;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.name.Width = 120;
            // 
            // comment
            // 
            this.comment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.comment.DataPropertyName = "comment";
            dataGridViewCellStyle10.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.comment.DefaultCellStyle = dataGridViewCellStyle10;
            this.comment.HeaderText = "Комментарий";
            this.comment.MinimumWidth = 6;
            this.comment.Name = "comment";
            this.comment.ReadOnly = true;
            this.comment.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // pinPic
            // 
            this.pinPic.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.pinPic.HeaderText = "";
            this.pinPic.MinimumWidth = 6;
            this.pinPic.Name = "pinPic";
            this.pinPic.ReadOnly = true;
            this.pinPic.Width = 6;
            // 
            // delete_row
            // 
            this.delete_row.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(156)))), ((int)(((byte)(241)))));
            this.delete_row.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.delete_row.DataPropertyName = "delete_row";
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F);
            dataGridViewCellStyle11.Padding = new System.Windows.Forms.Padding(10, 0, 15, 0);
            this.delete_row.DefaultCellStyle = dataGridViewCellStyle11;
            this.delete_row.HeaderText = "";
            this.delete_row.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.delete_row.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(118)))), ((int)(((byte)(131)))));
            this.delete_row.MinimumWidth = 6;
            this.delete_row.Name = "delete_row";
            this.delete_row.ReadOnly = true;
            this.delete_row.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.delete_row.Text = "✕";
            this.delete_row.TrackVisitedState = false;
            this.delete_row.UseColumnTextForLinkValue = true;
            this.delete_row.Width = 6;
            // 
            // prepayment
            // 
            this.prepayment.DataPropertyName = "prepayment";
            this.prepayment.HeaderText = "prepayment";
            this.prepayment.MinimumWidth = 6;
            this.prepayment.Name = "prepayment";
            this.prepayment.ReadOnly = true;
            this.prepayment.Visible = false;
            this.prepayment.Width = 125;
            // 
            // ready_date
            // 
            this.ready_date.DataPropertyName = "ready_date";
            this.ready_date.HeaderText = "ready_date";
            this.ready_date.MinimumWidth = 6;
            this.ready_date.Name = "ready_date";
            this.ready_date.ReadOnly = true;
            this.ready_date.Visible = false;
            this.ready_date.Width = 125;
            // 
            // pin_orders
            // 
            this.pin_orders.DataPropertyName = "pin";
            this.pin_orders.HeaderText = "pin_orders";
            this.pin_orders.MinimumWidth = 6;
            this.pin_orders.Name = "pin_orders";
            this.pin_orders.ReadOnly = true;
            this.pin_orders.Visible = false;
            this.pin_orders.Width = 125;
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
            this.cbxShopFilter.Location = new System.Drawing.Point(580, 35);
            this.cbxShopFilter.Margin = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.cbxShopFilter.Name = "cbxShopFilter";
            this.cbxShopFilter.ShadowDecoration.Parent = this.cbxShopFilter;
            this.cbxShopFilter.Size = new System.Drawing.Size(160, 42);
            this.cbxShopFilter.TabIndex = 23;
            this.cbxShopFilter.TabStop = false;
            this.cbxShopFilter.TextOffset = new System.Drawing.Point(5, 0);
            this.cbxShopFilter.SelectionChangeCommitted += new System.EventHandler(this.cbxShopFilter_SelectionChangeCommitted);
            // 
            // cmsOrder
            // 
            this.cmsOrder.BackColor = System.Drawing.Color.White;
            this.cmsOrder.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsOrder.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAboutOrder,
            this.tsmiPin});
            this.cmsOrder.Name = "cmsStatuses";
            this.cmsOrder.RenderStyle.ArrowColor = System.Drawing.Color.Black;
            this.cmsOrder.RenderStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.cmsOrder.RenderStyle.ColorTable = null;
            this.cmsOrder.RenderStyle.RoundedEdges = true;
            this.cmsOrder.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.cmsOrder.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(156)))), ((int)(((byte)(241)))));
            this.cmsOrder.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.cmsOrder.RenderStyle.SeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.cmsOrder.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.cmsOrder.Size = new System.Drawing.Size(137, 54);
            // 
            // tsmiAboutOrder
            // 
            this.tsmiAboutOrder.AutoSize = false;
            this.tsmiAboutOrder.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tsmiAboutOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(71)))));
            this.tsmiAboutOrder.Name = "tsmiAboutOrder";
            this.tsmiAboutOrder.Size = new System.Drawing.Size(180, 25);
            this.tsmiAboutOrder.Text = "О заказе";
            this.tsmiAboutOrder.Click += new System.EventHandler(this.tsmiAboutOrder_Click);
            // 
            // tsmiPin
            // 
            this.tsmiPin.AutoSize = false;
            this.tsmiPin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tsmiPin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(71)))));
            this.tsmiPin.Name = "tsmiPin";
            this.tsmiPin.Size = new System.Drawing.Size(180, 25);
            this.tsmiPin.Text = "Закрепить";
            this.tsmiPin.Click += new System.EventHandler(this.tsmiPin_Click);
            // 
            // cmsStatuses
            // 
            this.cmsStatuses.BackColor = System.Drawing.Color.White;
            this.cmsStatuses.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsStatuses.Name = "cmsStatuses";
            this.cmsStatuses.RenderStyle.ArrowColor = System.Drawing.Color.Black;
            this.cmsStatuses.RenderStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.cmsStatuses.RenderStyle.ColorTable = null;
            this.cmsStatuses.RenderStyle.RoundedEdges = true;
            this.cmsStatuses.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.cmsStatuses.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(156)))), ((int)(((byte)(241)))));
            this.cmsStatuses.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.cmsStatuses.RenderStyle.SeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.cmsStatuses.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.cmsStatuses.Size = new System.Drawing.Size(61, 4);
            // 
            // calendarTo
            // 
            this.calendarTo.BackColor = System.Drawing.Color.White;
            this.calendarTo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(71)))));
            this.calendarTo.Location = new System.Drawing.Point(211, 81);
            this.calendarTo.MaxSelectionCount = 1;
            this.calendarTo.Name = "calendarTo";
            this.calendarTo.ShowTodayCircle = false;
            this.calendarTo.TabIndex = 133;
            this.calendarTo.TabStop = false;
            this.calendarTo.TitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.calendarTo.Visible = false;
            this.calendarTo.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calendarTo_DateChanged);
            // 
            // cmsShops
            // 
            this.cmsShops.BackColor = System.Drawing.Color.White;
            this.cmsShops.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsShops.Name = "cmsStatuses";
            this.cmsShops.RenderStyle.ArrowColor = System.Drawing.Color.Black;
            this.cmsShops.RenderStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.cmsShops.RenderStyle.ColorTable = null;
            this.cmsShops.RenderStyle.RoundedEdges = true;
            this.cmsShops.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.cmsShops.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(156)))), ((int)(((byte)(241)))));
            this.cmsShops.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.cmsShops.RenderStyle.SeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.cmsShops.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.cmsShops.Size = new System.Drawing.Size(61, 4);
            // 
            // btnDateTo
            // 
            this.btnDateTo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.btnDateTo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.btnDateTo.BorderRadius = 4;
            this.btnDateTo.BorderThickness = 1;
            this.btnDateTo.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.btnDateTo.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.btnDateTo.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnDateTo.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(156)))), ((int)(((byte)(241)))));
            this.btnDateTo.CheckedState.Image = global::Order_Management.Properties.Resources.calendarIconOn;
            this.btnDateTo.CheckedState.Parent = this.btnDateTo;
            this.btnDateTo.CustomImages.Parent = this.btnDateTo;
            this.btnDateTo.DisabledState.Parent = this.btnDateTo;
            this.btnDateTo.FillColor = System.Drawing.Color.White;
            this.btnDateTo.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnDateTo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(112)))), ((int)(((byte)(126)))));
            this.btnDateTo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.btnDateTo.HoverState.FillColor = System.Drawing.Color.White;
            this.btnDateTo.HoverState.Parent = this.btnDateTo;
            this.btnDateTo.Image = global::Order_Management.Properties.Resources.calendarIconOff;
            this.btnDateTo.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnDateTo.ImageSize = new System.Drawing.Size(14, 16);
            this.btnDateTo.Location = new System.Drawing.Point(216, 35);
            this.btnDateTo.Margin = new System.Windows.Forms.Padding(0);
            this.btnDateTo.Name = "btnDateTo";
            this.btnDateTo.PressedColor = System.Drawing.Color.White;
            this.btnDateTo.ShadowDecoration.Parent = this.btnDateTo;
            this.btnDateTo.Size = new System.Drawing.Size(159, 42);
            this.btnDateTo.TabIndex = 132;
            this.btnDateTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDateTo.TextOffset = new System.Drawing.Point(0, -2);
            this.toolTip1.SetToolTip(this.btnDateTo, "Заказы до даты");
            this.btnDateTo.CheckedChanged += new System.EventHandler(this.btnDateTo_CheckedChanged);
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.BackColor = System.Drawing.Color.White;
            this.btnExport.CheckedState.Parent = this.btnExport;
            this.btnExport.CustomImages.Parent = this.btnExport;
            this.btnExport.DisabledState.Parent = this.btnExport;
            this.btnExport.FillColor = System.Drawing.Color.White;
            this.btnExport.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.btnExport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(156)))), ((int)(((byte)(241)))));
            this.btnExport.HoverState.FillColor = System.Drawing.Color.White;
            this.btnExport.HoverState.Image = global::Order_Management.Properties.Resources.exportIconOn;
            this.btnExport.HoverState.Parent = this.btnExport;
            this.btnExport.Image = global::Order_Management.Properties.Resources.exportIconOff;
            this.btnExport.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnExport.ImageSize = new System.Drawing.Size(15, 16);
            this.btnExport.Location = new System.Drawing.Point(1133, 14);
            this.btnExport.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.btnExport.Name = "btnExport";
            this.btnExport.PressedColor = System.Drawing.Color.White;
            this.btnExport.ShadowDecoration.Parent = this.btnExport;
            this.btnExport.Size = new System.Drawing.Size(35, 30);
            this.btnExport.TabIndex = 134;
            this.btnExport.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.btnExport, "Экспорт");
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnTemporarilyFolder
            // 
            this.btnTemporarilyFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTemporarilyFolder.CheckedState.Parent = this.btnTemporarilyFolder;
            this.btnTemporarilyFolder.CustomImages.Parent = this.btnTemporarilyFolder;
            this.btnTemporarilyFolder.DisabledState.Parent = this.btnTemporarilyFolder;
            this.btnTemporarilyFolder.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.btnTemporarilyFolder.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.btnTemporarilyFolder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(156)))), ((int)(((byte)(241)))));
            this.btnTemporarilyFolder.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.btnTemporarilyFolder.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(175)))), ((int)(((byte)(249)))));
            this.btnTemporarilyFolder.HoverState.Parent = this.btnTemporarilyFolder;
            this.btnTemporarilyFolder.Image = global::Order_Management.Properties.Resources.folderIconOn;
            this.btnTemporarilyFolder.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnTemporarilyFolder.ImageOffset = new System.Drawing.Point(0, 1);
            this.btnTemporarilyFolder.ImageSize = new System.Drawing.Size(16, 14);
            this.btnTemporarilyFolder.Location = new System.Drawing.Point(941, 41);
            this.btnTemporarilyFolder.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.btnTemporarilyFolder.Name = "btnTemporarilyFolder";
            this.btnTemporarilyFolder.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.btnTemporarilyFolder.ShadowDecoration.Parent = this.btnTemporarilyFolder;
            this.btnTemporarilyFolder.Size = new System.Drawing.Size(110, 30);
            this.btnTemporarilyFolder.TabIndex = 115;
            this.btnTemporarilyFolder.Text = "Временно";
            this.btnTemporarilyFolder.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.btnTemporarilyFolder, "Открыть папку");
            this.btnTemporarilyFolder.Click += new System.EventHandler(this.btnTemporarilyFolder_Click);
            // 
            // btnDateFrom
            // 
            this.btnDateFrom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.btnDateFrom.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.btnDateFrom.BorderRadius = 4;
            this.btnDateFrom.BorderThickness = 1;
            this.btnDateFrom.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.btnDateFrom.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.btnDateFrom.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnDateFrom.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(156)))), ((int)(((byte)(241)))));
            this.btnDateFrom.CheckedState.Image = global::Order_Management.Properties.Resources.calendarIconOn;
            this.btnDateFrom.CheckedState.Parent = this.btnDateFrom;
            this.btnDateFrom.CustomImages.Parent = this.btnDateFrom;
            this.btnDateFrom.DisabledState.Parent = this.btnDateFrom;
            this.btnDateFrom.FillColor = System.Drawing.Color.White;
            this.btnDateFrom.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnDateFrom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(112)))), ((int)(((byte)(126)))));
            this.btnDateFrom.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.btnDateFrom.HoverState.FillColor = System.Drawing.Color.White;
            this.btnDateFrom.HoverState.Parent = this.btnDateFrom;
            this.btnDateFrom.Image = global::Order_Management.Properties.Resources.calendarIconOff;
            this.btnDateFrom.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnDateFrom.ImageSize = new System.Drawing.Size(14, 16);
            this.btnDateFrom.Location = new System.Drawing.Point(35, 35);
            this.btnDateFrom.Margin = new System.Windows.Forms.Padding(0);
            this.btnDateFrom.Name = "btnDateFrom";
            this.btnDateFrom.PressedColor = System.Drawing.Color.White;
            this.btnDateFrom.ShadowDecoration.Parent = this.btnDateFrom;
            this.btnDateFrom.Size = new System.Drawing.Size(159, 42);
            this.btnDateFrom.TabIndex = 130;
            this.btnDateFrom.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDateFrom.TextOffset = new System.Drawing.Point(0, -2);
            this.toolTip1.SetToolTip(this.btnDateFrom, "Заказы с даты");
            this.btnDateFrom.CheckedChanged += new System.EventHandler(this.btnDateFrom_CheckedChanged);
            // 
            // OrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1266, 706);
            this.ControlBox = false;
            this.Controls.Add(this.calendarTo);
            this.Controls.Add(this.btnDateTo);
            this.Controls.Add(this.calendarFrom);
            this.Controls.Add(this.pDataGrid);
            this.Controls.Add(this.cbxStatusFilter);
            this.Controls.Add(this.cbxShopFilter);
            this.Controls.Add(this.btnNewOrder);
            this.Controls.Add(this.btnTemporarilyFolder);
            this.Controls.Add(this.chbxOrderNotGiven);
            this.Controls.Add(this.btnDateFrom);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OrdersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Заказы - Order Management";
            this.Load += new System.EventHandler(this.OrdersForm_Load);
            this.Click += new System.EventHandler(this.OrdersForm_Click);
            this.Resize += new System.EventHandler(this.OrdersForm_Resize);
            this.pDataGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.myDataGridView1)).EndInit();
            this.cmsOrder.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar calendarFrom;
        private Guna.UI2.WinForms.Guna2Button btnDateFrom;
        private Guna.UI2.WinForms.Guna2Button btnTemporarilyFolder;
        private Guna.UI2.WinForms.Guna2CheckBox chbxOrderNotGiven;
        private Guna.UI2.WinForms.Guna2ComboBox cbxStatusFilter;
        private Guna.UI2.WinForms.Guna2Panel pDataGrid;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
        private Guna.UI2.WinForms.Guna2ComboBox cbxShopFilter;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip cmsOrder;
        private System.Windows.Forms.ToolStripMenuItem tsmiAboutOrder;
        private System.Windows.Forms.ToolStripMenuItem tsmiPin;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip cmsStatuses;
        private System.Windows.Forms.ToolTip toolTip1;
        public Guna.UI2.WinForms.Guna2Button btnNewOrder;
        public MyDataGridView myDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_of_create;
        private System.Windows.Forms.DataGridViewTextBoxColumn services;
        private System.Windows.Forms.DataGridViewTextBoxColumn sum;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn shop_orders;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_of_deadline;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn comment;
        private System.Windows.Forms.DataGridViewImageColumn pinPic;
        private System.Windows.Forms.DataGridViewLinkColumn delete_row;
        private System.Windows.Forms.DataGridViewTextBoxColumn prepayment;
        private System.Windows.Forms.DataGridViewTextBoxColumn ready_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn pin_orders;
        private Guna.UI2.WinForms.Guna2Button btnDateTo;
        private System.Windows.Forms.MonthCalendar calendarTo;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip cmsShops;
        private Guna.UI2.WinForms.Guna2Button btnExport;
    }
}