using System.Threading.Tasks;
using Egz.Models;

namespace Egz.Repositories.Interfaces
{
    public interface IPatientRepository
    {
        Task<Patient> GetById(int id);
        void Remove(Patient patient);
    }
}