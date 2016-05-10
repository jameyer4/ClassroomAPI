using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClassroomAPI.Models.DB_Models
{
    public partial class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public partial class Subject
    {
        [NotMapped]
        public List<Subject> SubjectList { get; set; }
    }
}