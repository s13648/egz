using System.Net;
using System.Threading.Tasks;
using Egz.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Egz.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PatientController : ControllerBase
    {
        private readonly IPatientService patientService;

        public PatientController(IPatientService patientService)
        {
            this.patientService = patientService;
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var patient = await patientService.GetById(id);
            if (patient == null)
                return NotFound();

            await patientService.Delete(patient);
            
            return Ok();
        }
    }
}