﻿namespace Group_2
{
    partial class ProductionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductionForm));
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
            this.Required = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.create = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.invalidEnd = new System.Windows.Forms.Label();
            this.invalid_product = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Aharoni", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ID.Location = new System.Drawing.Point(392, 200);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(40, 28);
            this.ID.TabIndex = 0;
            this.ID.Text = "ID";
            // 
            // createDate
            // 
            this.createDate.AutoSize = true;
            this.createDate.Font = new System.Drawing.Font("Aharoni", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.createDate.Location = new System.Drawing.Point(313, 294);
            this.createDate.Name = "createDate";
            this.createDate.Size = new System.Drawing.Size(168, 28);
            this.createDate.TabIndex = 1;
            this.createDate.Text = "Create Date";
            this.createDate.Click += new System.EventHandler(this.label2_Click);
            // 
            // targetDate
            // 
            this.targetDate.AutoSize = true;
            this.targetDate.Font = new System.Drawing.Font("Aharoni", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.targetDate.Location = new System.Drawing.Point(326, 394);
            this.targetDate.Name = "targetDate";
            this.targetDate.Size = new System.Drawing.Size(165, 28);
            this.targetDate.TabIndex = 2;
            this.targetDate.Text = "Target Date";
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Font = new System.Drawing.Font("Aharoni", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.price.Location = new System.Drawing.Point(378, 472);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(77, 28);
            this.price.TabIndex = 3;
            this.price.Text = "Price";
            // 
            // orderStatus
            // 
            this.orderStatus.AutoSize = true;
            this.orderStatus.Font = new System.Drawing.Font("Aharoni", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.orderStatus.Location = new System.Drawing.Point(326, 551);
            this.orderStatus.Name = "orderStatus";
            this.orderStatus.Size = new System.Drawing.Size(181, 28);
            this.orderStatus.TabIndex = 4;
            this.orderStatus.Text = "Order Status";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(536, 201);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 26);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // crDate
            // 
            this.crDate.CustomFormat = "yyyy-MM-dd";
            this.crDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.crDate.Location = new System.Drawing.Point(536, 295);
            this.crDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.crDate.Name = "crDate";
            this.crDate.Size = new System.Drawing.Size(200, 26);
            this.crDate.TabIndex = 6;
            this.crDate.ValueChanged += new System.EventHandler(this.crDate_ValueChanged);
            // 
            // os
            // 
            this.os.FormattingEnabled = true;
            this.os.Location = new System.Drawing.Point(536, 552);
            this.os.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.os.Name = "os";
            this.os.Size = new System.Drawing.Size(200, 28);
            this.os.TabIndex = 7;
            // 
            // trDate
            // 
            this.trDate.CustomFormat = "yyyy-MM-dd";
            this.trDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.trDate.Location = new System.Drawing.Point(536, 392);
            this.trDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trDate.Name = "trDate";
            this.trDate.Size = new System.Drawing.Size(200, 26);
            this.trDate.TabIndex = 8;
            this.trDate.ValueChanged += new System.EventHandler(this.trDate_ValueChanged);
            // 
            // pr
            // 
            this.pr.Location = new System.Drawing.Point(536, 472);
            this.pr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pr.Name = "pr";
            this.pr.Size = new System.Drawing.Size(200, 26);
            this.pr.TabIndex = 9;
            this.pr.TextChanged += new System.EventHandler(this.pr_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Required,
            this.Product,
            this.Amount});
            this.dataGridView1.Location = new System.Drawing.Point(781, 64);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(501, 419);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Required
            // 
            this.Required.HeaderText = "Required";
            this.Required.MinimumWidth = 8;
            this.Required.Name = "Required";
            this.Required.Width = 150;
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
            // create
            // 
            this.create.Font = new System.Drawing.Font("Aharoni", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.create.Location = new System.Drawing.Point(666, 696);
            this.create.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(225, 62);
            this.create.TabIndex = 11;
            this.create.Text = "Create Form";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Aharoni", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Back.Location = new System.Drawing.Point(30, 728);
            this.Back.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(135, 62);
            this.Back.TabIndex = 12;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // invalidEnd
            // 
            this.invalidEnd.AutoSize = true;
            this.invalidEnd.ForeColor = System.Drawing.Color.Red;
            this.invalidEnd.Location = new System.Drawing.Point(440, 422);
            this.invalidEnd.Name = "invalidEnd";
            this.invalidEnd.Size = new System.Drawing.Size(270, 20);
            this.invalidEnd.TabIndex = 23;
            this.invalidEnd.Text = "target date must be after create date";
            this.invalidEnd.Click += new System.EventHandler(this.invalidEnd_Click);
            // 
            // invalid_product
            // 
            this.invalid_product.AutoSize = true;
            this.invalid_product.ForeColor = System.Drawing.Color.Red;
            this.invalid_product.Location = new System.Drawing.Point(918, 499);
            this.invalid_product.Name = "invalid_product";
            this.invalid_product.Size = new System.Drawing.Size(188, 20);
            this.invalid_product.TabIndex = 29;
            this.invalid_product.Text = "choose at least 1 product";
            this.invalid_product.Click += new System.EventHandler(this.invalid_product_Click);
            // 
            // ProductionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1442, 816);
            this.Controls.Add(this.invalid_product);
            this.Controls.Add(this.invalidEnd);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.create);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ProductionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductionForm";
            this.Load += new System.EventHandler(this.ProductionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Required;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.Label invalidEnd;
        private System.Windows.Forms.Label invalid_product;
    }
}