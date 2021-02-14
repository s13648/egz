using System.Threading.Tasks;
using Egz.Dto.Responses;
using Egz.Services;
using Egz.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Egz.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MedicamentController : ControllerBase
    {
        private readonly IMedicamentService medicamentService;

        public MedicamentController(IMedicamentService medicamentService)
        {
            this.medicamentService = medicamentService;
        }

        [Route("{id}")]
        [HttpGet]
        public async Task<IActionResult> Get(int id)
        {
            var response = await medicamentService.GetById(id);
            if (response == null)
                return NotFound();
            
            return Ok(response);
        }
    }
}