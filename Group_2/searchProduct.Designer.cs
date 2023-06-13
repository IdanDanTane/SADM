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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(searchProduct));
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
            this.needed = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.MaterialID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();

            this.invalid_ExpDate = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Type
            // 
            this.Type.FormattingEnabled = true;
            this.Type.Location = new System.Drawing.Point(612, 382);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(199, 24);
            this.Type.TabIndex = 26;
            this.Type.SelectedIndexChanged += new System.EventHandler(this.Type_SelectedIndexChanged);
            // 
            // ProductType
            // 
            this.ProductType.AutoSize = true;
            this.ProductType.Font = new System.Drawing.Font("Aharoni", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ProductType.Location = new System.Drawing.Point(380, 381);
            this.ProductType.Name = "ProductType";
            this.ProductType.Size = new System.Drawing.Size(160, 23);
            this.ProductType.TabIndex = 25;
            this.ProductType.Text = "Product type :";
            // 
            // expirationDate
            // 
            this.expirationDate.CustomFormat = "yyyy-MM-dd";
            this.expirationDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.expirationDate.Location = new System.Drawing.Point(612, 327);
            this.expirationDate.Name = "expirationDate";
            this.expirationDate.Size = new System.Drawing.Size(199, 22);
            this.expirationDate.TabIndex = 24;
            this.expirationDate.ValueChanged += new System.EventHandler(this.expirationDate_ValueChanged);
            // 
            // pricePerTon
            // 
            this.pricePerTon.Location = new System.Drawing.Point(612, 453);
            this.pricePerTon.Name = "pricePerTon";
            this.pricePerTon.Size = new System.Drawing.Size(199, 22);
            this.pricePerTon.TabIndex = 23;
            this.pricePerTon.TextChanged += new System.EventHandler(this.pricePerTon_TextChanged);
            // 
            // productName
            // 
            this.productName.Location = new System.Drawing.Point(612, 259);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(199, 22);
            this.productName.TabIndex = 22;
            this.productName.TextChanged += new System.EventHandler(this.productName_TextChanged);
            // 
            // productID
            // 
            this.productID.Location = new System.Drawing.Point(612, 197);
            this.productID.Name = "productID";
            this.productID.Size = new System.Drawing.Size(199, 22);
            this.productID.TabIndex = 21;
            this.productID.TextChanged += new System.EventHandler(this.productID_TextChanged);
            // 
            // search_Product
            // 
            this.search_Product.Font = new System.Drawing.Font("Aharoni", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.search_Product.Location = new System.Drawing.Point(331, 566);
            this.search_Product.Name = "search_Product";
            this.search_Product.Size = new System.Drawing.Size(200, 50);
            this.search_Product.TabIndex = 20;
            this.search_Product.Text = "search product";
            this.search_Product.UseVisualStyleBackColor = true;
            this.search_Product.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Aharoni", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.Location = new System.Drawing.Point(382, 452);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 23);
            this.label6.TabIndex = 19;
            this.label6.Text = "Price per ton :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Aharoni", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.Location = new System.Drawing.Point(352, 326);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 23);
            this.label5.TabIndex = 18;
            this.label5.Text = "Expiration date :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Aharoni", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(368, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 23);
            this.label4.TabIndex = 17;
            this.label4.Text = "Product name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Aharoni", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(391, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 23);
            this.label3.TabIndex = 16;
            this.label3.Text = "Product ID : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 14;
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Aharoni", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.back.Location = new System.Drawing.Point(42, 577);
            this.back.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(120, 50);
            this.back.TabIndex = 27;
            this.back.Text = "back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // deleteProduct
            // 
            this.deleteProduct.Font = new System.Drawing.Font("Aharoni", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.deleteProduct.Location = new System.Drawing.Point(571, 566);
            this.deleteProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteProduct.Name = "deleteProduct";
            this.deleteProduct.Size = new System.Drawing.Size(200, 50);
            this.deleteProduct.TabIndex = 28;
            this.deleteProduct.Text = "Delete Product";
            this.deleteProduct.UseVisualStyleBackColor = true;
            this.deleteProduct.Click += new System.EventHandler(this.deleteProduct_Click);
            // 
            // update_Product
            // 
            this.update_Product.Font = new System.Drawing.Font("Aharoni", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.update_Product.Location = new System.Drawing.Point(812, 566);
            this.update_Product.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.update_Product.Name = "update_Product";
            this.update_Product.Size = new System.Drawing.Size(200, 50);
            this.update_Product.TabIndex = 29;
            this.update_Product.Text = "update Product";
            this.update_Product.UseVisualStyleBackColor = true;
            this.update_Product.Click += new System.EventHandler(this.update_Product_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.needed,
            this.MaterialID,
            this.Amount});
            this.dataGridView1.Location = new System.Drawing.Point(841, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(392, 217);
            this.dataGridView1.TabIndex = 31;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // needed
            // 
            this.needed.HeaderText = "needed";
            this.needed.MinimumWidth = 8;
            this.needed.Name = "needed";
            this.needed.ReadOnly = true;
            this.needed.Width = 150;
            // 
            // MaterialID
            // 
            this.MaterialID.HeaderText = "Material ID";
            this.MaterialID.MinimumWidth = 8;
            this.MaterialID.Name = "MaterialID";
            this.MaterialID.ReadOnly = true;
            this.MaterialID.Width = 150;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.MinimumWidth = 8;
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            this.Amount.Width = 150;
            // 
            // label8
            // 
            this.label8.AutoSize = true;

            this.label8.Font = new System.Drawing.Font("Aharoni", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label8.Location = new System.Drawing.Point(971, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 23);
            this.label8.TabIndex = 30;
            this.label8.Text = "Materials  :";
            // 

            // invalid_ExpDate
            // 
            this.invalid_ExpDate.AutoSize = true;
            this.invalid_ExpDate.ForeColor = System.Drawing.Color.Red;
            this.invalid_ExpDate.Location = new System.Drawing.Point(172, 198);
            this.invalid_ExpDate.Name = "invalid_ExpDate";
            this.invalid_ExpDate.Size = new System.Drawing.Size(213, 20);
            this.invalid_ExpDate.TabIndex = 32;
            this.invalid_ExpDate.Text = "Exp date must be after today";
            // 

            // searchProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1282, 653);

            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.invalid_ExpDate);

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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "searchProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "searchProduct";
            this.Load += new System.EventHandler(this.searchProduct_Load);
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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewCheckBoxColumn needed;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaterialID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.Label invalid_ExpDate;
    }
}