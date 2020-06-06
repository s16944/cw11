using cw11.Models;
using cw11.Services;
using Microsoft.AspNetCore.Mvc;

namespace cw11.Controllers
{
    [Route("api/doctors")]
    [ApiController]
    public class DoctorsController : ControllerBase
    {
        private readonly IClinicDbService _dbService;

        public DoctorsController(IClinicDbService dbService)
        {
            _dbService = dbService;
        }

        [HttpGet]
        public IActionResult GetDoctors()
        {
            return Ok(_dbService.GetDoctors());
        }

        [HttpPut]
        public IActionResult PutDoctor(Doctor doctor)
        {
            _dbService.AddDoctor(doctor);
            return Ok(doctor);
        }

        [HttpPatch]
        public IActionResult UpdateDoctor(Doctor doctor)
        {
            try
            {
                _dbService.UpdateDoctor(doctor);
                return Ok();
            }
            catch (ObjectNotFoundException)
            {
                return NotFound();
            }
        }

        [HttpDelete("{doctorId}")]
        public IActionResult DeleteDoctor(int doctorId)
        {
            try
            {
                _dbService.RemoveDoctor(doctorId);
                return Ok();
            }
            catch (ObjectNotFoundException)
            {
                return NotFound();
            }
        }
    }
}