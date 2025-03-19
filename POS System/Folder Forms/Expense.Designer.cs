namespace POS_System.Folder_Forms
{
    partial class Expense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Expense));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ComboSort = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.s = new System.Windows.Forms.Label();
            this.StartDate = new Guna.UI.WinForms.GunaDateTimePicker();
            this.btnaddExpanse = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.EndDate = new Guna.UI.WinForms.GunaDateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.DataExpanse = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataExpanse)).BeginInit();
            this.SuspendLayout();
            // 
            // ComboSort
            // 
            this.ComboSort.BackColor = System.Drawing.Color.Transparent;
            this.ComboSort.BorderRadius = 10;
            this.ComboSort.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboSort.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboSort.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboSort.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 18F, System.Drawing.FontStyle.Bold);
            this.ComboSort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ComboSort.ItemHeight = 45;
            this.ComboSort.Items.AddRange(new object[] {
            "Hight Expanse",
            "Low Expanse"});
            this.ComboSort.Location = new System.Drawing.Point(12, 47);
            this.ComboSort.Name = "ComboSort";
            this.ComboSort.Size = new System.Drawing.Size(378, 51);
            this.ComboSort.TabIndex = 1;
            this.ComboSort.SelectedIndexChanged += new System.EventHandler(this.ComboSort_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sort by Hight and Low Expanse";
            // 
            // s
            // 
            this.s.AutoSize = true;
            this.s.BackColor = System.Drawing.Color.Transparent;
            this.s.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.s.ForeColor = System.Drawing.Color.Black;
            this.s.Location = new System.Drawing.Point(489, 15);
            this.s.Name = "s";
            this.s.Size = new System.Drawing.Size(93, 29);
            this.s.TabIndex = 3;
            this.s.Text = "Start Date";
            // 
            // StartDate
            // 
            this.StartDate.BackColor = System.Drawing.Color.Transparent;
            this.StartDate.BaseColor = System.Drawing.Color.White;
            this.StartDate.BorderColor = System.Drawing.Color.Silver;
            this.StartDate.BorderSize = 0;
            this.StartDate.CustomFormat = null;
            this.StartDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.StartDate.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.StartDate.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartDate.ForeColor = System.Drawing.Color.Black;
            this.StartDate.Location = new System.Drawing.Point(495, 47);
            this.StartDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.StartDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.StartDate.Name = "StartDate";
            this.StartDate.OnHoverBaseColor = System.Drawing.Color.White;
            this.StartDate.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.StartDate.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.StartDate.OnPressedColor = System.Drawing.Color.Black;
            this.StartDate.Padding = new System.Windows.Forms.Padding(5);
            this.StartDate.Radius = 10;
            this.StartDate.Size = new System.Drawing.Size(274, 51);
            this.StartDate.TabIndex = 4;
            this.StartDate.Text = "Saturday, March 1, 2025";
            this.StartDate.Value = new System.DateTime(2025, 3, 1, 13, 26, 46, 477);
            this.StartDate.ValueChanged += new System.EventHandler(this.StartDate_ValueChanged);
            // 
            // btnaddExpanse
            // 
            this.btnaddExpanse.AllowAnimations = true;
            this.btnaddExpanse.AllowMouseEffects = true;
            this.btnaddExpanse.AllowToggling = true;
            this.btnaddExpanse.AnimationSpeed = 200;
            this.btnaddExpanse.AutoGenerateColors = false;
            this.btnaddExpanse.AutoRoundBorders = false;
            this.btnaddExpanse.AutoSizeLeftIcon = true;
            this.btnaddExpanse.AutoSizeRightIcon = true;
            this.btnaddExpanse.BackColor = System.Drawing.Color.Transparent;
            this.btnaddExpanse.BackColor1 = System.Drawing.Color.Blue;
            this.btnaddExpanse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnaddExpanse.BackgroundImage")));
            this.btnaddExpanse.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnaddExpanse.ButtonText = "Add Expanse";
            this.btnaddExpanse.ButtonTextMarginLeft = 0;
            this.btnaddExpanse.ColorContrastOnClick = 45;
            this.btnaddExpanse.ColorContrastOnHover = 45;
            this.btnaddExpanse.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnaddExpanse.CustomizableEdges = borderEdges1;
            this.btnaddExpanse.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnaddExpanse.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnaddExpanse.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnaddExpanse.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnaddExpanse.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnaddExpanse.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddExpanse.ForeColor = System.Drawing.Color.White;
            this.btnaddExpanse.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnaddExpanse.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnaddExpanse.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnaddExpanse.IconMarginLeft = 11;
            this.btnaddExpanse.IconPadding = 10;
            this.btnaddExpanse.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnaddExpanse.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnaddExpanse.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnaddExpanse.IconSize = 25;
            this.btnaddExpanse.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnaddExpanse.IdleBorderRadius = 10;
            this.btnaddExpanse.IdleBorderThickness = 1;
            this.btnaddExpanse.IdleFillColor = System.Drawing.Color.Blue;
            this.btnaddExpanse.IdleIconLeftImage = null;
            this.btnaddExpanse.IdleIconRightImage = null;
            this.btnaddExpanse.IndicateFocus = true;
            this.btnaddExpanse.Location = new System.Drawing.Point(1431, 47);
            this.btnaddExpanse.Name = "btnaddExpanse";
            this.btnaddExpanse.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnaddExpanse.OnDisabledState.BorderRadius = 10;
            this.btnaddExpanse.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnaddExpanse.OnDisabledState.BorderThickness = 1;
            this.btnaddExpanse.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnaddExpanse.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnaddExpanse.OnDisabledState.IconLeftImage = null;
            this.btnaddExpanse.OnDisabledState.IconRightImage = null;
            this.btnaddExpanse.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnaddExpanse.onHoverState.BorderRadius = 10;
            this.btnaddExpanse.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnaddExpanse.onHoverState.BorderThickness = 1;
            this.btnaddExpanse.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnaddExpanse.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnaddExpanse.onHoverState.IconLeftImage = null;
            this.btnaddExpanse.onHoverState.IconRightImage = null;
            this.btnaddExpanse.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnaddExpanse.OnIdleState.BorderRadius = 10;
            this.btnaddExpanse.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnaddExpanse.OnIdleState.BorderThickness = 1;
            this.btnaddExpanse.OnIdleState.FillColor = System.Drawing.Color.Blue;
            this.btnaddExpanse.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnaddExpanse.OnIdleState.IconLeftImage = null;
            this.btnaddExpanse.OnIdleState.IconRightImage = null;
            this.btnaddExpanse.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnaddExpanse.OnPressedState.BorderRadius = 10;
            this.btnaddExpanse.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnaddExpanse.OnPressedState.BorderThickness = 1;
            this.btnaddExpanse.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnaddExpanse.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnaddExpanse.OnPressedState.IconLeftImage = null;
            this.btnaddExpanse.OnPressedState.IconRightImage = null;
            this.btnaddExpanse.Size = new System.Drawing.Size(180, 51);
            this.btnaddExpanse.TabIndex = 5;
            this.btnaddExpanse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnaddExpanse.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnaddExpanse.TextMarginLeft = 0;
            this.btnaddExpanse.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnaddExpanse.UseDefaultRadiusAndThickness = true;
            this.btnaddExpanse.Click += new System.EventHandler(this.btnaddExpanse_Click);
            // 
            // EndDate
            // 
            this.EndDate.BackColor = System.Drawing.Color.Transparent;
            this.EndDate.BaseColor = System.Drawing.Color.White;
            this.EndDate.BorderColor = System.Drawing.Color.Silver;
            this.EndDate.BorderSize = 0;
            this.EndDate.CustomFormat = null;
            this.EndDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.EndDate.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.EndDate.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndDate.ForeColor = System.Drawing.Color.Black;
            this.EndDate.Location = new System.Drawing.Point(792, 47);
            this.EndDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.EndDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.EndDate.Name = "EndDate";
            this.EndDate.OnHoverBaseColor = System.Drawing.Color.White;
            this.EndDate.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.EndDate.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.EndDate.OnPressedColor = System.Drawing.Color.Black;
            this.EndDate.Padding = new System.Windows.Forms.Padding(5);
            this.EndDate.Radius = 10;
            this.EndDate.Size = new System.Drawing.Size(274, 51);
            this.EndDate.TabIndex = 7;
            this.EndDate.Text = "Saturday, March 1, 2025";
            this.EndDate.Value = new System.DateTime(2025, 3, 1, 13, 26, 46, 477);
            this.EndDate.ValueChanged += new System.EventHandler(this.EndDate_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(786, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "End Date";
            // 
            // DataExpanse
            // 
            this.DataExpanse.AllowUserToAddRows = false;
            this.DataExpanse.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DataExpanse.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataExpanse.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataExpanse.ColumnHeadersHeight = 50;
            this.DataExpanse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column6});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataExpanse.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataExpanse.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataExpanse.Location = new System.Drawing.Point(12, 148);
            this.DataExpanse.Name = "DataExpanse";
            this.DataExpanse.RowHeadersVisible = false;
            this.DataExpanse.Size = new System.Drawing.Size(1599, 839);
            this.DataExpanse.TabIndex = 9;
            this.DataExpanse.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataExpanse.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataExpanse.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataExpanse.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataExpanse.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataExpanse.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DataExpanse.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataExpanse.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataExpanse.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataExpanse.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataExpanse.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataExpanse.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataExpanse.ThemeStyle.HeaderStyle.Height = 50;
            this.DataExpanse.ThemeStyle.ReadOnly = false;
            this.DataExpanse.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataExpanse.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataExpanse.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataExpanse.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataExpanse.ThemeStyle.RowsStyle.Height = 22;
            this.DataExpanse.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataExpanse.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.HeaderText = "Expanse ID";
            this.Column1.Name = "Column1";
            this.Column1.Width = 200;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Description";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column3.HeaderText = "Amount";
            this.Column3.Name = "Column3";
            this.Column3.Width = 300;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column4.HeaderText = "Expanse Date";
            this.Column4.Name = "Column4";
            this.Column4.Width = 350;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column6.HeaderText = "EmpID";
            this.Column6.Name = "Column6";
            // 
            // Expense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1623, 999);
            this.Controls.Add(this.DataExpanse);
            this.Controls.Add(this.EndDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnaddExpanse);
            this.Controls.Add(this.StartDate);
            this.Controls.Add(this.s);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ComboSort);
            this.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Gray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Expense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Expense";
            this.Load += new System.EventHandler(this.Expense_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataExpanse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ComboBox ComboSort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label s;
        private Guna.UI.WinForms.GunaDateTimePicker StartDate;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnaddExpanse;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI.WinForms.GunaDateTimePicker EndDate;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DataGridView DataExpanse;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}