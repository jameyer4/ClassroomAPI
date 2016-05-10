using ClassroomAPI.Models.DB_Models;
using System.Data.Entity;

namespace ClassroomAPI.Models
{
    public class ClassroomContext : DbContext
    {
        //public ClassroomContext() : base("name=ClassroomContext")
        //{
        //    Database.SetInitializer<ClassroomContext>(null);
        //}

        public DbSet<Student> Students { get; set; }

        public DbSet<Subject> Subjects { get; set; }

        public DbSet<Tasks> Tasks { get; set; }

        public DbSet<Teacher> Teacher { get; set; }

        public DbSet<StudentMark> StudentMark { get; set; }

        public DbSet<TeacherSubjects> TeacherSubjects { get; set; }

        public DbSet<Notes> Notes { get; set; }

    }
}