using System.Threading.Tasks;
using Egz.Dto.Responses;

namespace Egz.Repositories.Interfaces
{
    public interface IMedicamentRepository
    {
        Task<MedicamentResponse> GetById(int id);
    }
}