namespace new_project
{
    partial class ManageProduct
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
            this.pqTb = new System.Windows.Forms.MaskedTextBox();
            this.pnameTb = new System.Windows.Forms.MaskedTextBox();
            this.pidTb = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ppTb = new System.Windows.Forms.MaskedTextBox();
            this.pdTb = new System.Windows.Forms.MaskedTextBox();
            this.ProductGV = new System.Windows.Forms.DataGridView();
            this.catcombo = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductGV)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(1142, 100);
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
            this.label3.Location = new System.Drawing.Point(1092, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 41);
            this.label3.TabIndex = 0;
            this.label3.Text = "X";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // pqTb
            // 
            this.pqTb.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pqTb.ForeColor = System.Drawing.Color.Olive;
            this.pqTb.Location = new System.Drawing.Point(47, 337);
            this.pqTb.Name = "pqTb";
            this.pqTb.Size = new System.Drawing.Size(337, 38);
            this.pqTb.TabIndex = 5;
            this.pqTb.Text = "Product Qty : ";
            // 
            // pnameTb
            // 
            this.pnameTb.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnameTb.ForeColor = System.Drawing.Color.Olive;
            this.pnameTb.Location = new System.Drawing.Point(47, 271);
            this.pnameTb.Name = "pnameTb";
            this.pnameTb.Size = new System.Drawing.Size(337, 38);
            this.pnameTb.TabIndex = 6;
            this.pnameTb.Text = "Product Name :";
            // 
            // pidTb
            // 
            this.pidTb.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pidTb.ForeColor = System.Drawing.Color.Olive;
            this.pidTb.Location = new System.Drawing.Point(47, 207);
            this.pidTb.Name = "pidTb";
            this.pidTb.Size = new System.Drawing.Size(337, 38);
            this.pidTb.TabIndex = 7;
            this.pidTb.Text = "Product Id :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(41, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 41);
            this.label1.TabIndex = 8;
            this.label1.Text = "MANAGE PRODUCTS\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ppTb
            // 
            this.ppTb.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ppTb.ForeColor = System.Drawing.Color.Olive;
            this.ppTb.Location = new System.Drawing.Point(47, 407);
            this.ppTb.Name = "ppTb";
            this.ppTb.Size = new System.Drawing.Size(337, 38);
            this.ppTb.TabIndex = 5;
            this.ppTb.Text = "Product Price :";
            // 
            // pdTb
            // 
            this.pdTb.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pdTb.ForeColor = System.Drawing.Color.Olive;
            this.pdTb.Location = new System.Drawing.Point(47, 484);
            this.pdTb.Name = "pdTb";
            this.pdTb.Size = new System.Drawing.Size(337, 38);
            this.pdTb.TabIndex = 5;
            this.pdTb.Text = "Product Discription : ";
            // 
            // ProductGV
            // 
            this.ProductGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductGV.Location = new System.Drawing.Point(477, 196);
            this.ProductGV.Name = "ProductGV";
            this.ProductGV.ReadOnly = true;
            this.ProductGV.RowHeadersWidth = 51;
            this.ProductGV.RowTemplate.Height = 24;
            this.ProductGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductGV.Size = new System.Drawing.Size(642, 317);
            this.ProductGV.TabIndex = 9;
            this.ProductGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductGV_CellContentClick);
            // 
            // catcombo
            // 
            this.catcombo.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.catcombo.ForeColor = System.Drawing.Color.Olive;
            this.catcombo.FormattingEnabled = true;
            this.catcombo.Location = new System.Drawing.Point(48, 552);
            this.catcombo.Name = "catcombo";
            this.catcombo.Size = new System.Drawing.Size(336, 39);
            this.catcombo.TabIndex = 10;
            this.catcombo.Text = "Product Category";
            this.catcombo.SelectedIndexChanged += new System.EventHandler(this.catcombo_SelectedIndexChanged);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Gray;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.Control;
            this.button4.Location = new System.Drawing.Point(135, 805);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(142, 41);
            this.button4.TabIndex = 13;
            this.button4.Text = "Home";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Gray;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.Control;
            this.button3.Location = new System.Drawing.Point(135, 743);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(142, 41);
            this.button3.TabIndex = 14;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gray;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(135, 687);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 41);
            this.button2.TabIndex = 15;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(135, 629);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 41);
            this.button1.TabIndex = 16;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkCyan;
            this.panel2.Location = new System.Drawing.Point(0, 852);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1142, 17);
            this.panel2.TabIndex = 17;
            // 
            // ManageProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1142, 885);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.catcombo);
            this.Controls.Add(this.ProductGV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pdTb);
            this.Controls.Add(this.ppTb);
            this.Controls.Add(this.pqTb);
            this.Controls.Add(this.pnameTb);
            this.Controls.Add(this.pidTb);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageProduct";
            this.Load += new System.EventHandler(this.ManageProduct_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox pqTb;
        private System.Windows.Forms.MaskedTextBox pnameTb;
        private System.Windows.Forms.MaskedTextBox pidTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox ppTb;
        private System.Windows.Forms.MaskedTextBox pdTb;
        private System.Windows.Forms.DataGridView ProductGV;
        private System.Windows.Forms.ComboBox catcombo;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
    }
}