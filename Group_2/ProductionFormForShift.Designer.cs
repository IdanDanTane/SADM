﻿namespace Group_2
{
    partial class ProductionFormForShift
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
            this.ID = new System.Windows.Forms.Label();
            this.createDate = new System.Windows.Forms.Label();
            this.targetDate = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.orderStatus = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.crDate = new System.Windows.Forms.DateTimePicker();
            this.os = new System.Windows.Forms.ComboBox();
            this.trDate = new System.Windows.Forms.DateTimePicker();
            this.pr = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Back = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(38, 48);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(26, 20);
            this.ID.TabIndex = 0;
            this.ID.Text = "ID";
            // 
            // createDate
            // 
            this.createDate.AutoSize = true;
            this.createDate.Location = new System.Drawing.Point(38, 105);
            this.createDate.Name = "createDate";
            this.createDate.Size = new System.Drawing.Size(96, 20);
            this.createDate.TabIndex = 1;
            this.createDate.Text = "Create Date";
            this.createDate.Click += new System.EventHandler(this.label2_Click);
            // 
            // targetDate
            // 
            this.targetDate.AutoSize = true;
            this.targetDate.Location = new System.Drawing.Point(40, 151);
            this.targetDate.Name = "targetDate";
            this.targetDate.Size = new System.Drawing.Size(94, 20);
            this.targetDate.TabIndex = 2;
            this.targetDate.Text = "Target Date";
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Location = new System.Drawing.Point(38, 194);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(44, 20);
            this.price.TabIndex = 3;
            this.price.Text = "Price";
            // 
            // orderStatus
            // 
            this.orderStatus.AutoSize = true;
            this.orderStatus.Location = new System.Drawing.Point(38, 235);
            this.orderStatus.Name = "orderStatus";
            this.orderStatus.Size = new System.Drawing.Size(100, 20);
            this.orderStatus.TabIndex = 4;
            this.orderStatus.Text = "Order Status";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(154, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // crDate
            // 
            this.crDate.Location = new System.Drawing.Point(154, 105);
            this.crDate.Name = "crDate";
            this.crDate.Size = new System.Drawing.Size(200, 26);
            this.crDate.TabIndex = 6;
            // 
            // os
            // 
            this.os.FormattingEnabled = true;
            this.os.Location = new System.Drawing.Point(154, 235);
            this.os.Name = "os";
            this.os.Size = new System.Drawing.Size(121, 28);
            this.os.TabIndex = 7;
            // 
            // trDate
            // 
            this.trDate.Location = new System.Drawing.Point(154, 151);
            this.trDate.Name = "trDate";
            this.trDate.Size = new System.Drawing.Size(200, 26);
            this.trDate.TabIndex = 8;
            // 
            // pr
            // 
            this.pr.Location = new System.Drawing.Point(154, 191);
            this.pr.Name = "pr";
            this.pr.Size = new System.Drawing.Size(100, 26);
            this.pr.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Product,
            this.Amount});
            this.dataGridView1.Location = new System.Drawing.Point(374, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(404, 198);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(42, 414);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(104, 61);
            this.Back.TabIndex = 12;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dataGridView2.Location = new System.Drawing.Point(374, 277);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(404, 198);
            this.dataGridView2.TabIndex = 13;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(381, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Materials Needed for product:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(370, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Products Included :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(213, 414);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 61);
            this.button1.TabIndex = 16;
            this.button1.Text = "search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(605, 240);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 17;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Product
            // 
            this.Product.HeaderText = "Product ID";
            this.Product.MinimumWidth = 8;
            this.Product.Name = "Product";
            this.Product.Width = 150;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.MinimumWidth = 8;
            this.Amount.Name = "Amount";
            this.Amount.Width = 150;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Material ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Amount";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // ProductionFormForShift
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 501);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pr);
            this.Controls.Add(this.trDate);
            this.Controls.Add(this.os);
            this.Controls.Add(this.crDate);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.orderStatus);
            this.Controls.Add(this.price);
            this.Controls.Add(this.targetDate);
            this.Controls.Add(this.createDate);
            this.Controls.Add(this.ID);
            this.Name = "ProductionFormForShift";
            this.Text = "ProductionForm";
            this.Load += new System.EventHandler(this.ProductionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label createDate;
        private System.Windows.Forms.Label targetDate;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label orderStatus;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker crDate;
        private System.Windows.Forms.ComboBox os;
        private System.Windows.Forms.DateTimePicker trDate;
        private System.Windows.Forms.TextBox pr;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}