using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SmartLearning.Shared.Models
{
    [Table("Student")]
    public class Student : Personal
    {
        public Student()
        {
            Enrollments = new List<Enrollment>(); 
        } 
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
