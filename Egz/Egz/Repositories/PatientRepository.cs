using System.Linq;
using System.Threading.Tasks;
using Egz.Models;
using Egz.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Egz.Repositories
{
    public class PatientRepository : IPatientRepository
    {
        private readonly EgzDbContext context;

        public PatientRepository(EgzDbContext context)
        {
            this.context = context;
        }
        
        public async Task<Patient> GetById(int id)
        {
            return await context.Patients
                .Where(n => n.IdPatient == id)
                .FirstOrDefaultAsync();
        }

        public void Remove(Patient patient)
        {
            context.Patients.Remove(patient);
        }
    }
}