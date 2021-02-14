using System.Threading.Tasks;
using Egz.Models;

namespace Egz.Services.Interfaces
{
    public interface IPatientService
    {
        Task<Patient> GetById(int id);
        Task Delete(Patient patient);
    }
}