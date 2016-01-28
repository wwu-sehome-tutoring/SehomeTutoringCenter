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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.adminTab = new System.Windows.Forms.Button();
            this.studentTab = new System.Windows.Forms.Button();
            this.loginTab = new System.Windows.Forms.Button();
            this.subjectComboBox = new System.Windows.Forms.ComboBox();
            this.subjectGroupBox = new System.Windows.Forms.GroupBox();
            this.startDateGroupBox = new System.Windows.Forms.GroupBox();
            this.endDateGroupBox = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dailyPrizeGroupBox = new System.Windows.Forms.GroupBox();
            this.randomStudentListbox = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.centerStatsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.CenterStatsTable = new System.Windows.Forms.TableLayoutPanel();
            this.StartDatePicker = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.subjectGroupBox.SuspendLayout();
            this.startDateGroupBox.SuspendLayout();
            this.endDateGroupBox.SuspendLayout();
            this.dailyPrizeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.centerStatsChart)).BeginInit();
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.Location = new System.Drawing.Point(71, 555);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 48);
            this.button1.TabIndex = 15;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.dailyPrizeGroupBox.Controls.Add(this.randomStudentListbox);
            this.dailyPrizeGroupBox.Controls.Add(this.button2);
            this.dailyPrizeGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dailyPrizeGroupBox.Location = new System.Drawing.Point(28, 728);
            this.dailyPrizeGroupBox.Name = "dailyPrizeGroupBox";
            this.dailyPrizeGroupBox.Size = new System.Drawing.Size(258, 189);
            this.dailyPrizeGroupBox.TabIndex = 15;
            this.dailyPrizeGroupBox.TabStop = false;
            this.dailyPrizeGroupBox.Text = "Daily Prize";
            // 
            // randomStudentListbox
            // 
            this.randomStudentListbox.FormattingEnabled = true;
            this.randomStudentListbox.ItemHeight = 29;
            this.randomStudentListbox.Items.AddRange(new object[] {
            "Student name..."});
            this.randomStudentListbox.Location = new System.Drawing.Point(43, 126);
            this.randomStudentListbox.Name = "randomStudentListbox";
            this.randomStudentListbox.Size = new System.Drawing.Size(172, 33);
            this.randomStudentListbox.TabIndex = 19;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Teal;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button2.Location = new System.Drawing.Point(43, 46);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(172, 48);
            this.button2.TabIndex = 18;
            this.button2.Text = "Click Me!";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // centerStatsChart
            // 
            chartArea2.Name = "ChartArea1";
            this.centerStatsChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.centerStatsChart.Legends.Add(legend2);
            this.centerStatsChart.Location = new System.Drawing.Point(516, 60);
            this.centerStatsChart.Name = "centerStatsChart";
            this.centerStatsChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.centerStatsChart.Series.Add(series2);
            this.centerStatsChart.Size = new System.Drawing.Size(1130, 560);
            this.centerStatsChart.TabIndex = 18;
            this.centerStatsChart.Text = "chart1";
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.Name = "Center Information";
            title2.Text = "Center Information";
            this.centerStatsChart.Titles.Add(title2);
            // 
            // CenterStatsTable
            // 
            this.CenterStatsTable.BackColor = System.Drawing.Color.White;
            this.CenterStatsTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.CenterStatsTable.ColumnCount = 2;
            this.CenterStatsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.CenterStatsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
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
            // StartDatePicker
            // 
            this.StartDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartDatePicker.Location = new System.Drawing.Point(29, 34);
            this.StartDatePicker.Name = "StartDatePicker";
            this.StartDatePicker.Size = new System.Drawing.Size(200, 29);
            this.StartDatePicker.TabIndex = 0;
            this.StartDatePicker.ValueChanged += new System.EventHandler(this.StartDatePicker_ValueChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(29, 34);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 29);
            this.dateTimePicker1.TabIndex = 0;
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
            this.Controls.Add(this.button1);
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
            this.Load += new System.EventHandler(this.CenterStatsForm_Load);
            this.subjectGroupBox.ResumeLayout(false);
            this.startDateGroupBox.ResumeLayout(false);
            this.endDateGroupBox.ResumeLayout(false);
            this.dailyPrizeGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.centerStatsChart)).EndInit();
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox dailyPrizeGroupBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox randomStudentListbox;
        private System.Windows.Forms.DataVisualization.Charting.Chart centerStatsChart;
        private System.Windows.Forms.TableLayoutPanel CenterStatsTable;
        private System.Windows.Forms.DateTimePicker StartDatePicker;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}