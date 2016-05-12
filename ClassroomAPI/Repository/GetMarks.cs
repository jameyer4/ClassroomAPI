using ClassroomAPI.Models;
using ClassroomAPI.Models.DB_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClassroomAPI.Repository
{
    public class GetMarks
    {
        ClassroomContext _db = new ClassroomContext();
        // GetTeachers teachers = new GetTeachers();
        // GetSubjects subjects = new GetSubjects();

        public List<StudentMarks> GetAllMarks()
        {
            var marks = _db.StudentMark.ToList();
            return marks;
        }
        public List<StudentMarks> GetMarksById(int id)
        {
            var marks = _db.StudentMark.Where(m => m.Id.Equals(id)).ToList();
            return marks;
        }
        public List<StudentMarks> GetMarksByStudentId(int id)
        {
            var marks = _db.StudentMark.Where(m => m.StudentId.Equals(id)).ToList();
            return marks;
        }
        public List<StudentMarks> GetMarksByUserId(int id)
        {
            // var teacher = new GetTeachers().GetTeacherById(id);
            var marks = GetAllMarks().Where(m => m.UserId.Equals(id)).ToList();
            return marks;
        }
    }
}