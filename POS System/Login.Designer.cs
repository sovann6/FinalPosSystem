namespace POS_System
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.Role = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Pass = new Guna.UI2.WinForms.Guna2TextBox();
            this.Exit = new Guna.UI2.WinForms.Guna2Button();
            this.Users = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Showpass = new Guna.UI2.WinForms.Guna2CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("guna2Panel1.BackgroundImage")));
            this.guna2Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.guna2Panel1.Controls.Add(this.label5);
            this.guna2Panel1.Controls.Add(this.Role);
            this.guna2Panel1.Controls.Add(this.Pass);
            this.guna2Panel1.Controls.Add(this.Exit);
            this.guna2Panel1.Controls.Add(this.Users);
            this.guna2Panel1.Controls.Add(this.label4);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.Showpass);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.btnLogin);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1016, 508);
            this.guna2Panel1.TabIndex = 0;
            // 
            // Role
            // 
            this.Role.BackColor = System.Drawing.Color.Transparent;
            this.Role.BorderRadius = 10;
            this.Role.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Role.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Role.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Role.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 18F, System.Drawing.FontStyle.Bold);
            this.Role.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.Role.ItemHeight = 35;
            this.Role.Location = new System.Drawing.Point(596, 330);
            this.Role.Name = "Role";
            this.Role.Size = new System.Drawing.Size(330, 41);
            this.Role.TabIndex = 13;
            this.Role.TextOffset = new System.Drawing.Point(10, 0);
            this.Role.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Role_KeyDown);
            // 
            // Pass
            // 
            this.Pass.Animated = true;
            this.Pass.AutoRoundedCorners = true;
            this.Pass.BackColor = System.Drawing.Color.Transparent;
            this.Pass.BorderRadius = 21;
            this.Pass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Pass.DefaultText = "";
            this.Pass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Pass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Pass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Pass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Pass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Pass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Pass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Pass.Location = new System.Drawing.Point(596, 240);
            this.Pass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Pass.Name = "Pass";
            this.Pass.PasswordChar = '\0';
            this.Pass.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.Pass.PlaceholderText = "Enter Your Password";
            this.Pass.SelectedText = "";
            this.Pass.Size = new System.Drawing.Size(330, 45);
            this.Pass.TabIndex = 3;
            this.Pass.TextOffset = new System.Drawing.Point(15, 0);
            this.Pass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Pass_KeyDown);
            // 
            // Exit
            // 
            this.Exit.Animated = true;
            this.Exit.AutoRoundedCorners = true;
            this.Exit.BackColor = System.Drawing.Color.Transparent;
            this.Exit.BorderRadius = 21;
            this.Exit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Exit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Exit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Exit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Exit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Exit.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.Exit.ForeColor = System.Drawing.Color.White;
            this.Exit.Location = new System.Drawing.Point(692, 413);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(99, 45);
            this.Exit.TabIndex = 11;
            this.Exit.Text = "Exit";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Users
            // 
            this.Users.Animated = true;
            this.Users.AutoRoundedCorners = true;
            this.Users.BackColor = System.Drawing.Color.Transparent;
            this.Users.BorderRadius = 21;
            this.Users.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Users.DefaultText = "";
            this.Users.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Users.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Users.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Users.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Users.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Users.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Users.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Users.Location = new System.Drawing.Point(596, 154);
            this.Users.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Users.Name = "Users";
            this.Users.PasswordChar = '\0';
            this.Users.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.Users.PlaceholderText = "Enter Your Username";
            this.Users.SelectedText = "";
            this.Users.Size = new System.Drawing.Size(330, 45);
            this.Users.TabIndex = 2;
            this.Users.TextOffset = new System.Drawing.Point(15, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Fuchsia;
            this.label4.Location = new System.Drawing.Point(546, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(422, 46);
            this.label4.TabIndex = 10;
            this.label4.Text = "WellCome to POS System";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(596, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Username";
            // 
            // Showpass
            // 
            this.Showpass.AutoSize = true;
            this.Showpass.BackColor = System.Drawing.Color.Transparent;
            this.Showpass.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.Showpass.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Showpass.CheckedState.BorderRadius = 0;
            this.Showpass.CheckedState.BorderThickness = 0;
            this.Showpass.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Showpass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Showpass.ForeColor = System.Drawing.Color.DimGray;
            this.Showpass.Location = new System.Drawing.Point(779, 377);
            this.Showpass.Name = "Showpass";
            this.Showpass.Size = new System.Drawing.Size(147, 25);
            this.Showpass.TabIndex = 9;
            this.Showpass.Text = "Show Password";
            this.Showpass.UncheckedState.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Showpass.UncheckedState.BorderRadius = 0;
            this.Showpass.UncheckedState.BorderThickness = 0;
            this.Showpass.UncheckedState.FillColor = System.Drawing.Color.IndianRed;
            this.Showpass.UseVisualStyleBackColor = false;
            this.Showpass.CheckedChanged += new System.EventHandler(this.Showpass_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(596, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "Role";
            // 
            // btnLogin
            // 
            this.btnLogin.Animated = true;
            this.btnLogin.AutoRoundedCorners = true;
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.BorderRadius = 21;
            this.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(91)))), ((int)(((byte)(204)))));
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(797, 413);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(129, 45);
            this.btnLogin.TabIndex = 8;
            this.btnLogin.Text = "Sign In";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Location = new System.Drawing.Point(596, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "Password";
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(907, 482);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 21);
            this.label5.TabIndex = 14;
            this.label5.Text = "Version 1.0.1";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 508);
            this.Controls.Add(this.guna2Panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Green;
            this.Load += new System.EventHandler(this.Login_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2TextBox Users;
        private Guna.UI2.WinForms.Guna2TextBox Pass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private Guna.UI2.WinForms.Guna2CheckBox Showpass;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button Exit;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2ComboBox Role;
        private System.Windows.Forms.Label label5;
    }
}

