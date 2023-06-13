namespace Group_2
{
    partial class CreateShiftReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateShiftReport));
            this.shiD = new System.Windows.Forms.Label();
            this.ShiftID = new System.Windows.Forms.TextBox();
            this.proid = new System.Windows.Forms.Label();
            this.crepo = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.produced = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.productID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // shiD
            // 
            this.shiD.AutoSize = true;
            this.shiD.Font = new System.Drawing.Font("Aharoni", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.shiD.Location = new System.Drawing.Point(560, 89);
            this.shiD.Name = "shiD";
            this.shiD.Size = new System.Drawing.Size(88, 23);
            this.shiD.TabIndex = 0;
            this.shiD.Text = "Shift ID";
            this.shiD.Click += new System.EventHandler(this.proid_Click);
            // 
            // ShiftID
            // 
            this.ShiftID.Location = new System.Drawing.Point(670, 89);
            this.ShiftID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ShiftID.Name = "ShiftID";
            this.ShiftID.Size = new System.Drawing.Size(209, 22);
            this.ShiftID.TabIndex = 1;
            this.ShiftID.TextChanged += new System.EventHandler(this.ShiftID_TextChanged);
            // 
            // proid
            // 
            this.proid.AutoSize = true;
            this.proid.Location = new System.Drawing.Point(113, 110);
            this.proid.Name = "proid";
            this.proid.Size = new System.Drawing.Size(0, 16);
            this.proid.TabIndex = 2;
            this.proid.Click += new System.EventHandler(this.proid_Click_1);
            // 
            // crepo
            // 
            this.crepo.Font = new System.Drawing.Font("Aharoni", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.crepo.Location = new System.Drawing.Point(598, 503);
            this.crepo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.crepo.Name = "crepo";
            this.crepo.Size = new System.Drawing.Size(200, 50);
            this.crepo.TabIndex = 7;
            this.crepo.Text = "Create Report";
            this.crepo.UseVisualStyleBackColor = true;
            this.crepo.Click += new System.EventHandler(this.crepo_Click);
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Aharoni", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.backButton.Location = new System.Drawing.Point(31, 582);
            this.backButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(120, 50);
            this.backButton.TabIndex = 8;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.produced,
            this.productID,
            this.Quantity});
            this.dataGridView1.Location = new System.Drawing.Point(458, 144);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(533, 223);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // produced
            // 
            this.produced.HeaderText = "produced";
            this.produced.MinimumWidth = 8;
            this.produced.Name = "produced";
            this.produced.Width = 150;
            // 
            // productID
            // 
            this.productID.HeaderText = "product ID";
            this.productID.MinimumWidth = 8;
            this.productID.Name = "productID";
            this.productID.ReadOnly = true;
            this.productID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.productID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.productID.Width = 150;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 8;
            this.Quantity.Name = "Quantity";
            this.Quantity.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Quantity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Quantity.Width = 150;
            // 
            // CreateShiftReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1282, 653);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.crepo);
            this.Controls.Add(this.proid);
            this.Controls.Add(this.ShiftID);
            this.Controls.Add(this.shiD);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CreateShiftReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateShiftReport";
            this.Load += new System.EventHandler(this.CreateShiftReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label shiD;
        private System.Windows.Forms.TextBox ShiftID;
        private System.Windows.Forms.Label proid;
        private System.Windows.Forms.Button crepo;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn produced;
        private System.Windows.Forms.DataGridViewTextBoxColumn productID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
    }
}