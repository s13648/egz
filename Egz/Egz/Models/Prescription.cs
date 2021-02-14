using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Egz.Models
{
    public class Prescription
    {
        [Key] 
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdPrescription { get; set; }

        [Required]
        public DateTime Date { get; set; }
        
        [Required]
        public DateTime DueDate { get; set; }
        
        [Required]
        public int IdPatient { get; set; }

        public virtual Patient Patient { get; set; }
        
        [Required]
        public int IdDoctor { get; set; }

        public ICollection<Prescription_Medicament> PrescriptionMedicaments { get; set; }
    }
}