namespace POS_System.Sub_Form.Product_Form
{
    partial class Insert
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
            this.btnCancel = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.btnSubmit = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.txtCatID = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboCatName = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.txtPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcost = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtqty = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProductName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.Picture = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Animated = true;
            this.btnCancel.BorderRadius = 10;
            this.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancel.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancel.FillColor = System.Drawing.Color.Red;
            this.btnCancel.FillColor2 = System.Drawing.Color.Maroon;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(299, 662);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(116, 49);
            this.btnCancel.TabIndex = 90;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Animated = true;
            this.btnSubmit.BorderRadius = 10;
            this.btnSubmit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSubmit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSubmit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSubmit.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSubmit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSubmit.FillColor = System.Drawing.Color.Blue;
            this.btnSubmit.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(436, 662);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(143, 49);
            this.btnSubmit.TabIndex = 89;
            this.btnSubmit.Text = "INSERT";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtCatID
            // 
            this.txtCatID.Animated = true;
            this.txtCatID.BorderRadius = 10;
            this.txtCatID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCatID.DefaultText = "";
            this.txtCatID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCatID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCatID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCatID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCatID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCatID.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.txtCatID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCatID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCatID.Location = new System.Drawing.Point(28, 662);
            this.txtCatID.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtCatID.Name = "txtCatID";
            this.txtCatID.PasswordChar = '\0';
            this.txtCatID.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtCatID.PlaceholderText = "Category Name";
            this.txtCatID.SelectedText = "";
            this.txtCatID.Size = new System.Drawing.Size(258, 44);
            this.txtCatID.TabIndex = 88;
            this.txtCatID.TextOffset = new System.Drawing.Point(15, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(35, 627);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 29);
            this.label7.TabIndex = 87;
            this.label7.Text = "Category ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(35, 541);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 29);
            this.label6.TabIndex = 86;
            this.label6.Text = "Category Name";
            // 
            // comboCatName
            // 
            this.comboCatName.BackColor = System.Drawing.Color.Transparent;
            this.comboCatName.BorderRadius = 10;
            this.comboCatName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboCatName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCatName.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboCatName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboCatName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.comboCatName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboCatName.ItemHeight = 38;
            this.comboCatName.Location = new System.Drawing.Point(28, 576);
            this.comboCatName.Name = "comboCatName";
            this.comboCatName.Size = new System.Drawing.Size(258, 44);
            this.comboCatName.TabIndex = 85;
            this.comboCatName.TextOffset = new System.Drawing.Point(15, 0);
            this.comboCatName.SelectedIndexChanged += new System.EventHandler(this.comboCatID_SelectedIndexChanged);
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.BorderRadius = 15;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Blue;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(28, 451);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(214, 45);
            this.guna2Button1.TabIndex = 84;
            this.guna2Button1.Text = "Browse";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Animated = true;
            this.txtPrice.BorderRadius = 10;
            this.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrice.DefaultText = "";
            this.txtPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.txtPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrice.Location = new System.Drawing.Point(298, 576);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PasswordChar = '\0';
            this.txtPrice.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtPrice.PlaceholderText = "Enter Price of Poduct";
            this.txtPrice.SelectedText = "";
            this.txtPrice.Size = new System.Drawing.Size(281, 44);
            this.txtPrice.TabIndex = 82;
            this.txtPrice.TextOffset = new System.Drawing.Point(15, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(305, 541);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 29);
            this.label4.TabIndex = 81;
            this.label4.Text = "Price";
            // 
            // txtcost
            // 
            this.txtcost.Animated = true;
            this.txtcost.BorderRadius = 10;
            this.txtcost.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcost.DefaultText = "";
            this.txtcost.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtcost.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtcost.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtcost.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtcost.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtcost.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.txtcost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtcost.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtcost.Location = new System.Drawing.Point(298, 328);
            this.txtcost.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtcost.Name = "txtcost";
            this.txtcost.PasswordChar = '\0';
            this.txtcost.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtcost.PlaceholderText = "Enter Product Cost";
            this.txtcost.SelectedText = "";
            this.txtcost.Size = new System.Drawing.Size(272, 44);
            this.txtcost.TabIndex = 80;
            this.txtcost.TextOffset = new System.Drawing.Point(15, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(305, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 29);
            this.label5.TabIndex = 79;
            this.label5.Text = "Cost";
            // 
            // txtqty
            // 
            this.txtqty.Animated = true;
            this.txtqty.BorderRadius = 10;
            this.txtqty.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtqty.DefaultText = "";
            this.txtqty.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtqty.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtqty.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtqty.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtqty.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtqty.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.txtqty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtqty.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtqty.Location = new System.Drawing.Point(298, 452);
            this.txtqty.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtqty.Name = "txtqty";
            this.txtqty.PasswordChar = '\0';
            this.txtqty.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtqty.PlaceholderText = "Enter quantity Product";
            this.txtqty.SelectedText = "";
            this.txtqty.Size = new System.Drawing.Size(281, 44);
            this.txtqty.TabIndex = 78;
            this.txtqty.TextOffset = new System.Drawing.Point(15, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(305, 417);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 29);
            this.label3.TabIndex = 77;
            this.label3.Text = "Quantity";
            // 
            // txtProductName
            // 
            this.txtProductName.BorderRadius = 10;
            this.txtProductName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProductName.DefaultText = "";
            this.txtProductName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtProductName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtProductName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProductName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProductName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProductName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.txtProductName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtProductName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProductName.Location = new System.Drawing.Point(298, 204);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.PasswordChar = '\0';
            this.txtProductName.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtProductName.PlaceholderText = "Enter Name Product";
            this.txtProductName.SelectedText = "";
            this.txtProductName.Size = new System.Drawing.Size(272, 44);
            this.txtProductName.TabIndex = 76;
            this.txtProductName.TextOffset = new System.Drawing.Point(15, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(305, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 29);
            this.label2.TabIndex = 75;
            this.label2.Text = "Product Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(126, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 72);
            this.label1.TabIndex = 74;
            this.label1.Text = "Insert Products";
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // Picture
            // 
            this.Picture.BackColor = System.Drawing.Color.Transparent;
            this.Picture.BorderRadius = 10;
            this.Picture.ImageRotate = 0F;
            this.Picture.Location = new System.Drawing.Point(28, 176);
            this.Picture.Name = "Picture";
            this.Picture.Size = new System.Drawing.Size(214, 262);
            this.Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Picture.TabIndex = 83;
            this.Picture.TabStop = false;
            this.Picture.UseTransparentBackground = true;
            // 
            // Insert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(619, 745);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtCatID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboCatName);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.Picture);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtcost);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtqty);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Insert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Insert";
            this.Load += new System.EventHandler(this.Insert_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientTileButton btnCancel;
        private Guna.UI2.WinForms.Guna2GradientTileButton btnSubmit;
        private Guna.UI2.WinForms.Guna2TextBox txtCatID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2ComboBox comboCatName;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2PictureBox Picture;
        private Guna.UI2.WinForms.Guna2TextBox txtPrice;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtcost;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtqty;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtProductName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
    }
}