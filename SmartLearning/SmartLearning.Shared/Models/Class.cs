using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SmartLearning.Shared.Models
{
    [Table("Class")]
    public class Class
    {
        public Class()
        {
            DateSheet = new List<TimeTable>();
            Enrollments = new List<Enrollment>();
        }
        public int Id { get; set; }

        [Required(ErrorMessage ="Name is required")]
        [MaxLength(20,ErrorMessage ="Enter valid Name. Max '20'")]
        [MinLength(3, ErrorMessage = "Enter valid Name. Min '3'")]
        public string Name { get; set; }
        
        public ICollection<TimeTable> DateSheet { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
