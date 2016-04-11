using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void ShowStudents_Click(object sender, EventArgs e)
        {
            Students ShowStudents = new Students();
            ShowStudents.Show();
        }

        private void ShowTeachers_Click(object sender, EventArgs e)
        {
            Teachers ShowTeachers = new Teachers();
            ShowTeachers.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Courses ShowCourses = new Courses();
            ShowCourses.Show();
        }
    }
}
