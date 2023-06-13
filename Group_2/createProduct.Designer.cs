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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(createProduct));
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
            this.Back = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.needed = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Material_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invalid_ProdID = new System.Windows.Forms.Label();
            this.invalid_ExpDate = new System.Windows.Forms.Label();
            this.invalid_materials = new System.Windows.Forms.Label();
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
            this.label3.Font = new System.Drawing.Font("Aharoni", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(404, 338);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Product ID : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Aharoni", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(388, 412);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "Product name :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Aharoni", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.Location = new System.Drawing.Point(370, 495);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(231, 28);
            this.label5.TabIndex = 4;
            this.label5.Text = "Expiration date :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Aharoni", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.Location = new System.Drawing.Point(404, 572);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(196, 28);
            this.label6.TabIndex = 5;
            this.label6.Text = "Price per ton :";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Aharoni", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button1.Location = new System.Drawing.Point(648, 676);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 62);
            this.button1.TabIndex = 6;
            this.button1.Text = "Create product";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // productID
            // 
            this.productID.Location = new System.Drawing.Point(648, 338);
            this.productID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.productID.Name = "productID";
            this.productID.Size = new System.Drawing.Size(192, 26);
            this.productID.TabIndex = 7;
            this.productID.TextChanged += new System.EventHandler(this.productID_TextChanged);
            // 
            // productName
            // 
            this.productName.Location = new System.Drawing.Point(648, 412);
            this.productName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(192, 26);
            this.productName.TabIndex = 8;
            this.productName.TextChanged += new System.EventHandler(this.productName_TextChanged);
            // 
            // pricePerTon
            // 
            this.pricePerTon.Location = new System.Drawing.Point(648, 574);
            this.pricePerTon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pricePerTon.Name = "pricePerTon";
            this.pricePerTon.Size = new System.Drawing.Size(192, 26);
            this.pricePerTon.TabIndex = 10;
            // 
            // expirationDate
            // 
            this.expirationDate.CustomFormat = "yyyy-MM-dd";
            this.expirationDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.expirationDate.Location = new System.Drawing.Point(648, 494);
            this.expirationDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.expirationDate.Name = "expirationDate";
            this.expirationDate.Size = new System.Drawing.Size(192, 26);
            this.expirationDate.TabIndex = 11;
            this.expirationDate.ValueChanged += new System.EventHandler(this.expirationDate_ValueChanged);
            // 
            // ProductType
            // 
            this.ProductType.AutoSize = true;
            this.ProductType.Font = new System.Drawing.Font("Aharoni", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ProductType.Location = new System.Drawing.Point(402, 260);
            this.ProductType.Name = "ProductType";
            this.ProductType.Size = new System.Drawing.Size(196, 28);
            this.ProductType.TabIndex = 12;
            this.ProductType.Text = "Product type :";
            // 
            // Type
            // 
            this.Type.FormattingEnabled = true;
            this.Type.Location = new System.Drawing.Point(648, 261);
            this.Type.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(192, 28);
            this.Type.TabIndex = 13;
            this.Type.SelectedIndexChanged += new System.EventHandler(this.Type_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Aharoni", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label8.Location = new System.Drawing.Point(1084, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(162, 28);
            this.label8.TabIndex = 15;
            this.label8.Text = "Materials  :";
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Aharoni", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Back.Location = new System.Drawing.Point(35, 722);
            this.Back.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(135, 62);
            this.Back.TabIndex = 17;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.needed,
            this.Material_ID,
            this.Amount});
            this.dataGridView1.Location = new System.Drawing.Point(947, 86);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(408, 355);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // needed
            // 
            this.needed.HeaderText = "needed";
            this.needed.MinimumWidth = 8;
            this.needed.Name = "needed";
            this.needed.Width = 150;
            // 
            // Material_ID
            // 
            this.Material_ID.HeaderText = "Material ID";
            this.Material_ID.MinimumWidth = 8;
            this.Material_ID.Name = "Material_ID";
            this.Material_ID.ReadOnly = true;
            this.Material_ID.Width = 150;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.MinimumWidth = 8;
            this.Amount.Name = "Amount";
            this.Amount.Width = 150;
            // 
            // invalid_ProdID
            // 
            this.invalid_ProdID.AutoSize = true;
            this.invalid_ProdID.ForeColor = System.Drawing.Color.Red;
            this.invalid_ProdID.Location = new System.Drawing.Point(640, 368);
            this.invalid_ProdID.Name = "invalid_ProdID";
            this.invalid_ProdID.Size = new System.Drawing.Size(233, 20);
            this.invalid_ProdID.TabIndex = 25;
            this.invalid_ProdID.Text = "Product ID format: \\\" P number \\";
            // 
            // invalid_ExpDate
            // 
            this.invalid_ExpDate.AutoSize = true;
            this.invalid_ExpDate.ForeColor = System.Drawing.Color.Red;
            this.invalid_ExpDate.Location = new System.Drawing.Point(644, 524);
            this.invalid_ExpDate.Name = "invalid_ExpDate";
            this.invalid_ExpDate.Size = new System.Drawing.Size(213, 20);
            this.invalid_ExpDate.TabIndex = 26;
            this.invalid_ExpDate.Text = "Exp date must be after today";
            // 
            // invalid_materials
            // 
            this.invalid_materials.AutoSize = true;
            this.invalid_materials.ForeColor = System.Drawing.Color.Red;
            this.invalid_materials.Location = new System.Drawing.Point(1025, 457);
            this.invalid_materials.Name = "invalid_materials";
            this.invalid_materials.Size = new System.Drawing.Size(190, 20);
            this.invalid_materials.TabIndex = 27;
            this.invalid_materials.Text = "choose at least 1 material";
            // 
            // createProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1442, 816);
            this.Controls.Add(this.invalid_materials);
            this.Controls.Add(this.invalid_ExpDate);
            this.Controls.Add(this.invalid_ProdID);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Back);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn needed;
        private System.Windows.Forms.DataGridViewTextBoxColumn Material_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.Label invalid_ProdID;
        private System.Windows.Forms.Label invalid_ExpDate;
        private System.Windows.Forms.Label invalid_materials;
        }
}
