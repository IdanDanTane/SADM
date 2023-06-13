namespace Group_2
{
    partial class searchEMP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(searchEMP));
            this.search_Employee = new System.Windows.Forms.Button();
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
            this.back = new System.Windows.Forms.Button();
            this.deleteEMP = new System.Windows.Forms.Button();
            this.UpdateEMP = new System.Windows.Forms.Button();
            this.invalidPhone = new System.Windows.Forms.Label();
            this.invalidEmail = new System.Windows.Forms.Label();
            this.invalidBD = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // search_Employee
            // 
            this.search_Employee.Font = new System.Drawing.Font("Aharoni", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.search_Employee.Location = new System.Drawing.Point(256, 566);
            this.search_Employee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.search_Employee.Name = "search_Employee";
            this.search_Employee.Size = new System.Drawing.Size(212, 50);
            this.search_Employee.TabIndex = 0;
            this.search_Employee.Text = "search employee";
            this.search_Employee.UseVisualStyleBackColor = true;
            this.search_Employee.Click += new System.EventHandler(this.search_Employee_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Aharoni", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(370, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "employeeID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Aharoni", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(422, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Aharoni", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(422, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Aharoni", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(400, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "first name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Aharoni", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.Location = new System.Drawing.Point(403, 350);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "last name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Aharoni", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.Location = new System.Drawing.Point(392, 417);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 23);
            this.label6.TabIndex = 6;
            this.label6.Text = "Birth Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Aharoni", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.Location = new System.Drawing.Point(429, 471);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 23);
            this.label7.TabIndex = 7;
            this.label7.Text = "Type";
            // 
            // EmployeeID
            // 
            this.EmployeeID.Location = new System.Drawing.Point(533, 78);
            this.EmployeeID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EmployeeID.Name = "EmployeeID";
            this.EmployeeID.Size = new System.Drawing.Size(200, 22);
            this.EmployeeID.TabIndex = 8;
            this.EmployeeID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // EmployeePhone
            // 
            this.EmployeePhone.Location = new System.Drawing.Point(533, 148);
            this.EmployeePhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EmployeePhone.Name = "EmployeePhone";
            this.EmployeePhone.Size = new System.Drawing.Size(200, 22);
            this.EmployeePhone.TabIndex = 9;
            this.EmployeePhone.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // EmployeeEmail
            // 
            this.EmployeeEmail.Location = new System.Drawing.Point(533, 210);
            this.EmployeeEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EmployeeEmail.Name = "EmployeeEmail";
            this.EmployeeEmail.Size = new System.Drawing.Size(200, 22);
            this.EmployeeEmail.TabIndex = 10;
            this.EmployeeEmail.TextChanged += new System.EventHandler(this.EmployeeEmail_TextChanged);
            // 
            // EmployeeFirstName
            // 
            this.EmployeeFirstName.Location = new System.Drawing.Point(533, 281);
            this.EmployeeFirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EmployeeFirstName.Name = "EmployeeFirstName";
            this.EmployeeFirstName.Size = new System.Drawing.Size(200, 22);
            this.EmployeeFirstName.TabIndex = 11;
            this.EmployeeFirstName.TextChanged += new System.EventHandler(this.EmployeeFirstName_TextChanged);
            // 
            // EmployeeLastName
            // 
            this.EmployeeLastName.Location = new System.Drawing.Point(533, 347);
            this.EmployeeLastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EmployeeLastName.Name = "EmployeeLastName";
            this.EmployeeLastName.Size = new System.Drawing.Size(200, 22);
            this.EmployeeLastName.TabIndex = 12;
            this.EmployeeLastName.TextChanged += new System.EventHandler(this.EmployeeLastName_TextChanged);
            // 
            // EmployeeType_choose
            // 
            this.EmployeeType_choose.FormattingEnabled = true;
            this.EmployeeType_choose.Location = new System.Drawing.Point(533, 471);
            this.EmployeeType_choose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EmployeeType_choose.Name = "EmployeeType_choose";
            this.EmployeeType_choose.Size = new System.Drawing.Size(200, 24);
            this.EmployeeType_choose.TabIndex = 14;
            this.EmployeeType_choose.SelectedIndexChanged += new System.EventHandler(this.EmployeeType_choose_SelectedIndexChanged);
            // 
            // employeeBirthDate
            // 
            this.employeeBirthDate.CustomFormat = "yyyy-MM-dd";
            this.employeeBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.employeeBirthDate.Location = new System.Drawing.Point(533, 411);
            this.employeeBirthDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.employeeBirthDate.Name = "employeeBirthDate";
            this.employeeBirthDate.Size = new System.Drawing.Size(200, 22);
            this.employeeBirthDate.TabIndex = 15;
            this.employeeBirthDate.ValueChanged += new System.EventHandler(this.employeeBirthDate_ValueChanged);
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Aharoni", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.back.Location = new System.Drawing.Point(37, 575);
            this.back.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(120, 50);
            this.back.TabIndex = 16;
            this.back.Text = "back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.button1_Click);
            // 
            // deleteEMP
            // 
            this.deleteEMP.Font = new System.Drawing.Font("Aharoni", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.deleteEMP.Location = new System.Drawing.Point(533, 566);
            this.deleteEMP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteEMP.Name = "deleteEMP";
            this.deleteEMP.Size = new System.Drawing.Size(200, 50);
            this.deleteEMP.TabIndex = 17;
            this.deleteEMP.Text = "Delete employee";
            this.deleteEMP.UseVisualStyleBackColor = true;
            this.deleteEMP.Click += new System.EventHandler(this.deleteEMP_Click);
            // 
            // UpdateEMP
            // 
            this.UpdateEMP.Font = new System.Drawing.Font("Aharoni", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.UpdateEMP.Location = new System.Drawing.Point(786, 566);
            this.UpdateEMP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UpdateEMP.Name = "UpdateEMP";
            this.UpdateEMP.Size = new System.Drawing.Size(218, 50);
            this.UpdateEMP.TabIndex = 18;
            this.UpdateEMP.Text = "update employee";
            this.UpdateEMP.UseVisualStyleBackColor = true;
            this.UpdateEMP.Click += new System.EventHandler(this.UpdateEMP_Click);
            // 
            // invalidPhone
            // 
            this.invalidPhone.AutoSize = true;
            this.invalidPhone.ForeColor = System.Drawing.Color.Red;
            this.invalidPhone.Location = new System.Drawing.Point(483, 84);
            this.invalidPhone.Name = "invalidPhone";
            this.invalidPhone.Size = new System.Drawing.Size(271, 20);
            this.invalidPhone.TabIndex = 21;
            this.invalidPhone.Text = "Phone number must contain 10 digits";
            this.invalidPhone.Click += new System.EventHandler(this.invalidPhone_Click);
            // 
            // invalidEmail
            // 
            this.invalidEmail.AutoSize = true;
            this.invalidEmail.ForeColor = System.Drawing.Color.Red;
            this.invalidEmail.Location = new System.Drawing.Point(483, 123);
            this.invalidEmail.Name = "invalidEmail";
            this.invalidEmail.Size = new System.Drawing.Size(323, 20);
            this.invalidEmail.TabIndex = 22;
            this.invalidEmail.Text = "Email format: \" ***@***.com / org / co.il / gov \"";
            this.invalidEmail.Click += new System.EventHandler(this.invalidEmail_Click);
            // 
            // invalidBD
            // 
            this.invalidBD.AutoSize = true;
            this.invalidBD.ForeColor = System.Drawing.Color.Red;
            this.invalidBD.Location = new System.Drawing.Point(574, 238);
            this.invalidBD.Name = "invalidBD";
            this.invalidBD.Size = new System.Drawing.Size(259, 20);
            this.invalidBD.TabIndex = 23;
            this.invalidBD.Text = "Birth Date must be erlier than today";
            // 
            // searchEMP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1282, 653);

            this.Controls.Add(this.UpdateEMP);
            this.Controls.Add(this.deleteEMP);
            this.Controls.Add(this.back);
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
            this.Controls.Add(this.search_Employee);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "searchEMP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button search_Employee;
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
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button deleteEMP;
        private System.Windows.Forms.Button UpdateEMP;
        private System.Windows.Forms.Label invalidPhone;
        private System.Windows.Forms.Label invalidEmail;
        private System.Windows.Forms.Label invalidBD;
    }
}