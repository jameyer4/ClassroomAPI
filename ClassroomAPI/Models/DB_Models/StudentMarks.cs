using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClassroomAPI.Models.DB_Models
{
    public partial class StudentMarks
    {
        public int Id { get; set; }
        public int TeacherSubjectId { get; set; }
        public int StudentId { get; set; }
        public double? Mark { get; set; }
        public int UserId { get; set; }
        public int TaskId { get; set; }
    }
    public partial class StudentMarks
    {
        public List<StudentMarks> StudentMarkList { get; set; }
    }
}