using ClassroomAPI.Controllers;
using ClassroomAPI.Models.DB_Models;
using System.Data.Entity;

namespace ClassroomAPI.Models
{
    public class ClassroomContext : DbContext
    {
        public ClassroomContext() : base("name=DefaultConnection")
        {
            Database.SetInitializer<ClassroomContext>(null);
        }

        public DbSet<Student> Students { get; set; }

        public DbSet<Subject> Subjects { get; set; }

        public DbSet<Tasks> Tasks { get; set; }

        public DbSet<Users> Users { get; set; }

        public DbSet<StudentMarks> StudentMark { get; set; }

        public DbSet<TeacherSubjects> TeacherSubjects { get; set; }

        public DbSet<Notes> Notes { get; set; }

    }
}