namespace SehomeTutoringCenter
{
    partial class MainForm
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
            this.MainTabs = new System.Windows.Forms.TabControl();
            this.LoginTabPage = new System.Windows.Forms.TabPage();
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
            this.checkOut = new System.Windows.Forms.Button();
            this.checkIn = new System.Windows.Forms.Button();
            this.loginBackdrop = new System.Windows.Forms.RichTextBox();
            this.CheckInVisitButton = new System.Windows.Forms.Button();
            this.sehomeLogo = new System.Windows.Forms.PictureBox();
            this.studentNames = new System.Windows.Forms.ListBox();
            this.newStudentBtn = new System.Windows.Forms.Button();
            this.StudentTabPage = new System.Windows.Forms.TabPage();
            this.CenterTabPage = new System.Windows.Forms.TabPage();
            this.AdminTabPage = new System.Windows.Forms.TabPage();
            this.MainTabs.SuspendLayout();
            this.LoginTabPage.SuspendLayout();
            this.CourseSelectBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sehomeLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // MainTabs
            // 
            this.MainTabs.Alignment = System.Windows.Forms.TabAlignment.Right;
            this.MainTabs.Controls.Add(this.LoginTabPage);
            this.MainTabs.Controls.Add(this.StudentTabPage);
            this.MainTabs.Controls.Add(this.CenterTabPage);
            this.MainTabs.Controls.Add(this.AdminTabPage);
            this.MainTabs.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainTabs.Location = new System.Drawing.Point(0, 0);
            this.MainTabs.Multiline = true;
            this.MainTabs.Name = "MainTabs";
            this.MainTabs.SelectedIndex = 0;
            this.MainTabs.Size = new System.Drawing.Size(1917, 1015);
            this.MainTabs.TabIndex = 0;
            // 
            // LoginTabPage
            // 
            this.LoginTabPage.Controls.Add(this.checkOut);
            this.LoginTabPage.Controls.Add(this.checkIn);
            this.LoginTabPage.Controls.Add(this.loginBackdrop);
            this.LoginTabPage.Controls.Add(this.sehomeLogo);
            this.LoginTabPage.Controls.Add(this.studentNames);
            this.LoginTabPage.Controls.Add(this.newStudentBtn);
            this.LoginTabPage.Controls.Add(this.CancelButton);
            this.LoginTabPage.Controls.Add(this.CheckInVisitButton);
            this.LoginTabPage.Controls.Add(this.CourseSelectBox);
            this.LoginTabPage.Location = new System.Drawing.Point(4, 4);
            this.LoginTabPage.Name = "LoginTabPage";
            this.LoginTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.LoginTabPage.Size = new System.Drawing.Size(1869, 1007);
            this.LoginTabPage.TabIndex = 0;
            this.LoginTabPage.Text = "Login";
            this.LoginTabPage.UseVisualStyleBackColor = true;
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
            this.CourseSelectBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CourseSelectBox.Location = new System.Drawing.Point(751, 528);
            this.CourseSelectBox.Name = "CourseSelectBox";
            this.CourseSelectBox.Size = new System.Drawing.Size(526, 333);
            this.CourseSelectBox.TabIndex = 19;
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
            this.CancelButton.Location = new System.Drawing.Point(1309, 475);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(113, 55);
            this.CancelButton.TabIndex = 18;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Visible = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // checkOut
            // 
            this.checkOut.BackColor = System.Drawing.Color.Green;
            this.checkOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.checkOut.Location = new System.Drawing.Point(1016, 269);
            this.checkOut.Name = "checkOut";
            this.checkOut.Size = new System.Drawing.Size(260, 142);
            this.checkOut.TabIndex = 14;
            this.checkOut.Text = "Check Out";
            this.checkOut.UseVisualStyleBackColor = false;
            this.checkOut.Click += new System.EventHandler(this.checkOut_Click);
            // 
            // checkIn
            // 
            this.checkIn.BackColor = System.Drawing.Color.Green;
            this.checkIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.checkIn.Location = new System.Drawing.Point(749, 269);
            this.checkIn.Name = "checkIn";
            this.checkIn.Size = new System.Drawing.Size(260, 142);
            this.checkIn.TabIndex = 13;
            this.checkIn.Text = "Check In";
            this.checkIn.UseVisualStyleBackColor = false;
            this.checkIn.Click += new System.EventHandler(this.checkIn_Click);
            // 
            // loginBackdrop
            // 
            this.loginBackdrop.BackColor = System.Drawing.Color.Silver;
            this.loginBackdrop.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.loginBackdrop.CausesValidation = false;
            this.loginBackdrop.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.loginBackdrop.Location = new System.Drawing.Point(731, 234);
            this.loginBackdrop.MaxLength = 0;
            this.loginBackdrop.Name = "loginBackdrop";
            this.loginBackdrop.ReadOnly = true;
            this.loginBackdrop.Size = new System.Drawing.Size(565, 209);
            this.loginBackdrop.TabIndex = 16;
            this.loginBackdrop.TabStop = false;
            this.loginBackdrop.Text = "";
            // 
            // CheckInVisitButton
            // 
            this.CheckInVisitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckInVisitButton.Location = new System.Drawing.Point(751, 439);
            this.CheckInVisitButton.Name = "CheckInVisitButton";
            this.CheckInVisitButton.Size = new System.Drawing.Size(525, 55);
            this.CheckInVisitButton.TabIndex = 17;
            this.CheckInVisitButton.Text = "Students Subjects";
            this.CheckInVisitButton.UseVisualStyleBackColor = true;
            this.CheckInVisitButton.Click += new System.EventHandler(this.CheckInVisitButton_Click);
            // 
            // sehomeLogo
            // 
            this.sehomeLogo.Image = global::SehomeTutoringCenter.Properties.Resources.logo;
            this.sehomeLogo.Location = new System.Drawing.Point(938, 36);
            this.sehomeLogo.Name = "sehomeLogo";
            this.sehomeLogo.Size = new System.Drawing.Size(143, 197);
            this.sehomeLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sehomeLogo.TabIndex = 15;
            this.sehomeLogo.TabStop = false;
            // 
            // studentNames
            // 
            this.studentNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentNames.FormattingEnabled = true;
            this.studentNames.ItemHeight = 29;
            this.studentNames.Location = new System.Drawing.Point(0, 45);
            this.studentNames.Name = "studentNames";
            this.studentNames.Size = new System.Drawing.Size(263, 816);
            this.studentNames.TabIndex = 10;
            this.studentNames.SelectedIndexChanged += new System.EventHandler(this.studentNames_SelectedIndexChanged);
            // 
            // newStudentBtn
            // 
            this.newStudentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newStudentBtn.Location = new System.Drawing.Point(31, 858);
            this.newStudentBtn.Name = "newStudentBtn";
            this.newStudentBtn.Size = new System.Drawing.Size(201, 52);
            this.newStudentBtn.TabIndex = 11;
            this.newStudentBtn.Text = "New Student";
            this.newStudentBtn.UseVisualStyleBackColor = true;
            this.newStudentBtn.Click += new System.EventHandler(this.newStudentBtn_Click);
            // 
            // StudentTabPage
            // 
            this.StudentTabPage.Location = new System.Drawing.Point(4, 4);
            this.StudentTabPage.Name = "StudentTabPage";
            this.StudentTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.StudentTabPage.Size = new System.Drawing.Size(1869, 1007);
            this.StudentTabPage.TabIndex = 1;
            this.StudentTabPage.Text = "Student Stats";
            this.StudentTabPage.UseVisualStyleBackColor = true;
            // 
            // CenterTabPage
            // 
            this.CenterTabPage.Location = new System.Drawing.Point(4, 4);
            this.CenterTabPage.Name = "CenterTabPage";
            this.CenterTabPage.Size = new System.Drawing.Size(1869, 1007);
            this.CenterTabPage.TabIndex = 2;
            this.CenterTabPage.Text = "Center Stats";
            this.CenterTabPage.UseVisualStyleBackColor = true;
            // 
            // AdminTabPage
            // 
            this.AdminTabPage.Location = new System.Drawing.Point(4, 4);
            this.AdminTabPage.Name = "AdminTabPage";
            this.AdminTabPage.Size = new System.Drawing.Size(1869, 1007);
            this.AdminTabPage.TabIndex = 3;
            this.AdminTabPage.Text = "Admin";
            this.AdminTabPage.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1001);
            this.Controls.Add(this.MainTabs);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MainTabs.ResumeLayout(false);
            this.LoginTabPage.ResumeLayout(false);
            this.CourseSelectBox.ResumeLayout(false);
            this.CourseSelectBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sehomeLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MainTabs;
        private System.Windows.Forms.TabPage LoginTabPage;
        private System.Windows.Forms.TabPage StudentTabPage;
        private System.Windows.Forms.TabPage CenterTabPage;
        private System.Windows.Forms.TabPage AdminTabPage;
        public System.Windows.Forms.ListBox studentNames;
        private System.Windows.Forms.Button newStudentBtn;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button checkOut;
        private System.Windows.Forms.Button checkIn;
        private System.Windows.Forms.RichTextBox loginBackdrop;
        private System.Windows.Forms.Button CheckInVisitButton;
        private System.Windows.Forms.PictureBox sehomeLogo;
        private System.Windows.Forms.GroupBox CourseSelectBox;
        private System.Windows.Forms.Button NewClassButton;
        private System.Windows.Forms.ComboBox NewClassComboBox;
        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}