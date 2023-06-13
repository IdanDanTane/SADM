namespace Group_2
{
    partial class viewMAT
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(viewMAT));
            this.getallemployeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sADM_2DataSet2 = new Group_2.SADM_2DataSet2();
            this.get_all_employeesTableAdapter = new Group_2.SADM_2DataSet2TableAdapters.Get_all_employeesTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.viewMAT2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.getallemployeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sADM_2DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewMAT2)).BeginInit();
            this.SuspendLayout();
            // 
            // getallemployeesBindingSource
            // 
            this.getallemployeesBindingSource.DataMember = "Get_all_employees";
            this.getallemployeesBindingSource.DataSource = this.sADM_2DataSet2;
            // 
            // sADM_2DataSet2
            // 
            this.sADM_2DataSet2.DataSetName = "SADM_2DataSet2";
            this.sADM_2DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // get_all_employeesTableAdapter
            // 
            this.get_all_employeesTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Aharoni", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button1.Location = new System.Drawing.Point(35, 583);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 50);
            this.button1.TabIndex = 1;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // viewMAT2
            // 
            this.viewMAT2.AllowUserToAddRows = false;
            this.viewMAT2.AllowUserToDeleteRows = false;
            this.viewMAT2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewMAT2.Location = new System.Drawing.Point(35, 32);
            this.viewMAT2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.viewMAT2.Name = "viewMAT2";
            this.viewMAT2.ReadOnly = true;
            this.viewMAT2.RowHeadersWidth = 62;
            this.viewMAT2.RowTemplate.Height = 28;
            this.viewMAT2.Size = new System.Drawing.Size(1200, 341);
            this.viewMAT2.TabIndex = 2;
            this.viewMAT2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // viewMAT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1282, 653);
            this.Controls.Add(this.viewMAT2);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "viewMAT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "view Materials";
            this.Load += new System.EventHandler(this.ViewMAT2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.getallemployeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sADM_2DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewMAT2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private SADM_2DataSet2 sADM_2DataSet2;
        private System.Windows.Forms.BindingSource getallemployeesBindingSource;
        private SADM_2DataSet2TableAdapters.Get_all_employeesTableAdapter get_all_employeesTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView viewMAT2;
    }
}