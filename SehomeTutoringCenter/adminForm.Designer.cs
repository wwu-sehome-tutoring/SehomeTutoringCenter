namespace SehomeTutoringCenter
{
    partial class adminForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.centerTab = new System.Windows.Forms.Button();
            this.studentTab = new System.Windows.Forms.Button();
            this.loginTab = new System.Windows.Forms.Button();
            this.rightBorderLine = new System.Windows.Forms.GroupBox();
            this.bottomBorderLine = new System.Windows.Forms.GroupBox();
            this.sehomeLogo = new System.Windows.Forms.PictureBox();
            this.OptionsGroupBox = new System.Windows.Forms.GroupBox();
            this.NewSemesterButton = new System.Windows.Forms.Button();
            this.EditStudentButton = new System.Windows.Forms.Button();
            this.EditClassButton = new System.Windows.Forms.Button();
            this.ImportButton = new System.Windows.Forms.Button();
            this.TotalStudentsGB = new System.Windows.Forms.GroupBox();
            this.TotalStudentsBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.student = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Class = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timein = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeout = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totaltime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.sehomeLogo)).BeginInit();
            this.OptionsGroupBox.SuspendLayout();
            this.TotalStudentsGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // centerTab
            // 
            this.centerTab.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.centerTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.centerTab.Location = new System.Drawing.Point(1864, 666);
            this.centerTab.Name = "centerTab";
            this.centerTab.Size = new System.Drawing.Size(40, 300);
            this.centerTab.TabIndex = 13;
            this.centerTab.Text = "C\r\nE\r\nN\r\nT\r\nE\r\nR\r\n";
            this.centerTab.UseVisualStyleBackColor = true;
            this.centerTab.Click += new System.EventHandler(this.centerTab_Click);
            // 
            // studentTab
            // 
            this.studentTab.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.studentTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentTab.Location = new System.Drawing.Point(1864, 347);
            this.studentTab.Name = "studentTab";
            this.studentTab.Size = new System.Drawing.Size(40, 300);
            this.studentTab.TabIndex = 12;
            this.studentTab.Text = "S\r\nT\r\nU\r\nD\r\nE\r\nN\r\nT\r\nS\r\n";
            this.studentTab.UseVisualStyleBackColor = true;
            this.studentTab.Click += new System.EventHandler(this.studentTab_Click);
            // 
            // loginTab
            // 
            this.loginTab.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loginTab.BackColor = System.Drawing.SystemColors.Control;
            this.loginTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginTab.Location = new System.Drawing.Point(1864, 29);
            this.loginTab.Name = "loginTab";
            this.loginTab.Size = new System.Drawing.Size(40, 300);
            this.loginTab.TabIndex = 11;
            this.loginTab.Text = "L\r\nO\r\nG\r\nI\r\nN\r\n\r\n";
            this.loginTab.UseVisualStyleBackColor = true;
            this.loginTab.Click += new System.EventHandler(this.loginTab_Click);
            // 
            // rightBorderLine
            // 
            this.rightBorderLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rightBorderLine.Location = new System.Drawing.Point(320, 26);
            this.rightBorderLine.Name = "rightBorderLine";
            this.rightBorderLine.Size = new System.Drawing.Size(2, 937);
            this.rightBorderLine.TabIndex = 26;
            this.rightBorderLine.TabStop = false;
            // 
            // bottomBorderLine
            // 
            this.bottomBorderLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bottomBorderLine.Location = new System.Drawing.Point(28, 687);
            this.bottomBorderLine.Name = "bottomBorderLine";
            this.bottomBorderLine.Size = new System.Drawing.Size(275, 2);
            this.bottomBorderLine.TabIndex = 27;
            this.bottomBorderLine.TabStop = false;
            // 
            // sehomeLogo
            // 
            this.sehomeLogo.Image = global::SehomeTutoringCenter.Properties.Resources.Sehome_color129x200_97x150;
            this.sehomeLogo.Location = new System.Drawing.Point(105, 762);
            this.sehomeLogo.Name = "sehomeLogo";
            this.sehomeLogo.Size = new System.Drawing.Size(100, 150);
            this.sehomeLogo.TabIndex = 28;
            this.sehomeLogo.TabStop = false;
            // 
            // OptionsGroupBox
            // 
            this.OptionsGroupBox.Controls.Add(this.NewSemesterButton);
            this.OptionsGroupBox.Controls.Add(this.EditStudentButton);
            this.OptionsGroupBox.Controls.Add(this.EditClassButton);
            this.OptionsGroupBox.Controls.Add(this.ImportButton);
            this.OptionsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptionsGroupBox.Location = new System.Drawing.Point(28, 29);
            this.OptionsGroupBox.Name = "OptionsGroupBox";
            this.OptionsGroupBox.Size = new System.Drawing.Size(258, 389);
            this.OptionsGroupBox.TabIndex = 29;
            this.OptionsGroupBox.TabStop = false;
            this.OptionsGroupBox.Text = "Options";
            // 
            // NewSemesterButton
            // 
            this.NewSemesterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewSemesterButton.Location = new System.Drawing.Point(23, 287);
            this.NewSemesterButton.Name = "NewSemesterButton";
            this.NewSemesterButton.Size = new System.Drawing.Size(210, 48);
            this.NewSemesterButton.TabIndex = 20;
            this.NewSemesterButton.Text = "New Semester";
            this.NewSemesterButton.UseVisualStyleBackColor = true;
            this.NewSemesterButton.Click += new System.EventHandler(this.NewSemesterButton_Click);
            // 
            // EditStudentButton
            // 
            this.EditStudentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditStudentButton.Location = new System.Drawing.Point(23, 206);
            this.EditStudentButton.Name = "EditStudentButton";
            this.EditStudentButton.Size = new System.Drawing.Size(210, 48);
            this.EditStudentButton.TabIndex = 19;
            this.EditStudentButton.Text = "Edit Student Data";
            this.EditStudentButton.UseVisualStyleBackColor = true;
            this.EditStudentButton.Click += new System.EventHandler(this.EditStudentButton_Click);
            // 
            // EditClassButton
            // 
            this.EditClassButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditClassButton.Location = new System.Drawing.Point(23, 125);
            this.EditClassButton.Name = "EditClassButton";
            this.EditClassButton.Size = new System.Drawing.Size(210, 48);
            this.EditClassButton.TabIndex = 18;
            this.EditClassButton.Text = "Add/Remove Class";
            this.EditClassButton.UseVisualStyleBackColor = true;
            this.EditClassButton.Click += new System.EventHandler(this.EditClassButton_Click);
            // 
            // ImportButton
            // 
            this.ImportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImportButton.Location = new System.Drawing.Point(23, 44);
            this.ImportButton.Name = "ImportButton";
            this.ImportButton.Size = new System.Drawing.Size(210, 48);
            this.ImportButton.TabIndex = 17;
            this.ImportButton.Text = "Import Class Data";
            this.ImportButton.UseVisualStyleBackColor = true;
            this.ImportButton.Click += new System.EventHandler(this.ImportButton_Click);
            // 
            // TotalStudentsGB
            // 
            this.TotalStudentsGB.Controls.Add(this.TotalStudentsBox);
            this.TotalStudentsGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalStudentsGB.Location = new System.Drawing.Point(28, 482);
            this.TotalStudentsGB.Name = "TotalStudentsGB";
            this.TotalStudentsGB.Size = new System.Drawing.Size(258, 129);
            this.TotalStudentsGB.TabIndex = 30;
            this.TotalStudentsGB.TabStop = false;
            this.TotalStudentsGB.Text = "Total Students";
            // 
            // TotalStudentsBox
            // 
            this.TotalStudentsBox.Location = new System.Drawing.Point(42, 58);
            this.TotalStudentsBox.Name = "TotalStudentsBox";
            this.TotalStudentsBox.Size = new System.Drawing.Size(172, 35);
            this.TotalStudentsBox.TabIndex = 20;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.student,
            this.Class,
            this.timein,
            this.timeout,
            this.totaltime});
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridView1.Location = new System.Drawing.Point(360, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1462, 616);
            this.dataGridView1.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(360, 29);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(186, 29);
            this.label1.TabIndex = 32;
            this.label1.Text = "Current Sudents";
            // 
            // student
            // 
            this.student.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.student.HeaderText = "Student";
            this.student.Name = "student";
            // 
            // Class
            // 
            this.Class.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Class.HeaderText = "Class";
            this.Class.Name = "Class";
            // 
            // timein
            // 
            this.timein.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.timein.HeaderText = "Time In";
            this.timein.Name = "timein";
            // 
            // timeout
            // 
            this.timeout.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.timeout.HeaderText = "Time Out";
            this.timeout.Name = "timeout";
            // 
            // totaltime
            // 
            this.totaltime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.totaltime.HeaderText = "Total Time";
            this.totaltime.Name = "totaltime";
            // 
            // adminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1001);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TotalStudentsGB);
            this.Controls.Add(this.OptionsGroupBox);
            this.Controls.Add(this.sehomeLogo);
            this.Controls.Add(this.bottomBorderLine);
            this.Controls.Add(this.rightBorderLine);
            this.Controls.Add(this.centerTab);
            this.Controls.Add(this.studentTab);
            this.Controls.Add(this.loginTab);
            this.Name = "adminForm";
            this.Text = "Administration";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.sehomeLogo)).EndInit();
            this.OptionsGroupBox.ResumeLayout(false);
            this.TotalStudentsGB.ResumeLayout(false);
            this.TotalStudentsGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button centerTab;
        private System.Windows.Forms.Button studentTab;
        private System.Windows.Forms.Button loginTab;
        private System.Windows.Forms.GroupBox rightBorderLine;
        private System.Windows.Forms.GroupBox bottomBorderLine;
        private System.Windows.Forms.PictureBox sehomeLogo;
        private System.Windows.Forms.GroupBox OptionsGroupBox;
        private System.Windows.Forms.GroupBox TotalStudentsGB;
        private System.Windows.Forms.Button ImportButton;
        private System.Windows.Forms.Button EditClassButton;
        private System.Windows.Forms.Button NewSemesterButton;
        private System.Windows.Forms.Button EditStudentButton;
        private System.Windows.Forms.TextBox TotalStudentsBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn student;
        private System.Windows.Forms.DataGridViewTextBoxColumn Class;
        private System.Windows.Forms.DataGridViewTextBoxColumn timein;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeout;
        private System.Windows.Forms.DataGridViewTextBoxColumn totaltime;
    }
}