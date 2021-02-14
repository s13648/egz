using System.Collections.Generic;
using Egz.Models;

namespace Egz.Dto.Responses
{
    public class MedicamentResponse
    {
        public int IdMedicament { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public ICollection<PrescriptionResponse> Prescription { get; set; }
    }
}