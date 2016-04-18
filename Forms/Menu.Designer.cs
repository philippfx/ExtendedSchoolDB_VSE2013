namespace Forms
{
    partial class Menu
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
            this.ShowStudents = new System.Windows.Forms.Button();
            this.ShowTeachers = new System.Windows.Forms.Button();
            this.ShowCourses = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ShowStudents
            // 
            this.ShowStudents.Location = new System.Drawing.Point(101, 55);
            this.ShowStudents.Name = "ShowStudents";
            this.ShowStudents.Size = new System.Drawing.Size(75, 23);
            this.ShowStudents.TabIndex = 0;
            this.ShowStudents.Text = "Students";
            this.ShowStudents.UseVisualStyleBackColor = true;
            this.ShowStudents.Click += new System.EventHandler(this.ShowStudents_Click);
            // 
            // ShowTeachers
            // 
            this.ShowTeachers.Location = new System.Drawing.Point(101, 104);
            this.ShowTeachers.Name = "ShowTeachers";
            this.ShowTeachers.Size = new System.Drawing.Size(75, 23);
            this.ShowTeachers.TabIndex = 1;
            this.ShowTeachers.Text = "Teachers";
            this.ShowTeachers.UseVisualStyleBackColor = true;
            this.ShowTeachers.Click += new System.EventHandler(this.ShowTeachers_Click);
            // 
            // ShowCourses
            // 
            this.ShowCourses.Location = new System.Drawing.Point(101, 158);
            this.ShowCourses.Name = "ShowCourses";
            this.ShowCourses.Size = new System.Drawing.Size(75, 23);
            this.ShowCourses.TabIndex = 2;
            this.ShowCourses.Text = "Courses";
            this.ShowCourses.UseVisualStyleBackColor = true;
            this.ShowCourses.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(198, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Text 1";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ShowCourses);
            this.Controls.Add(this.ShowTeachers);
            this.Controls.Add(this.ShowStudents);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ShowStudents;
        private System.Windows.Forms.Button ShowTeachers;
        private System.Windows.Forms.Button ShowCourses;
        private System.Windows.Forms.Label label1;
    }
}