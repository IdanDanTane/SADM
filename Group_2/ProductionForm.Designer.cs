namespace Group_2
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
            this.create = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.Required = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.Required,
            this.Product,
            this.Amount});
            this.dataGridView1.Location = new System.Drawing.Point(374, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(404, 382);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // create
            // 
            this.create.Location = new System.Drawing.Point(216, 377);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(104, 61);
            this.create.TabIndex = 11;
            this.create.Text = "Create Form";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(44, 377);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(104, 61);
            this.Back.TabIndex = 12;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Required
            // 
            this.Required.HeaderText = "Required";
            this.Required.MinimumWidth = 8;
            this.Required.Name = "Required";
            this.Required.ReadOnly = true;
            this.Required.Width = 150;
            // 
            // Product
            // 
            this.Product.HeaderText = "Product ID";
            this.Product.MinimumWidth = 8;
            this.Product.Name = "Product";
            this.Product.ReadOnly = true;
            this.Product.Width = 150;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.MinimumWidth = 8;
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            this.Amount.Width = 150;
            // 
            // ProductionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Name = "ProductionForm";
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
    }
}