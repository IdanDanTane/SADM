namespace Group_2
{
    partial class createMAT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(createMAT));
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
            this.Loc = new System.Windows.Forms.ComboBox();
            this.RecivedDate = new System.Windows.Forms.DateTimePicker();
            this.back = new System.Windows.Forms.Button();
            this.UpdateMAT = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.ExpDate = new System.Windows.Forms.DateTimePicker();
            this.AmountEX = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.ComboBox();
            this.invalid_matID = new System.Windows.Forms.Label();
            this.invalid_ExpDate = new System.Windows.Forms.Label();
            this.minthersh = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Aharoni", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(400, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Material ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Aharoni", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(426, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Aharoni", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(382, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "price per ton";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Aharoni", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(342, 400);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(268, 28);
            this.label4.TabIndex = 4;
            this.label4.Text = "minimum threshold";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Aharoni", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.Location = new System.Drawing.Point(426, 482);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 28);
            this.label5.TabIndex = 5;
            this.label5.Text = "Status";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Aharoni", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.Location = new System.Drawing.Point(888, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 28);
            this.label6.TabIndex = 6;
            this.label6.Text = "recived date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Aharoni", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.Location = new System.Drawing.Point(416, 565);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 28);
            this.label7.TabIndex = 7;
            this.label7.Text = "Location";
            // 
            // MATID
            // 
            this.MATID.Location = new System.Drawing.Point(621, 148);
            this.MATID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MATID.Name = "MATID";
            this.MATID.Size = new System.Drawing.Size(206, 26);
            this.MATID.TabIndex = 8;
            this.MATID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // MATname
            // 
            this.MATname.Location = new System.Drawing.Point(621, 232);
            this.MATname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MATname.Name = "MATname";
            this.MATname.Size = new System.Drawing.Size(206, 26);
            this.MATname.TabIndex = 9;
            this.MATname.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // priceperton
            // 
            this.priceperton.Location = new System.Drawing.Point(621, 314);
            this.priceperton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.priceperton.Name = "priceperton";
            this.priceperton.Size = new System.Drawing.Size(206, 26);
            this.priceperton.TabIndex = 10;
            this.priceperton.TextChanged += new System.EventHandler(this.EmployeeEmail_TextChanged);
            // 
            // Loc
            // 
            this.Loc.FormattingEnabled = true;
            this.Loc.Location = new System.Drawing.Point(621, 564);
            this.Loc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Loc.Name = "Loc";
            this.Loc.Size = new System.Drawing.Size(206, 28);
            this.Loc.TabIndex = 14;
            this.Loc.SelectedIndexChanged += new System.EventHandler(this.EmployeeType_choose_SelectedIndexChanged);
            // 
            // RecivedDate
            // 
            this.RecivedDate.CustomFormat = "yyyy-MM-dd";
            this.RecivedDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.RecivedDate.Location = new System.Drawing.Point(1084, 149);
            this.RecivedDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RecivedDate.Name = "RecivedDate";
            this.RecivedDate.Size = new System.Drawing.Size(200, 26);
            this.RecivedDate.TabIndex = 15;
            this.RecivedDate.ValueChanged += new System.EventHandler(this.employeeBirthDate_ValueChanged);
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Aharoni", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.back.Location = new System.Drawing.Point(35, 715);
            this.back.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(135, 62);
            this.back.TabIndex = 16;
            this.back.Text = "back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.button1_Click);
            // 
            // UpdateMAT
            // 
            this.UpdateMAT.Font = new System.Drawing.Font("Aharoni", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.UpdateMAT.Location = new System.Drawing.Point(726, 672);
            this.UpdateMAT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UpdateMAT.Name = "UpdateMAT";
            this.UpdateMAT.Size = new System.Drawing.Size(225, 62);
            this.UpdateMAT.TabIndex = 18;
            this.UpdateMAT.Text = "Create Material";
            this.UpdateMAT.UseVisualStyleBackColor = true;
            this.UpdateMAT.Click += new System.EventHandler(this.UpdateEMP_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Aharoni", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label8.Location = new System.Drawing.Point(862, 232);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(217, 28);
            this.label8.TabIndex = 19;
            this.label8.Text = "expiration date";
            // 
            // ExpDate
            // 
            this.ExpDate.CustomFormat = "yyyy-MM-dd";
            this.ExpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ExpDate.Location = new System.Drawing.Point(1084, 230);
            this.ExpDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ExpDate.Name = "ExpDate";
            this.ExpDate.Size = new System.Drawing.Size(200, 26);
            this.ExpDate.TabIndex = 20;
            this.ExpDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // AmountEX
            // 
            this.AmountEX.Location = new System.Drawing.Point(1084, 312);
            this.AmountEX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AmountEX.Name = "AmountEX";
            this.AmountEX.Size = new System.Drawing.Size(200, 26);
            this.AmountEX.TabIndex = 22;
            this.AmountEX.TextChanged += new System.EventHandler(this.AmountEX_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Aharoni", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label9.Location = new System.Drawing.Point(900, 312);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 28);
            this.label9.TabIndex = 21;
            this.label9.Text = "Amount";
            // 
            // Status
            // 
            this.Status.FormattingEnabled = true;
            this.Status.Location = new System.Drawing.Point(621, 484);
            this.Status.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(206, 28);
            this.Status.TabIndex = 23;
            this.Status.SelectedIndexChanged += new System.EventHandler(this.Status_SelectedIndexChanged);
            // 
            // invalid_matID
            // 
            this.invalid_matID.AutoSize = true;
            this.invalid_matID.ForeColor = System.Drawing.Color.Red;
            this.invalid_matID.Location = new System.Drawing.Point(582, 188);
            this.invalid_matID.Name = "invalid_matID";
            this.invalid_matID.Size = new System.Drawing.Size(245, 20);
            this.invalid_matID.TabIndex = 24;
            this.invalid_matID.Text = "Material ID format: \\\" M*number* \\";
            // 
            // invalid_ExpDate
            // 
            this.invalid_ExpDate.AutoSize = true;
            this.invalid_ExpDate.ForeColor = System.Drawing.Color.Red;
            this.invalid_ExpDate.Location = new System.Drawing.Point(1067, 272);
            this.invalid_ExpDate.Name = "invalid_ExpDate";
            this.invalid_ExpDate.Size = new System.Drawing.Size(278, 20);
            this.invalid_ExpDate.TabIndex = 25;
            this.invalid_ExpDate.Text = "Exp date must be after the recive date";
            // 
            // minthersh
            // 
            this.minthersh.Location = new System.Drawing.Point(621, 400);
            this.minthersh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.minthersh.Name = "minthersh";
            this.minthersh.Size = new System.Drawing.Size(206, 26);
            this.minthersh.TabIndex = 11;
            this.minthersh.TextChanged += new System.EventHandler(this.EmployeeFirstName_TextChanged);
            // 
            // createMAT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1442, 816);
            this.Controls.Add(this.invalid_ExpDate);
            this.Controls.Add(this.invalid_matID);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.AmountEX);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ExpDate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.UpdateMAT);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "createMAT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Material";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox MATID;
        private System.Windows.Forms.TextBox MATname;
        private System.Windows.Forms.TextBox priceperton;
        private System.Windows.Forms.ComboBox Loc;
        private System.Windows.Forms.DateTimePicker RecivedDate;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button UpdateMAT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker ExpDate;
        private System.Windows.Forms.TextBox AmountEX;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox Status;
        private System.Windows.Forms.Label invalid_matID;
        private System.Windows.Forms.Label invalid_ExpDate;
        private System.Windows.Forms.TextBox minthersh;
    }
}