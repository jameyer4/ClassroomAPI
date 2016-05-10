using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClassroomAPI.Models.DB_Models
{
    public partial class StudentMark
    {
        public int Id { get; set; }
        public int TeacherSubjectId { get; set; }
        public int StudentId { get; set; }
        public double? Mark { get; set; }
        public int TeacherId { get; set; }
        public int TaskId { get; set; }
    }
    public partial class StudentMark
    {
        public List<StudentMark> StudentMarkList { get; set; }
    }
}