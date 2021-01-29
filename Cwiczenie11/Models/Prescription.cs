using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Cwiczenie11.Models
{
    public class Prescription
    {
        [Key]
        public int IdPrescription { get; set; } // jak dodac ze to id
        public DateTime Date { get; set; }
        public DateTime DueDate { get; set; }



        [ForeignKey("IdDoctor")]
     
        public  Doctor doctor { get; set; }

        [ForeignKey("IdPatient")]
        public Patient patient { get; set; }


        public virtual ICollection<Prescription_Medicament> Prescription_Medicaments { get; set; }
    }
}
