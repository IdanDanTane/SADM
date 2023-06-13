namespace Group_2
{
    partial class CreateForecast
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
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.endDate = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Include = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.invalidStart = new System.Windows.Forms.Label();
            this.invalidEnd = new System.Windows.Forms.Label();
            this.invalid_product = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // startDate
            // 
            this.startDate.Location = new System.Drawing.Point(132, 68);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(200, 26);
            this.startDate.TabIndex = 2;
            this.startDate.ValueChanged += new System.EventHandler(this.startDate_ValueChanged);
            // 
            // endDate
            // 
            this.endDate.Location = new System.Drawing.Point(132, 149);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(200, 26);
            this.endDate.TabIndex = 3;
            this.endDate.ValueChanged += new System.EventHandler(this.endDate_ValueChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Include,
            this.ProductID});
            this.dataGridView1.Location = new System.Drawing.Point(372, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(416, 361);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Include
            // 
            this.Include.HeaderText = "Include";
            this.Include.MinimumWidth = 8;
            this.Include.Name = "Include";
            this.Include.Width = 150;
            // 
            // ProductID
            // 
            this.ProductID.HeaderText = "Product ID";
            this.ProductID.MinimumWidth = 8;
            this.ProductID.Name = "ProductID";
            this.ProductID.ReadOnly = true;
            this.ProductID.Width = 150;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 380);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 42);
            this.button1.TabIndex = 5;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(188, 380);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 58);
            this.button2.TabIndex = 6;
            this.button2.Text = "create forecast";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // invalidStart
            // 
            this.invalidStart.AutoSize = true;
            this.invalidStart.ForeColor = System.Drawing.Color.Red;
            this.invalidStart.Location = new System.Drawing.Point(83, 108);
            this.invalidStart.Name = "invalidStart";
            this.invalidStart.Size = new System.Drawing.Size(254, 20);
            this.invalidStart.TabIndex = 21;
            this.invalidStart.Text = "start date must be after than today";
            this.invalidStart.Click += new System.EventHandler(this.invalidStart_Click);
            // 
            // invalidEnd
            // 
            this.invalidEnd.AutoSize = true;
            this.invalidEnd.ForeColor = System.Drawing.Color.Red;
            this.invalidEnd.Location = new System.Drawing.Point(78, 198);
            this.invalidEnd.Name = "invalidEnd";
            this.invalidEnd.Size = new System.Drawing.Size(242, 20);
            this.invalidEnd.TabIndex = 22;
            this.invalidEnd.Text = "end date must be after start date";
            this.invalidEnd.Click += new System.EventHandler(this.invalidEnd_Click);
            // 
            // invalid_product
            // 
            this.invalid_product.AutoSize = true;
            this.invalid_product.ForeColor = System.Drawing.Color.Red;
            this.invalid_product.Location = new System.Drawing.Point(429, 35);
            this.invalid_product.Name = "invalid_product";
            this.invalid_product.Size = new System.Drawing.Size(188, 20);
            this.invalid_product.TabIndex = 28;
            this.invalid_product.Text = "choose at least 1 product";
            this.invalid_product.Click += new System.EventHandler(this.invalid_product_Click);
            // 
            // CreateForecast
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.invalid_product);
            this.Controls.Add(this.invalidEnd);
            this.Controls.Add(this.invalidStart);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.endDate);
            this.Controls.Add(this.startDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CreateForecast";
            this.Text = "CreateForecast";
            this.Load += new System.EventHandler(this.CreateForecast_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker startDate;
        private System.Windows.Forms.DateTimePicker endDate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Include;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.Label invalidStart;
        private System.Windows.Forms.Label invalidEnd;
        private System.Windows.Forms.Label invalid_product;
    }
}