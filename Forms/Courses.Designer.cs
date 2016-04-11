namespace Forms
{
    partial class Courses
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label courseNameLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label teacherIdLabel;
            System.Windows.Forms.Label teacherNameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Courses));
            System.Windows.Forms.Label studentIDLabel;
            System.Windows.Forms.Label studentNameLabel;
            this.program_CourseBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.program_CourseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.program_CourseBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.courseNameTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataRepeater1 = new Microsoft.VisualBasic.PowerPacks.DataRepeater();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buscarNombreBtn = new System.Windows.Forms.Button();
            this.filtroTextBox = new System.Windows.Forms.TextBox();
            this.TeachersComboBox = new System.Windows.Forms.ComboBox();
            this.program_TeacherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teacherIdTextBox = new System.Windows.Forms.TextBox();
            this.teacherNameTextBox = new System.Windows.Forms.TextBox();
            this.studentIDTextBox = new System.Windows.Forms.TextBox();
            this.studentNameTextBox = new System.Windows.Forms.TextBox();
            courseNameLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            teacherIdLabel = new System.Windows.Forms.Label();
            teacherNameLabel = new System.Windows.Forms.Label();
            studentIDLabel = new System.Windows.Forms.Label();
            studentNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.program_CourseBindingNavigator)).BeginInit();
            this.program_CourseBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.program_CourseBindingSource)).BeginInit();
            this.dataRepeater1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.program_TeacherBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // courseNameLabel
            // 
            courseNameLabel.AutoSize = true;
            courseNameLabel.Location = new System.Drawing.Point(31, 67);
            courseNameLabel.Name = "courseNameLabel";
            courseNameLabel.Size = new System.Drawing.Size(74, 13);
            courseNameLabel.TabIndex = 1;
            courseNameLabel.Text = "Course Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(283, 51);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(83, 13);
            label1.TabIndex = 9;
            label1.Text = "Asignar profesor";
            // 
            // teacherIdLabel
            // 
            teacherIdLabel.AutoSize = true;
            teacherIdLabel.Location = new System.Drawing.Point(43, 216);
            teacherIdLabel.Name = "teacherIdLabel";
            teacherIdLabel.Size = new System.Drawing.Size(62, 13);
            teacherIdLabel.TabIndex = 10;
            teacherIdLabel.Text = "Teacher Id:";
            // 
            // teacherNameLabel
            // 
            teacherNameLabel.AutoSize = true;
            teacherNameLabel.Location = new System.Drawing.Point(24, 254);
            teacherNameLabel.Name = "teacherNameLabel";
            teacherNameLabel.Size = new System.Drawing.Size(81, 13);
            teacherNameLabel.TabIndex = 12;
            teacherNameLabel.Text = "Teacher Name:";
            // 
            // program_CourseBindingNavigator
            // 
            this.program_CourseBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.program_CourseBindingNavigator.BindingSource = this.program_CourseBindingSource;
            this.program_CourseBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.program_CourseBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.program_CourseBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.program_CourseBindingNavigatorSaveItem});
            this.program_CourseBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.program_CourseBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.program_CourseBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.program_CourseBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.program_CourseBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.program_CourseBindingNavigator.Name = "program_CourseBindingNavigator";
            this.program_CourseBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.program_CourseBindingNavigator.Size = new System.Drawing.Size(835, 25);
            this.program_CourseBindingNavigator.TabIndex = 0;
            this.program_CourseBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // program_CourseBindingSource
            // 
            this.program_CourseBindingSource.DataSource = typeof(MyExtendedSchoolDB.Program.Course);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // program_CourseBindingNavigatorSaveItem
            // 
            this.program_CourseBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.program_CourseBindingNavigatorSaveItem.Enabled = false;
            this.program_CourseBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("program_CourseBindingNavigatorSaveItem.Image")));
            this.program_CourseBindingNavigatorSaveItem.Name = "program_CourseBindingNavigatorSaveItem";
            this.program_CourseBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.program_CourseBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // courseNameTextBox
            // 
            this.courseNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.program_CourseBindingSource, "CourseName", true));
            this.courseNameTextBox.Location = new System.Drawing.Point(111, 64);
            this.courseNameTextBox.Name = "courseNameTextBox";
            this.courseNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.courseNameTextBox.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(44, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Crear Nuevo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(125, 100);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Remove";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataRepeater1
            // 
            // 
            // dataRepeater1.ItemTemplate
            // 
            this.dataRepeater1.ItemTemplate.Size = new System.Drawing.Size(343, 56);
            this.dataRepeater1.Location = new System.Drawing.Point(286, 212);
            this.dataRepeater1.Name = "dataRepeater1";
            this.dataRepeater1.Size = new System.Drawing.Size(351, 100);
            this.dataRepeater1.TabIndex = 5;
            this.dataRepeater1.Text = "dataRepeater1";
            // 
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataMember = "Students";
            this.studentsBindingSource.DataSource = this.program_CourseBindingSource;
            // 
            // buscarNombreBtn
            // 
            this.buscarNombreBtn.Location = new System.Drawing.Point(547, 119);
            this.buscarNombreBtn.Name = "buscarNombreBtn";
            this.buscarNombreBtn.Size = new System.Drawing.Size(75, 23);
            this.buscarNombreBtn.TabIndex = 6;
            this.buscarNombreBtn.Text = "Buscar nombre";
            this.buscarNombreBtn.UseVisualStyleBackColor = true;
            this.buscarNombreBtn.Click += new System.EventHandler(this.buscarNombreBtn_Click);
            // 
            // filtroTextBox
            // 
            this.filtroTextBox.Location = new System.Drawing.Point(533, 93);
            this.filtroTextBox.Name = "filtroTextBox";
            this.filtroTextBox.Size = new System.Drawing.Size(100, 20);
            this.filtroTextBox.TabIndex = 7;
            // 
            // TeachersComboBox
            // 
            this.TeachersComboBox.DisplayMember = "TeacherName";
            this.TeachersComboBox.Location = new System.Drawing.Point(286, 67);
            this.TeachersComboBox.Name = "TeachersComboBox";
            this.TeachersComboBox.Size = new System.Drawing.Size(167, 21);
            this.TeachersComboBox.TabIndex = 8;
            this.TeachersComboBox.SelectionChangeCommitted += new System.EventHandler(this.TeachersComboBox_SelectionChangeCommitted);
            // 
            // program_TeacherBindingSource
            // 
            this.program_TeacherBindingSource.DataSource = typeof(MyExtendedSchoolDB.Program.Teacher);
            // 
            // teacherIdTextBox
            // 
            this.teacherIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.program_CourseBindingSource, "Teacher.TeacherId", true));
            this.teacherIdTextBox.Location = new System.Drawing.Point(111, 213);
            this.teacherIdTextBox.Name = "teacherIdTextBox";
            this.teacherIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.teacherIdTextBox.TabIndex = 11;
            // 
            // teacherNameTextBox
            // 
            this.teacherNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.program_CourseBindingSource, "Teacher.TeacherName", true));
            this.teacherNameTextBox.Location = new System.Drawing.Point(111, 251);
            this.teacherNameTextBox.Name = "teacherNameTextBox";
            this.teacherNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.teacherNameTextBox.TabIndex = 13;
            // 
            // studentIDLabel
            // 
            studentIDLabel.AutoSize = true;
            studentIDLabel.Location = new System.Drawing.Point(109, 355);
            studentIDLabel.Name = "studentIDLabel";
            studentIDLabel.Size = new System.Drawing.Size(61, 13);
            studentIDLabel.TabIndex = 14;
            studentIDLabel.Text = "Student ID:";
            // 
            // studentIDTextBox
            // 
            this.studentIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.program_CourseBindingSource, "Student.StudentID", true));
            this.studentIDTextBox.Location = new System.Drawing.Point(176, 352);
            this.studentIDTextBox.Name = "studentIDTextBox";
            this.studentIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.studentIDTextBox.TabIndex = 15;
            // 
            // studentNameLabel
            // 
            studentNameLabel.AutoSize = true;
            studentNameLabel.Location = new System.Drawing.Point(111, 396);
            studentNameLabel.Name = "studentNameLabel";
            studentNameLabel.Size = new System.Drawing.Size(78, 13);
            studentNameLabel.TabIndex = 16;
            studentNameLabel.Text = "Student Name:";
            // 
            // studentNameTextBox
            // 
            this.studentNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.program_CourseBindingSource, "Student.StudentName", true));
            this.studentNameTextBox.Location = new System.Drawing.Point(195, 393);
            this.studentNameTextBox.Name = "studentNameTextBox";
            this.studentNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.studentNameTextBox.TabIndex = 17;
            // 
            // Courses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 483);
            this.Controls.Add(studentNameLabel);
            this.Controls.Add(this.studentNameTextBox);
            this.Controls.Add(studentIDLabel);
            this.Controls.Add(this.studentIDTextBox);
            this.Controls.Add(teacherNameLabel);
            this.Controls.Add(this.teacherNameTextBox);
            this.Controls.Add(teacherIdLabel);
            this.Controls.Add(this.teacherIdTextBox);
            this.Controls.Add(label1);
            this.Controls.Add(this.TeachersComboBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.courseNameTextBox);
            this.Controls.Add(this.filtroTextBox);
            this.Controls.Add(this.buscarNombreBtn);
            this.Controls.Add(this.dataRepeater1);
            this.Controls.Add(this.button1);
            this.Controls.Add(courseNameLabel);
            this.Controls.Add(this.program_CourseBindingNavigator);
            this.Name = "Courses";
            this.Text = "Courses";
            this.Load += new System.EventHandler(this.Courses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.program_CourseBindingNavigator)).EndInit();
            this.program_CourseBindingNavigator.ResumeLayout(false);
            this.program_CourseBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.program_CourseBindingSource)).EndInit();
            this.dataRepeater1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.program_TeacherBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Courses_Load(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.BindingSource program_CourseBindingSource;
        private System.Windows.Forms.BindingNavigator program_CourseBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton program_CourseBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox courseNameTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private Microsoft.VisualBasic.PowerPacks.DataRepeater dataRepeater1;
        private System.Windows.Forms.Button buscarNombreBtn;
        private System.Windows.Forms.TextBox filtroTextBox;
        private System.Windows.Forms.ComboBox TeachersComboBox;
        private System.Windows.Forms.BindingSource program_TeacherBindingSource;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private System.Windows.Forms.TextBox teacherIdTextBox;
        private System.Windows.Forms.TextBox teacherNameTextBox;
        private System.Windows.Forms.TextBox studentIDTextBox;
        private System.Windows.Forms.TextBox studentNameTextBox;
    }
}