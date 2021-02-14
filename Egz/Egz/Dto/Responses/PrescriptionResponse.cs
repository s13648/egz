using System;

namespace Egz.Dto.Responses
{
    public class PrescriptionResponse
    {
        public int IdPrescription { get; set; }
        public DateTime Date { get; set; }
        public DateTime DueDate { get; set; }
    }
}