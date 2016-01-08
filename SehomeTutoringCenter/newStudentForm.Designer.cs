namespace SehomeTutoringCenter
{
    partial class newStudentForm
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
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.addStudentButton = new System.Windows.Forms.Button();
            this.studentDataGroupBox = new System.Windows.Forms.GroupBox();
            this.gradeLevel = new System.Windows.Forms.Label();
            this.FreshmanLabel = new System.Windows.Forms.RadioButton();
            this.SophomoreLabel = new System.Windows.Forms.RadioButton();
            this.JuniorLabel = new System.Windows.Forms.RadioButton();
            this.SeniorLabel = new System.Windows.Forms.RadioButton();
            this.ClassGroupBox = new System.Windows.Forms.GroupBox();
            this.ClassLabel = new System.Windows.Forms.Label();
            this.TeacherNameLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.studentDataGroupBox.SuspendLayout();
            this.ClassGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLabel.Location = new System.Drawing.Point(21, 45);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(81, 18);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "First Name";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(108, 46);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(173, 26);
            this.firstNameTextBox.TabIndex = 1;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(108, 88);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(173, 26);
            this.lastNameTextBox.TabIndex = 3;
            this.lastNameTextBox.TextChanged += new System.EventHandler(this.lastNameTextBox_TextChanged);
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLabel.Location = new System.Drawing.Point(21, 87);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(80, 18);
            this.lastNameLabel.TabIndex = 2;
            this.lastNameLabel.Text = "Last Name";
            // 
            // addStudentButton
            // 
            this.addStudentButton.BackColor = System.Drawing.Color.Green;
            this.addStudentButton.Enabled = false;
            this.addStudentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStudentButton.ForeColor = System.Drawing.Color.White;
            this.addStudentButton.Location = new System.Drawing.Point(103, 264);
            this.addStudentButton.Name = "addStudentButton";
            this.addStudentButton.Size = new System.Drawing.Size(124, 37);
            this.addStudentButton.TabIndex = 4;
            this.addStudentButton.Text = "Add Student";
            this.addStudentButton.UseVisualStyleBackColor = false;
            this.addStudentButton.Click += new System.EventHandler(this.addStudentButton_Click);
            // 
            // studentDataGroupBox
            // 
            this.studentDataGroupBox.Controls.Add(this.SeniorLabel);
            this.studentDataGroupBox.Controls.Add(this.JuniorLabel);
            this.studentDataGroupBox.Controls.Add(this.SophomoreLabel);
            this.studentDataGroupBox.Controls.Add(this.FreshmanLabel);
            this.studentDataGroupBox.Controls.Add(this.gradeLevel);
            this.studentDataGroupBox.Controls.Add(this.firstNameLabel);
            this.studentDataGroupBox.Controls.Add(this.addStudentButton);
            this.studentDataGroupBox.Controls.Add(this.firstNameTextBox);
            this.studentDataGroupBox.Controls.Add(this.lastNameTextBox);
            this.studentDataGroupBox.Controls.Add(this.lastNameLabel);
            this.studentDataGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentDataGroupBox.Location = new System.Drawing.Point(12, 23);
            this.studentDataGroupBox.Name = "studentDataGroupBox";
            this.studentDataGroupBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.studentDataGroupBox.Size = new System.Drawing.Size(324, 326);
            this.studentDataGroupBox.TabIndex = 5;
            this.studentDataGroupBox.TabStop = false;
            this.studentDataGroupBox.Text = "Student Information";
            // 
            // gradeLevel
            // 
            this.gradeLevel.AutoSize = true;
            this.gradeLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradeLevel.Location = new System.Drawing.Point(22, 128);
            this.gradeLevel.Name = "gradeLevel";
            this.gradeLevel.Size = new System.Drawing.Size(49, 18);
            this.gradeLevel.TabIndex = 5;
            this.gradeLevel.Text = "Grade";
            // 
            // FreshmanLabel
            // 
            this.FreshmanLabel.AutoSize = true;
            this.FreshmanLabel.Location = new System.Drawing.Point(108, 128);
            this.FreshmanLabel.Name = "FreshmanLabel";
            this.FreshmanLabel.Size = new System.Drawing.Size(99, 24);
            this.FreshmanLabel.TabIndex = 6;
            this.FreshmanLabel.TabStop = true;
            this.FreshmanLabel.Text = "Freshman";
            this.FreshmanLabel.UseVisualStyleBackColor = true;
            // 
            // SophomoreLabel
            // 
            this.SophomoreLabel.AutoSize = true;
            this.SophomoreLabel.Location = new System.Drawing.Point(108, 158);
            this.SophomoreLabel.Name = "SophomoreLabel";
            this.SophomoreLabel.Size = new System.Drawing.Size(110, 24);
            this.SophomoreLabel.TabIndex = 7;
            this.SophomoreLabel.TabStop = true;
            this.SophomoreLabel.Text = "Sophomore";
            this.SophomoreLabel.UseVisualStyleBackColor = true;
            // 
            // JuniorLabel
            // 
            this.JuniorLabel.AutoSize = true;
            this.JuniorLabel.Location = new System.Drawing.Point(108, 188);
            this.JuniorLabel.Name = "JuniorLabel";
            this.JuniorLabel.Size = new System.Drawing.Size(70, 24);
            this.JuniorLabel.TabIndex = 8;
            this.JuniorLabel.TabStop = true;
            this.JuniorLabel.Text = "Junior";
            this.JuniorLabel.UseVisualStyleBackColor = true;
            // 
            // SeniorLabel
            // 
            this.SeniorLabel.AutoSize = true;
            this.SeniorLabel.Location = new System.Drawing.Point(108, 218);
            this.SeniorLabel.Name = "SeniorLabel";
            this.SeniorLabel.Size = new System.Drawing.Size(73, 24);
            this.SeniorLabel.TabIndex = 9;
            this.SeniorLabel.TabStop = true;
            this.SeniorLabel.Text = "Senior";
            this.SeniorLabel.UseVisualStyleBackColor = true;
            // 
            // ClassGroupBox
            // 
            this.ClassGroupBox.Controls.Add(this.textBox11);
            this.ClassGroupBox.Controls.Add(this.textBox12);
            this.ClassGroupBox.Controls.Add(this.textBox9);
            this.ClassGroupBox.Controls.Add(this.textBox10);
            this.ClassGroupBox.Controls.Add(this.textBox7);
            this.ClassGroupBox.Controls.Add(this.textBox8);
            this.ClassGroupBox.Controls.Add(this.textBox5);
            this.ClassGroupBox.Controls.Add(this.textBox6);
            this.ClassGroupBox.Controls.Add(this.textBox3);
            this.ClassGroupBox.Controls.Add(this.textBox4);
            this.ClassGroupBox.Controls.Add(this.textBox2);
            this.ClassGroupBox.Controls.Add(this.textBox1);
            this.ClassGroupBox.Controls.Add(this.TeacherNameLabel);
            this.ClassGroupBox.Controls.Add(this.ClassLabel);
            this.ClassGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassGroupBox.Location = new System.Drawing.Point(353, 23);
            this.ClassGroupBox.Name = "ClassGroupBox";
            this.ClassGroupBox.Size = new System.Drawing.Size(416, 326);
            this.ClassGroupBox.TabIndex = 6;
            this.ClassGroupBox.TabStop = false;
            this.ClassGroupBox.Text = "Class List";
            // 
            // ClassLabel
            // 
            this.ClassLabel.AutoSize = true;
            this.ClassLabel.Location = new System.Drawing.Point(19, 34);
            this.ClassLabel.Name = "ClassLabel";
            this.ClassLabel.Size = new System.Drawing.Size(48, 20);
            this.ClassLabel.TabIndex = 0;
            this.ClassLabel.Text = "Class";
            // 
            // TeacherNameLabel
            // 
            this.TeacherNameLabel.AutoSize = true;
            this.TeacherNameLabel.Location = new System.Drawing.Point(211, 34);
            this.TeacherNameLabel.Name = "TeacherNameLabel";
            this.TeacherNameLabel.Size = new System.Drawing.Size(67, 20);
            this.TeacherNameLabel.TabIndex = 1;
            this.TeacherNameLabel.Text = "Teacher";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(23, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(175, 26);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(215, 57);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(175, 26);
            this.textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(215, 98);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(175, 26);
            this.textBox3.TabIndex = 5;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(23, 98);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(175, 26);
            this.textBox4.TabIndex = 4;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(215, 142);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(175, 26);
            this.textBox5.TabIndex = 7;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(23, 142);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(175, 26);
            this.textBox6.TabIndex = 6;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(215, 186);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(175, 26);
            this.textBox7.TabIndex = 9;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(23, 186);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(175, 26);
            this.textBox8.TabIndex = 8;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(215, 230);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(175, 26);
            this.textBox9.TabIndex = 11;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(23, 230);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(175, 26);
            this.textBox10.TabIndex = 10;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(215, 275);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(175, 26);
            this.textBox11.TabIndex = 13;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(23, 275);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(175, 26);
            this.textBox12.TabIndex = 12;
            // 
            // newStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.ClassGroupBox);
            this.Controls.Add(this.studentDataGroupBox);
            this.MaximumSize = new System.Drawing.Size(800, 400);
            this.MinimumSize = new System.Drawing.Size(800, 400);
            this.Name = "newStudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add New Student";
            this.studentDataGroupBox.ResumeLayout(false);
            this.studentDataGroupBox.PerformLayout();
            this.ClassGroupBox.ResumeLayout(false);
            this.ClassGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Button addStudentButton;
        public System.Windows.Forms.TextBox firstNameTextBox;
        public System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.GroupBox studentDataGroupBox;
        private System.Windows.Forms.RadioButton SeniorLabel;
        private System.Windows.Forms.RadioButton JuniorLabel;
        private System.Windows.Forms.RadioButton SophomoreLabel;
        private System.Windows.Forms.RadioButton FreshmanLabel;
        private System.Windows.Forms.Label gradeLevel;
        private System.Windows.Forms.GroupBox ClassGroupBox;
        private System.Windows.Forms.Label TeacherNameLabel;
        private System.Windows.Forms.Label ClassLabel;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}