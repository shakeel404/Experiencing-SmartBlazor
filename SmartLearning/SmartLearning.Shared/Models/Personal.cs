using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartLearning.Shared.Models
{
   [Table("Personal")]
   [NotMapped]
    public  class Personal 
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();   

        [Required(ErrorMessage ="First Name is required")]
        [MaxLength(10,ErrorMessage ="Enter a valid first name. Max '10'")]
        [MinLength(3,ErrorMessage ="Enter a valid first name. Min '3'")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required")]
        [MaxLength(10, ErrorMessage = "Enter a valid last name. Max '10'")]
        [MinLength(3, ErrorMessage = "Enter a valid last name. Min '3'")]
        public string LastName { get; set; }


        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:ddd dd MMM yyyy}")]
        [DataType(DataType.Date)]
        public DateTime? DateOfBirth { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "Gender is required")]
        [MaxLength(10, ErrorMessage = "Enter a valid gender. Max '10'")] 
        public string Gender { get; set; } 

        [Required(ErrorMessage = " Religion is required")]
        [MaxLength(20, ErrorMessage = "Enter valid religion. Max '20'")]
        [MinLength(3, ErrorMessage = "Enter valid religion. Min '3'")]
        public string Religion { get; set; }

        [Required(ErrorMessage = " Nationality is required")]
        [MaxLength(20, ErrorMessage = "Enter valid nationality. Max '20'")]
        [MinLength(3, ErrorMessage = "Enter valid nationality. Min '3'")]
        public string Nationality { get; set; }
    }
}
