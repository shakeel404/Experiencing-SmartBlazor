using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartLearning.Shared.Models
{
    [Table("Contact")]
    public class Contact
    {
        public string Id { get; set; } = Guid.NewGuid().ToString(); 

        [Required(ErrorMessage ="Type is required")] 
        [MaxLength(20,ErrorMessage ="Enter a valid type")]
        public string Type { get; set; }

        [Required(ErrorMessage = "Contact is required")]
        [MaxLength(30, ErrorMessage = "Enter a valid Detail. Max 30")]
        [MinLength(10, ErrorMessage = "Enter a valid Detail. Min 10")]
        public string Detail { get; set; }

        public string IsVarified { get; set; }
    }
}