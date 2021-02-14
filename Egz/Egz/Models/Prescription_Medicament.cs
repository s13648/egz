using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Egz.Models
{
    public class Prescription_Medicament
    {
        public int IdMedicament { get; set; }

        public virtual Medicament Medicament { get; set; }

        public int IdPrescription { get; set; }

        [ForeignKey("IdPrescription")]
        public virtual Prescription Prescription { get; set; }

        public int? Dose { get; set; }

        [MaxLength(100)] 
        [Required]
        public string Details { get; set; }
    }
}