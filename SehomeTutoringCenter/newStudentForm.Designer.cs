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
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.AddStudentButton = new System.Windows.Forms.Button();
            this.studentDataGroupBox = new System.Windows.Forms.GroupBox();
            this.RadioBtnPanel = new System.Windows.Forms.Panel();
            this.FreshmanLabel = new System.Windows.Forms.RadioButton();
            this.SeniorLabel = new System.Windows.Forms.RadioButton();
            this.SophomoreLabel = new System.Windows.Forms.RadioButton();
            this.JuniorLabel = new System.Windows.Forms.RadioButton();
            this.gradeLevel = new System.Windows.Forms.Label();
            this.ClassGroupBox = new System.Windows.Forms.GroupBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.studentDataGroupBox.SuspendLayout();
            this.RadioBtnPanel.SuspendLayout();
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
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(108, 46);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(173, 26);
            this.FirstNameTextBox.TabIndex = 1;
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(108, 88);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(173, 26);
            this.LastNameTextBox.TabIndex = 3;
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
            // AddStudentButton
            // 
            this.AddStudentButton.BackColor = System.Drawing.Color.Green;
            this.AddStudentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddStudentButton.ForeColor = System.Drawing.Color.White;
            this.AddStudentButton.Location = new System.Drawing.Point(103, 264);
            this.AddStudentButton.Name = "AddStudentButton";
            this.AddStudentButton.Size = new System.Drawing.Size(124, 37);
            this.AddStudentButton.TabIndex = 4;
            this.AddStudentButton.Text = "Add Student";
            this.AddStudentButton.UseVisualStyleBackColor = false;
            this.AddStudentButton.Click += new System.EventHandler(this.AddStudentButton_Click);
            // 
            // studentDataGroupBox
            // 
            this.studentDataGroupBox.Controls.Add(this.RadioBtnPanel);
            this.studentDataGroupBox.Controls.Add(this.gradeLevel);
            this.studentDataGroupBox.Controls.Add(this.firstNameLabel);
            this.studentDataGroupBox.Controls.Add(this.AddStudentButton);
            this.studentDataGroupBox.Controls.Add(this.FirstNameTextBox);
            this.studentDataGroupBox.Controls.Add(this.LastNameTextBox);
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
            // RadioBtnPanel
            // 
            this.RadioBtnPanel.Controls.Add(this.FreshmanLabel);
            this.RadioBtnPanel.Controls.Add(this.SeniorLabel);
            this.RadioBtnPanel.Controls.Add(this.SophomoreLabel);
            this.RadioBtnPanel.Controls.Add(this.JuniorLabel);
            this.RadioBtnPanel.Location = new System.Drawing.Point(91, 128);
            this.RadioBtnPanel.Name = "RadioBtnPanel";
            this.RadioBtnPanel.Size = new System.Drawing.Size(145, 124);
            this.RadioBtnPanel.TabIndex = 10;
            // 
            // FreshmanLabel
            // 
            this.FreshmanLabel.AutoSize = true;
            this.FreshmanLabel.Location = new System.Drawing.Point(20, 3);
            this.FreshmanLabel.Name = "FreshmanLabel";
            this.FreshmanLabel.Size = new System.Drawing.Size(99, 24);
            this.FreshmanLabel.TabIndex = 6;
            this.FreshmanLabel.TabStop = true;
            this.FreshmanLabel.Text = "Freshman";
            this.FreshmanLabel.UseVisualStyleBackColor = true;
            // 
            // SeniorLabel
            // 
            this.SeniorLabel.AutoSize = true;
            this.SeniorLabel.Location = new System.Drawing.Point(20, 93);
            this.SeniorLabel.Name = "SeniorLabel";
            this.SeniorLabel.Size = new System.Drawing.Size(73, 24);
            this.SeniorLabel.TabIndex = 9;
            this.SeniorLabel.TabStop = true;
            this.SeniorLabel.Text = "Senior";
            this.SeniorLabel.UseVisualStyleBackColor = true;
            // 
            // SophomoreLabel
            // 
            this.SophomoreLabel.AutoSize = true;
            this.SophomoreLabel.Location = new System.Drawing.Point(20, 33);
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
            this.JuniorLabel.Location = new System.Drawing.Point(20, 63);
            this.JuniorLabel.Name = "JuniorLabel";
            this.JuniorLabel.Size = new System.Drawing.Size(70, 24);
            this.JuniorLabel.TabIndex = 8;
            this.JuniorLabel.TabStop = true;
            this.JuniorLabel.Text = "Junior";
            this.JuniorLabel.UseVisualStyleBackColor = true;
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
            // ClassGroupBox
            // 
            this.ClassGroupBox.Controls.Add(this.comboBox6);
            this.ClassGroupBox.Controls.Add(this.label6);
            this.ClassGroupBox.Controls.Add(this.comboBox5);
            this.ClassGroupBox.Controls.Add(this.label5);
            this.ClassGroupBox.Controls.Add(this.comboBox4);
            this.ClassGroupBox.Controls.Add(this.label4);
            this.ClassGroupBox.Controls.Add(this.comboBox3);
            this.ClassGroupBox.Controls.Add(this.label3);
            this.ClassGroupBox.Controls.Add(this.comboBox2);
            this.ClassGroupBox.Controls.Add(this.label2);
            this.ClassGroupBox.Controls.Add(this.comboBox1);
            this.ClassGroupBox.Controls.Add(this.label1);
            this.ClassGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassGroupBox.Location = new System.Drawing.Point(353, 23);
            this.ClassGroupBox.Name = "ClassGroupBox";
            this.ClassGroupBox.Size = new System.Drawing.Size(416, 326);
            this.ClassGroupBox.TabIndex = 6;
            this.ClassGroupBox.TabStop = false;
            this.ClassGroupBox.Text = "Class List";
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(83, 273);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(309, 28);
            this.comboBox6.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Class 6";
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(83, 221);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(309, 28);
            this.comboBox5.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Class 5";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(83, 171);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(309, 28);
            this.comboBox4.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Class 4";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(83, 124);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(309, 28);
            this.comboBox3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Class 3";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(83, 77);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(309, 28);
            this.comboBox2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Class 2";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(83, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(309, 28);
            this.comboBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Class 1";
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
            this.RadioBtnPanel.ResumeLayout(false);
            this.RadioBtnPanel.PerformLayout();
            this.ClassGroupBox.ResumeLayout(false);
            this.ClassGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Button AddStudentButton;
        public System.Windows.Forms.TextBox FirstNameTextBox;
        public System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.GroupBox studentDataGroupBox;
        private System.Windows.Forms.RadioButton SeniorLabel;
        private System.Windows.Forms.RadioButton JuniorLabel;
        private System.Windows.Forms.RadioButton SophomoreLabel;
        private System.Windows.Forms.RadioButton FreshmanLabel;
        private System.Windows.Forms.Label gradeLevel;
        private System.Windows.Forms.GroupBox ClassGroupBox;
        private System.Windows.Forms.Panel RadioBtnPanel;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
    }
}