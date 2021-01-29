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
    //    public int IdPatient { get; set; }
      //  public int IdDoctor{ get; set; }



        [ForeignKey("IdDoctor")]
       // public int idDoctor { get; set; }
        public  Doctor doctor { get; set; }

        [ForeignKey("IdPatient")]
       // public int idPatient { get; set; }
        public Patient patient { get; set; }


        public virtual ICollection<Prescription_Medicament> Prescription_Medicaments { get; set; }
    }
}
