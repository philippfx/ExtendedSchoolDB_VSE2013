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
    public partial class Students : Form
    {
        public Students()
        {
            InitializeComponent();

        }

        Program.SchoolContext _context;

        protected override void OnLoad(EventArgs e)
        {
            //LLAMADA A LOS DATOS
            _context = new Program.SchoolContext();
            var Students = _context.Students.ToList();

            //ORDENO LOS DATOS
            var studentsPorPeso = (from s in Students
                                   orderby s.Weight
                                   select s).ToList();

            //INTRODUZCO LOS DATOS EN EL FORMULARIO
            program_StudentBindingSource.DataSource = studentsPorPeso;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            this.Validate();

            this._context.SaveChanges();//IMPORTANTE


            base.OnClosing(e);
            this._context.Dispose();
        }

        private void newStudentButton_Click(object sender, EventArgs e)
        {
            var newStudent = new Program.Student();

            program_StudentBindingSource.Add(newStudent);
            _context.Students.Add(newStudent);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
    }
}
