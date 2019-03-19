using SmartLearning.Shared.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SmartLearning.Shared.Models
{

    [Table("TimeTable")]
    public class TimeTable
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();

        public string ExaminationId { get; set; }

        public int ClassId { get; set; }

        public int SubjectId { get; set; }

        public Examination Examination { get; set; }

        public Class Class { get; set; }

        public Subject Subject { get; set; }

        public DateTime? DateAndTime { get; set; }

        [Display(Name ="Theory Allowed")]
        [Required(ErrorMessage ="Marks is required")]  
        [Range(1,1000,ErrorMessage ="Marks Should be greater then 0")]
        public int TheoryAllowedMarks { get; set; }

        [Display(Name = "Theory Passing")] 
        [Required(ErrorMessage ="Marks is required")] 
        [PassingMarksComparer(nameof(TheoryAllowedMarks))]
        public int TheoryPassingMarks { get; set; }

        [Display(Name = "Practical Allowed")] 
        [Required(ErrorMessage = "Marks is required")] 
        public int PracticalAllowedMarks { get; set; }

        [Display(Name = "Practical Passing")]
        [Required(ErrorMessage = "Marks is required")]
        [PassingMarksComparer(nameof(PracticalAllowedMarks))]
        public int PracticalPassingMarks { get; set; }
        
    }
}
