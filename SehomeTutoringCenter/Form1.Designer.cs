namespace SehomeTutoringCenter
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
            ((System.ComponentModel.ISupportInitialize)(this.sehomeLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // checkIn
            // 
            this.checkIn.BackColor = System.Drawing.Color.Green;
            this.checkIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.checkIn.Location = new System.Drawing.Point(478, 258);
            this.checkIn.Name = "checkIn";
            this.checkIn.Size = new System.Drawing.Size(187, 98);
            this.checkIn.TabIndex = 0;
            this.checkIn.Text = "Check In";
            this.checkIn.UseVisualStyleBackColor = false;
            this.checkIn.Click += new System.EventHandler(this.checkIn_Click);
            // 
            // checkOut
            // 
            this.checkOut.BackColor = System.Drawing.Color.Green;
            this.checkOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.checkOut.Location = new System.Drawing.Point(682, 258);
            this.checkOut.Name = "checkOut";
            this.checkOut.Size = new System.Drawing.Size(187, 98);
            this.checkOut.TabIndex = 1;
            this.checkOut.Text = "Check Out";
            this.checkOut.UseVisualStyleBackColor = false;
            this.checkOut.Click += new System.EventHandler(this.checkOut_Click);
            // 
            // sehomeLogo
            // 
            this.sehomeLogo.Image = global::SehomeTutoringCenter.Properties.Resources.Sehome_color129x200_97x150;
            this.sehomeLogo.Location = new System.Drawing.Point(627, 57);
            this.sehomeLogo.Name = "sehomeLogo";
            this.sehomeLogo.Size = new System.Drawing.Size(97, 153);
            this.sehomeLogo.TabIndex = 2;
            this.sehomeLogo.TabStop = false;
            // 
            // loginBackdrop
            // 
            this.loginBackdrop.BackColor = System.Drawing.Color.Silver;
            this.loginBackdrop.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.loginBackdrop.Location = new System.Drawing.Point(457, 228);
            this.loginBackdrop.Name = "loginBackdrop";
            this.loginBackdrop.Size = new System.Drawing.Size(436, 162);
            this.loginBackdrop.TabIndex = 3;
            this.loginBackdrop.Text = "";
            // 
            // coursesDropDown
            // 
            this.coursesDropDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coursesDropDown.Location = new System.Drawing.Point(468, 388);
            this.coursesDropDown.Name = "coursesDropDown";
            this.coursesDropDown.Size = new System.Drawing.Size(413, 39);
            this.coursesDropDown.TabIndex = 4;
            this.coursesDropDown.Text = "Courses Offered";
            this.coursesDropDown.UseVisualStyleBackColor = true;
            this.coursesDropDown.Click += new System.EventHandler(this.coursesDropDown_Click);
            // 
            // studentsTab
            // 
            this.studentsTab.BackColor = System.Drawing.SystemColors.ControlLight;
            this.studentsTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentsTab.Location = new System.Drawing.Point(1230, 37);
            this.studentsTab.Name = "studentsTab";
            this.studentsTab.Size = new System.Drawing.Size(37, 210);
            this.studentsTab.TabIndex = 5;
            this.studentsTab.Text = "S\r\nT\r\nU\r\nD\r\nE\r\nN\r\nT\r\nS\r\n";
            this.studentsTab.UseVisualStyleBackColor = false;
            this.studentsTab.Click += new System.EventHandler(this.studentsTab_Click);
            // 
            // centerTab
            // 
            this.centerTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.centerTab.Location = new System.Drawing.Point(1230, 270);
            this.centerTab.Name = "centerTab";
            this.centerTab.Size = new System.Drawing.Size(37, 210);
            this.centerTab.TabIndex = 6;
            this.centerTab.Text = "C\r\nE\r\nN\r\nT\r\nE\r\nR\r\n";
            this.centerTab.UseVisualStyleBackColor = true;
            this.centerTab.Click += new System.EventHandler(this.centerTab_Click);
            // 
            // adminTab
            // 
            this.adminTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminTab.Location = new System.Drawing.Point(1230, 501);
            this.adminTab.Name = "adminTab";
            this.adminTab.Size = new System.Drawing.Size(37, 210);
            this.adminTab.TabIndex = 7;
            this.adminTab.Text = "A\r\nD\r\nM\r\nI\r\nN\r\n";
            this.adminTab.UseVisualStyleBackColor = true;
            this.adminTab.Click += new System.EventHandler(this.adminTab_Click);
            // 
            // studentNames
            // 
            this.studentNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentNames.FormattingEnabled = true;
            this.studentNames.ItemHeight = 20;
            this.studentNames.Items.AddRange(new object[] {
            "Lyla Askins  ",
            "Shavonda Pancoast  ",
            "Val Mcclaran  ",
            "Greta Sanluis  ",
            "Tynisha Holben  ",
            "Shondra Shiffer  ",
            "Collin Hults  ",
            "Fonda Siggers  ",
            "Karlene Sain  ",
            "Bess Tardiff  ",
            "Loyce Hickson  ",
            "Ingrid Diez  ",
            "Kaley Demby  ",
            "Jayne Bourgeois  ",
            "Ruthann Blackwood  ",
            "Anette Rotz  ",
            "Christy Eason  ",
            "Leilani Yeldell  ",
            "Mickey Jemison  ",
            "Eden Davenport  ",
            "Evalyn Tawil  ",
            "Jessenia Coppage  ",
            "Jordon Peppers  ",
            "Noemi Iddings  ",
            "Vanita Shorts  ",
            "Bart Morrell  ",
            "Keri Leisure  ",
            "Hoa Bramer  ",
            "Samuel Luttrell  ",
            "Lillian Nelson  "});
            this.studentNames.Location = new System.Drawing.Point(3, 57);
            this.studentNames.Name = "studentNames";
            this.studentNames.Size = new System.Drawing.Size(183, 584);
            this.studentNames.TabIndex = 8;
            this.studentNames.SelectedIndexChanged += new System.EventHandler(this.studentNames_SelectedIndexChanged);
            // 
            // newStudentBtn
            // 
            this.newStudentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newStudentBtn.Location = new System.Drawing.Point(20, 639);
            this.newStudentBtn.Name = "newStudentBtn";
            this.newStudentBtn.Size = new System.Drawing.Size(145, 39);
            this.newStudentBtn.TabIndex = 9;
            this.newStudentBtn.Text = "New Student";
            this.newStudentBtn.UseVisualStyleBackColor = true;
            this.newStudentBtn.Click += new System.EventHandler(this.newStudentBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 761);
            this.Controls.Add(this.studentNames);
            this.Controls.Add(this.adminTab);
            this.Controls.Add(this.centerTab);
            this.Controls.Add(this.studentsTab);
            this.Controls.Add(this.sehomeLogo);
            this.Controls.Add(this.checkOut);
            this.Controls.Add(this.checkIn);
            this.Controls.Add(this.loginBackdrop);
            this.Controls.Add(this.coursesDropDown);
            this.Controls.Add(this.newStudentBtn);
            this.Name = "Form1";
            this.Text = "SLC Attendence System";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.ListBox studentNames;
        private System.Windows.Forms.Button newStudentBtn;
    }
}

