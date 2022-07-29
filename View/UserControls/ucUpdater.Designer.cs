
namespace Order_Management.UserControls
{
    partial class ucUpdater
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pMain = new Guna.UI2.WinForms.Guna2Panel();
            this.lblFullState = new System.Windows.Forms.Label();
            this.btnConfirm = new Guna.UI2.WinForms.Guna2Button();
            this.pbxState = new System.Windows.Forms.PictureBox();
            this.lblState = new System.Windows.Forms.Label();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.pMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxState)).BeginInit();
            this.SuspendLayout();
            // 
            // pMain
            // 
            this.pMain.BackColor = System.Drawing.Color.White;
            this.pMain.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.pMain.BorderThickness = 1;
            this.pMain.Controls.Add(this.lblFullState);
            this.pMain.Controls.Add(this.btnConfirm);
            this.pMain.Controls.Add(this.pbxState);
            this.pMain.Controls.Add(this.lblState);
            this.pMain.Controls.Add(this.guna2ControlBox1);
            this.pMain.Location = new System.Drawing.Point(0, 0);
            this.pMain.Name = "pMain";
            this.pMain.ShadowDecoration.Parent = this.pMain;
            this.pMain.Size = new System.Drawing.Size(375, 495);
            this.pMain.TabIndex = 102;
            // 
            // lblFullState
            // 
            this.lblFullState.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblFullState.ForeColor = System.Drawing.Color.Gray;
            this.lblFullState.Location = new System.Drawing.Point(42, 248);
            this.lblFullState.Name = "lblFullState";
            this.lblFullState.Size = new System.Drawing.Size(291, 135);
            this.lblFullState.TabIndex = 123;
            this.lblFullState.Text = "Новая версия загружается,\r\nпожалуйста подождите.";
            this.lblFullState.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.Transparent;
            this.btnConfirm.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(156)))), ((int)(((byte)(241)))));
            this.btnConfirm.BorderRadius = 4;
            this.btnConfirm.BorderThickness = 1;
            this.btnConfirm.CheckedState.Parent = this.btnConfirm;
            this.btnConfirm.CustomImages.Parent = this.btnConfirm;
            this.btnConfirm.DisabledState.Parent = this.btnConfirm;
            this.btnConfirm.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(156)))), ((int)(((byte)(241)))));
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(175)))), ((int)(((byte)(249)))));
            this.btnConfirm.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(175)))), ((int)(((byte)(249)))));
            this.btnConfirm.HoverState.Parent = this.btnConfirm;
            this.btnConfirm.Location = new System.Drawing.Point(97, 402);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(0);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.PressedDepth = 20;
            this.btnConfirm.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(156)))), ((int)(((byte)(241)))));
            this.btnConfirm.ShadowDecoration.Parent = this.btnConfirm;
            this.btnConfirm.Size = new System.Drawing.Size(180, 42);
            this.btnConfirm.TabIndex = 121;
            this.btnConfirm.TabStop = false;
            this.btnConfirm.Text = "ОК";
            this.btnConfirm.Visible = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // pbxState
            // 
            this.pbxState.Image = global::Order_Management.Properties.Resources.installing_updates;
            this.pbxState.Location = new System.Drawing.Point(132, 77);
            this.pbxState.Name = "pbxState";
            this.pbxState.Size = new System.Drawing.Size(110, 110);
            this.pbxState.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxState.TabIndex = 120;
            this.pbxState.TabStop = false;
            // 
            // lblState
            // 
            this.lblState.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(71)))));
            this.lblState.Location = new System.Drawing.Point(30, 203);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(315, 20);
            this.lblState.TabIndex = 119;
            this.lblState.Text = "Приложение обновляется";
            this.lblState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
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
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.pMain;
            // 
            // ucUpdater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pMain);
            this.Name = "ucUpdater";
            this.Size = new System.Drawing.Size(375, 495);
            this.pMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxState)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pMain;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        public System.Windows.Forms.Label lblState;
        public System.Windows.Forms.Label lblFullState;
        public System.Windows.Forms.PictureBox pbxState;
        public Guna.UI2.WinForms.Guna2Button btnConfirm;
    }
}
