using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartLearning.Shared.Models
{
    [Table("Address")]
    public class Address
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();  

        [Required(ErrorMessage ="Street is required")]
        [MaxLength(20, ErrorMessage ="Enter valid street.Max '20'")]
        [MinLength(3, ErrorMessage ="Enter valid street. Min '3'")]
        public string Street { get; set; }

        [Required(ErrorMessage = "City is required")]
        [MaxLength(20, ErrorMessage = "Enter valid city. Max '20'")]
        [MinLength(3, ErrorMessage = "Enter valid city. Min '3'")]
        public string City { get; set; }

        [Required(ErrorMessage = " Province is required")]
        [MaxLength(20, ErrorMessage = "Enter valid province. Max '20'")]
        [MinLength(3, ErrorMessage = "Enter valid province. Min '3'")]
        public string StateOrProvince { get; set; }

        [Required(ErrorMessage = " Country is required")]
        [MaxLength(20, ErrorMessage = "Enter valid country. Max '20'")]
        [MinLength(3, ErrorMessage = "Enter valid country. Min '3'")]
        public string Country { get; set; } = "Pakistan";
    }
}
