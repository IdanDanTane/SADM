namespace Group_2
{
    partial class homepage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(homepage));
            this.label1 = new System.Windows.Forms.Label();
            this.customers = new System.Windows.Forms.Button();
            this.employees = new System.Windows.Forms.Button();
            this.products = new System.Windows.Forms.Button();
            this.materials = new System.Windows.Forms.Button();
            this.forecast = new System.Windows.Forms.Button();
            this.incomeReport = new System.Windows.Forms.Button();
            this.productionForm = new System.Windows.Forms.Button();
            this.EndshiftReport = new System.Windows.Forms.Button();
            this.updateStock = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Aharoni", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(499, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome!";
            // 
            // customers
            // 
            this.customers.Font = new System.Drawing.Font("Aharoni", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.customers.Location = new System.Drawing.Point(241, 93);
            this.customers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.customers.Name = "customers";
            this.customers.Size = new System.Drawing.Size(195, 45);
            this.customers.TabIndex = 1;
            this.customers.Text = "customers";
            this.customers.UseVisualStyleBackColor = true;
            this.customers.Click += new System.EventHandler(this.customers_Click);
            // 
            // employees
            // 
            this.employees.Font = new System.Drawing.Font("Aharoni", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.employees.Location = new System.Drawing.Point(219, 185);
            this.employees.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.employees.Name = "employees";
            this.employees.Size = new System.Drawing.Size(228, 49);
            this.employees.TabIndex = 2;
            this.employees.Text = "employees";
            this.employees.UseVisualStyleBackColor = true;
            this.employees.Click += new System.EventHandler(this.employees_Click);
            // 
            // products
            // 
            this.products.Font = new System.Drawing.Font("Aharoni", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.products.Location = new System.Drawing.Point(503, 85);
            this.products.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.products.Name = "products";
            this.products.Size = new System.Drawing.Size(166, 53);
            this.products.TabIndex = 3;
            this.products.Text = "products";
            this.products.UseVisualStyleBackColor = true;
            this.products.Click += new System.EventHandler(this.products_Click);
            // 
            // materials
            // 
            this.materials.Font = new System.Drawing.Font("Aharoni", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.materials.Location = new System.Drawing.Point(480, 185);
            this.materials.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.materials.Name = "materials";
            this.materials.Size = new System.Drawing.Size(199, 50);
            this.materials.TabIndex = 4;
            this.materials.Text = "materials";
            this.materials.UseVisualStyleBackColor = true;
            this.materials.Click += new System.EventHandler(this.materials_Click);
            // 
            // forecast
            // 
            this.forecast.Font = new System.Drawing.Font("Aharoni", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.forecast.Location = new System.Drawing.Point(742, 85);
            this.forecast.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.forecast.Name = "forecast";
            this.forecast.Size = new System.Drawing.Size(164, 69);
            this.forecast.TabIndex = 5;
            this.forecast.Text = "create forecast";
            this.forecast.UseVisualStyleBackColor = true;
            this.forecast.Click += new System.EventHandler(this.forecast_Click);
            // 
            // incomeReport
            // 
            this.incomeReport.Font = new System.Drawing.Font("Aharoni", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.incomeReport.Location = new System.Drawing.Point(729, 185);
            this.incomeReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.incomeReport.Name = "incomeReport";
            this.incomeReport.Size = new System.Drawing.Size(198, 41);
            this.incomeReport.TabIndex = 6;
            this.incomeReport.Text = "Create Fault";
            this.incomeReport.UseVisualStyleBackColor = true;
            this.incomeReport.Click += new System.EventHandler(this.incomeReport_Click);
            // 
            // productionForm
            // 
            this.productionForm.Font = new System.Drawing.Font("Aharoni", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.productionForm.Location = new System.Drawing.Point(716, 277);
            this.productionForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.productionForm.Name = "productionForm";
            this.productionForm.Size = new System.Drawing.Size(198, 79);
            this.productionForm.TabIndex = 7;
            this.productionForm.Text = "Create prudoction form";
            this.productionForm.UseVisualStyleBackColor = true;
            this.productionForm.Click += new System.EventHandler(this.productionForm_Click);
            // 
            // EndshiftReport
            // 
            this.EndshiftReport.Font = new System.Drawing.Font("Aharoni", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.EndshiftReport.Location = new System.Drawing.Point(471, 277);
            this.EndshiftReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EndshiftReport.Name = "EndshiftReport";
            this.EndshiftReport.Size = new System.Drawing.Size(217, 77);
            this.EndshiftReport.TabIndex = 8;
            this.EndshiftReport.Text = "Create end shift report";
            this.EndshiftReport.UseVisualStyleBackColor = true;
            this.EndshiftReport.Click += new System.EventHandler(this.EndshiftReport_Click);
            // 
            // updateStock
            // 
            this.updateStock.Font = new System.Drawing.Font("Aharoni", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.updateStock.Location = new System.Drawing.Point(251, 275);
            this.updateStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.updateStock.Name = "updateStock";
            this.updateStock.Size = new System.Drawing.Size(163, 79);
            this.updateStock.TabIndex = 9;
            this.updateStock.Text = "update stock";
            this.updateStock.UseVisualStyleBackColor = true;
            this.updateStock.Click += new System.EventHandler(this.updateStock_Click_1);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Aharoni", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button1.Location = new System.Drawing.Point(32, 385);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 45);
            this.button1.TabIndex = 10;
            this.button1.Text = "back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1130, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.updateStock);
            this.Controls.Add(this.EndshiftReport);
            this.Controls.Add(this.productionForm);
            this.Controls.Add(this.incomeReport);
            this.Controls.Add(this.forecast);
            this.Controls.Add(this.materials);
            this.Controls.Add(this.products);
            this.Controls.Add(this.employees);
            this.Controls.Add(this.customers);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "homepage";
            this.Text = "homepage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button customers;
        private System.Windows.Forms.Button employees;
        private System.Windows.Forms.Button products;
        private System.Windows.Forms.Button materials;
        private System.Windows.Forms.Button forecast;
        private System.Windows.Forms.Button incomeReport;
        private System.Windows.Forms.Button productionForm;
        private System.Windows.Forms.Button EndshiftReport;
        private System.Windows.Forms.Button updateStock;
        private System.Windows.Forms.Button button1;
    }
}