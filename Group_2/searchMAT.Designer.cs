namespace Group_2
{
    partial class searchMAT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(searchMAT));
            this.search_MAT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.MATID = new System.Windows.Forms.TextBox();
            this.MATname = new System.Windows.Forms.TextBox();
            this.priceperton = new System.Windows.Forms.TextBox();
            this.minthersh = new System.Windows.Forms.TextBox();
            this.Loc = new System.Windows.Forms.ComboBox();
            this.RecivedDate = new System.Windows.Forms.DateTimePicker();
            this.back = new System.Windows.Forms.Button();
            this.deleteMAT = new System.Windows.Forms.Button();
            this.UpdateMAT = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.ExpDate = new System.Windows.Forms.DateTimePicker();
            this.AmountEX = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.ComboBox();
            this.invalid_ExpDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // search_MAT
            // 

            this.search_MAT.Font = new System.Drawing.Font("Aharoni", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_MAT.Location = new System.Drawing.Point(314, 570);
            this.search_MAT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.search_MAT.Name = "search_MAT";
            this.search_MAT.Size = new System.Drawing.Size(200, 50);

            this.search_MAT.TabIndex = 0;
            this.search_MAT.Text = "search Material";
            this.search_MAT.UseVisualStyleBackColor = true;
            this.search_MAT.Click += new System.EventHandler(this.search_Employee_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;

            this.label1.Font = new System.Drawing.Font("Aharoni", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(285, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 23);

            this.label1.TabIndex = 1;
            this.label1.Text = "Material ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;

            this.label2.Font = new System.Drawing.Font("Aharoni", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(330, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 23);

            this.label2.TabIndex = 2;
            this.label2.Text = "name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;

            this.label3.Font = new System.Drawing.Font("Aharoni", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(275, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 23);

            this.label3.TabIndex = 3;
            this.label3.Text = "price per ton";
            // 
            // label4
            // 
            this.label4.AutoSize = true;

            this.label4.Font = new System.Drawing.Font("Aharoni", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(203, 330);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(218, 23);

            this.label4.TabIndex = 4;
            this.label4.Text = "minimum threshold";
            // 
            // label5
            // 
            this.label5.AutoSize = true;

            this.label5.Font = new System.Drawing.Font("Aharoni", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.Location = new System.Drawing.Point(344, 399);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 23);

            this.label5.TabIndex = 5;
            this.label5.Text = "Status";
            // 
            // label6
            // 
            this.label6.AutoSize = true;

            this.label6.Font = new System.Drawing.Font("Aharoni", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.Location = new System.Drawing.Point(738, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 23);

            this.label6.TabIndex = 6;
            this.label6.Text = "recived date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;

            this.label7.Font = new System.Drawing.Font("Aharoni", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.Location = new System.Drawing.Point(320, 469);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 23);

            this.label7.TabIndex = 7;
            this.label7.Text = "Location";
            // 
            // MATID
            // 

            this.MATID.Location = new System.Drawing.Point(482, 131);
            this.MATID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MATID.Name = "MATID";
            this.MATID.Size = new System.Drawing.Size(177, 22);

            this.MATID.TabIndex = 8;
            this.MATID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // MATname
            // 

            this.MATname.Location = new System.Drawing.Point(482, 208);
            this.MATname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MATname.Name = "MATname";
            this.MATname.Size = new System.Drawing.Size(177, 22);

            this.MATname.TabIndex = 9;
            this.MATname.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // priceperton
            // 

            this.priceperton.Location = new System.Drawing.Point(482, 271);
            this.priceperton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.priceperton.Name = "priceperton";
            this.priceperton.Size = new System.Drawing.Size(177, 22);

            this.priceperton.TabIndex = 10;
            this.priceperton.TextChanged += new System.EventHandler(this.EmployeeEmail_TextChanged);
            // 
            // minthersh
            // 

            this.minthersh.Location = new System.Drawing.Point(482, 330);
            this.minthersh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.minthersh.Name = "minthersh";
            this.minthersh.Size = new System.Drawing.Size(177, 22);

            this.minthersh.TabIndex = 11;
            this.minthersh.TextChanged += new System.EventHandler(this.EmployeeFirstName_TextChanged);
            // 
            // Loc
            // 
            this.Loc.FormattingEnabled = true;

            this.Loc.Location = new System.Drawing.Point(482, 468);
            this.Loc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Loc.Name = "Loc";
            this.Loc.Size = new System.Drawing.Size(177, 24);

            this.Loc.TabIndex = 14;
            this.Loc.SelectedIndexChanged += new System.EventHandler(this.EmployeeType_choose_SelectedIndexChanged);
            // 
            // RecivedDate
            // 
            this.RecivedDate.CustomFormat = "yyyy-MM-dd";
            this.RecivedDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.RecivedDate.Location = new System.Drawing.Point(939, 206);

            this.RecivedDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RecivedDate.Name = "RecivedDate";
            this.RecivedDate.Size = new System.Drawing.Size(200, 26);
            this.RecivedDate.TabIndex = 15;
            this.RecivedDate.ValueChanged += new System.EventHandler(this.employeeBirthDate_ValueChanged);
            // 
            // back
            // 

            this.back.Font = new System.Drawing.Font("Aharoni", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.back.Location = new System.Drawing.Point(30, 579);
            this.back.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(120, 50);

            this.back.TabIndex = 16;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.button1_Click);
            // 
            // deleteMAT
            // 

            this.deleteMAT.Font = new System.Drawing.Font("Aharoni", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.deleteMAT.Location = new System.Drawing.Point(575, 570);
            this.deleteMAT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteMAT.Name = "deleteMAT";
            this.deleteMAT.Size = new System.Drawing.Size(200, 50);

            this.deleteMAT.TabIndex = 17;
            this.deleteMAT.Text = "Delete Material";
            this.deleteMAT.UseVisualStyleBackColor = true;
            this.deleteMAT.Click += new System.EventHandler(this.deleteEMP_Click);
            // 
            // UpdateMAT
            // 

            this.UpdateMAT.Font = new System.Drawing.Font("Aharoni", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.UpdateMAT.Location = new System.Drawing.Point(834, 570);
            this.UpdateMAT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UpdateMAT.Name = "UpdateMAT";
            this.UpdateMAT.Size = new System.Drawing.Size(200, 50);

            this.UpdateMAT.TabIndex = 18;
            this.UpdateMAT.Text = "update Material";
            this.UpdateMAT.UseVisualStyleBackColor = true;
            this.UpdateMAT.Click += new System.EventHandler(this.UpdateEMP_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;

            this.label8.Font = new System.Drawing.Font("Aharoni", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label8.Location = new System.Drawing.Point(713, 270);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(178, 23);

            this.label8.TabIndex = 19;
            this.label8.Text = "expiration date";
            // 
            // ExpDate
            // 
            this.ExpDate.CustomFormat = "yyyy-MM-dd";
            this.ExpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;

            this.ExpDate.Location = new System.Drawing.Point(939, 269);

            this.ExpDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ExpDate.Name = "ExpDate";
            this.ExpDate.Size = new System.Drawing.Size(200, 26);
            this.ExpDate.TabIndex = 20;
            this.ExpDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // AmountEX
            // 

            this.AmountEX.Location = new System.Drawing.Point(939, 331);
            this.AmountEX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AmountEX.Name = "AmountEX";
            this.AmountEX.Size = new System.Drawing.Size(178, 22);

            this.AmountEX.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;

            this.label9.Font = new System.Drawing.Font("Aharoni", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label9.Location = new System.Drawing.Point(767, 330);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 23);

            this.label9.TabIndex = 21;
            this.label9.Text = "Amount";
            // 
            // Status
            // 
            this.Status.FormattingEnabled = true;

            this.Status.Location = new System.Drawing.Point(482, 399);
            this.Status.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(177, 24);

            this.Status.TabIndex = 23;
            this.Status.SelectedIndexChanged += new System.EventHandler(this.Status_SelectedIndexChanged);
            // 
            // invalid_ExpDate
            // 
            this.invalid_ExpDate.AutoSize = true;
            this.invalid_ExpDate.ForeColor = System.Drawing.Color.Red;
            this.invalid_ExpDate.Location = new System.Drawing.Point(454, 114);
            this.invalid_ExpDate.Name = "invalid_ExpDate";
            this.invalid_ExpDate.Size = new System.Drawing.Size(278, 20);
            this.invalid_ExpDate.TabIndex = 26;
            this.invalid_ExpDate.Text = "Exp date must be after the recive date";
            this.invalid_ExpDate.Click += new System.EventHandler(this.invalid_ExpDate_Click);
            // 
            // searchMAT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1282, 653);

            this.Controls.Add(this.Status);
            this.Controls.Add(this.AmountEX);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ExpDate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.UpdateMAT);
            this.Controls.Add(this.deleteMAT);
            this.Controls.Add(this.back);
            this.Controls.Add(this.RecivedDate);
            this.Controls.Add(this.Loc);
            this.Controls.Add(this.minthersh);
            this.Controls.Add(this.priceperton);
            this.Controls.Add(this.MATname);
            this.Controls.Add(this.MATID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.search_MAT);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "searchMAT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Material";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button search_MAT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox MATID;
        private System.Windows.Forms.TextBox MATname;
        private System.Windows.Forms.TextBox priceperton;
        private System.Windows.Forms.TextBox minthersh;
        private System.Windows.Forms.ComboBox Loc;
        private System.Windows.Forms.DateTimePicker RecivedDate;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button deleteMAT;
        private System.Windows.Forms.Button UpdateMAT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker ExpDate;
        private System.Windows.Forms.TextBox AmountEX;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox Status;
        private System.Windows.Forms.Label invalid_ExpDate;
    }
}