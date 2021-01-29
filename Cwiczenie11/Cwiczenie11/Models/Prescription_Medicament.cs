using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Cwiczenie11.Models
{
    public class Prescription_Medicament
    {
      
        [Key]
        public int id { get; set; }


        [ForeignKey("IdPrescription")]
        // public int idDoctor { get; set; }
        public Prescription Prescription { get; set; }

        [ForeignKey("IdMedicament")]
        // public int idPatient { get; set; }
        public Medicament Medicament { get; set; }

        public int?  Dose { get; set; }
        public string Details { get; set; }

        
     
       

    }
}
