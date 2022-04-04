
namespace UserRegistration2
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.submitButton1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.bloodGroupComboBox1 = new System.Windows.Forms.ComboBox();
            this.femaleRadioButton2 = new System.Windows.Forms.RadioButton();
            this.maleRadioButton1 = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.EmailTextBox4 = new System.Windows.Forms.TextBox();
            this.confirmPasswordTextBox3 = new System.Windows.Forms.TextBox();
            this.passwordTextBox2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.usernameTextBox1 = new System.Windows.Forms.TextBox();
            this.nameTextBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Aquamarine;
            this.groupBox1.Controls.Add(this.submitButton1);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.bloodGroupComboBox1);
            this.groupBox1.Controls.Add(this.femaleRadioButton2);
            this.groupBox1.Controls.Add(this.maleRadioButton1);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.EmailTextBox4);
            this.groupBox1.Controls.Add(this.confirmPasswordTextBox3);
            this.groupBox1.Controls.Add(this.passwordTextBox2);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.usernameTextBox1);
            this.groupBox1.Controls.Add(this.nameTextBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Location = new System.Drawing.Point(223, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registration";
            // 
            // submitButton1
            // 
            this.submitButton1.BackColor = System.Drawing.SystemColors.Highlight;
            this.submitButton1.Enabled = false;
            this.submitButton1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.submitButton1.Location = new System.Drawing.Point(125, 360);
            this.submitButton1.Name = "submitButton1";
            this.submitButton1.Size = new System.Drawing.Size(75, 31);
            this.submitButton1.TabIndex = 18;
            this.submitButton1.Text = "Submit";
            this.submitButton1.UseVisualStyleBackColor = false;
            this.submitButton1.Click += new System.EventHandler(this.submitButton1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(43, 319);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(277, 26);
            this.checkBox1.TabIndex = 17;
            this.checkBox1.Text = "I agree all the terms and conditions";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Click += new System.EventHandler(this.checkBox1_Click);
            // 
            // bloodGroupComboBox1
            // 
            this.bloodGroupComboBox1.FormattingEnabled = true;
            this.bloodGroupComboBox1.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-",
            "O+",
            "O-"});
            this.bloodGroupComboBox1.Location = new System.Drawing.Point(169, 269);
            this.bloodGroupComboBox1.Name = "bloodGroupComboBox1";
            this.bloodGroupComboBox1.Size = new System.Drawing.Size(121, 30);
            this.bloodGroupComboBox1.TabIndex = 16;
            // 
            // femaleRadioButton2
            // 
            this.femaleRadioButton2.AutoSize = true;
            this.femaleRadioButton2.Location = new System.Drawing.Point(241, 239);
            this.femaleRadioButton2.Name = "femaleRadioButton2";
            this.femaleRadioButton2.Size = new System.Drawing.Size(77, 26);
            this.femaleRadioButton2.TabIndex = 15;
            this.femaleRadioButton2.TabStop = true;
            this.femaleRadioButton2.Text = "Female";
            this.femaleRadioButton2.UseVisualStyleBackColor = true;
            // 
            // maleRadioButton1
            // 
            this.maleRadioButton1.AutoSize = true;
            this.maleRadioButton1.Location = new System.Drawing.Point(169, 239);
            this.maleRadioButton1.Name = "maleRadioButton1";
            this.maleRadioButton1.Size = new System.Drawing.Size(61, 26);
            this.maleRadioButton1.TabIndex = 14;
            this.maleRadioButton1.TabStop = true;
            this.maleRadioButton1.Text = "Male";
            this.maleRadioButton1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(169, 201);
            this.dateTimePicker1.MaxDate = new System.DateTime(2021, 7, 22, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(150, 28);
            this.dateTimePicker1.TabIndex = 13;
            this.dateTimePicker1.Value = new System.DateTime(2021, 7, 22, 0, 0, 0, 0);
            // 
            // EmailTextBox4
            // 
            this.EmailTextBox4.Location = new System.Drawing.Point(169, 166);
            this.EmailTextBox4.Name = "EmailTextBox4";
            this.EmailTextBox4.Size = new System.Drawing.Size(130, 28);
            this.EmailTextBox4.TabIndex = 12;
            // 
            // confirmPasswordTextBox3
            // 
            this.confirmPasswordTextBox3.Location = new System.Drawing.Point(169, 130);
            this.confirmPasswordTextBox3.Name = "confirmPasswordTextBox3";
            this.confirmPasswordTextBox3.PasswordChar = '*';
            this.confirmPasswordTextBox3.Size = new System.Drawing.Size(130, 28);
            this.confirmPasswordTextBox3.TabIndex = 11;
            // 
            // passwordTextBox2
            // 
            this.passwordTextBox2.Location = new System.Drawing.Point(169, 95);
            this.passwordTextBox2.Name = "passwordTextBox2";
            this.passwordTextBox2.PasswordChar = '*';
            this.passwordTextBox2.Size = new System.Drawing.Size(130, 28);
            this.passwordTextBox2.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 207);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 22);
            this.label8.TabIndex = 9;
            this.label8.Text = "Date of Birth";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(76, 243);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 22);
            this.label7.TabIndex = 8;
            this.label7.Text = "Gender";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 22);
            this.label6.TabIndex = 7;
            this.label6.Text = "Blood Group";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(91, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 22);
            this.label5.TabIndex = 6;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "Confirm Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Username";
            // 
            // usernameTextBox1
            // 
            this.usernameTextBox1.Location = new System.Drawing.Point(169, 62);
            this.usernameTextBox1.Name = "usernameTextBox1";
            this.usernameTextBox1.Size = new System.Drawing.Size(130, 28);
            this.usernameTextBox1.TabIndex = 2;
            // 
            // nameTextBox1
            // 
            this.nameTextBox1.Location = new System.Drawing.Point(169, 28);
            this.nameTextBox1.Name = "nameTextBox1";
            this.nameTextBox1.Size = new System.Drawing.Size(130, 28);
            this.nameTextBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Ragistration";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox EmailTextBox4;
        private System.Windows.Forms.TextBox confirmPasswordTextBox3;
        private System.Windows.Forms.TextBox passwordTextBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox usernameTextBox1;
        private System.Windows.Forms.TextBox nameTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button submitButton1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox bloodGroupComboBox1;
        private System.Windows.Forms.RadioButton femaleRadioButton2;
        private System.Windows.Forms.RadioButton maleRadioButton1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

