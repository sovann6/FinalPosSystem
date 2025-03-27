namespace POS_System.Folder_Forms
{
    partial class Payments
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.Data = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbSubtotals = new System.Windows.Forms.Label();
            this.DisAmount = new System.Windows.Forms.Label();
            this.LbTax = new System.Windows.Forms.Label();
            this.lbTotalsPay = new System.Windows.Forms.Label();
            this.lbReturn = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.EmpID = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.Role = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtCashReceived = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnPayment = new Guna.UI2.WinForms.Guna2Button();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.lbRole = new System.Windows.Forms.Label();
            this.lbempID = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ComboDis = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Data)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(594, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item :";
            // 
            // Data
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.Data.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Data.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Data.ColumnHeadersHeight = 32;
            this.Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.Data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column3});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Data.DefaultCellStyle = dataGridViewCellStyle3;
            this.Data.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Data.Location = new System.Drawing.Point(601, 73);
            this.Data.Name = "Data";
            this.Data.RowHeadersVisible = false;
            this.Data.RowTemplate.Height = 35;
            this.Data.Size = new System.Drawing.Size(558, 261);
            this.Data.TabIndex = 1;
            this.Data.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.Data.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.Data.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.Data.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.Data.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.Data.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.Data.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Data.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Data.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Data.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Data.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.Data.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.Data.ThemeStyle.HeaderStyle.Height = 32;
            this.Data.ThemeStyle.ReadOnly = false;
            this.Data.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.Data.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Data.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Data.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.Data.ThemeStyle.RowsStyle.Height = 35;
            this.Data.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Data.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.HeaderText = "Qauntity";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Product Name";
            this.Column2.Name = "Column2";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column4.HeaderText = "Unit";
            this.Column4.Name = "Column4";
            this.Column4.Width = 120;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column3.HeaderText = "Amount";
            this.Column3.Name = "Column3";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gunaControlBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1162, 40);
            this.panel1.TabIndex = 2;
            // 
            // gunaControlBox1
            // 
            this.gunaControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox1.AnimationSpeed = 0.03F;
            this.gunaControlBox1.IconColor = System.Drawing.Color.Black;
            this.gunaControlBox1.IconSize = 15F;
            this.gunaControlBox1.Location = new System.Drawing.Point(1117, 3);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox1.Size = new System.Drawing.Size(45, 29);
            this.gunaControlBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(2, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "Pay Transcastions";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(594, 337);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 37);
            this.label3.TabIndex = 3;
            this.label3.Text = "Payments :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(603, 378);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 30);
            this.label4.TabIndex = 4;
            this.label4.Text = "Subtotals :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 393);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 30);
            this.label5.TabIndex = 5;
            this.label5.Text = "Discount Value :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(603, 471);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(199, 30);
            this.label6.TabIndex = 6;
            this.label6.Text = "Discount Amount :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(603, 520);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 30);
            this.label7.TabIndex = 7;
            this.label7.Text = "Totals Pay :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(603, 422);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 30);
            this.label8.TabIndex = 8;
            this.label8.Text = "Tax (10%) :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(604, 575);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 30);
            this.label9.TabIndex = 9;
            this.label9.Text = "Cash Return :";
            // 
            // lbSubtotals
            // 
            this.lbSubtotals.AutoSize = true;
            this.lbSubtotals.Location = new System.Drawing.Point(983, 378);
            this.lbSubtotals.Name = "lbSubtotals";
            this.lbSubtotals.Size = new System.Drawing.Size(55, 30);
            this.lbSubtotals.TabIndex = 11;
            this.lbSubtotals.Text = "0.00";
            // 
            // DisAmount
            // 
            this.DisAmount.AutoSize = true;
            this.DisAmount.Location = new System.Drawing.Point(983, 471);
            this.DisAmount.Name = "DisAmount";
            this.DisAmount.Size = new System.Drawing.Size(55, 30);
            this.DisAmount.TabIndex = 13;
            this.DisAmount.Text = "0.00";
            // 
            // LbTax
            // 
            this.LbTax.AutoSize = true;
            this.LbTax.Location = new System.Drawing.Point(983, 422);
            this.LbTax.Name = "LbTax";
            this.LbTax.Size = new System.Drawing.Size(55, 30);
            this.LbTax.TabIndex = 14;
            this.LbTax.Text = "0.00";
            // 
            // lbTotalsPay
            // 
            this.lbTotalsPay.AutoSize = true;
            this.lbTotalsPay.Location = new System.Drawing.Point(987, 520);
            this.lbTotalsPay.Name = "lbTotalsPay";
            this.lbTotalsPay.Size = new System.Drawing.Size(55, 30);
            this.lbTotalsPay.TabIndex = 15;
            this.lbTotalsPay.Text = "0.00";
            // 
            // lbReturn
            // 
            this.lbReturn.AutoSize = true;
            this.lbReturn.Location = new System.Drawing.Point(987, 575);
            this.lbReturn.Name = "lbReturn";
            this.lbReturn.Size = new System.Drawing.Size(55, 30);
            this.lbReturn.TabIndex = 17;
            this.lbReturn.Text = "0.00";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Gray;
            this.label11.Location = new System.Drawing.Point(0, 73);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(303, 45);
            this.label11.TabIndex = 18;
            this.label11.Text = "Transcation Details";
            // 
            // EmpID
            // 
            this.EmpID.AutoSize = true;
            this.EmpID.Location = new System.Drawing.Point(3, 145);
            this.EmpID.Name = "EmpID";
            this.EmpID.Size = new System.Drawing.Size(148, 30);
            this.EmpID.TabIndex = 19;
            this.EmpID.Text = "Employee ID :";
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Location = new System.Drawing.Point(3, 347);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(73, 30);
            this.Time.TabIndex = 20;
            this.Time.Text = "Time :";
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Location = new System.Drawing.Point(2, 280);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(70, 30);
            this.Date.TabIndex = 21;
            this.Date.Text = "Date :";
            // 
            // Role
            // 
            this.Role.AutoSize = true;
            this.Role.Location = new System.Drawing.Point(3, 210);
            this.Role.Name = "Role";
            this.Role.Size = new System.Drawing.Size(77, 30);
            this.Role.TabIndex = 22;
            this.Role.Text = "Roles :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(4, 480);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(163, 30);
            this.label16.TabIndex = 24;
            this.label16.Text = "Cash Received :";
            // 
            // txtCashReceived
            // 
            this.txtCashReceived.Animated = true;
            this.txtCashReceived.BorderRadius = 10;
            this.txtCashReceived.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCashReceived.DefaultText = "";
            this.txtCashReceived.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCashReceived.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCashReceived.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCashReceived.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCashReceived.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCashReceived.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtCashReceived.ForeColor = System.Drawing.Color.Gray;
            this.txtCashReceived.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCashReceived.Location = new System.Drawing.Point(7, 520);
            this.txtCashReceived.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtCashReceived.Name = "txtCashReceived";
            this.txtCashReceived.PasswordChar = '\0';
            this.txtCashReceived.PlaceholderText = "Cash Received";
            this.txtCashReceived.SelectedText = "";
            this.txtCashReceived.Size = new System.Drawing.Size(300, 40);
            this.txtCashReceived.TabIndex = 25;
            this.txtCashReceived.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCashReceived_KeyUp);
            // 
            // guna2TextBox2
            // 
            this.guna2TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox2.DefaultText = "";
            this.guna2TextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.Location = new System.Drawing.Point(306, 785);
            this.guna2TextBox2.Margin = new System.Windows.Forms.Padding(5);
            this.guna2TextBox2.Name = "guna2TextBox2";
            this.guna2TextBox2.PasswordChar = '\0';
            this.guna2TextBox2.PlaceholderText = "Cash Return";
            this.guna2TextBox2.SelectedText = "";
            this.guna2TextBox2.Size = new System.Drawing.Size(470, 60);
            this.guna2TextBox2.TabIndex = 26;
            // 
            // btnPayment
            // 
            this.btnPayment.Animated = true;
            this.btnPayment.BorderRadius = 10;
            this.btnPayment.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPayment.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPayment.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPayment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPayment.FillColor = System.Drawing.Color.Blue;
            this.btnPayment.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.ForeColor = System.Drawing.Color.White;
            this.btnPayment.Location = new System.Drawing.Point(12, 575);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(194, 45);
            this.btnPayment.TabIndex = 27;
            this.btnPayment.Text = "Payment";
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Location = new System.Drawing.Point(179, 280);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(70, 30);
            this.lbDate.TabIndex = 29;
            this.lbDate.Text = "Date :";
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Location = new System.Drawing.Point(179, 347);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(73, 30);
            this.lbTime.TabIndex = 30;
            this.lbTime.Text = "Time :";
            // 
            // lbRole
            // 
            this.lbRole.AutoSize = true;
            this.lbRole.Location = new System.Drawing.Point(179, 210);
            this.lbRole.Name = "lbRole";
            this.lbRole.Size = new System.Drawing.Size(77, 30);
            this.lbRole.TabIndex = 31;
            this.lbRole.Text = "Roles :";
            // 
            // lbempID
            // 
            this.lbempID.AutoSize = true;
            this.lbempID.Location = new System.Drawing.Point(179, 145);
            this.lbempID.Name = "lbempID";
            this.lbempID.Size = new System.Drawing.Size(148, 30);
            this.lbempID.TabIndex = 32;
            this.lbempID.Text = "Employee ID :";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ComboDis
            // 
            this.ComboDis.BackColor = System.Drawing.Color.Transparent;
            this.ComboDis.BorderRadius = 10;
            this.ComboDis.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboDis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboDis.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboDis.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboDis.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.ComboDis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ComboDis.ItemHeight = 35;
            this.ComboDis.Items.AddRange(new object[] {
            "0%",
            "5%",
            "10%",
            "15%",
            "20%"});
            this.ComboDis.Location = new System.Drawing.Point(7, 426);
            this.ComboDis.Name = "ComboDis";
            this.ComboDis.Size = new System.Drawing.Size(295, 41);
            this.ComboDis.TabIndex = 37;
            this.ComboDis.SelectedIndexChanged += new System.EventHandler(this.ComboDis_SelectedIndexChanged);
            // 
            // Payments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1162, 683);
            this.Controls.Add(this.ComboDis);
            this.Controls.Add(this.lbempID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DisAmount);
            this.Controls.Add(this.lbRole);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.btnPayment);
            this.Controls.Add(this.guna2TextBox2);
            this.Controls.Add(this.txtCashReceived);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.Role);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.EmpID);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lbReturn);
            this.Controls.Add(this.lbTotalsPay);
            this.Controls.Add(this.LbTax);
            this.Controls.Add(this.lbSubtotals);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Data);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "Payments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "`";
            this.Load += new System.EventHandler(this.Payments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Data)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView Data;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbSubtotals;
        private System.Windows.Forms.Label DisAmount;
        private System.Windows.Forms.Label LbTax;
        private System.Windows.Forms.Label lbTotalsPay;
        private System.Windows.Forms.Label lbReturn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label EmpID;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Label Role;
        private System.Windows.Forms.Label label16;
        private Guna.UI2.WinForms.Guna2TextBox txtCashReceived;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox2;
        private Guna.UI2.WinForms.Guna2Button btnPayment;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label lbRole;
        private System.Windows.Forms.Label lbempID;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private Guna.UI2.WinForms.Guna2ComboBox ComboDis;
    }
}