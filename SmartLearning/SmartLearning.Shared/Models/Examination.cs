using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SmartLearning.Shared.Models
{
    [Table("Examination")]
    public class Examination
    {
        public Examination()
        {
            DateSheet = new List<TimeTable>();
        }

        public string Id { get; set; } = Guid.NewGuid().ToString();

        public string Term { get; set; }

        [Display(Name = "Starts")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:ddd dd MMM yyyy}")]
        public DateTime? Start { get; set; }

        [Display(Name = "Ends")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:ddd dd MMM yyyy}")]
        public DateTime? End { get; set; }

        [Display(Name = "Result Declares On")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:ddd dd MMM yyyy}")]
        public DateTime? ResultDeclaration { get; set; }

        [MaxLength(100,ErrorMessage ="Commints should not exceed 100")]
        public string Comments { get; set; }

        public ICollection<TimeTable> DateSheet { get; set; }
    }
}
