
namespace Order_Management.View.SettingsForms
{
    partial class InterfaceForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.chbxWindowMax = new Guna.UI2.WinForms.Guna2CheckBox();
            this.cbxShop = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblShopTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(71)))));
            this.label1.Location = new System.Drawing.Point(20, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Интерфейс";
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Separator1.BackColor = System.Drawing.Color.White;
            this.guna2Separator1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.guna2Separator1.Location = new System.Drawing.Point(0, 75);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(905, 10);
            this.guna2Separator1.TabIndex = 138;
            // 
            // chbxWindowMax
            // 
            this.chbxWindowMax.AutoSize = true;
            this.chbxWindowMax.BackColor = System.Drawing.Color.White;
            this.chbxWindowMax.CheckedState.BorderRadius = 4;
            this.chbxWindowMax.CheckedState.BorderThickness = 0;
            this.chbxWindowMax.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(156)))), ((int)(((byte)(241)))));
            this.chbxWindowMax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(112)))), ((int)(((byte)(126)))));
            this.chbxWindowMax.Location = new System.Drawing.Point(24, 110);
            this.chbxWindowMax.Margin = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.chbxWindowMax.Name = "chbxWindowMax";
            this.chbxWindowMax.Size = new System.Drawing.Size(178, 19);
            this.chbxWindowMax.TabIndex = 139;
            this.chbxWindowMax.TabStop = false;
            this.chbxWindowMax.Text = "  На весь экран при запуске";
            this.chbxWindowMax.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chbxWindowMax.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.chbxWindowMax.UncheckedState.BorderRadius = 4;
            this.chbxWindowMax.UncheckedState.BorderThickness = 1;
            this.chbxWindowMax.UncheckedState.FillColor = System.Drawing.Color.White;
            this.chbxWindowMax.UseVisualStyleBackColor = false;
            this.chbxWindowMax.CheckedChanged += new System.EventHandler(this.chbxWindowMax_CheckedChanged);
            // 
            // cbxShop
            // 
            this.cbxShop.BackColor = System.Drawing.Color.White;
            this.cbxShop.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.cbxShop.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxShop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxShop.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(142)))), ((int)(((byte)(155)))));
            this.cbxShop.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(142)))), ((int)(((byte)(155)))));
            this.cbxShop.FocusedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(156)))), ((int)(((byte)(241)))));
            this.cbxShop.FocusedState.Parent = this.cbxShop;
            this.cbxShop.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbxShop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(207)))), ((int)(((byte)(224)))));
            this.cbxShop.HoverState.Parent = this.cbxShop;
            this.cbxShop.ItemHeight = 30;
            this.cbxShop.ItemsAppearance.BackColor = System.Drawing.Color.White;
            this.cbxShop.ItemsAppearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(112)))), ((int)(((byte)(126)))));
            this.cbxShop.ItemsAppearance.Parent = this.cbxShop;
            this.cbxShop.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(156)))), ((int)(((byte)(241)))));
            this.cbxShop.ItemsAppearance.SelectedForeColor = System.Drawing.Color.White;
            this.cbxShop.Location = new System.Drawing.Point(24, 172);
            this.cbxShop.Margin = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.cbxShop.Name = "cbxShop";
            this.cbxShop.ShadowDecoration.Parent = this.cbxShop;
            this.cbxShop.Size = new System.Drawing.Size(180, 36);
            this.cbxShop.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cbxShop.TabIndex = 140;
            this.cbxShop.TabStop = false;
            this.cbxShop.TextOffset = new System.Drawing.Point(-8, 1);
            this.cbxShop.SelectionChangeCommitted += new System.EventHandler(this.cbxShop_SelectionChangeCommitted);
            // 
            // lblShopTitle
            // 
            this.lblShopTitle.AutoSize = true;
            this.lblShopTitle.BackColor = System.Drawing.Color.White;
            this.lblShopTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.lblShopTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(142)))), ((int)(((byte)(155)))));
            this.lblShopTitle.Location = new System.Drawing.Point(21, 160);
            this.lblShopTitle.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.lblShopTitle.Name = "lblShopTitle";
            this.lblShopTitle.Size = new System.Drawing.Size(136, 15);
            this.lblShopTitle.TabIndex = 141;
            this.lblShopTitle.Text = "Филиал по умолчанию";
            // 
            // InterfaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(905, 628);
            this.ControlBox = false;
            this.Controls.Add(this.lblShopTitle);
            this.Controls.Add(this.cbxShop);
            this.Controls.Add(this.chbxWindowMax);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InterfaceForm";
            this.Text = "InterfaceForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2CheckBox chbxWindowMax;
        private Guna.UI2.WinForms.Guna2ComboBox cbxShop;
        private System.Windows.Forms.Label lblShopTitle;
    }
}