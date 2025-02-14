namespace POS_System.Sub_Form.Orders_Form
{
    partial class Wights
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Wights));
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.ProductsName = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.bunifuPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 10;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.guna2PictureBox1);
            this.bunifuPanel1.Controls.Add(this.Price);
            this.bunifuPanel1.Controls.Add(this.ProductsName);
            this.bunifuPanel1.Location = new System.Drawing.Point(0, 3);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = false;
            this.bunifuPanel1.Size = new System.Drawing.Size(146, 70);
            this.bunifuPanel1.TabIndex = 0;
            // 
            // ProductsName
            // 
            this.ProductsName.AutoSize = true;
            this.ProductsName.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductsName.Location = new System.Drawing.Point(7, 5);
            this.ProductsName.Name = "ProductsName";
            this.ProductsName.Size = new System.Drawing.Size(45, 19);
            this.ProductsName.TabIndex = 0;
            this.ProductsName.Text = "Name";
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.BackColor = System.Drawing.Color.Transparent;
            this.Price.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Price.Location = new System.Drawing.Point(4, 28);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(70, 41);
            this.Price.TabIndex = 1;
            this.Price.Text = "0.00";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = global::POS_System.Properties.Resources.C__A__M__E__R__A_1_removebg_preview;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(71, 8);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(50, 46);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 2;
            this.guna2PictureBox1.TabStop = false;
            // 
            // Wights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.bunifuPanel1);
            this.Name = "Wights";
            this.Size = new System.Drawing.Size(146, 76);
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.Label ProductsName;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}
