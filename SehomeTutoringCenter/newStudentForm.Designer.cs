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
            this.studentDataGroupBox.SuspendLayout();
            this.RadioBtnPanel.SuspendLayout();
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
            this.ClassGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassGroupBox.Location = new System.Drawing.Point(353, 23);
            this.ClassGroupBox.Name = "ClassGroupBox";
            this.ClassGroupBox.Size = new System.Drawing.Size(416, 326);
            this.ClassGroupBox.TabIndex = 6;
            this.ClassGroupBox.TabStop = false;
            this.ClassGroupBox.Text = "Class List";
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
    }
}