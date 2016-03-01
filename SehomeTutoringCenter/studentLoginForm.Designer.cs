namespace SehomeTutoringCenter
{
    partial class studentLoginForm
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
            this.checkIn = new System.Windows.Forms.Button();
            this.checkOut = new System.Windows.Forms.Button();
            this.CheckInVisitButton = new System.Windows.Forms.Button();
            this.studentsTab = new System.Windows.Forms.Button();
            this.centerTab = new System.Windows.Forms.Button();
            this.adminTab = new System.Windows.Forms.Button();
            this.studentNames = new System.Windows.Forms.ListBox();
            this.newStudentBtn = new System.Windows.Forms.Button();
            this.CourseSelectBox = new System.Windows.Forms.GroupBox();
            this.NewClassButton = new System.Windows.Forms.Button();
            this.NewClassComboBox = new System.Windows.Forms.ComboBox();
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.CancelButton = new System.Windows.Forms.Button();
            this.sehomeLogo = new System.Windows.Forms.PictureBox();
            this.loginBackdrop = new System.Windows.Forms.RichTextBox();
            this.CourseSelectBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sehomeLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // checkIn
            // 
            this.checkIn.BackColor = System.Drawing.Color.Green;
            this.checkIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.checkIn.Location = new System.Drawing.Point(733, 261);
            this.checkIn.Name = "checkIn";
            this.checkIn.Size = new System.Drawing.Size(260, 142);
            this.checkIn.TabIndex = 0;
            this.checkIn.Text = "Check In";
            this.checkIn.UseVisualStyleBackColor = false;
            this.checkIn.Click += new System.EventHandler(this.checkIn_Click);
            // 
            // checkOut
            // 
            this.checkOut.BackColor = System.Drawing.Color.Green;
            this.checkOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.checkOut.Location = new System.Drawing.Point(1000, 261);
            this.checkOut.Name = "checkOut";
            this.checkOut.Size = new System.Drawing.Size(260, 142);
            this.checkOut.TabIndex = 1;
            this.checkOut.Text = "Check Out";
            this.checkOut.UseVisualStyleBackColor = false;
            this.checkOut.Click += new System.EventHandler(this.checkOut_Click);
            // 
            // CheckInVisitButton
            // 
            this.CheckInVisitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckInVisitButton.Location = new System.Drawing.Point(734, 432);
            this.CheckInVisitButton.Name = "CheckInVisitButton";
            this.CheckInVisitButton.Size = new System.Drawing.Size(525, 55);
            this.CheckInVisitButton.TabIndex = 4;
            this.CheckInVisitButton.Text = "Students Subjects";
            this.CheckInVisitButton.UseVisualStyleBackColor = true;
            this.CheckInVisitButton.Click += new System.EventHandler(this.CheckInVisitButton_Click);
            // 
            // studentsTab
            // 
            this.studentsTab.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.studentsTab.BackColor = System.Drawing.SystemColors.Control;
            this.studentsTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentsTab.Location = new System.Drawing.Point(1864, 33);
            this.studentsTab.Name = "studentsTab";
            this.studentsTab.Size = new System.Drawing.Size(40, 300);
            this.studentsTab.TabIndex = 5;
            this.studentsTab.Text = "S\r\nT\r\nU\r\nD\r\nE\r\nN\r\nT\r\nS\r\n";
            this.studentsTab.UseVisualStyleBackColor = true;
            this.studentsTab.Click += new System.EventHandler(this.studentsTab_Click);
            // 
            // centerTab
            // 
            this.centerTab.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.centerTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.centerTab.Location = new System.Drawing.Point(1864, 351);
            this.centerTab.Name = "centerTab";
            this.centerTab.Size = new System.Drawing.Size(40, 300);
            this.centerTab.TabIndex = 6;
            this.centerTab.Text = "C\r\nE\r\nN\r\nT\r\nE\r\nR\r\n";
            this.centerTab.UseVisualStyleBackColor = true;
            this.centerTab.Click += new System.EventHandler(this.centerTab_Click);
            // 
            // adminTab
            // 
            this.adminTab.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.adminTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminTab.Location = new System.Drawing.Point(1864, 670);
            this.adminTab.Name = "adminTab";
            this.adminTab.Size = new System.Drawing.Size(40, 300);
            this.adminTab.TabIndex = 7;
            this.adminTab.Text = "A\r\nD\r\nM\r\nI\r\nN\r\n";
            this.adminTab.UseVisualStyleBackColor = true;
            this.adminTab.Click += new System.EventHandler(this.adminTab_Click);
            // 
            // studentNames
            // 
            this.studentNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentNames.FormattingEnabled = true;
            this.studentNames.ItemHeight = 29;
            this.studentNames.Location = new System.Drawing.Point(3, 57);
            this.studentNames.Name = "studentNames";
            this.studentNames.Size = new System.Drawing.Size(236, 816);
            this.studentNames.TabIndex = 8;
            this.studentNames.SelectedIndexChanged += new System.EventHandler(this.studentNames_SelectedIndexChanged);
            // 
            // newStudentBtn
            // 
            this.newStudentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newStudentBtn.Location = new System.Drawing.Point(34, 870);
            this.newStudentBtn.Name = "newStudentBtn";
            this.newStudentBtn.Size = new System.Drawing.Size(174, 52);
            this.newStudentBtn.TabIndex = 9;
            this.newStudentBtn.Text = "New Student";
            this.newStudentBtn.UseVisualStyleBackColor = true;
            this.newStudentBtn.Click += new System.EventHandler(this.newStudentBtn_Click);
            // 
            // CourseSelectBox
            // 
            this.CourseSelectBox.BackColor = System.Drawing.Color.White;
            this.CourseSelectBox.Controls.Add(this.NewClassButton);
            this.CourseSelectBox.Controls.Add(this.NewClassComboBox);
            this.CourseSelectBox.Controls.Add(this.WelcomeLabel);
            this.CourseSelectBox.Controls.Add(this.radioButton6);
            this.CourseSelectBox.Controls.Add(this.radioButton5);
            this.CourseSelectBox.Controls.Add(this.radioButton4);
            this.CourseSelectBox.Controls.Add(this.radioButton3);
            this.CourseSelectBox.Controls.Add(this.radioButton2);
            this.CourseSelectBox.Controls.Add(this.radioButton1);
            this.CourseSelectBox.Location = new System.Drawing.Point(733, 529);
            this.CourseSelectBox.Name = "CourseSelectBox";
            this.CourseSelectBox.Size = new System.Drawing.Size(526, 333);
            this.CourseSelectBox.TabIndex = 11;
            this.CourseSelectBox.TabStop = false;
            this.CourseSelectBox.Visible = false;
            // 
            // NewClassButton
            // 
            this.NewClassButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewClassButton.Location = new System.Drawing.Point(373, 283);
            this.NewClassButton.Name = "NewClassButton";
            this.NewClassButton.Size = new System.Drawing.Size(75, 30);
            this.NewClassButton.TabIndex = 13;
            this.NewClassButton.Text = "Add";
            this.NewClassButton.UseVisualStyleBackColor = true;
            this.NewClassButton.Visible = false;
            this.NewClassButton.Click += new System.EventHandler(this.NewClassButton_Click);
            // 
            // NewClassComboBox
            // 
            this.NewClassComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewClassComboBox.FormattingEnabled = true;
            this.NewClassComboBox.Location = new System.Drawing.Point(60, 284);
            this.NewClassComboBox.Name = "NewClassComboBox";
            this.NewClassComboBox.Size = new System.Drawing.Size(307, 28);
            this.NewClassComboBox.TabIndex = 7;
            this.NewClassComboBox.Visible = false;
            this.NewClassComboBox.SelectedIndexChanged += new System.EventHandler(this.NewClassComboBox_SelectedIndexChanged);
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLabel.Location = new System.Drawing.Point(34, 33);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(455, 24);
            this.WelcomeLabel.TabIndex = 6;
            this.WelcomeLabel.Text = "Welcome (name), what are you going to study today?";
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton6.Location = new System.Drawing.Point(305, 219);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(133, 28);
            this.radioButton6.TabIndex = 5;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "radioButton6";
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.Visible = false;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton5.Location = new System.Drawing.Point(305, 158);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(133, 28);
            this.radioButton5.TabIndex = 4;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "radioButton5";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.Visible = false;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton4.Location = new System.Drawing.Point(305, 94);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(133, 28);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "radioButton4";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.Visible = false;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.Location = new System.Drawing.Point(60, 219);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(133, 28);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.Visible = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(60, 158);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(133, 28);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.Visible = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(60, 94);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(133, 28);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.Visible = false;
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(1283, 432);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(113, 55);
            this.CancelButton.TabIndex = 12;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Visible = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // sehomeLogo
            // 
            this.sehomeLogo.Image = global::SehomeTutoringCenter.Properties.Resources.logo;
            this.sehomeLogo.Location = new System.Drawing.Point(922, 28);
            this.sehomeLogo.Name = "sehomeLogo";
            this.sehomeLogo.Size = new System.Drawing.Size(143, 197);
            this.sehomeLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sehomeLogo.TabIndex = 2;
            this.sehomeLogo.TabStop = false;
            // 
            // loginBackdrop
            // 
            this.loginBackdrop.BackColor = System.Drawing.Color.Silver;
            this.loginBackdrop.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.loginBackdrop.CausesValidation = false;
            this.loginBackdrop.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.loginBackdrop.Location = new System.Drawing.Point(715, 226);
            this.loginBackdrop.MaxLength = 0;
            this.loginBackdrop.Name = "loginBackdrop";
            this.loginBackdrop.ReadOnly = true;
            this.loginBackdrop.Size = new System.Drawing.Size(565, 209);
            this.loginBackdrop.TabIndex = 3;
            this.loginBackdrop.TabStop = false;
            this.loginBackdrop.Text = "";
            // 
            // studentLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1001);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.studentNames);
            this.Controls.Add(this.adminTab);
            this.Controls.Add(this.centerTab);
            this.Controls.Add(this.studentsTab);
            this.Controls.Add(this.checkOut);
            this.Controls.Add(this.checkIn);
            this.Controls.Add(this.newStudentBtn);
            this.Controls.Add(this.loginBackdrop);
            this.Controls.Add(this.CheckInVisitButton);
            this.Controls.Add(this.sehomeLogo);
            this.Controls.Add(this.CourseSelectBox);
            this.Name = "studentLoginForm";
            this.Text = "SLC Attendence System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.CourseSelectBox.ResumeLayout(false);
            this.CourseSelectBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sehomeLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button checkIn;
        private System.Windows.Forms.Button checkOut;
        private System.Windows.Forms.PictureBox sehomeLogo;
        private System.Windows.Forms.Button CheckInVisitButton;
        private System.Windows.Forms.Button studentsTab;
        private System.Windows.Forms.Button centerTab;
        private System.Windows.Forms.Button adminTab;
        private System.Windows.Forms.Button newStudentBtn;
        private System.Windows.Forms.GroupBox CourseSelectBox;
        public System.Windows.Forms.ListBox studentNames;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.ComboBox NewClassComboBox;
        private System.Windows.Forms.Button NewClassButton;
        private System.Windows.Forms.RichTextBox loginBackdrop;
    }
}

