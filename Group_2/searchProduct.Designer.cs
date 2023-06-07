namespace Group_2
{
    partial class searchProduct
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
            this.Type = new System.Windows.Forms.ComboBox();
            this.ProductType = new System.Windows.Forms.Label();
            this.expirationDate = new System.Windows.Forms.DateTimePicker();
            this.pricePerTon = new System.Windows.Forms.TextBox();
            this.productName = new System.Windows.Forms.TextBox();
            this.productID = new System.Windows.Forms.TextBox();
            this.search_Product = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.deleteProduct = new System.Windows.Forms.Button();
            this.update_Product = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.getMaterials = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Type
            // 
            this.Type.FormattingEnabled = true;
            this.Type.Location = new System.Drawing.Point(209, 245);
            this.Type.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(140, 28);
            this.Type.TabIndex = 26;
            this.Type.SelectedIndexChanged += new System.EventHandler(this.Type_SelectedIndexChanged);
            // 
            // ProductType
            // 
            this.ProductType.AutoSize = true;
            this.ProductType.Location = new System.Drawing.Point(67, 245);
            this.ProductType.Name = "ProductType";
            this.ProductType.Size = new System.Drawing.Size(106, 20);
            this.ProductType.TabIndex = 25;
            this.ProductType.Text = "Product type :";
            // 
            // expirationDate
            // 
            this.expirationDate.CustomFormat = "yyyy-MM-dd";
            this.expirationDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.expirationDate.Location = new System.Drawing.Point(209, 168);
            this.expirationDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.expirationDate.Name = "expirationDate";
            this.expirationDate.Size = new System.Drawing.Size(140, 26);
            this.expirationDate.TabIndex = 24;
            this.expirationDate.ValueChanged += new System.EventHandler(this.expirationDate_ValueChanged);
            // 
            // pricePerTon
            // 
            this.pricePerTon.Location = new System.Drawing.Point(209, 316);
            this.pricePerTon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pricePerTon.Name = "pricePerTon";
            this.pricePerTon.Size = new System.Drawing.Size(140, 26);
            this.pricePerTon.TabIndex = 23;
            // 
            // productName
            // 
            this.productName.Location = new System.Drawing.Point(209, 102);
            this.productName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(140, 26);
            this.productName.TabIndex = 22;
            this.productName.TextChanged += new System.EventHandler(this.productName_TextChanged);
            // 
            // productID
            // 
            this.productID.Location = new System.Drawing.Point(209, 32);
            this.productID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.productID.Name = "productID";
            this.productID.Size = new System.Drawing.Size(140, 26);
            this.productID.TabIndex = 21;
            this.productID.TextChanged += new System.EventHandler(this.productID_TextChanged);
            // 
            // search_Product
            // 
            this.search_Product.Location = new System.Drawing.Point(209, 389);
            this.search_Product.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.search_Product.Name = "search_Product";
            this.search_Product.Size = new System.Drawing.Size(176, 45);
            this.search_Product.TabIndex = 20;
            this.search_Product.Text = "search product";
            this.search_Product.UseVisualStyleBackColor = true;
            this.search_Product.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(67, 320);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Price per ton :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Expiration date :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Product name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Product ID : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 14;
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(71, 397);
            this.back.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(101, 35);
            this.back.TabIndex = 27;
            this.back.Text = "back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // deleteProduct
            // 
            this.deleteProduct.Location = new System.Drawing.Point(436, 389);
            this.deleteProduct.Name = "deleteProduct";
            this.deleteProduct.Size = new System.Drawing.Size(155, 41);
            this.deleteProduct.TabIndex = 28;
            this.deleteProduct.Text = "Deleta Product";
            this.deleteProduct.UseVisualStyleBackColor = true;
            this.deleteProduct.Click += new System.EventHandler(this.deleteProduct_Click);
            // 
            // update_Product
            // 
            this.update_Product.Location = new System.Drawing.Point(655, 395);
            this.update_Product.Name = "update_Product";
            this.update_Product.Size = new System.Drawing.Size(133, 39);
            this.update_Product.TabIndex = 29;
            this.update_Product.Text = "update Product";
            this.update_Product.UseVisualStyleBackColor = true;
            this.update_Product.Click += new System.EventHandler(this.update_Product_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.getMaterials,
            this.Amount});
            this.dataGridView1.Location = new System.Drawing.Point(461, 110);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(327, 84);
            this.dataGridView1.TabIndex = 31;
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(457, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 20);
            this.label8.TabIndex = 30;
            this.label8.Text = "Materials  :";
            // 
            // searchProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.update_Product);
            this.Controls.Add(this.deleteProduct);
            this.Controls.Add(this.back);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.ProductType);
            this.Controls.Add(this.expirationDate);
            this.Controls.Add(this.pricePerTon);
            this.Controls.Add(this.productName);
            this.Controls.Add(this.productID);
            this.Controls.Add(this.search_Product);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "searchProduct";
            this.Text = "searchProduct";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Type;
        private System.Windows.Forms.Label ProductType;
        private System.Windows.Forms.DateTimePicker expirationDate;
        private System.Windows.Forms.TextBox pricePerTon;
        private System.Windows.Forms.TextBox productName;
        private System.Windows.Forms.TextBox productID;
        private System.Windows.Forms.Button search_Product;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button deleteProduct;
        private System.Windows.Forms.Button update_Product;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewComboBoxColumn getMaterials;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.Label label8;
    }
}