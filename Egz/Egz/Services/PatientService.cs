using System.Threading.Tasks;
using Egz.Models;
using Egz.Repositories.Interfaces;
using Egz.Services.Interfaces;

namespace Egz.Services
{
    public class PatientService : IPatientService
    {
        private readonly IPatientRepository patientRepository;
        private readonly EgzDbContext context;

        public PatientService(IPatientRepository patientRepository,EgzDbContext context)
        {
            this.patientRepository = patientRepository;
            this.context = context;
        }

        public async Task<Patient> GetById(int id)
        {
            return await patientRepository.GetById(id);
        }

        public async Task Delete(Patient patient)
        {
            patientRepository.Remove(patient);
            await context.SaveChangesAsync();
        }
    }
}