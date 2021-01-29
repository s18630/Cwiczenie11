using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cwiczenie11.DTOs
{
    public class ModifyDoctorRequest
    {
        [Required]
        public int idDoctor { get; set; } // jak dodac ze to id
        public string FirstName { get; set; }
      
        public string LastName { get; set; }
        public string Email { get; set; }
    }
}

