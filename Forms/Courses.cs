using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyExtendedSchoolDB;


namespace Forms
{
    public partial class Courses : Form
    {
        public Courses()
        {
            InitializeComponent();
        }

        Program.SchoolContext _context;
        List<Program.Course> AllCourses;
        List<Program.Teacher> AllTeachers;

        protected override void OnLoad(EventArgs e)
        {
            //LLAMADA A LOS DATOS
            _context = new Program.SchoolContext();
            AllCourses = _context.Course.ToList();

            //INTRODUZCO LOS DATOS EN EL FORMULARIO
            program_CourseBindingSource.DataSource = AllCourses;

            //////////////////

            AllTeachers = _context.Teachers.ToList();
            TeachersComboBox.DataSource = AllTeachers;
            

        }

        protected override void OnClosing(CancelEventArgs e)
        {
            this.Validate();

            this._context.SaveChanges(); //IMPORTANTE


            base.OnClosing(e);
            this._context.Dispose();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            var newCourse = new Program.Course();

            program_CourseBindingSource.Add(newCourse);
            _context.Course.Add(newCourse);                 

        }



        private void button2_Click(object sender, EventArgs e)
        {

            var CourseDelete = (MyExtendedSchoolDB.Program.Course)program_CourseBindingSource.Current;
            program_CourseBindingSource.RemoveCurrent();
            _context.Course.Remove(CourseDelete);

        }

        private void buscarNombreBtn_Click(object sender, EventArgs e)
        {
            var textoFiltro = this.filtroTextBox.Text;

            /*
            var filtered = from s in AllCourses
                           where s.CourseName.Contains(textoFiltro)
                           //where s.CourseName.Equals(textoFiltro, StringComparison.CurrentCultureIgnoreCase)
                           select s;
             */


            var filtered = from s in AllCourses
                           where s.CourseName.ToLower().Contains(textoFiltro.ToLower())
                           select s;

            program_CourseBindingSource.DataSource = filtered;
        }

        private void TeachersComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var teacherElegido = (Program.Teacher)TeachersComboBox.SelectedItem;

        }

        

    }
}
