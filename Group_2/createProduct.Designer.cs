namespace Group_2
{
    partial class createProduct
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.productID = new System.Windows.Forms.TextBox();
            this.productName = new System.Windows.Forms.TextBox();
            this.pricePerTon = new System.Windows.Forms.TextBox();
            this.expirationDate = new System.Windows.Forms.DateTimePicker();
            this.ProductType = new System.Windows.Forms.Label();
            this.Type = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.getMaterials = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 0;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(124, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Product ID : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(124, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Product name :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(124, 341);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Expiration date :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(124, 409);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Price per ton :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(384, 478);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 45);
            this.button1.TabIndex = 6;
            this.button1.Text = "Create product";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // productID
            // 
            this.productID.Location = new System.Drawing.Point(266, 198);
            this.productID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.productID.Name = "productID";
            this.productID.Size = new System.Drawing.Size(140, 26);
            this.productID.TabIndex = 7;
            // 
            // productName
            // 
            this.productName.Location = new System.Drawing.Point(266, 268);
            this.productName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(140, 26);
            this.productName.TabIndex = 8;
            // 
            // pricePerTon
            // 
            this.pricePerTon.Location = new System.Drawing.Point(266, 405);
            this.pricePerTon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pricePerTon.Name = "pricePerTon";
            this.pricePerTon.Size = new System.Drawing.Size(140, 26);
            this.pricePerTon.TabIndex = 10;
            // 
            // expirationDate
            // 
            this.expirationDate.CustomFormat = "yyyy-MM-dd";
            this.expirationDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.expirationDate.Location = new System.Drawing.Point(266, 334);
            this.expirationDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.expirationDate.Name = "expirationDate";
            this.expirationDate.Size = new System.Drawing.Size(140, 26);
            this.expirationDate.TabIndex = 11;
            this.expirationDate.ValueChanged += new System.EventHandler(this.expirationDate_ValueChanged);
            // 
            // ProductType
            // 
            this.ProductType.AutoSize = true;
            this.ProductType.Location = new System.Drawing.Point(124, 128);
            this.ProductType.Name = "ProductType";
            this.ProductType.Size = new System.Drawing.Size(106, 20);
            this.ProductType.TabIndex = 12;
            this.ProductType.Text = "Product type :";
            // 
            // Type
            // 
            this.Type.FormattingEnabled = true;
            this.Type.Location = new System.Drawing.Point(266, 128);
            this.Type.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(140, 28);
            this.Type.TabIndex = 13;
            this.Type.SelectedIndexChanged += new System.EventHandler(this.Type_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(515, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Materials  :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.getMaterials,
            this.Amount});
            this.dataGridView1.Location = new System.Drawing.Point(519, 169);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(327, 84);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // getMaterials
            // 
            this.getMaterials.HeaderText = "Material";
            this.getMaterials.MinimumWidth = 6;
            this.getMaterials.Name = "getMaterials";
            this.getMaterials.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.getMaterials.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.getMaterials.Width = 125;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.MinimumWidth = 6;
            this.Amount.Name = "Amount";
            this.Amount.Width = 125;
            // 
            // createProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.ProductType);
            this.Controls.Add(this.expirationDate);
            this.Controls.Add(this.pricePerTon);
            this.Controls.Add(this.productName);
            this.Controls.Add(this.productID);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "createProduct";
            this.Text = "Create product";
            this.Load += new System.EventHandler(this.createProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox productID;
        private System.Windows.Forms.TextBox productName;
        private System.Windows.Forms.TextBox pricePerTon;
        private System.Windows.Forms.DateTimePicker expirationDate;
        private System.Windows.Forms.Label ProductType;
        private System.Windows.Forms.ComboBox Type;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewComboBoxColumn getMaterials;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
    }
}