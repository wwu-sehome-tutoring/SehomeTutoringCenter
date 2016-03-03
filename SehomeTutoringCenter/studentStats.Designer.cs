namespace SehomeTutoringCenter
{
    partial class studentStats
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.studentGridView = new System.Windows.Forms.DataGridView();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sehomeLogo = new System.Windows.Forms.PictureBox();
            this.adminTab = new System.Windows.Forms.Button();
            this.centerTab = new System.Windows.Forms.Button();
            this.studentsTab = new System.Windows.Forms.Button();
            this.studentPieChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.rightBorderLine = new System.Windows.Forms.GroupBox();
            this.bottomBorderLine = new System.Windows.Forms.GroupBox();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.endDateGroupBox = new System.Windows.Forms.GroupBox();
            this.endDatePicker = new System.Windows.Forms.DateTimePicker();
            this.startDateGroupBox = new System.Windows.Forms.GroupBox();
            this.startDatePicker = new System.Windows.Forms.DateTimePicker();
            this.studentGroupBox = new System.Windows.Forms.GroupBox();
            this.studentComboBox = new System.Windows.Forms.ComboBox();
            this.currentStudentGroupBox = new System.Windows.Forms.GroupBox();
            this.currentStudentText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.studentGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sehomeLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentPieChart)).BeginInit();
            this.endDateGroupBox.SuspendLayout();
            this.startDateGroupBox.SuspendLayout();
            this.studentGroupBox.SuspendLayout();
            this.currentStudentGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // studentGridView
            // 
            this.studentGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.date,
            this.subject,
            this.timeIn,
            this.timeOut,
            this.totalTime});
            this.studentGridView.Location = new System.Drawing.Point(454, 507);
            this.studentGridView.Name = "studentGridView";
            this.studentGridView.Size = new System.Drawing.Size(1310, 453);
            this.studentGridView.TabIndex = 20;
            // 
            // date
            // 
            this.date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            // 
            // subject
            // 
            this.subject.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.subject.HeaderText = "Subject";
            this.subject.Name = "subject";
            // 
            // timeIn
            // 
            this.timeIn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.timeIn.HeaderText = "Time In";
            this.timeIn.Name = "timeIn";
            // 
            // timeOut
            // 
            this.timeOut.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.timeOut.HeaderText = "Time Out";
            this.timeOut.Name = "timeOut";
            // 
            // totalTime
            // 
            this.totalTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.totalTime.HeaderText = "Total Time";
            this.totalTime.Name = "totalTime";
            // 
            // sehomeLogo
            // 
            this.sehomeLogo.Image = global::SehomeTutoringCenter.Properties.Resources.Sehome_color129x200_97x150;
            this.sehomeLogo.Location = new System.Drawing.Point(105, 772);
            this.sehomeLogo.Name = "sehomeLogo";
            this.sehomeLogo.Size = new System.Drawing.Size(100, 150);
            this.sehomeLogo.TabIndex = 19;
            this.sehomeLogo.TabStop = false;
            // 
            // adminTab
            // 
            this.adminTab.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.adminTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminTab.Location = new System.Drawing.Point(1852, 667);
            this.adminTab.Name = "adminTab";
            this.adminTab.Size = new System.Drawing.Size(40, 302);
            this.adminTab.TabIndex = 23;
            this.adminTab.Text = "A\r\nD\r\nM\r\nI\r\nN\r\n";
            this.adminTab.UseVisualStyleBackColor = true;
            // 
            // centerTab
            // 
            this.centerTab.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.centerTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.centerTab.Location = new System.Drawing.Point(1852, 348);
            this.centerTab.Name = "centerTab";
            this.centerTab.Size = new System.Drawing.Size(40, 302);
            this.centerTab.TabIndex = 22;
            this.centerTab.Text = "C\r\nE\r\nN\r\nT\r\nE\r\nR\r\n";
            this.centerTab.UseVisualStyleBackColor = true;
            // 
            // studentsTab
            // 
            this.studentsTab.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.studentsTab.BackColor = System.Drawing.SystemColors.Control;
            this.studentsTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentsTab.Location = new System.Drawing.Point(1852, 30);
            this.studentsTab.Name = "studentsTab";
            this.studentsTab.Size = new System.Drawing.Size(40, 302);
            this.studentsTab.TabIndex = 21;
            this.studentsTab.Text = "L\r\nO\r\nG\r\nI\r\nN\r\n";
            this.studentsTab.UseVisualStyleBackColor = true;
            // 
            // studentPieChart
            // 
            chartArea1.Name = "ChartArea1";
            this.studentPieChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.studentPieChart.Legends.Add(legend1);
            this.studentPieChart.Location = new System.Drawing.Point(454, 30);
            this.studentPieChart.Name = "studentPieChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Subjects";
            this.studentPieChart.Series.Add(series1);
            this.studentPieChart.Size = new System.Drawing.Size(1310, 462);
            this.studentPieChart.TabIndex = 24;
            this.studentPieChart.Text = "chart1";
            this.studentPieChart.Click += new System.EventHandler(this.chart1_Click);
            // 
            // rightBorderLine
            // 
            this.rightBorderLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rightBorderLine.Location = new System.Drawing.Point(320, 26);
            this.rightBorderLine.Name = "rightBorderLine";
            this.rightBorderLine.Size = new System.Drawing.Size(2, 937);
            this.rightBorderLine.TabIndex = 25;
            this.rightBorderLine.TabStop = false;
            // 
            // bottomBorderLine
            // 
            this.bottomBorderLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bottomBorderLine.Location = new System.Drawing.Point(28, 687);
            this.bottomBorderLine.Name = "bottomBorderLine";
            this.bottomBorderLine.Size = new System.Drawing.Size(275, 2);
            this.bottomBorderLine.TabIndex = 26;
            this.bottomBorderLine.TabStop = false;
            // 
            // GenerateButton
            // 
            this.GenerateButton.BackColor = System.Drawing.Color.Green;
            this.GenerateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenerateButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.GenerateButton.Location = new System.Drawing.Point(71, 587);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(172, 48);
            this.GenerateButton.TabIndex = 30;
            this.GenerateButton.Text = "Generate";
            this.GenerateButton.UseVisualStyleBackColor = false;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // endDateGroupBox
            // 
            this.endDateGroupBox.Controls.Add(this.endDatePicker);
            this.endDateGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDateGroupBox.Location = new System.Drawing.Point(28, 419);
            this.endDateGroupBox.Name = "endDateGroupBox";
            this.endDateGroupBox.Size = new System.Drawing.Size(258, 82);
            this.endDateGroupBox.TabIndex = 29;
            this.endDateGroupBox.TabStop = false;
            this.endDateGroupBox.Text = "End Date";
            this.endDateGroupBox.Enter += new System.EventHandler(this.endDateGroupBox_Enter);
            // 
            // endDatePicker
            // 
            this.endDatePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDatePicker.Location = new System.Drawing.Point(15, 34);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(226, 29);
            this.endDatePicker.TabIndex = 0;
            // 
            // startDateGroupBox
            // 
            this.startDateGroupBox.Controls.Add(this.startDatePicker);
            this.startDateGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDateGroupBox.Location = new System.Drawing.Point(28, 244);
            this.startDateGroupBox.Name = "startDateGroupBox";
            this.startDateGroupBox.Size = new System.Drawing.Size(258, 82);
            this.startDateGroupBox.TabIndex = 28;
            this.startDateGroupBox.TabStop = false;
            this.startDateGroupBox.Text = "Start Date";
            this.startDateGroupBox.Enter += new System.EventHandler(this.startDateGroupBox_Enter);
            // 
            // startDatePicker
            // 
            this.startDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDatePicker.Location = new System.Drawing.Point(15, 34);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(226, 29);
            this.startDatePicker.TabIndex = 0;
            this.startDatePicker.ValueChanged += new System.EventHandler(this.StartDatePicker_ValueChanged);
            // 
            // studentGroupBox
            // 
            this.studentGroupBox.Controls.Add(this.studentComboBox);
            this.studentGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentGroupBox.Location = new System.Drawing.Point(28, 58);
            this.studentGroupBox.Name = "studentGroupBox";
            this.studentGroupBox.Size = new System.Drawing.Size(258, 82);
            this.studentGroupBox.TabIndex = 27;
            this.studentGroupBox.TabStop = false;
            this.studentGroupBox.Text = "Student";
            this.studentGroupBox.Enter += new System.EventHandler(this.subjectGroupBox_Enter);
            // 
            // studentComboBox
            // 
            this.studentComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentComboBox.FormattingEnabled = true;
            this.studentComboBox.Location = new System.Drawing.Point(29, 34);
            this.studentComboBox.Name = "studentComboBox";
            this.studentComboBox.Size = new System.Drawing.Size(203, 32);
            this.studentComboBox.TabIndex = 11;
            this.studentComboBox.SelectedIndexChanged += new System.EventHandler(this.subjectComboBox_SelectedIndexChanged);
            // 
            // currentStudentGroupBox
            // 
            this.currentStudentGroupBox.Controls.Add(this.currentStudentText);
            this.currentStudentGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentStudentGroupBox.Location = new System.Drawing.Point(474, 58);
            this.currentStudentGroupBox.Name = "currentStudentGroupBox";
            this.currentStudentGroupBox.Size = new System.Drawing.Size(258, 82);
            this.currentStudentGroupBox.TabIndex = 28;
            this.currentStudentGroupBox.TabStop = false;
            this.currentStudentGroupBox.Text = "Current Student";
            // 
            // currentStudentText
            // 
            this.currentStudentText.Location = new System.Drawing.Point(6, 30);
            this.currentStudentText.Name = "currentStudentText";
            this.currentStudentText.Size = new System.Drawing.Size(246, 35);
            this.currentStudentText.TabIndex = 0;
            // 
            // studentStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1002);
            this.Controls.Add(this.currentStudentGroupBox);
            this.Controls.Add(this.GenerateButton);
            this.Controls.Add(this.endDateGroupBox);
            this.Controls.Add(this.startDateGroupBox);
            this.Controls.Add(this.studentGroupBox);
            this.Controls.Add(this.bottomBorderLine);
            this.Controls.Add(this.rightBorderLine);
            this.Controls.Add(this.studentPieChart);
            this.Controls.Add(this.adminTab);
            this.Controls.Add(this.centerTab);
            this.Controls.Add(this.studentsTab);
            this.Controls.Add(this.studentGridView);
            this.Controls.Add(this.sehomeLogo);
            this.Name = "studentStats";
            this.Text = "studentStats";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.studentStats_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sehomeLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentPieChart)).EndInit();
            this.endDateGroupBox.ResumeLayout(false);
            this.startDateGroupBox.ResumeLayout(false);
            this.studentGroupBox.ResumeLayout(false);
            this.currentStudentGroupBox.ResumeLayout(false);
            this.currentStudentGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView studentGridView;
        private System.Windows.Forms.PictureBox sehomeLogo;
        private System.Windows.Forms.Button adminTab;
        private System.Windows.Forms.Button centerTab;
        private System.Windows.Forms.Button studentsTab;
        private System.Windows.Forms.DataVisualization.Charting.Chart studentPieChart;
        private System.Windows.Forms.GroupBox rightBorderLine;
        private System.Windows.Forms.GroupBox bottomBorderLine;
        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.GroupBox endDateGroupBox;
        private System.Windows.Forms.DateTimePicker endDatePicker;
        private System.Windows.Forms.GroupBox startDateGroupBox;
        private System.Windows.Forms.DateTimePicker startDatePicker;
        private System.Windows.Forms.GroupBox studentGroupBox;
        private System.Windows.Forms.ComboBox studentComboBox;
        private System.Windows.Forms.GroupBox currentStudentGroupBox;
        private System.Windows.Forms.TextBox currentStudentText;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalTime;
    }
}