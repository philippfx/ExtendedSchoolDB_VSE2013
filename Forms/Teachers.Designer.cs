namespace Forms
{
    partial class Teachers
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
            System.Windows.Forms.Label teacherNameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Teachers));
            this.program_TeacherBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.program_TeacherBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.program_TeacherBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.teacherNameTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.nombreCurso = new System.Windows.Forms.Button();
            this.program_StudentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            teacherNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.program_TeacherBindingNavigator)).BeginInit();
            this.program_TeacherBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.program_TeacherBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.program_StudentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // teacherNameLabel
            // 
            teacherNameLabel.AutoSize = true;
            teacherNameLabel.Location = new System.Drawing.Point(16, 55);
            teacherNameLabel.Name = "teacherNameLabel";
            teacherNameLabel.Size = new System.Drawing.Size(81, 13);
            teacherNameLabel.TabIndex = 1;
            teacherNameLabel.Text = "Teacher Name:";
            // 
            // program_TeacherBindingNavigator
            // 
            this.program_TeacherBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.program_TeacherBindingNavigator.BindingSource = this.program_TeacherBindingSource;
            this.program_TeacherBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.program_TeacherBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.program_TeacherBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.program_TeacherBindingNavigatorSaveItem});
            this.program_TeacherBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.program_TeacherBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.program_TeacherBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.program_TeacherBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.program_TeacherBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.program_TeacherBindingNavigator.Name = "program_TeacherBindingNavigator";
            this.program_TeacherBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.program_TeacherBindingNavigator.Size = new System.Drawing.Size(727, 25);
            this.program_TeacherBindingNavigator.TabIndex = 0;
            this.program_TeacherBindingNavigator.Text = "bindingNavigator1";
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
            // program_TeacherBindingSource
            // 
            this.program_TeacherBindingSource.DataSource = typeof(MyExtendedSchoolDB.Program.Teacher);
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
            // program_TeacherBindingNavigatorSaveItem
            // 
            this.program_TeacherBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.program_TeacherBindingNavigatorSaveItem.Enabled = false;
            this.program_TeacherBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("program_TeacherBindingNavigatorSaveItem.Image")));
            this.program_TeacherBindingNavigatorSaveItem.Name = "program_TeacherBindingNavigatorSaveItem";
            this.program_TeacherBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.program_TeacherBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // teacherNameTextBox
            // 
            this.teacherNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.program_TeacherBindingSource, "TeacherName", true));
            this.teacherNameTextBox.Location = new System.Drawing.Point(103, 52);
            this.teacherNameTextBox.Name = "teacherNameTextBox";
            this.teacherNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.teacherNameTextBox.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(64, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Crear nuevo";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nombreCurso
            // 
            this.nombreCurso.Location = new System.Drawing.Point(320, 55);
            this.nombreCurso.Name = "nombreCurso";
            this.nombreCurso.Size = new System.Drawing.Size(116, 46);
            this.nombreCurso.TabIndex = 5;
            this.nombreCurso.Text = "Nombre del primer curso del profesor";
            this.nombreCurso.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.nombreCurso.UseVisualStyleBackColor = true;
            this.nombreCurso.Click += new System.EventHandler(this.nombreCurso_Click);
            // 
            // program_StudentBindingSource
            // 
            this.program_StudentBindingSource.DataSource = typeof(MyExtendedSchoolDB.Program.Student);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(31, 120);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 8;
            // 
            // listBox2
            // 
            this.listBox2.DisplayMember = "CourseName";
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(173, 120);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(473, 95);
            this.listBox2.TabIndex = 9;
            // 
            // Teachers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 548);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.nombreCurso);
            this.Controls.Add(this.button1);
            this.Controls.Add(teacherNameLabel);
            this.Controls.Add(this.teacherNameTextBox);
            this.Controls.Add(this.program_TeacherBindingNavigator);
            this.Name = "Teachers";
            this.Text = "Teachers";
            this.Load += new System.EventHandler(this.Teachers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.program_TeacherBindingNavigator)).EndInit();
            this.program_TeacherBindingNavigator.ResumeLayout(false);
            this.program_TeacherBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.program_TeacherBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.program_StudentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Teachers_Load(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.BindingSource program_TeacherBindingSource;
        private System.Windows.Forms.BindingNavigator program_TeacherBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton program_TeacherBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox teacherNameTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button nombreCurso;
        private System.Windows.Forms.BindingSource program_StudentBindingSource;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
    }
}