namespace POS_System.Sub_Form.Orders_Form
{
    partial class Orders
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lbtPrice = new System.Windows.Forms.Label();
            this.PName = new System.Windows.Forms.Label();
            this.btn_AddItem = new Guna.UI2.WinForms.Guna2Button();
            this.PIcPro = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PIcPro)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.BorderRadius = 10;
            this.guna2Panel1.Controls.Add(this.lbtPrice);
            this.guna2Panel1.Controls.Add(this.PName);
            this.guna2Panel1.Controls.Add(this.btn_AddItem);
            this.guna2Panel1.Controls.Add(this.PIcPro);
            this.guna2Panel1.Location = new System.Drawing.Point(4, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(146, 156);
            this.guna2Panel1.TabIndex = 1;
            // 
            // lbtPrice
            // 
            this.lbtPrice.AutoSize = true;
            this.lbtPrice.BackColor = System.Drawing.Color.Transparent;
            this.lbtPrice.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtPrice.Location = new System.Drawing.Point(3, 104);
            this.lbtPrice.Name = "lbtPrice";
            this.lbtPrice.Size = new System.Drawing.Size(36, 19);
            this.lbtPrice.TabIndex = 4;
            this.lbtPrice.Text = "Price";
            // 
            // PName
            // 
            this.PName.AutoSize = true;
            this.PName.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PName.Location = new System.Drawing.Point(3, 89);
            this.PName.Name = "PName";
            this.PName.Size = new System.Drawing.Size(83, 19);
            this.PName.TabIndex = 2;
            this.PName.Text = "Product Name";
            // 
            // btn_AddItem
            // 
            this.btn_AddItem.Animated = true;
            this.btn_AddItem.BorderRadius = 10;
            this.btn_AddItem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_AddItem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_AddItem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_AddItem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_AddItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddItem.ForeColor = System.Drawing.Color.White;
            this.btn_AddItem.Location = new System.Drawing.Point(9, 122);
            this.btn_AddItem.Name = "btn_AddItem";
            this.btn_AddItem.Size = new System.Drawing.Size(124, 25);
            this.btn_AddItem.TabIndex = 1;
            this.btn_AddItem.Text = "Add Item";
            this.btn_AddItem.Click += new System.EventHandler(this.btn_AddItem_Click);
            // 
            // PIcPro
            // 
            this.PIcPro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PIcPro.Image = global::POS_System.Properties.Resources.C__A__M__E__R__A_1_removebg_preview;
            this.PIcPro.ImageRotate = 0F;
            this.PIcPro.Location = new System.Drawing.Point(26, 3);
            this.PIcPro.Name = "PIcPro";
            this.PIcPro.Size = new System.Drawing.Size(87, 69);
            this.PIcPro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PIcPro.TabIndex = 0;
            this.PIcPro.TabStop = false;
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2Panel1);
            this.Name = "Orders";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PIcPro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label lbtPrice;
        private System.Windows.Forms.Label PName;
        private Guna.UI2.WinForms.Guna2Button btn_AddItem;
        private Guna.UI2.WinForms.Guna2PictureBox PIcPro;
    }
}
