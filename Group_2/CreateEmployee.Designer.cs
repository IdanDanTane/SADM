﻿namespace Group_2
{
    partial class CreateEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateEmployee));
            this.create_Employee = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.EmployeeID = new System.Windows.Forms.TextBox();
            this.EmployeePhone = new System.Windows.Forms.TextBox();
            this.EmployeeEmail = new System.Windows.Forms.TextBox();
            this.EmployeeFirstName = new System.Windows.Forms.TextBox();
            this.EmployeeLastName = new System.Windows.Forms.TextBox();
            this.EmployeeType_choose = new System.Windows.Forms.ComboBox();
            this.employeeBirthDate = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.invalidEmail = new System.Windows.Forms.Label();
            this.invalidPhone = new System.Windows.Forms.Label();
            this.invalid_ID = new System.Windows.Forms.Label();
            this.invalidBD = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // create_Employee
            // 
            this.create_Employee.Font = new System.Drawing.Font("Aharoni", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.create_Employee.Location = new System.Drawing.Point(608, 624);
            this.create_Employee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.create_Employee.Name = "create_Employee";
            this.create_Employee.Size = new System.Drawing.Size(225, 62);
            this.create_Employee.TabIndex = 0;
            this.create_Employee.Text = "create employee";
            this.create_Employee.UseVisualStyleBackColor = true;
            this.create_Employee.Click += new System.EventHandler(this.create_Employee_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Aharoni", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(475, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "employeeID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Aharoni", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(518, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Aharoni", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(529, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Aharoni", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(503, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 28);
            this.label4.TabIndex = 4;
            this.label4.Text = "first name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Aharoni", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.Location = new System.Drawing.Point(503, 399);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 28);
            this.label5.TabIndex = 5;
            this.label5.Text = "last name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Aharoni", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.Location = new System.Drawing.Point(503, 478);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 28);
            this.label6.TabIndex = 6;
            this.label6.Text = "Birth Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Aharoni", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.Location = new System.Drawing.Point(547, 552);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 24);
            this.label7.TabIndex = 7;
            this.label7.Text = "Type";
            // 
            // EmployeeID
            // 
            this.EmployeeID.Location = new System.Drawing.Point(673, 122);
            this.EmployeeID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EmployeeID.Name = "EmployeeID";
            this.EmployeeID.Size = new System.Drawing.Size(200, 26);
            this.EmployeeID.TabIndex = 8;
            this.EmployeeID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // EmployeePhone
            // 
            this.EmployeePhone.Location = new System.Drawing.Point(673, 189);
            this.EmployeePhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EmployeePhone.Name = "EmployeePhone";
            this.EmployeePhone.Size = new System.Drawing.Size(200, 26);
            this.EmployeePhone.TabIndex = 9;
            this.EmployeePhone.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // EmployeeEmail
            // 
            this.EmployeeEmail.Location = new System.Drawing.Point(672, 260);
            this.EmployeeEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EmployeeEmail.Name = "EmployeeEmail";
            this.EmployeeEmail.Size = new System.Drawing.Size(201, 26);
            this.EmployeeEmail.TabIndex = 10;
            this.EmployeeEmail.TextChanged += new System.EventHandler(this.EmployeeEmail_TextChanged);
            // 
            // EmployeeFirstName
            // 
            this.EmployeeFirstName.Location = new System.Drawing.Point(672, 328);
            this.EmployeeFirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EmployeeFirstName.Name = "EmployeeFirstName";
            this.EmployeeFirstName.Size = new System.Drawing.Size(201, 26);
            this.EmployeeFirstName.TabIndex = 11;
            this.EmployeeFirstName.TextChanged += new System.EventHandler(this.EmployeeFirstName_TextChanged);
            // 
            // EmployeeLastName
            // 
            this.EmployeeLastName.Location = new System.Drawing.Point(672, 400);
            this.EmployeeLastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EmployeeLastName.Name = "EmployeeLastName";
            this.EmployeeLastName.Size = new System.Drawing.Size(201, 26);
            this.EmployeeLastName.TabIndex = 12;
            this.EmployeeLastName.TextChanged += new System.EventHandler(this.EmployeeLastName_TextChanged);
            // 
            // EmployeeType_choose
            // 
            this.EmployeeType_choose.FormattingEnabled = true;
            this.EmployeeType_choose.Location = new System.Drawing.Point(673, 552);
            this.EmployeeType_choose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EmployeeType_choose.Name = "EmployeeType_choose";
            this.EmployeeType_choose.Size = new System.Drawing.Size(203, 28);
            this.EmployeeType_choose.TabIndex = 14;
            this.EmployeeType_choose.SelectedIndexChanged += new System.EventHandler(this.EmployeeType_choose_SelectedIndexChanged);
            // 
            // employeeBirthDate
            // 
            this.employeeBirthDate.CustomFormat = "yyyy-MM-dd";
            this.employeeBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.employeeBirthDate.Location = new System.Drawing.Point(673, 479);
            this.employeeBirthDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.employeeBirthDate.Name = "employeeBirthDate";
            this.employeeBirthDate.Size = new System.Drawing.Size(200, 26);
            this.employeeBirthDate.TabIndex = 15;
            this.employeeBirthDate.ValueChanged += new System.EventHandler(this.employeeBirthDate_ValueChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Aharoni", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button1.Location = new System.Drawing.Point(35, 724);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 62);
            this.button1.TabIndex = 16;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // invalidEmail
            // 
           this.invalidEmail.AutoSize = true;
            this.invalidEmail.ForeColor = System.Drawing.Color.Red;
            this.invalidEmail.Location = new System.Drawing.Point(668, 290);
            this.invalidEmail.Name = "invalidEmail";
            this.invalidEmail.Size = new System.Drawing.Size(323, 20);
            this.invalidEmail.TabIndex = 17;
            this.invalidEmail.Text = "Email format: \" ***@***.com / org / co.il / gov \"";
            this.invalidEmail.Click += new System.EventHandler(this.invalidEmail_Click);
            // 
            // invalidPhone
            // 
            this.invalidPhone.AutoSize = true;
            this.invalidPhone.ForeColor = System.Drawing.Color.Red;
            this.invalidPhone.Location = new System.Drawing.Point(669, 219);
            this.invalidPhone.Name = "invalidPhone";
            this.invalidPhone.Size = new System.Drawing.Size(271, 20);
            this.invalidPhone.TabIndex = 18;
            this.invalidPhone.Text = "Phone number must contain 10 digits";
            this.invalidPhone.Click += new System.EventHandler(this.invalidPhone_Click);
            // 
            // invalid_ID
            // 
            this.invalid_ID.AutoSize = true;
            this.invalid_ID.ForeColor = System.Drawing.Color.Red;
            this.invalid_ID.Location = new System.Drawing.Point(669, 150);
            this.invalid_ID.Name = "invalid_ID";
            this.invalid_ID.Size = new System.Drawing.Size(175, 20);
            this.invalid_ID.TabIndex = 19;
            this.invalid_ID.Text = "ID must contain 9 digits";
            this.invalid_ID.Click += new System.EventHandler(this.label8_Click);
            // 
            // invalidBD
            // 
            this.invalidBD.AutoSize = true;
            this.invalidBD.ForeColor = System.Drawing.Color.Red;
            this.invalidBD.Location = new System.Drawing.Point(669, 507);
            this.invalidBD.Name = "invalidBD";
            this.invalidBD.Size = new System.Drawing.Size(259, 20);
            this.invalidBD.TabIndex = 20;
            this.invalidBD.Text = "Birth Date must be erlier than today";
            // */
            // CreateEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1442, 816);
           this.Controls.Add(this.invalidBD);
            this.Controls.Add(this.invalid_ID);
            this.Controls.Add(this.invalidPhone);
            this.Controls.Add(this.invalidEmail);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.employeeBirthDate);
            this.Controls.Add(this.EmployeeType_choose);
            this.Controls.Add(this.EmployeeLastName);
            this.Controls.Add(this.EmployeeFirstName);
            this.Controls.Add(this.EmployeeEmail);
            this.Controls.Add(this.EmployeePhone);
            this.Controls.Add(this.EmployeeID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.create_Employee);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CreateEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button create_Employee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox EmployeeID;
        private System.Windows.Forms.TextBox EmployeePhone;
        private System.Windows.Forms.TextBox EmployeeEmail;
        private System.Windows.Forms.TextBox EmployeeFirstName;
        private System.Windows.Forms.TextBox EmployeeLastName;
        private System.Windows.Forms.ComboBox EmployeeType_choose;
        private System.Windows.Forms.DateTimePicker employeeBirthDate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label invalidEmail;
        private System.Windows.Forms.Label invalidPhone;
        private System.Windows.Forms.Label invalid_ID;
        private System.Windows.Forms.Label invalidBD;
    }
}