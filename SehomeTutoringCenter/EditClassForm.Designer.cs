namespace SehomeTutoringCenter
{
    partial class EditClassForm
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
            this.AddGroupBox = new System.Windows.Forms.GroupBox();
            this.AddClassButton = new System.Windows.Forms.Button();
            this.TeacherNameTB = new System.Windows.Forms.TextBox();
            this.ClassNameTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RemoveClassGB = new System.Windows.Forms.GroupBox();
            this.ClassList = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.RemoveClassButton = new System.Windows.Forms.Button();
            this.AddGroupBox.SuspendLayout();
            this.RemoveClassGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddGroupBox
            // 
            this.AddGroupBox.Controls.Add(this.AddClassButton);
            this.AddGroupBox.Controls.Add(this.TeacherNameTB);
            this.AddGroupBox.Controls.Add(this.ClassNameTB);
            this.AddGroupBox.Controls.Add(this.label2);
            this.AddGroupBox.Controls.Add(this.label1);
            this.AddGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddGroupBox.Location = new System.Drawing.Point(12, 12);
            this.AddGroupBox.Name = "AddGroupBox";
            this.AddGroupBox.Size = new System.Drawing.Size(352, 230);
            this.AddGroupBox.TabIndex = 0;
            this.AddGroupBox.TabStop = false;
            this.AddGroupBox.Text = "Add Class";
            // 
            // AddClassButton
            // 
            this.AddClassButton.BackColor = System.Drawing.Color.Green;
            this.AddClassButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddClassButton.ForeColor = System.Drawing.Color.White;
            this.AddClassButton.Location = new System.Drawing.Point(106, 163);
            this.AddClassButton.Name = "AddClassButton";
            this.AddClassButton.Size = new System.Drawing.Size(124, 37);
            this.AddClassButton.TabIndex = 5;
            this.AddClassButton.Text = "Add Class";
            this.AddClassButton.UseVisualStyleBackColor = false;
            this.AddClassButton.Click += new System.EventHandler(this.AddClassButton_Click);
            // 
            // TeacherNameTB
            // 
            this.TeacherNameTB.Location = new System.Drawing.Point(106, 101);
            this.TeacherNameTB.Name = "TeacherNameTB";
            this.TeacherNameTB.Size = new System.Drawing.Size(226, 31);
            this.TeacherNameTB.TabIndex = 3;
            // 
            // ClassNameTB
            // 
            this.ClassNameTB.Location = new System.Drawing.Point(106, 48);
            this.ClassNameTB.Name = "ClassNameTB";
            this.ClassNameTB.Size = new System.Drawing.Size(226, 31);
            this.ClassNameTB.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Teacher";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // RemoveClassGB
            // 
            this.RemoveClassGB.Controls.Add(this.ClassList);
            this.RemoveClassGB.Controls.Add(this.label3);
            this.RemoveClassGB.Controls.Add(this.RemoveClassButton);
            this.RemoveClassGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveClassGB.Location = new System.Drawing.Point(389, 12);
            this.RemoveClassGB.Name = "RemoveClassGB";
            this.RemoveClassGB.Size = new System.Drawing.Size(352, 160);
            this.RemoveClassGB.TabIndex = 6;
            this.RemoveClassGB.TabStop = false;
            this.RemoveClassGB.Text = "Remove Class";
            // 
            // ClassList
            // 
            this.ClassList.FormattingEnabled = true;
            this.ClassList.Location = new System.Drawing.Point(92, 48);
            this.ClassList.Name = "ClassList";
            this.ClassList.Size = new System.Drawing.Size(233, 33);
            this.ClassList.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Name";
            // 
            // RemoveClassButton
            // 
            this.RemoveClassButton.BackColor = System.Drawing.Color.Green;
            this.RemoveClassButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveClassButton.ForeColor = System.Drawing.Color.White;
            this.RemoveClassButton.Location = new System.Drawing.Point(117, 101);
            this.RemoveClassButton.Name = "RemoveClassButton";
            this.RemoveClassButton.Size = new System.Drawing.Size(124, 37);
            this.RemoveClassButton.TabIndex = 5;
            this.RemoveClassButton.Text = "Remove Class";
            this.RemoveClassButton.UseVisualStyleBackColor = false;
            this.RemoveClassButton.Click += new System.EventHandler(this.RemoveClassButton_Click);
            // 
            // EditClassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 289);
            this.Controls.Add(this.RemoveClassGB);
            this.Controls.Add(this.AddGroupBox);
            this.Name = "EditClassForm";
            this.Text = "EditClassForm";
            this.AddGroupBox.ResumeLayout(false);
            this.AddGroupBox.PerformLayout();
            this.RemoveClassGB.ResumeLayout(false);
            this.RemoveClassGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox AddGroupBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TeacherNameTB;
        private System.Windows.Forms.TextBox ClassNameTB;
        private System.Windows.Forms.Button AddClassButton;
        private System.Windows.Forms.GroupBox RemoveClassGB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button RemoveClassButton;
        private System.Windows.Forms.ComboBox ClassList;
    }
}