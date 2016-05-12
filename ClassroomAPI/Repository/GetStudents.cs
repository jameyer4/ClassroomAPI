using ClassroomAPI.Models;
using ClassroomAPI.Models.DB_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClassroomAPI.Repository
{
    public class GetStudents
    {
        //  GetTeachers teachers = new GetTeachers();
        // GetMarks marks = new GetMarks();
        // GetSubjects subjects = new GetSubjects();

        private readonly ClassroomContext _db = new ClassroomContext();

        public List<Student> GetAllStudents()
        {
            List<Student> students = _db.Students.ToList();
            return students;
        }

        public Student GetStudentById(int id)
        {
            Student student = _db.Students.Where(x => x.Id.Equals(id)).Single();
            return student;
        }

        public List<Student> GetStudentsByTeacherUsername(string user)
        {
            var userId = new GetUsers().GetUsersByUsername(user).Id;
            var markList = new GetMarks().GetMarksByUserId(userId).Where(m => m.TeacherSubjectId.Equals(1));
            List<Student> students = new List<Student>();
            foreach (var x in markList)
            {
                students.Add(GetStudentById(x.StudentId));
            }
            return students;
        }
        //public Student GetStudentByStudentTaskId(int id)
        //{
        //    var sId = new GetStudentTasks().GetStudentTasksById(id).StudentId;
        //    var student = GetStudentById(sId);
        //    return student;
        //}
    }
}