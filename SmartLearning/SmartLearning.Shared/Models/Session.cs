using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SmartLearning.Shared.Models
{
    [Table("Session")]
    public class Session
    {
        public int Id { get; set; } 

        public string Note { get; set; }

        [Display(Name = "Starts")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:ddd dd MMM yyyy}")]
        public DateTime? Start { get; set; }

        [Display(Name = "Ends")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:ddd dd MMM yyyy}")]
        public DateTime? End { get; set; } 
    }
}
