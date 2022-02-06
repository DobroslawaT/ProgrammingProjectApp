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
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Gender { get; set; }
        [DisplayName("Date of birth")]
        public string DateOfBirth { get; set; }
        public string Email { get; set; }
        [DisplayName("Choose an offer")]
        public string Offer { get; set; }
    }

    
}