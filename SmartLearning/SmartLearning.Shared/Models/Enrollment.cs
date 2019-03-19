using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SmartLearning.Shared.Models
{
    [Table("Enrollment")]
    public class Enrollment
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();

        public string StudentId { get; set; }

        public Student Student { get; set; }

        public int ClassId { get; set; }

        public Class Class { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:ddd dd MMM yyyy}")]
        public DateTime? Date { get; set; }
    }
}
