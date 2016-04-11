using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyExtendedSchoolDB
{
    public class Program
    {
        public class Student
        {
            public Student()
            {

            }
            public int StudentID { get; set; }
            public string StudentName { get; set; }
            public DateTime DateOfBirth { get; set; }
            public byte[] Photo { get; set; }
            public decimal Height { get; set; }
            public float Weight { get; set; }
            public int calification { get; set; }

            public int? CourseId { get; set; }

            //Navigation property
            public virtual ICollection<Course> Courses { get; set; }
        }

        public class StudentAddress
        {
            public int StudentAddressId { get; set; }
            public string Address1 { get; set; }
            public string Address2 { get; set; }
            public string City { get; set; }
            public int Zipcode { get; set; }
            public string State { get; set; }
            public string Country { get; set; }

            public virtual Student Student { get; set; }
        }

        public class Teacher
        {
            public Teacher()
            {

            }
            public int TeacherId { get; set; }
            public string TeacherName { get; set; }
            
            public int? CourseId { get; set; }

            public virtual ICollection<Course> Courses { get; set; }
        }

        public class Course
        {
            public Course()
            {

            }
            public int CourseId { get; set; }
            public string CourseName { get; set; }

            // Foreign key
            //[ForeignKey("TeacherId")]
            public int? TeacherId { get; set; }
            public int? StudentId { get; set; }

            //Navigation properties
            public virtual Teacher Teacher { get; set; }
            //public virtual ICollection<Student> Students { get; set; }
            public virtual Student Student { get; set; }

        }

        public class TimeTable
        {
            public int TimeTableId { get; set; }
            public string titulo { get; set; }
        }

        //Para actualizar: Update-Database -ProjectName MyExtendedSchoolDB -Verbose -Force
        public class SchoolContext : DbContext
        {
            public SchoolContext()
                : base()
            {

            }

            public DbSet<Student> Students { get; set; }
            public DbSet<Teacher> Teachers { get; set; }
            public DbSet<StudentAddress> StudentAddress { get; set; }
            public DbSet<Course> Course { get; set; }
            public DbSet<TimeTable> TimeTables { get; set; }

        }

        static void Main(string[] args)
        {

            var _context = new SchoolContext();

            var teacher1 = _context.Teachers.FirstOrDefault(t=>t.TeacherId==1);
            var coursesListTeacher1 = teacher1.Courses;

            var Courses = _context.Course.ToList();

            var coursesTeacher1Alt = (from c in Courses
                                      where c.TeacherId == 1
                                      select c).ToList();

            /*peter.Weight = 91;

            var newStudent = new Student();
            newStudent.Weight = 88;
            newStudent.StudentName = "Luis";
            newStudent.DateOfBirth = new DateTime(1999, 1, 1);


            _context.Students.Add(newStudent);

            _context.SaveChanges();
             */
            
        }
    }
}
