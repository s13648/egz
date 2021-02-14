using System.Linq;
using System.Threading.Tasks;
using Egz.Dto.Responses;
using Egz.Models;
using Egz.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Egz.Repositories
{
    public class MedicamentRepository : IMedicamentRepository
    {
        private readonly EgzDbContext context;

        public MedicamentRepository(EgzDbContext context)
        {
            this.context = context;
        }
        public async Task<MedicamentResponse> GetById(int id)
        {
            return await context.Medicaments
                .Where(n => n.IdMedicament == id)
                .Select(n => new MedicamentResponse
                {
                    IdMedicament = n.IdMedicament,
                    Name = n.Name,
                    Description = n.Description,
                    Type = n.Type,
                    Prescription = n.PrescriptionMedicaments
                        .Select(p => new PrescriptionResponse
                        {
                            Date = p.Prescription.Date,
                            DueDate = p.Prescription.DueDate,
                            IdPrescription = p.IdPrescription
                        }).OrderByDescending(p => p.Date)
                        .ToList()
                })
                .FirstOrDefaultAsync();
        }
    }
}