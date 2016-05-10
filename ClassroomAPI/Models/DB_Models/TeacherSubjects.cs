using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ClassroomAPI.Models.DB_Models
{
    public partial class TeacherSubjects
    {
        public int Id { get; set; }
        public int TeacherId { get; set; }
        public int SubjectId { get; set; }
    }
    public partial class TeacherSubjects
    {
        [NotMapped]
        public List<TeacherSubjects> TeacherSubjectsList { get; set; }
    }
}