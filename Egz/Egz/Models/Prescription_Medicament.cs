﻿using System.ComponentModel.DataAnnotations;

namespace Egz.Models
{
    public class Prescription_Medicament
    {
        public int IdMedicament { get; set; }

        public int IdPrescription { get; set; }

        public int? Dose { get; set; }

        [MaxLength(100)] 
        [Required]
        public string Details { get; set; }
    }
}