using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Egz.Models
{
    public class Medicament
    {
        [Key] 
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdMedicament { get; set; }

        [MaxLength(100)] 
        [Required]
        public string Name { get; set; }

        [MaxLength(100)] 
        [Required]
        public string Description { get; set; }

        [MaxLength(100)] 
        [Required]
        public string Type { get; set; }

        [ForeignKey("IdMedicament")]
        public virtual ICollection<Prescription_Medicament> PrescriptionMedicaments { get; set; }
    }
}