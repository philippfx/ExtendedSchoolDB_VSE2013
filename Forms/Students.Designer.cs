namespace Forms
{
    partial class Students
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
            System.Windows.Forms.Label studentNameLabel;
            System.Windows.Forms.Label weightLabel;
            System.Windows.Forms.Label dateOfBirthLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Students));
            this.program_StudentBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.program_StudentBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.program_StudentBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.studentNameTextBox = new System.Windows.Forms.TextBox();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.dateOfBirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.newStudentButton = new System.Windows.Forms.Button();
            this.EditStudentName = new System.Windows.Forms.Button();
            studentNameLabel = new System.Windows.Forms.Label();
            weightLabel = new System.Windows.Forms.Label();
            dateOfBirthLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.program_StudentBindingNavigator)).BeginInit();
            this.program_StudentBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.program_StudentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // studentNameLabel
            // 
            studentNameLabel.AutoSize = true;
            studentNameLabel.Location = new System.Drawing.Point(51, 134);
            studentNameLabel.Name = "studentNameLabel";
            studentNameLabel.Size = new System.Drawing.Size(78, 13);
            studentNameLabel.TabIndex = 1;
            studentNameLabel.Text = "Student Name:";
            // 
            // weightLabel
            // 
            weightLabel.AutoSize = true;
            weightLabel.Location = new System.Drawing.Point(85, 182);
            weightLabel.Name = "weightLabel";
            weightLabel.Size = new System.Drawing.Size(44, 13);
            weightLabel.TabIndex = 3;
            weightLabel.Text = "Weight:";
            // 
            // dateOfBirthLabel
            // 
            dateOfBirthLabel.AutoSize = true;
            dateOfBirthLabel.Location = new System.Drawing.Point(58, 228);
            dateOfBirthLabel.Name = "dateOfBirthLabel";
            dateOfBirthLabel.Size = new System.Drawing.Size(71, 13);
            dateOfBirthLabel.TabIndex = 5;
            dateOfBirthLabel.Text = "Date Of Birth:";
            // 
            // program_StudentBindingNavigator
            // 
            this.program_StudentBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.program_StudentBindingNavigator.BindingSource = this.program_StudentBindingSource;
            this.program_StudentBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.program_StudentBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.program_StudentBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.program_StudentBindingNavigatorSaveItem});
            this.program_StudentBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.program_StudentBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.program_StudentBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.program_StudentBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.program_StudentBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.program_StudentBindingNavigator.Name = "program_StudentBindingNavigator";
            this.program_StudentBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.program_StudentBindingNavigator.Size = new System.Drawing.Size(526, 25);
            this.program_StudentBindingNavigator.TabIndex = 0;
            this.program_StudentBindingNavigator.Text = "bindingNavigator1";
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
            // program_StudentBindingSource
            // 
            this.program_StudentBindingSource.DataSource = typeof(MyExtendedSchoolDB.Program.Student);
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
            // program_StudentBindingNavigatorSaveItem
            // 
            this.program_StudentBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.program_StudentBindingNavigatorSaveItem.Enabled = false;
            this.program_StudentBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("program_StudentBindingNavigatorSaveItem.Image")));
            this.program_StudentBindingNavigatorSaveItem.Name = "program_StudentBindingNavigatorSaveItem";
            this.program_StudentBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.program_StudentBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // studentNameTextBox
            // 
            this.studentNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.program_StudentBindingSource, "StudentName", true));
            this.studentNameTextBox.Location = new System.Drawing.Point(135, 131);
            this.studentNameTextBox.Name = "studentNameTextBox";
            this.studentNameTextBox.ReadOnly = true;
            this.studentNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.studentNameTextBox.TabIndex = 2;
            // 
            // weightTextBox
            // 
            this.weightTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.program_StudentBindingSource, "Weight", true));
            this.weightTextBox.Location = new System.Drawing.Point(135, 179);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(100, 20);
            this.weightTextBox.TabIndex = 4;
            // 
            // dateOfBirthDateTimePicker
            // 
            this.dateOfBirthDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.program_StudentBindingSource, "DateOfBirth", true));
            this.dateOfBirthDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateOfBirthDateTimePicker.Location = new System.Drawing.Point(135, 224);
            this.dateOfBirthDateTimePicker.Name = "dateOfBirthDateTimePicker";
            this.dateOfBirthDateTimePicker.Size = new System.Drawing.Size(100, 20);
            this.dateOfBirthDateTimePicker.TabIndex = 6;
            // 
            // newStudentButton
            // 
            this.newStudentButton.Location = new System.Drawing.Point(135, 300);
            this.newStudentButton.Name = "newStudentButton";
            this.newStudentButton.Size = new System.Drawing.Size(87, 33);
            this.newStudentButton.TabIndex = 7;
            this.newStudentButton.Text = "Crear Nuevo";
            this.newStudentButton.UseVisualStyleBackColor = true;
            this.newStudentButton.Click += new System.EventHandler(this.newStudentButton_Click);
            // 
            // EditStudentName
            // 
            this.EditStudentName.Location = new System.Drawing.Point(251, 129);
            this.EditStudentName.Name = "EditStudentName";
            this.EditStudentName.Size = new System.Drawing.Size(117, 23);
            this.EditStudentName.TabIndex = 8;
            this.EditStudentName.Text = "Edit Student Name";
            this.EditStudentName.UseVisualStyleBackColor = true;
            this.EditStudentName.Click += new System.EventHandler(this.EditStudentName_Click);
            // 
            // Students
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 408);
            this.Controls.Add(this.EditStudentName);
            this.Controls.Add(this.newStudentButton);
            this.Controls.Add(dateOfBirthLabel);
            this.Controls.Add(this.dateOfBirthDateTimePicker);
            this.Controls.Add(weightLabel);
            this.Controls.Add(this.weightTextBox);
            this.Controls.Add(studentNameLabel);
            this.Controls.Add(this.studentNameTextBox);
            this.Controls.Add(this.program_StudentBindingNavigator);
            this.Name = "Students";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.program_StudentBindingNavigator)).EndInit();
            this.program_StudentBindingNavigator.ResumeLayout(false);
            this.program_StudentBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.program_StudentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource program_StudentBindingSource;
        private System.Windows.Forms.BindingNavigator program_StudentBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton program_StudentBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox studentNameTextBox;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.DateTimePicker dateOfBirthDateTimePicker;
        private System.Windows.Forms.Button newStudentButton;
        private System.Windows.Forms.Button EditStudentName;
    }
}

