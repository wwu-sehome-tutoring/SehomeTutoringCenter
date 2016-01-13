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
            this.sehomeLogo = new System.Windows.Forms.PictureBox();
            this.loginBackdrop = new System.Windows.Forms.RichTextBox();
            this.coursesDropDown = new System.Windows.Forms.Button();
            this.studentsTab = new System.Windows.Forms.Button();
            this.centerTab = new System.Windows.Forms.Button();
            this.adminTab = new System.Windows.Forms.Button();
            this.studentNames = new System.Windows.Forms.ListBox();
            this.newStudentBtn = new System.Windows.Forms.Button();
            this.courseSelectBox = new System.Windows.Forms.GroupBox();
            this.CancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sehomeLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // checkIn
            // 
            this.checkIn.BackColor = System.Drawing.Color.Green;
            this.checkIn.Enabled = false;
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
            this.checkOut.Enabled = false;
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
            // sehomeLogo
            // 
            this.sehomeLogo.Image = global::SehomeTutoringCenter.Properties.Resources.Sehome_color129x200_97x150;
            this.sehomeLogo.Location = new System.Drawing.Point(948, 57);
            this.sehomeLogo.Name = "sehomeLogo";
            this.sehomeLogo.Size = new System.Drawing.Size(97, 153);
            this.sehomeLogo.TabIndex = 2;
            this.sehomeLogo.TabStop = false;
            // 
            // loginBackdrop
            // 
            this.loginBackdrop.BackColor = System.Drawing.Color.Silver;
            this.loginBackdrop.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.loginBackdrop.CausesValidation = false;
            this.loginBackdrop.Location = new System.Drawing.Point(715, 226);
            this.loginBackdrop.MaxLength = 0;
            this.loginBackdrop.Name = "loginBackdrop";
            this.loginBackdrop.ReadOnly = true;
            this.loginBackdrop.Size = new System.Drawing.Size(565, 209);
            this.loginBackdrop.TabIndex = 3;
            this.loginBackdrop.TabStop = false;
            this.loginBackdrop.Text = "";
            // 
            // coursesDropDown
            // 
            this.coursesDropDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coursesDropDown.Location = new System.Drawing.Point(734, 432);
            this.coursesDropDown.Name = "coursesDropDown";
            this.coursesDropDown.Size = new System.Drawing.Size(525, 55);
            this.coursesDropDown.TabIndex = 4;
            this.coursesDropDown.Text = "Students Subjects";
            this.coursesDropDown.UseVisualStyleBackColor = true;
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
            this.studentNames.Items.AddRange(new object[] {
            "Andrew Feely",
            "Nathan Shive",
            "JJ Small",
            "Tucker Robot Man",
            "Patrick Patrickson",
            "Elvis Presley"});
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
            // courseSelectBox
            // 
            this.courseSelectBox.BackColor = System.Drawing.Color.White;
            this.courseSelectBox.Location = new System.Drawing.Point(733, 529);
            this.courseSelectBox.Name = "courseSelectBox";
            this.courseSelectBox.Size = new System.Drawing.Size(526, 303);
            this.courseSelectBox.TabIndex = 11;
            this.courseSelectBox.TabStop = false;
            this.courseSelectBox.Visible = false;
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
            this.Controls.Add(this.sehomeLogo);
            this.Controls.Add(this.checkOut);
            this.Controls.Add(this.checkIn);
            this.Controls.Add(this.loginBackdrop);
            this.Controls.Add(this.newStudentBtn);
            this.Controls.Add(this.coursesDropDown);
            this.Controls.Add(this.courseSelectBox);
            this.Name = "studentLoginForm";
            this.Text = "SLC Attendence System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.sehomeLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button checkIn;
        private System.Windows.Forms.Button checkOut;
        private System.Windows.Forms.PictureBox sehomeLogo;
        private System.Windows.Forms.RichTextBox loginBackdrop;
        private System.Windows.Forms.Button coursesDropDown;
        private System.Windows.Forms.Button studentsTab;
        private System.Windows.Forms.Button centerTab;
        private System.Windows.Forms.Button adminTab;
        private System.Windows.Forms.Button newStudentBtn;
        private System.Windows.Forms.GroupBox courseSelectBox;
        public System.Windows.Forms.ListBox studentNames;
        private System.Windows.Forms.Button CancelButton;
    }
}

