namespace SehomeTutoringCenter
{
    partial class CenterStatsForm
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
            this.adminTab = new System.Windows.Forms.Button();
            this.studentTab = new System.Windows.Forms.Button();
            this.loginTab = new System.Windows.Forms.Button();
            this.subjectComboBox = new System.Windows.Forms.ComboBox();
            this.subjectGroupBox = new System.Windows.Forms.GroupBox();
            this.startDateGroupBox = new System.Windows.Forms.GroupBox();
            this.StartDatePicker = new System.Windows.Forms.DateTimePicker();
            this.endDateGroupBox = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dailyPrizeGroupBox = new System.Windows.Forms.GroupBox();
            this.RandomNameTextbox = new System.Windows.Forms.TextBox();
            this.PrizeButton = new System.Windows.Forms.Button();
            this.centerStatsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.CenterStatsTable = new System.Windows.Forms.TableLayoutPanel();
            this.SummaryLabel = new System.Windows.Forms.Label();
            this.TotalStudentsLabel = new System.Windows.Forms.Label();
            this.TotalTimeLabel = new System.Windows.Forms.Label();
            this.AverageStudentsLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TotalStudentsValue = new System.Windows.Forms.Label();
            this.TotalTimeValue = new System.Windows.Forms.Label();
            this.StudentAverageValue = new System.Windows.Forms.Label();
            this.AverageTimeValue = new System.Windows.Forms.Label();
            this.subjectGroupBox.SuspendLayout();
            this.startDateGroupBox.SuspendLayout();
            this.endDateGroupBox.SuspendLayout();
            this.dailyPrizeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.centerStatsChart)).BeginInit();
            this.CenterStatsTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // adminTab
            // 
            this.adminTab.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.adminTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminTab.Location = new System.Drawing.Point(1864, 663);
            this.adminTab.Name = "adminTab";
            this.adminTab.Size = new System.Drawing.Size(40, 300);
            this.adminTab.TabIndex = 10;
            this.adminTab.Text = "A\r\nD\r\nM\r\nI\r\nN\r\n";
            this.adminTab.UseVisualStyleBackColor = true;
            this.adminTab.Click += new System.EventHandler(this.adminTab_Click);
            // 
            // studentTab
            // 
            this.studentTab.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.studentTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentTab.Location = new System.Drawing.Point(1864, 344);
            this.studentTab.Name = "studentTab";
            this.studentTab.Size = new System.Drawing.Size(40, 300);
            this.studentTab.TabIndex = 9;
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
            this.loginTab.Location = new System.Drawing.Point(1864, 26);
            this.loginTab.Name = "loginTab";
            this.loginTab.Size = new System.Drawing.Size(40, 300);
            this.loginTab.TabIndex = 8;
            this.loginTab.Text = "L\r\nO\r\nG\r\nI\r\nN\r\n\r\n";
            this.loginTab.UseVisualStyleBackColor = true;
            this.loginTab.Click += new System.EventHandler(this.loginTab_Click);
            // 
            // subjectComboBox
            // 
            this.subjectComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectComboBox.FormattingEnabled = true;
            this.subjectComboBox.Location = new System.Drawing.Point(29, 34);
            this.subjectComboBox.Name = "subjectComboBox";
            this.subjectComboBox.Size = new System.Drawing.Size(203, 32);
            this.subjectComboBox.TabIndex = 11;
            this.subjectComboBox.SelectedIndexChanged += new System.EventHandler(this.subjectComboBox_SelectedIndexChanged);
            // 
            // subjectGroupBox
            // 
            this.subjectGroupBox.Controls.Add(this.subjectComboBox);
            this.subjectGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectGroupBox.Location = new System.Drawing.Point(28, 26);
            this.subjectGroupBox.Name = "subjectGroupBox";
            this.subjectGroupBox.Size = new System.Drawing.Size(258, 82);
            this.subjectGroupBox.TabIndex = 12;
            this.subjectGroupBox.TabStop = false;
            this.subjectGroupBox.Text = "Subject";
            // 
            // startDateGroupBox
            // 
            this.startDateGroupBox.Controls.Add(this.StartDatePicker);
            this.startDateGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDateGroupBox.Location = new System.Drawing.Point(28, 212);
            this.startDateGroupBox.Name = "startDateGroupBox";
            this.startDateGroupBox.Size = new System.Drawing.Size(258, 82);
            this.startDateGroupBox.TabIndex = 13;
            this.startDateGroupBox.TabStop = false;
            this.startDateGroupBox.Text = "Start Date";
            // 
            // StartDatePicker
            // 
            this.StartDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartDatePicker.Location = new System.Drawing.Point(29, 34);
            this.StartDatePicker.Name = "StartDatePicker";
            this.StartDatePicker.Size = new System.Drawing.Size(200, 29);
            this.StartDatePicker.TabIndex = 0;
            this.StartDatePicker.ValueChanged += new System.EventHandler(this.StartDatePicker_ValueChanged);
            // 
            // endDateGroupBox
            // 
            this.endDateGroupBox.Controls.Add(this.dateTimePicker1);
            this.endDateGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDateGroupBox.Location = new System.Drawing.Point(28, 387);
            this.endDateGroupBox.Name = "endDateGroupBox";
            this.endDateGroupBox.Size = new System.Drawing.Size(258, 82);
            this.endDateGroupBox.TabIndex = 14;
            this.endDateGroupBox.TabStop = false;
            this.endDateGroupBox.Text = "End Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(29, 34);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 29);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // GenerateButton
            // 
            this.GenerateButton.BackColor = System.Drawing.Color.Green;
            this.GenerateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenerateButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.GenerateButton.Location = new System.Drawing.Point(71, 555);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(172, 48);
            this.GenerateButton.TabIndex = 15;
            this.GenerateButton.Text = "Generate";
            this.GenerateButton.UseVisualStyleBackColor = false;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox1.Location = new System.Drawing.Point(320, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(2, 937);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox2.Location = new System.Drawing.Point(28, 687);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(275, 2);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            // 
            // dailyPrizeGroupBox
            // 
            this.dailyPrizeGroupBox.Controls.Add(this.RandomNameTextbox);
            this.dailyPrizeGroupBox.Controls.Add(this.PrizeButton);
            this.dailyPrizeGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dailyPrizeGroupBox.Location = new System.Drawing.Point(28, 728);
            this.dailyPrizeGroupBox.Name = "dailyPrizeGroupBox";
            this.dailyPrizeGroupBox.Size = new System.Drawing.Size(258, 189);
            this.dailyPrizeGroupBox.TabIndex = 15;
            this.dailyPrizeGroupBox.TabStop = false;
            this.dailyPrizeGroupBox.Text = "Daily Prize";
            // 
            // RandomNameTextbox
            // 
            this.RandomNameTextbox.Location = new System.Drawing.Point(43, 128);
            this.RandomNameTextbox.Name = "RandomNameTextbox";
            this.RandomNameTextbox.Size = new System.Drawing.Size(172, 35);
            this.RandomNameTextbox.TabIndex = 19;
            // 
            // PrizeButton
            // 
            this.PrizeButton.BackColor = System.Drawing.Color.Teal;
            this.PrizeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrizeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PrizeButton.Location = new System.Drawing.Point(43, 46);
            this.PrizeButton.Name = "PrizeButton";
            this.PrizeButton.Size = new System.Drawing.Size(172, 48);
            this.PrizeButton.TabIndex = 18;
            this.PrizeButton.Text = "Click Me!";
            this.PrizeButton.UseVisualStyleBackColor = false;
            this.PrizeButton.Click += new System.EventHandler(this.PrizeButton_Click);
            // 
            // centerStatsChart
            // 
            chartArea1.Name = "ChartArea1";
            this.centerStatsChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.centerStatsChart.Legends.Add(legend1);
            this.centerStatsChart.Location = new System.Drawing.Point(516, 60);
            this.centerStatsChart.Name = "centerStatsChart";
            this.centerStatsChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.centerStatsChart.Series.Add(series1);
            this.centerStatsChart.Size = new System.Drawing.Size(1130, 560);
            this.centerStatsChart.TabIndex = 18;
            this.centerStatsChart.Text = "chart1";
            // 
            // CenterStatsTable
            // 
            this.CenterStatsTable.BackColor = System.Drawing.Color.White;
            this.CenterStatsTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.CenterStatsTable.ColumnCount = 2;
            this.CenterStatsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.CenterStatsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CenterStatsTable.Controls.Add(this.AverageTimeValue, 1, 4);
            this.CenterStatsTable.Controls.Add(this.StudentAverageValue, 1, 3);
            this.CenterStatsTable.Controls.Add(this.label1, 0, 4);
            this.CenterStatsTable.Controls.Add(this.AverageStudentsLabel, 0, 3);
            this.CenterStatsTable.Controls.Add(this.TotalTimeLabel, 0, 2);
            this.CenterStatsTable.Controls.Add(this.SummaryLabel, 0, 0);
            this.CenterStatsTable.Controls.Add(this.TotalStudentsLabel, 0, 1);
            this.CenterStatsTable.Controls.Add(this.TotalStudentsValue, 1, 1);
            this.CenterStatsTable.Controls.Add(this.TotalTimeValue, 1, 2);
            this.CenterStatsTable.Location = new System.Drawing.Point(742, 648);
            this.CenterStatsTable.Name = "CenterStatsTable";
            this.CenterStatsTable.RowCount = 5;
            this.CenterStatsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.CenterStatsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.CenterStatsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.CenterStatsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.CenterStatsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.CenterStatsTable.Size = new System.Drawing.Size(669, 286);
            this.CenterStatsTable.TabIndex = 19;
            // 
            // SummaryLabel
            // 
            this.SummaryLabel.AutoSize = true;
            this.SummaryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SummaryLabel.Location = new System.Drawing.Point(15, 14);
            this.SummaryLabel.Name = "SummaryLabel";
            this.SummaryLabel.Size = new System.Drawing.Size(129, 31);
            this.SummaryLabel.TabIndex = 0;
            this.SummaryLabel.Text = "Summary";
            // 
            // TotalStudentsLabel
            // 
            this.TotalStudentsLabel.AutoSize = true;
            this.TotalStudentsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalStudentsLabel.Location = new System.Drawing.Point(17, 72);
            this.TotalStudentsLabel.Name = "TotalStudentsLabel";
            this.TotalStudentsLabel.Size = new System.Drawing.Size(151, 25);
            this.TotalStudentsLabel.TabIndex = 1;
            this.TotalStudentsLabel.Text = "Total Students";
            // 
            // TotalTimeLabel
            // 
            this.TotalTimeLabel.AutoSize = true;
            this.TotalTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalTimeLabel.Location = new System.Drawing.Point(17, 128);
            this.TotalTimeLabel.Name = "TotalTimeLabel";
            this.TotalTimeLabel.Size = new System.Drawing.Size(175, 25);
            this.TotalTimeLabel.TabIndex = 20;
            this.TotalTimeLabel.Text = "Total Time Spent";
            // 
            // AverageStudentsLabel
            // 
            this.AverageStudentsLabel.AutoSize = true;
            this.AverageStudentsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AverageStudentsLabel.Location = new System.Drawing.Point(20, 183);
            this.AverageStudentsLabel.Name = "AverageStudentsLabel";
            this.AverageStudentsLabel.Size = new System.Drawing.Size(264, 25);
            this.AverageStudentsLabel.TabIndex = 20;
            this.AverageStudentsLabel.Text = "Average Students per Day";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "Average Time per Student per Day";
            // 
            // TotalStudentsValue
            // 
            this.TotalStudentsValue.AutoSize = true;
            this.TotalStudentsValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalStudentsValue.Location = new System.Drawing.Point(510, 74);
            this.TotalStudentsValue.Name = "TotalStudentsValue";
            this.TotalStudentsValue.Size = new System.Drawing.Size(142, 25);
            this.TotalStudentsValue.TabIndex = 20;
            this.TotalStudentsValue.Text = "num-students";
            // 
            // TotalTimeValue
            // 
            this.TotalTimeValue.AutoSize = true;
            this.TotalTimeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalTimeValue.Location = new System.Drawing.Point(520, 130);
            this.TotalTimeValue.Name = "TotalTimeValue";
            this.TotalTimeValue.Size = new System.Drawing.Size(100, 25);
            this.TotalTimeValue.TabIndex = 20;
            this.TotalTimeValue.Text = "total-time";
            // 
            // StudentAverageValue
            // 
            this.StudentAverageValue.AutoSize = true;
            this.StudentAverageValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentAverageValue.Location = new System.Drawing.Point(502, 185);
            this.StudentAverageValue.Name = "StudentAverageValue";
            this.StudentAverageValue.Size = new System.Drawing.Size(168, 25);
            this.StudentAverageValue.TabIndex = 20;
            this.StudentAverageValue.Text = "student-average";
            // 
            // AverageTimeValue
            // 
            this.AverageTimeValue.AutoSize = true;
            this.AverageTimeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AverageTimeValue.Location = new System.Drawing.Point(512, 242);
            this.AverageTimeValue.Name = "AverageTimeValue";
            this.AverageTimeValue.Size = new System.Drawing.Size(137, 25);
            this.AverageTimeValue.TabIndex = 20;
            this.AverageTimeValue.Text = "time-average";
            // 
            // CenterStatsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1001);
            this.Controls.Add(this.CenterStatsTable);
            this.Controls.Add(this.centerStatsChart);
            this.Controls.Add(this.dailyPrizeGroupBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GenerateButton);
            this.Controls.Add(this.endDateGroupBox);
            this.Controls.Add(this.startDateGroupBox);
            this.Controls.Add(this.subjectGroupBox);
            this.Controls.Add(this.adminTab);
            this.Controls.Add(this.studentTab);
            this.Controls.Add(this.loginTab);
            this.MaximumSize = new System.Drawing.Size(1920, 1040);
            this.Name = "CenterStatsForm";
            this.Text = "SLC Attendance System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.subjectGroupBox.ResumeLayout(false);
            this.startDateGroupBox.ResumeLayout(false);
            this.endDateGroupBox.ResumeLayout(false);
            this.dailyPrizeGroupBox.ResumeLayout(false);
            this.dailyPrizeGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.centerStatsChart)).EndInit();
            this.CenterStatsTable.ResumeLayout(false);
            this.CenterStatsTable.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button adminTab;
        private System.Windows.Forms.Button studentTab;
        private System.Windows.Forms.Button loginTab;
        private System.Windows.Forms.ComboBox subjectComboBox;
        private System.Windows.Forms.GroupBox subjectGroupBox;
        private System.Windows.Forms.GroupBox startDateGroupBox;
        private System.Windows.Forms.GroupBox endDateGroupBox;
        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox dailyPrizeGroupBox;
        private System.Windows.Forms.Button PrizeButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart centerStatsChart;
        private System.Windows.Forms.TableLayoutPanel CenterStatsTable;
        private System.Windows.Forms.DateTimePicker StartDatePicker;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox RandomNameTextbox;
        private System.Windows.Forms.Label AverageTimeValue;
        private System.Windows.Forms.Label StudentAverageValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label AverageStudentsLabel;
        private System.Windows.Forms.Label TotalTimeLabel;
        private System.Windows.Forms.Label SummaryLabel;
        private System.Windows.Forms.Label TotalStudentsLabel;
        private System.Windows.Forms.Label TotalStudentsValue;
        private System.Windows.Forms.Label TotalTimeValue;
    }
}