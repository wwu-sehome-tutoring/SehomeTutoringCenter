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
            this.currentStudents = new System.Windows.Forms.Label();
            this.subjectOptions = new System.Windows.Forms.Label();
            this.dataOptions = new System.Windows.Forms.Label();
            this.addSubject = new System.Windows.Forms.Button();
            this.removeSubject = new System.Windows.Forms.Button();
            this.backupData = new System.Windows.Forms.Button();
            this.importData = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // currentStudents
            // 
            this.currentStudents.AutoSize = true;
            this.currentStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentStudents.Location = new System.Drawing.Point(13, 13);
            this.currentStudents.Name = "currentStudents";
            this.currentStudents.Size = new System.Drawing.Size(240, 36);
            this.currentStudents.TabIndex = 0;
            this.currentStudents.Text = "Current Students";
            this.currentStudents.Click += new System.EventHandler(this.label1_Click);
            // 
            // subjectOptions
            // 
            this.subjectOptions.AutoSize = true;
            this.subjectOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectOptions.Location = new System.Drawing.Point(14, 408);
            this.subjectOptions.Name = "subjectOptions";
            this.subjectOptions.Size = new System.Drawing.Size(184, 29);
            this.subjectOptions.TabIndex = 1;
            this.subjectOptions.Text = "Subject Options";
            // 
            // dataOptions
            // 
            this.dataOptions.AutoSize = true;
            this.dataOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataOptions.Location = new System.Drawing.Point(383, 408);
            this.dataOptions.Name = "dataOptions";
            this.dataOptions.Size = new System.Drawing.Size(152, 29);
            this.dataOptions.TabIndex = 2;
            this.dataOptions.Text = "Data Options";
            // 
            // addSubject
            // 
            this.addSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.addSubject.Location = new System.Drawing.Point(19, 474);
            this.addSubject.Name = "addSubject";
            this.addSubject.Size = new System.Drawing.Size(160, 37);
            this.addSubject.TabIndex = 3;
            this.addSubject.Text = "Add Subject";
            this.addSubject.UseVisualStyleBackColor = true;
            // 
            // removeSubject
            // 
            this.removeSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.removeSubject.Location = new System.Drawing.Point(19, 535);
            this.removeSubject.Name = "removeSubject";
            this.removeSubject.Size = new System.Drawing.Size(160, 37);
            this.removeSubject.TabIndex = 4;
            this.removeSubject.Text = "Remove Subject";
            this.removeSubject.UseVisualStyleBackColor = true;
            // 
            // backupData
            // 
            this.backupData.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.backupData.Location = new System.Drawing.Point(388, 474);
            this.backupData.Name = "backupData";
            this.backupData.Size = new System.Drawing.Size(160, 37);
            this.backupData.TabIndex = 5;
            this.backupData.Text = "Backup Data";
            this.backupData.UseVisualStyleBackColor = true;
            // 
            // importData
            // 
            this.importData.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.importData.Location = new System.Drawing.Point(388, 535);
            this.importData.Name = "importData";
            this.importData.Size = new System.Drawing.Size(160, 37);
            this.importData.TabIndex = 6;
            this.importData.Text = "Import Data";
            this.importData.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(824, 319);
            this.dataGridView1.TabIndex = 7;
            // 
            // adminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 635);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.importData);
            this.Controls.Add(this.backupData);
            this.Controls.Add(this.removeSubject);
            this.Controls.Add(this.addSubject);
            this.Controls.Add(this.dataOptions);
            this.Controls.Add(this.subjectOptions);
            this.Controls.Add(this.currentStudents);
            this.Name = "adminForm";
            this.Text = "Administration";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label currentStudents;
        private System.Windows.Forms.Label subjectOptions;
        private System.Windows.Forms.Label dataOptions;
        private System.Windows.Forms.Button addSubject;
        private System.Windows.Forms.Button removeSubject;
        private System.Windows.Forms.Button backupData;
        private System.Windows.Forms.Button importData;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}