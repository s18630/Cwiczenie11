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
       
        public int id { get; set; } // jak dodac ze to id
        public int Dose { get; set; }
        public string Details { get; set; }



        [ForeignKey("IdPrescription")]
     
        public Prescription Prescription { get; set; }

        [ForeignKey("IdMedicament")]
        public Medicament Medicament { get; set; }


      
    }
}
