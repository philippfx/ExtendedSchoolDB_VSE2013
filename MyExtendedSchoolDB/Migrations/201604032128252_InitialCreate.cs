namespace MyExtendedSchoolDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        CourseId = c.Int(nullable: false, identity: true),
                        CourseName = c.String(),
                        Teacher_TeacherId = c.Int(),
                    })
                .PrimaryKey(t => t.CourseId)
                .ForeignKey("dbo.Teachers", t => t.Teacher_TeacherId)
                .Index(t => t.Teacher_TeacherId);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudentID = c.Int(nullable: false, identity: true),
                        StudentName = c.String(),
                        DateOfBirth = c.DateTime(nullable: false),
                        Photo = c.Binary(),
                        Height = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Weight = c.Single(nullable: false),
                        calification = c.Int(nullable: false),
                        Course_CourseId = c.Int(),
                        Teacher_TeacherId = c.Int(),
                    })
                .PrimaryKey(t => t.StudentID)
                .ForeignKey("dbo.Courses", t => t.Course_CourseId)
                .ForeignKey("dbo.Teachers", t => t.Teacher_TeacherId)
                .Index(t => t.Course_CourseId)
                .Index(t => t.Teacher_TeacherId);
            
            CreateTable(
                "dbo.Teachers",
                c => new
                    {
                        TeacherId = c.Int(nullable: false, identity: true),
                        TeacherName = c.String(),
                    })
                .PrimaryKey(t => t.TeacherId);
            
            CreateTable(
                "dbo.StudentAddresses",
                c => new
                    {
                        StudentAddressId = c.Int(nullable: false, identity: true),
                        Address1 = c.String(),
                        Address2 = c.String(),
                        City = c.String(),
                        Zipcode = c.Int(nullable: false),
                        State = c.String(),
                        Country = c.String(),
                        Student_StudentID = c.Int(),
                    })
                .PrimaryKey(t => t.StudentAddressId)
                .ForeignKey("dbo.Students", t => t.Student_StudentID)
                .Index(t => t.Student_StudentID);
            
            CreateTable(
                "dbo.TimeTables",
                c => new
                    {
                        TimeTableId = c.Int(nullable: false, identity: true),
                        titulo = c.String(),
                    })
                .PrimaryKey(t => t.TimeTableId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StudentAddresses", "Student_StudentID", "dbo.Students");
            DropForeignKey("dbo.Courses", "Teacher_TeacherId", "dbo.Teachers");
            DropForeignKey("dbo.Students", "Teacher_TeacherId", "dbo.Teachers");
            DropForeignKey("dbo.Students", "Course_CourseId", "dbo.Courses");
            DropIndex("dbo.StudentAddresses", new[] { "Student_StudentID" });
            DropIndex("dbo.Students", new[] { "Teacher_TeacherId" });
            DropIndex("dbo.Students", new[] { "Course_CourseId" });
            DropIndex("dbo.Courses", new[] { "Teacher_TeacherId" });
            DropTable("dbo.TimeTables");
            DropTable("dbo.StudentAddresses");
            DropTable("dbo.Teachers");
            DropTable("dbo.Students");
            DropTable("dbo.Courses");
        }
    }
}
