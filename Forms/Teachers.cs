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
    public partial class Teachers : Form
    {
        public Teachers()
        {
            InitializeComponent();
        }

        Program.SchoolContext _context;
        List<Program.Teacher> AllTeachers;

        protected override void OnLoad(EventArgs e)
        {
            //LLAMADA A LOS DATOS
            _context = new Program.SchoolContext();
            var Teachers = _context.Teachers.ToList();

            //INTRODUZCO LOS DATOS EN EL FORMULARIO
            program_TeacherBindingSource.DataSource = Teachers;

           

            
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            this.Validate();

            this._context.SaveChanges();//IMPORTANTE


            base.OnClosing(e);
            this._context.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var newTeacher = new Program.Teacher();

            program_TeacherBindingSource.Add(newTeacher);
            _context.Teachers.Add(newTeacher);
        }

        public void nombreCurso_Click(object sender, EventArgs e)
        {
           //1. 
            var currentTeacher = (MyExtendedSchoolDB.Program.Teacher)program_TeacherBindingSource.Current;
            
            var myItems = new List<string> { "a", "b", "c" };
            listBox1.DataSource = myItems;

            var Courses = _context.Course.ToList();

            //var ListOfCourses = currentTeacher.Courses.ToList();
            
            var ListOfCourses = _context.Course.SelectMany(x => x.CourseName);

            /*var ListOfCourses = (from c in Courses
                              where c.TeacherId == currentTeacher.TeacherId
                              select c).FirstOrDefault().CourseName;*/

            listBox2.DataSource = ListOfCourses; 



            //var ListCourseNameOfCurrentTeacher = new List<string> 
            //listBox2.DataSource = ListCourseNameOfCurrentTeacher;




            /*
            //main
            string mensaje = currentTeacher.Courses.Skip(1).FirstOrDefault().CourseName;
            MessageBox.Show(mensaje);

            //alt
            var Courses = _context.Course.ToList();
            
            var mensajeAlt = (from c in Courses
                              where c.TeacherId == currentTeacher.TeacherId
                              select c).FirstOrDefault().CourseName;
            MessageBox.Show(mensajeAlt);
             */
            





        }
    }
}
