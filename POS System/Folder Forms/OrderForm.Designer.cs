namespace POS_System.Folder_Forms
{
    partial class OrderForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            this.Desplay = new Guna.UI2.WinForms.Guna2DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Product_Card = new POS_System.Sub_Form.Orders_Form.Orders();
            this.orders2 = new POS_System.Sub_Form.Orders_Form.Orders();
            this.orders3 = new POS_System.Sub_Form.Orders_Form.Orders();
            this.orders4 = new POS_System.Sub_Form.Orders_Form.Orders();
            this.orders5 = new POS_System.Sub_Form.Orders_Form.Orders();
            this.orders6 = new POS_System.Sub_Form.Orders_Form.Orders();
            this.orders7 = new POS_System.Sub_Form.Orders_Form.Orders();
            this.orders8 = new POS_System.Sub_Form.Orders_Form.Orders();
            this.orders9 = new POS_System.Sub_Form.Orders_Form.Orders();
            this.orders10 = new POS_System.Sub_Form.Orders_Form.Orders();
            this.orders11 = new POS_System.Sub_Form.Orders_Form.Orders();
            this.orders12 = new POS_System.Sub_Form.Orders_Form.Orders();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.totalssub = new System.Windows.Forms.Label();
            this.taxs = new System.Windows.Forms.Label();
            this.Amounts = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbTPO = new System.Windows.Forms.Label();
            this.ComCat = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnPay = new Guna.UI2.WinForms.Guna2Button();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Desplay)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Desplay
            // 
            this.Desplay.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.Desplay.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Desplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Desplay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Desplay.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Desplay.ColumnHeadersHeight = 50;
            this.Desplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.Desplay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.PName,
            this.Qty,
            this.Price,
            this.Amount,
            this.delete,
            this.Column1,
            this.Column2});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Desplay.DefaultCellStyle = dataGridViewCellStyle3;
            this.Desplay.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Desplay.Location = new System.Drawing.Point(974, 89);
            this.Desplay.Name = "Desplay";
            this.Desplay.RowHeadersVisible = false;
            this.Desplay.Size = new System.Drawing.Size(637, 505);
            this.Desplay.TabIndex = 1;
            this.Desplay.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.Desplay.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.Desplay.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.Desplay.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.Desplay.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.Desplay.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.Desplay.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Desplay.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Desplay.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Desplay.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Desplay.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.Desplay.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.Desplay.ThemeStyle.HeaderStyle.Height = 50;
            this.Desplay.ThemeStyle.ReadOnly = false;
            this.Desplay.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.Desplay.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Desplay.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Desplay.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.Desplay.ThemeStyle.RowsStyle.Height = 22;
            this.Desplay.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Desplay.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.Desplay.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Desplay_CellContentClick);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.Product_Card);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(8, 89);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(960, 898);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // Product_Card
            // 
            this.Product_Card.costPrice = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.Product_Card.Location = new System.Drawing.Point(3, 4);
            this.Product_Card.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Product_Card.Name = "Product_Card";
            this.Product_Card.Product_ID = 0;
            this.Product_Card.Product_Image = ((System.Drawing.Image)(resources.GetObject("Product_Card.Product_Image")));
            this.Product_Card.Product_Name = "Product Name";
            this.Product_Card.Product_Price = "Price";
            this.Product_Card.Size = new System.Drawing.Size(202, 267);
            this.Product_Card.Stock = 0;
            this.Product_Card.TabIndex = 0;
            // 
            // orders2
            // 
            this.orders2.costPrice = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.orders2.Location = new System.Drawing.Point(212, 5);
            this.orders2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.orders2.Name = "orders2";
            this.orders2.Product_ID = 0;
            this.orders2.Product_Image = ((System.Drawing.Image)(resources.GetObject("orders2.Product_Image")));
            this.orders2.Product_Name = "Product Name";
            this.orders2.Product_Price = "Price";
            this.orders2.Size = new System.Drawing.Size(202, 267);
            this.orders2.Stock = 0;
            this.orders2.TabIndex = 1;
            // 
            // orders3
            // 
            this.orders3.costPrice = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.orders3.Location = new System.Drawing.Point(422, 5);
            this.orders3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.orders3.Name = "orders3";
            this.orders3.Product_ID = 0;
            this.orders3.Product_Image = ((System.Drawing.Image)(resources.GetObject("orders3.Product_Image")));
            this.orders3.Product_Name = "Product Name";
            this.orders3.Product_Price = "Price";
            this.orders3.Size = new System.Drawing.Size(202, 267);
            this.orders3.Stock = 0;
            this.orders3.TabIndex = 2;
            // 
            // orders4
            // 
            this.orders4.costPrice = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.orders4.Location = new System.Drawing.Point(632, 5);
            this.orders4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.orders4.Name = "orders4";
            this.orders4.Product_ID = 0;
            this.orders4.Product_Image = ((System.Drawing.Image)(resources.GetObject("orders4.Product_Image")));
            this.orders4.Product_Name = "Product Name";
            this.orders4.Product_Price = "Price";
            this.orders4.Size = new System.Drawing.Size(202, 267);
            this.orders4.Stock = 0;
            this.orders4.TabIndex = 3;
            // 
            // orders5
            // 
            this.orders5.costPrice = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.orders5.Location = new System.Drawing.Point(4, 282);
            this.orders5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.orders5.Name = "orders5";
            this.orders5.Product_ID = 0;
            this.orders5.Product_Image = ((System.Drawing.Image)(resources.GetObject("orders5.Product_Image")));
            this.orders5.Product_Name = "Product Name";
            this.orders5.Product_Price = "Price";
            this.orders5.Size = new System.Drawing.Size(202, 267);
            this.orders5.Stock = 0;
            this.orders5.TabIndex = 4;
            // 
            // orders6
            // 
            this.orders6.costPrice = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.orders6.Location = new System.Drawing.Point(216, 286);
            this.orders6.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.orders6.Name = "orders6";
            this.orders6.Product_ID = 0;
            this.orders6.Product_Image = ((System.Drawing.Image)(resources.GetObject("orders6.Product_Image")));
            this.orders6.Product_Name = "Product Name";
            this.orders6.Product_Price = "Price";
            this.orders6.Size = new System.Drawing.Size(202, 267);
            this.orders6.Stock = 0;
            this.orders6.TabIndex = 5;
            // 
            // orders7
            // 
            this.orders7.costPrice = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.orders7.Location = new System.Drawing.Point(430, 286);
            this.orders7.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.orders7.Name = "orders7";
            this.orders7.Product_ID = 0;
            this.orders7.Product_Image = ((System.Drawing.Image)(resources.GetObject("orders7.Product_Image")));
            this.orders7.Product_Name = "Product Name";
            this.orders7.Product_Price = "Price";
            this.orders7.Size = new System.Drawing.Size(202, 267);
            this.orders7.Stock = 0;
            this.orders7.TabIndex = 6;
            // 
            // orders8
            // 
            this.orders8.costPrice = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.orders8.Location = new System.Drawing.Point(644, 286);
            this.orders8.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.orders8.Name = "orders8";
            this.orders8.Product_ID = 0;
            this.orders8.Product_Image = ((System.Drawing.Image)(resources.GetObject("orders8.Product_Image")));
            this.orders8.Product_Name = "Product Name";
            this.orders8.Product_Price = "Price";
            this.orders8.Size = new System.Drawing.Size(202, 267);
            this.orders8.Stock = 0;
            this.orders8.TabIndex = 7;
            // 
            // orders9
            // 
            this.orders9.costPrice = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.orders9.Location = new System.Drawing.Point(4, 567);
            this.orders9.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.orders9.Name = "orders9";
            this.orders9.Product_ID = 0;
            this.orders9.Product_Image = ((System.Drawing.Image)(resources.GetObject("orders9.Product_Image")));
            this.orders9.Product_Name = "Product Name";
            this.orders9.Product_Price = "Price";
            this.orders9.Size = new System.Drawing.Size(202, 267);
            this.orders9.Stock = 0;
            this.orders9.TabIndex = 8;
            // 
            // orders10
            // 
            this.orders10.costPrice = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.orders10.Location = new System.Drawing.Point(214, 567);
            this.orders10.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.orders10.Name = "orders10";
            this.orders10.Product_ID = 0;
            this.orders10.Product_Image = ((System.Drawing.Image)(resources.GetObject("orders10.Product_Image")));
            this.orders10.Product_Name = "Product Name";
            this.orders10.Product_Price = "Price";
            this.orders10.Size = new System.Drawing.Size(202, 267);
            this.orders10.Stock = 0;
            this.orders10.TabIndex = 9;
            // 
            // orders11
            // 
            this.orders11.costPrice = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.orders11.Location = new System.Drawing.Point(424, 567);
            this.orders11.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.orders11.Name = "orders11";
            this.orders11.Product_ID = 0;
            this.orders11.Product_Image = ((System.Drawing.Image)(resources.GetObject("orders11.Product_Image")));
            this.orders11.Product_Name = "Product Name";
            this.orders11.Product_Price = "Price";
            this.orders11.Size = new System.Drawing.Size(202, 267);
            this.orders11.Stock = 0;
            this.orders11.TabIndex = 10;
            // 
            // orders12
            // 
            this.orders12.costPrice = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.orders12.Location = new System.Drawing.Point(634, 567);
            this.orders12.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.orders12.Name = "orders12";
            this.orders12.Product_ID = 0;
            this.orders12.Product_Image = ((System.Drawing.Image)(resources.GetObject("orders12.Product_Image")));
            this.orders12.Product_Name = "Product Name";
            this.orders12.Product_Price = "Price";
            this.orders12.Size = new System.Drawing.Size(202, 267);
            this.orders12.Stock = 0;
            this.orders12.TabIndex = 11;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderRadius = 20;
            this.guna2Panel1.Controls.Add(this.totalssub);
            this.guna2Panel1.Controls.Add(this.taxs);
            this.guna2Panel1.Controls.Add(this.Amounts);
            this.guna2Panel1.Controls.Add(this.label4);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.FillColor = System.Drawing.Color.Cornsilk;
            this.guna2Panel1.Location = new System.Drawing.Point(974, 612);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(637, 204);
            this.guna2Panel1.TabIndex = 5;
            // 
            // totalssub
            // 
            this.totalssub.AutoSize = true;
            this.totalssub.Location = new System.Drawing.Point(449, 31);
            this.totalssub.Name = "totalssub";
            this.totalssub.Size = new System.Drawing.Size(49, 23);
            this.totalssub.TabIndex = 5;
            this.totalssub.Text = "$0.00";
            // 
            // taxs
            // 
            this.taxs.AutoSize = true;
            this.taxs.Location = new System.Drawing.Point(449, 79);
            this.taxs.Name = "taxs";
            this.taxs.Size = new System.Drawing.Size(49, 23);
            this.taxs.TabIndex = 4;
            this.taxs.Text = "$0.00";
            // 
            // Amounts
            // 
            this.Amounts.AutoSize = true;
            this.Amounts.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Amounts.Location = new System.Drawing.Point(447, 136);
            this.Amounts.Name = "Amounts";
            this.Amounts.Size = new System.Drawing.Size(61, 33);
            this.Amounts.TabIndex = 3;
            this.Amounts.Text = "$0.00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(46, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 33);
            this.label4.TabIndex = 2;
            this.label4.Text = "Totals Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tax (10%)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sub totals :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(967, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(287, 39);
            this.label5.TabIndex = 6;
            this.label5.Text = "Totals Product Orders";
            // 
            // lbTPO
            // 
            this.lbTPO.AutoSize = true;
            this.lbTPO.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTPO.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbTPO.Location = new System.Drawing.Point(1288, 21);
            this.lbTPO.Name = "lbTPO";
            this.lbTPO.Size = new System.Drawing.Size(38, 45);
            this.lbTPO.TabIndex = 7;
            this.lbTPO.Text = "0";
            // 
            // ComCat
            // 
            this.ComCat.BackColor = System.Drawing.Color.Transparent;
            this.ComCat.BorderRadius = 10;
            this.ComCat.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComCat.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComCat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComCat.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComCat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ComCat.ItemHeight = 35;
            this.ComCat.Location = new System.Drawing.Point(12, 42);
            this.ComCat.Name = "ComCat";
            this.ComCat.Size = new System.Drawing.Size(254, 41);
            this.ComCat.TabIndex = 8;
            this.ComCat.SelectedIndexChanged += new System.EventHandler(this.ComCat_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 29);
            this.label6.TabIndex = 9;
            this.label6.Text = "Sort By Category";
            // 
            // btnPay
            // 
            this.btnPay.Animated = true;
            this.btnPay.BackColor = System.Drawing.Color.Transparent;
            this.btnPay.BorderRadius = 10;
            this.btnPay.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPay.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPay.FillColor = System.Drawing.Color.Blue;
            this.btnPay.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnPay.ForeColor = System.Drawing.Color.White;
            this.btnPay.Location = new System.Drawing.Point(1405, 928);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(180, 45);
            this.btnPay.TabIndex = 10;
            this.btnPay.Text = "PAY NOW";
            this.btnPay.UseTransparentBackground = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // No
            // 
            this.No.HeaderText = "No.";
            this.No.Name = "No";
            // 
            // PName
            // 
            this.PName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PName.HeaderText = "Product Name";
            this.PName.Name = "PName";
            // 
            // Qty
            // 
            this.Qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Qty.HeaderText = "Quantity";
            this.Qty.Name = "Qty";
            this.Qty.Width = 80;
            // 
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            // 
            // Amount
            // 
            this.Amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            // 
            // delete
            // 
            this.delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.delete.HeaderText = "";
            this.delete.Image = ((System.Drawing.Image)(resources.GetObject("delete.Image")));
            this.delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.delete.Name = "delete";
            this.delete.Width = 30;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            this.Column1.Width = 5;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column2.HeaderText = "";
            this.Column2.Name = "Column2";
            this.Column2.Width = 5;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1623, 999);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ComCat);
            this.Controls.Add(this.lbTPO);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.Desplay);
            this.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderForm";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Desplay)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2DataGridView Desplay;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Sub_Form.Orders_Form.Orders Product_Card;
        private Sub_Form.Orders_Form.Orders orders2;
        private Sub_Form.Orders_Form.Orders orders3;
        private Sub_Form.Orders_Form.Orders orders4;
        private Sub_Form.Orders_Form.Orders orders5;
        private Sub_Form.Orders_Form.Orders orders6;
        private Sub_Form.Orders_Form.Orders orders7;
        private Sub_Form.Orders_Form.Orders orders8;
        private Sub_Form.Orders_Form.Orders orders9;
        private Sub_Form.Orders_Form.Orders orders10;
        private Sub_Form.Orders_Form.Orders orders11;
        private Sub_Form.Orders_Form.Orders orders12;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label totalssub;
        private System.Windows.Forms.Label taxs;
        private System.Windows.Forms.Label Amounts;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbTPO;
        private Guna.UI2.WinForms.Guna2ComboBox ComCat;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Button btnPay;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn PName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewImageColumn delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}