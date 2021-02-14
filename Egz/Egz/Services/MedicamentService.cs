using System;
using System.Threading.Tasks;
using Egz.Dto.Responses;
using Egz.Repositories;
using Egz.Repositories.Interfaces;
using Egz.Services.Interfaces;

namespace Egz.Services
{
    public class MedicamentService : IMedicamentService
    {
        private readonly IMedicamentRepository medicamentRepository;

        public MedicamentService(IMedicamentRepository medicamentRepository)
        {
            this.medicamentRepository = medicamentRepository;
        }

        public Task<MedicamentResponse> GetById(int id)
        {
            return medicamentRepository.GetById(id);
        }
    }
}