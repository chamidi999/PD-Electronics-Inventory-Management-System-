namespace new_project
{
    partial class Manage_Order
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CustomersGV = new System.Windows.Forms.DataGridView();
            this.customerid = new System.Windows.Forms.MaskedTextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.ProductsGV = new System.Windows.Forms.DataGridView();
            this.orderdate = new System.Windows.Forms.MaskedTextBox();
            this.SearchCombo = new System.Windows.Forms.ComboBox();
            this.QtyTb = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.OrderGV = new System.Windows.Forms.DataGridView();
            this.Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Products = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UPrices = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrices = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.TotalAmount = new System.Windows.Forms.MaskedTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.orderidTb = new System.Windows.Forms.MaskedTextBox();
            this.home = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1124, 100);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(298, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(540, 41);
            this.label2.TabIndex = 0;
            this.label2.Text = "INVENTORY MANAGEMENT SYSTEM";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(1074, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 41);
            this.label3.TabIndex = 0;
            this.label3.Text = "X";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(137, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 41);
            this.label1.TabIndex = 3;
            this.label1.Text = "CUSTOMER LIST";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CustomersGV
            // 
            this.CustomersGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomersGV.Location = new System.Drawing.Point(39, 176);
            this.CustomersGV.Name = "CustomersGV";
            this.CustomersGV.ReadOnly = true;
            this.CustomersGV.RowHeadersWidth = 51;
            this.CustomersGV.RowTemplate.Height = 24;
            this.CustomersGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CustomersGV.Size = new System.Drawing.Size(457, 209);
            this.CustomersGV.TabIndex = 7;
            this.CustomersGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomersGV_CellContentClick);
            // 
            // customerid
            // 
            this.customerid.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerid.ForeColor = System.Drawing.Color.Olive;
            this.customerid.Location = new System.Drawing.Point(39, 474);
            this.customerid.Name = "customerid";
            this.customerid.Size = new System.Drawing.Size(193, 38);
            this.customerid.TabIndex = 9;
            this.customerid.Text = "Customer ID :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(39, 606);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(248, 22);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // ProductsGV
            // 
            this.ProductsGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsGV.Location = new System.Drawing.Point(593, 176);
            this.ProductsGV.Name = "ProductsGV";
            this.ProductsGV.ReadOnly = true;
            this.ProductsGV.RowHeadersWidth = 51;
            this.ProductsGV.RowTemplate.Height = 24;
            this.ProductsGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductsGV.Size = new System.Drawing.Size(485, 209);
            this.ProductsGV.TabIndex = 11;
            this.ProductsGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductsGV_CellContentClick);
            // 
            // orderdate
            // 
            this.orderdate.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderdate.ForeColor = System.Drawing.Color.Olive;
            this.orderdate.Location = new System.Drawing.Point(39, 540);
            this.orderdate.Name = "orderdate";
            this.orderdate.Size = new System.Drawing.Size(193, 38);
            this.orderdate.TabIndex = 12;
            this.orderdate.Text = "Order Date :";
            // 
            // SearchCombo
            // 
            this.SearchCombo.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.SearchCombo.ForeColor = System.Drawing.Color.Olive;
            this.SearchCombo.FormattingEnabled = true;
            this.SearchCombo.Location = new System.Drawing.Point(669, 123);
            this.SearchCombo.Name = "SearchCombo";
            this.SearchCombo.Size = new System.Drawing.Size(336, 39);
            this.SearchCombo.TabIndex = 13;
            this.SearchCombo.Text = "Product Category";
            this.SearchCombo.SelectedIndexChanged += new System.EventHandler(this.SearchCombo_SelectedIndexChanged);
            // 
            // QtyTb
            // 
            this.QtyTb.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QtyTb.ForeColor = System.Drawing.Color.Olive;
            this.QtyTb.Location = new System.Drawing.Point(793, 417);
            this.QtyTb.Name = "QtyTb";
            this.QtyTb.Size = new System.Drawing.Size(230, 38);
            this.QtyTb.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Azure;
            this.label4.Location = new System.Drawing.Point(597, 417);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 31);
            this.label4.TabIndex = 15;
            this.label4.Text = "Quantity";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(793, 490);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(230, 41);
            this.button1.TabIndex = 16;
            this.button1.Text = "Add To Cart";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // OrderGV
            // 
            this.OrderGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Num,
            this.Products,
            this.Quantity,
            this.UPrices,
            this.TotalPrices});
            this.OrderGV.Location = new System.Drawing.Point(401, 580);
            this.OrderGV.Name = "OrderGV";
            this.OrderGV.ReadOnly = true;
            this.OrderGV.RowHeadersWidth = 51;
            this.OrderGV.RowTemplate.Height = 24;
            this.OrderGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OrderGV.Size = new System.Drawing.Size(677, 198);
            this.OrderGV.TabIndex = 17;
            this.OrderGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrderGV_CellContentClick);
            // 
            // Num
            // 
            this.Num.HeaderText = "Num";
            this.Num.MinimumWidth = 6;
            this.Num.Name = "Num";
            this.Num.ReadOnly = true;
            this.Num.Width = 125;
            // 
            // Products
            // 
            this.Products.HeaderText = "Products";
            this.Products.MinimumWidth = 6;
            this.Products.Name = "Products";
            this.Products.ReadOnly = true;
            this.Products.Width = 125;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Width = 125;
            // 
            // UPrices
            // 
            this.UPrices.HeaderText = "Uprices";
            this.UPrices.MinimumWidth = 6;
            this.UPrices.Name = "UPrices";
            this.UPrices.ReadOnly = true;
            this.UPrices.Width = 125;
            // 
            // TotalPrices
            // 
            this.TotalPrices.HeaderText = "TotalPrices";
            this.TotalPrices.MinimumWidth = 6;
            this.TotalPrices.Name = "TotalPrices";
            this.TotalPrices.ReadOnly = true;
            this.TotalPrices.Width = 125;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Azure;
            this.label5.Location = new System.Drawing.Point(532, 797);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 31);
            this.label5.TabIndex = 18;
            this.label5.Text = "Total Amount :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // TotalAmount
            // 
            this.TotalAmount.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalAmount.ForeColor = System.Drawing.Color.Olive;
            this.TotalAmount.Location = new System.Drawing.Point(775, 797);
            this.TotalAmount.Name = "TotalAmount";
            this.TotalAmount.Size = new System.Drawing.Size(230, 38);
            this.TotalAmount.TabIndex = 19;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gray;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(39, 677);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(230, 41);
            this.button2.TabIndex = 20;
            this.button2.Text = "Insert Order";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Gray;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.Control;
            this.button3.Location = new System.Drawing.Point(39, 737);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(230, 41);
            this.button3.TabIndex = 21;
            this.button3.Text = "View Order";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // orderidTb
            // 
            this.orderidTb.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderidTb.ForeColor = System.Drawing.Color.Olive;
            this.orderidTb.Location = new System.Drawing.Point(264, 474);
            this.orderidTb.Name = "orderidTb";
            this.orderidTb.Size = new System.Drawing.Size(283, 38);
            this.orderidTb.TabIndex = 9;
            this.orderidTb.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.orderidTb_MaskInputRejected);
            // 
            // home
            // 
            this.home.BackColor = System.Drawing.Color.Gray;
            this.home.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.home.Location = new System.Drawing.Point(39, 795);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(230, 33);
            this.home.TabIndex = 24;
            this.home.Text = "Home";
            this.home.UseVisualStyleBackColor = false;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkCyan;
            this.panel2.Location = new System.Drawing.Point(0, 859);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1142, 17);
            this.panel2.TabIndex = 25;
            // 
            // Manage_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1124, 888);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.home);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.TotalAmount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.OrderGV);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.QtyTb);
            this.Controls.Add(this.SearchCombo);
            this.Controls.Add(this.orderdate);
            this.Controls.Add(this.ProductsGV);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.customerid);
            this.Controls.Add(this.orderidTb);
            this.Controls.Add(this.CustomersGV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Manage_Order";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage_Order";
            this.Load += new System.EventHandler(this.Manage_Order_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView CustomersGV;
        private System.Windows.Forms.MaskedTextBox customerid;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView ProductsGV;
        private System.Windows.Forms.MaskedTextBox orderdate;
        private System.Windows.Forms.ComboBox SearchCombo;
        private System.Windows.Forms.MaskedTextBox QtyTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView OrderGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num;
        private System.Windows.Forms.DataGridViewTextBoxColumn Products;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn UPrices;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrices;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox TotalAmount;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.MaskedTextBox orderidTb;
        private System.Windows.Forms.Button home;
        private System.Windows.Forms.Panel panel2;
    }
}