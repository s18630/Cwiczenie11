using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cwiczenie11.Models
{
    public class Medicament
    {
        [Key]
        public int IdMedicament { get; set; } // jak dodac ze to id
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
    }
}
