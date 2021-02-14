using System.Threading.Tasks;
using Egz.Dto.Responses;

namespace Egz.Services.Interfaces
{
    public interface IMedicamentService
    {
        Task<MedicamentResponse> GetById(int id);
    }
}