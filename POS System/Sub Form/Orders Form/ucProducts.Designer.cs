namespace POS_System.Sub_Form.Orders_Form
{
    partial class ucProducts
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucProducts));
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.lbPrice = new System.Windows.Forms.Label();
            this.Product_Name = new System.Windows.Forms.Label();
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.ProductPic = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2ShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductPic)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.lbPrice);
            this.guna2ShadowPanel1.Controls.Add(this.Product_Name);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(0, 22);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(80, 71);
            this.guna2ShadowPanel1.TabIndex = 0;
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.Location = new System.Drawing.Point(3, 39);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(29, 13);
            this.lbPrice.TabIndex = 1;
            this.lbPrice.Text = "Price";
            // 
            // Product_Name
            // 
            this.Product_Name.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Product_Name.Location = new System.Drawing.Point(5, 17);
            this.Product_Name.Name = "Product_Name";
            this.Product_Name.Size = new System.Drawing.Size(72, 22);
            this.Product_Name.TabIndex = 0;
            this.Product_Name.Text = "Products Name";
            // 
            // ProductPic
            // 
            this.ProductPic.BackColor = System.Drawing.Color.Transparent;
            this.ProductPic.Image = ((System.Drawing.Image)(resources.GetObject("ProductPic.Image")));
            this.ProductPic.ImageRotate = 0F;
            this.ProductPic.Location = new System.Drawing.Point(23, 0);
            this.ProductPic.Name = "ProductPic";
            this.ProductPic.Size = new System.Drawing.Size(33, 36);
            this.ProductPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ProductPic.TabIndex = 0;
            this.ProductPic.TabStop = false;
            this.ProductPic.Click += new System.EventHandler(this.ProductPic_Click);
            // 
            // ucProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ProductPic);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Name = "ucProducts";
            this.Size = new System.Drawing.Size(80, 96);
            this.Load += new System.EventHandler(this.ucProducts_Load);
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2ShadowPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2PictureBox ProductPic;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label Product_Name;
    }
}
