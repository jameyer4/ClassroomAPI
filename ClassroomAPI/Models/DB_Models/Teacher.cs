using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClassroomAPI.Models.DB_Models
{
    public partial class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
    }
    public partial class Teacher
    {
        [NotMapped]
        public List<Teacher> TeacherList { get; set; }
    }
}