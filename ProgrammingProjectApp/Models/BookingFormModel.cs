using System.Runtime.InteropServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ProgrammingProjectApp.Models
{
    public class BookingForm
    {
        [System.ComponentModel.DataAnnotations.Key]
        [Required]
        public int Id { get; set; }
        [Required, RegularExpression("[a-zA-Z]", ErrorMessage = "Name has to contain only letters")]
        public string Name { get; set; }
        [Required, RegularExpression("[a-zA-Z]", ErrorMessage ="Surname has to contain only letters")]
        public string Surname { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        [DisplayName("Date of birth")]
        public string DateOfBirth { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        [DisplayName("Choose an offer")]
        public string Offer { get; set; }
    }

    
}