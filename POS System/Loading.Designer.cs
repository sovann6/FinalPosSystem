namespace POS_System
{
    partial class Loading
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loading));
            this.guna2CircleProgressBar1 = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_value = new System.Windows.Forms.Label();
            this.load = new System.Windows.Forms.Label();
            this.Logo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.guna2CircleProgressBar1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2CircleProgressBar1
            // 
            this.guna2CircleProgressBar1.Controls.Add(this.label3);
            this.guna2CircleProgressBar1.Controls.Add(this.label2);
            this.guna2CircleProgressBar1.Controls.Add(this.label_value);
            this.guna2CircleProgressBar1.Controls.Add(this.load);
            this.guna2CircleProgressBar1.Controls.Add(this.Logo);
            this.guna2CircleProgressBar1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.guna2CircleProgressBar1.FillThickness = 800;
            this.guna2CircleProgressBar1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.guna2CircleProgressBar1.ForeColor = System.Drawing.Color.White;
            this.guna2CircleProgressBar1.Location = new System.Drawing.Point(19, -527);
            this.guna2CircleProgressBar1.Minimum = 0;
            this.guna2CircleProgressBar1.Name = "guna2CircleProgressBar1";
            this.guna2CircleProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(91)))), ((int)(((byte)(204)))));
            this.guna2CircleProgressBar1.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(186)))), ((int)(((byte)(235)))));
            this.guna2CircleProgressBar1.ProgressThickness = 700;
            this.guna2CircleProgressBar1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleProgressBar1.Size = new System.Drawing.Size(1800, 1800);
            this.guna2CircleProgressBar1.TabIndex = 0;
            this.guna2CircleProgressBar1.Text = "guna2CircleProgressBar1";
            this.guna2CircleProgressBar1.Value = 100;
            this.guna2CircleProgressBar1.ValueChanged += new System.EventHandler(this.guna2CircleProgressBar1_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(165, 661);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(453, 65);
            this.label3.TabIndex = 4;
            this.label3.Text = "System is Loading";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(135, 580);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(294, 65);
            this.label2.TabIndex = 3;
            this.label2.Text = "Please wait";
            // 
            // label_value
            // 
            this.label_value.AutoSize = true;
            this.label_value.BackColor = System.Drawing.Color.Transparent;
            this.label_value.Font = new System.Drawing.Font("Segoe UI", 100F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_value.ForeColor = System.Drawing.Color.Fuchsia;
            this.label_value.Location = new System.Drawing.Point(155, 988);
            this.label_value.Name = "label_value";
            this.label_value.Size = new System.Drawing.Size(152, 177);
            this.label_value.TabIndex = 2;
            this.label_value.Text = "0";
            // 
            // load
            // 
            this.load.AutoSize = true;
            this.load.BackColor = System.Drawing.Color.Transparent;
            this.load.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.load.ForeColor = System.Drawing.Color.Black;
            this.load.Location = new System.Drawing.Point(674, 1126);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(102, 28);
            this.load.TabIndex = 1;
            this.load.Text = "Loading...";
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.Color.Transparent;
            this.Logo.FillColor = System.Drawing.Color.Transparent;
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.ImageRotate = 0F;
            this.Logo.Location = new System.Drawing.Point(802, 783);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(197, 224);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 40;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // timer2
            // 
            this.timer2.Interval = 5;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Loading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 708);
            this.Controls.Add(this.guna2CircleProgressBar1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Loading";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loading";
            this.Load += new System.EventHandler(this.Loading_Load);
            this.guna2CircleProgressBar1.ResumeLayout(false);
            this.guna2CircleProgressBar1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CircleProgressBar guna2CircleProgressBar1;
        private Guna.UI2.WinForms.Guna2PictureBox Logo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_value;
        private System.Windows.Forms.Label load;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer2;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
    }
}