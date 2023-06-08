namespace Group_2
{
    partial class Create_fault
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
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.MTypeCh = new System.Windows.Forms.ComboBox();
            this.FTypeCh = new System.Windows.Forms.ComboBox();
            this.UtypeCh = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(256, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Machine Type";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(256, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fault Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(256, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Urgency";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(486, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 38);
            this.button1.TabIndex = 3;
            this.button1.Text = "Create Fault";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(238, 366);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 38);
            this.button2.TabIndex = 4;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MTypeCh
            // 
            this.MTypeCh.FormattingEnabled = true;
            this.MTypeCh.Location = new System.Drawing.Point(431, 103);
            this.MTypeCh.Name = "MTypeCh";
            this.MTypeCh.Size = new System.Drawing.Size(121, 28);
            this.MTypeCh.TabIndex = 5;
            this.MTypeCh.SelectedIndexChanged += new System.EventHandler(this.MTypeCh_SelectedIndexChanged);
            // 
            // FTypeCh
            // 
            this.FTypeCh.FormattingEnabled = true;
            this.FTypeCh.Location = new System.Drawing.Point(431, 170);
            this.FTypeCh.Name = "FTypeCh";
            this.FTypeCh.Size = new System.Drawing.Size(121, 28);
            this.FTypeCh.TabIndex = 6;
            this.FTypeCh.SelectedIndexChanged += new System.EventHandler(this.FTypeCh_SelectedIndexChanged);
            // 
            // UtypeCh
            // 
            this.UtypeCh.FormattingEnabled = true;
            this.UtypeCh.Location = new System.Drawing.Point(431, 246);
            this.UtypeCh.Name = "UtypeCh";
            this.UtypeCh.Size = new System.Drawing.Size(121, 28);
            this.UtypeCh.TabIndex = 7;
            // 
            // Create_fault
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UtypeCh);
            this.Controls.Add(this.FTypeCh);
            this.Controls.Add(this.MTypeCh);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Create_fault";
            this.Text = "Create_fault";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox MTypeCh;
        private System.Windows.Forms.ComboBox FTypeCh;
        private System.Windows.Forms.ComboBox UtypeCh;
    }
}