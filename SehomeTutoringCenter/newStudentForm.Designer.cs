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
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Class1 = new System.Windows.Forms.TextBox();
            this.Teacher1 = new System.Windows.Forms.TextBox();
            this.TeacherNameLabel = new System.Windows.Forms.Label();
            this.ClassLabel = new System.Windows.Forms.Label();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.Class2 = new System.Windows.Forms.TextBox();
            this.Teacher2 = new System.Windows.Forms.TextBox();
            this.Panel3 = new System.Windows.Forms.Panel();
            this.Class3 = new System.Windows.Forms.TextBox();
            this.Teacher3 = new System.Windows.Forms.TextBox();
            this.Panel4 = new System.Windows.Forms.Panel();
            this.Class4 = new System.Windows.Forms.TextBox();
            this.Teacher4 = new System.Windows.Forms.TextBox();
            this.Panel5 = new System.Windows.Forms.Panel();
            this.Class5 = new System.Windows.Forms.TextBox();
            this.Teacher5 = new System.Windows.Forms.TextBox();
            this.Panel6 = new System.Windows.Forms.Panel();
            this.Class6 = new System.Windows.Forms.TextBox();
            this.Teacher6 = new System.Windows.Forms.TextBox();
            this.studentDataGroupBox.SuspendLayout();
            this.RadioBtnPanel.SuspendLayout();
            this.ClassGroupBox.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.Panel3.SuspendLayout();
            this.Panel4.SuspendLayout();
            this.Panel5.SuspendLayout();
            this.Panel6.SuspendLayout();
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
            this.AddStudentButton.Click += new System.EventHandler(this.addStudentButton_Click);
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
            this.ClassGroupBox.Controls.Add(this.Panel6);
            this.ClassGroupBox.Controls.Add(this.Panel5);
            this.ClassGroupBox.Controls.Add(this.Panel4);
            this.ClassGroupBox.Controls.Add(this.Panel3);
            this.ClassGroupBox.Controls.Add(this.Panel2);
            this.ClassGroupBox.Controls.Add(this.Panel1);
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
            // Panel1
            // 
            this.Panel1.Controls.Add(this.Class1);
            this.Panel1.Controls.Add(this.Teacher1);
            this.Panel1.Location = new System.Drawing.Point(23, 57);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(367, 26);
            this.Panel1.TabIndex = 14;
            // 
            // Class1
            // 
            this.Class1.Location = new System.Drawing.Point(0, 0);
            this.Class1.Name = "Class1";
            this.Class1.Size = new System.Drawing.Size(175, 26);
            this.Class1.TabIndex = 2;
            // 
            // Teacher1
            // 
            this.Teacher1.Location = new System.Drawing.Point(192, 0);
            this.Teacher1.Name = "Teacher1";
            this.Teacher1.Size = new System.Drawing.Size(175, 26);
            this.Teacher1.TabIndex = 3;
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
            // ClassLabel
            // 
            this.ClassLabel.AutoSize = true;
            this.ClassLabel.Location = new System.Drawing.Point(19, 34);
            this.ClassLabel.Name = "ClassLabel";
            this.ClassLabel.Size = new System.Drawing.Size(48, 20);
            this.ClassLabel.TabIndex = 0;
            this.ClassLabel.Text = "Class";
            // 
            // Panel2
            // 
            this.Panel2.Controls.Add(this.Class2);
            this.Panel2.Controls.Add(this.Teacher2);
            this.Panel2.Location = new System.Drawing.Point(23, 99);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(367, 26);
            this.Panel2.TabIndex = 15;
            // 
            // Class2
            // 
            this.Class2.Location = new System.Drawing.Point(0, 0);
            this.Class2.Name = "Class2";
            this.Class2.Size = new System.Drawing.Size(175, 26);
            this.Class2.TabIndex = 2;
            // 
            // Teacher2
            // 
            this.Teacher2.Location = new System.Drawing.Point(192, 0);
            this.Teacher2.Name = "Teacher2";
            this.Teacher2.Size = new System.Drawing.Size(175, 26);
            this.Teacher2.TabIndex = 3;
            // 
            // Panel3
            // 
            this.Panel3.Controls.Add(this.Class3);
            this.Panel3.Controls.Add(this.Teacher3);
            this.Panel3.Location = new System.Drawing.Point(23, 142);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(367, 26);
            this.Panel3.TabIndex = 15;
            // 
            // Class3
            // 
            this.Class3.Location = new System.Drawing.Point(0, 0);
            this.Class3.Name = "Class3";
            this.Class3.Size = new System.Drawing.Size(175, 26);
            this.Class3.TabIndex = 2;
            // 
            // Teacher3
            // 
            this.Teacher3.Location = new System.Drawing.Point(192, 0);
            this.Teacher3.Name = "Teacher3";
            this.Teacher3.Size = new System.Drawing.Size(175, 26);
            this.Teacher3.TabIndex = 3;
            // 
            // Panel4
            // 
            this.Panel4.Controls.Add(this.Class4);
            this.Panel4.Controls.Add(this.Teacher4);
            this.Panel4.Location = new System.Drawing.Point(23, 189);
            this.Panel4.Name = "Panel4";
            this.Panel4.Size = new System.Drawing.Size(367, 26);
            this.Panel4.TabIndex = 15;
            // 
            // Class4
            // 
            this.Class4.Location = new System.Drawing.Point(0, 0);
            this.Class4.Name = "Class4";
            this.Class4.Size = new System.Drawing.Size(175, 26);
            this.Class4.TabIndex = 2;
            // 
            // Teacher4
            // 
            this.Teacher4.Location = new System.Drawing.Point(192, 0);
            this.Teacher4.Name = "Teacher4";
            this.Teacher4.Size = new System.Drawing.Size(175, 26);
            this.Teacher4.TabIndex = 3;
            // 
            // Panel5
            // 
            this.Panel5.Controls.Add(this.Class5);
            this.Panel5.Controls.Add(this.Teacher5);
            this.Panel5.Location = new System.Drawing.Point(23, 235);
            this.Panel5.Name = "Panel5";
            this.Panel5.Size = new System.Drawing.Size(367, 26);
            this.Panel5.TabIndex = 15;
            // 
            // Class5
            // 
            this.Class5.Location = new System.Drawing.Point(0, 0);
            this.Class5.Name = "Class5";
            this.Class5.Size = new System.Drawing.Size(175, 26);
            this.Class5.TabIndex = 2;
            // 
            // Teacher5
            // 
            this.Teacher5.Location = new System.Drawing.Point(192, 0);
            this.Teacher5.Name = "Teacher5";
            this.Teacher5.Size = new System.Drawing.Size(175, 26);
            this.Teacher5.TabIndex = 3;
            // 
            // Panel6
            // 
            this.Panel6.Controls.Add(this.Class6);
            this.Panel6.Controls.Add(this.Teacher6);
            this.Panel6.Location = new System.Drawing.Point(23, 275);
            this.Panel6.Name = "Panel6";
            this.Panel6.Size = new System.Drawing.Size(367, 26);
            this.Panel6.TabIndex = 15;
            // 
            // Class6
            // 
            this.Class6.Location = new System.Drawing.Point(0, 0);
            this.Class6.Name = "Class6";
            this.Class6.Size = new System.Drawing.Size(175, 26);
            this.Class6.TabIndex = 2;
            // 
            // Teacher6
            // 
            this.Teacher6.Location = new System.Drawing.Point(192, 0);
            this.Teacher6.Name = "Teacher6";
            this.Teacher6.Size = new System.Drawing.Size(175, 26);
            this.Teacher6.TabIndex = 3;
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
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.Panel3.ResumeLayout(false);
            this.Panel3.PerformLayout();
            this.Panel4.ResumeLayout(false);
            this.Panel4.PerformLayout();
            this.Panel5.ResumeLayout(false);
            this.Panel5.PerformLayout();
            this.Panel6.ResumeLayout(false);
            this.Panel6.PerformLayout();
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
        private System.Windows.Forms.Label TeacherNameLabel;
        private System.Windows.Forms.Label ClassLabel;
        private System.Windows.Forms.TextBox Teacher1;
        private System.Windows.Forms.TextBox Class1;
        private System.Windows.Forms.Panel RadioBtnPanel;
        private System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.Panel Panel6;
        private System.Windows.Forms.TextBox Class6;
        private System.Windows.Forms.TextBox Teacher6;
        private System.Windows.Forms.Panel Panel5;
        private System.Windows.Forms.TextBox Class5;
        private System.Windows.Forms.TextBox Teacher5;
        private System.Windows.Forms.Panel Panel4;
        private System.Windows.Forms.TextBox Class4;
        private System.Windows.Forms.TextBox Teacher4;
        private System.Windows.Forms.Panel Panel3;
        private System.Windows.Forms.TextBox Class3;
        private System.Windows.Forms.TextBox Teacher3;
        private System.Windows.Forms.Panel Panel2;
        private System.Windows.Forms.TextBox Class2;
        private System.Windows.Forms.TextBox Teacher2;
    }
}