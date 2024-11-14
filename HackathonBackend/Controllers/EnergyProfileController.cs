using HackathonBackend.Models;
using HackathonBackend.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HackathonBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnergyProfileController : ControllerBase
    {
        private readonly EnergyProfileRepository _repository;

        public EnergyProfileController(EnergyProfileRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<EnergyProfile>>> GetAll()
        {
            var energyProfiles = await _repository.GetAll();
            return Ok(energyProfiles);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<EnergyProfile>> GetById(int id)
        {
            var energyProfile = await _repository.GetById(id);
            if (energyProfile == null)
            {
                return NotFound();
            }
            return Ok(energyProfile);
        }

        [HttpPost]
        public async Task<ActionResult<EnergyProfile>> Create(EnergyProfile energyProfile)
        {
            var createdEnergyProfile = await _repository.Create(energyProfile);
            return CreatedAtAction(nameof(GetById), new { id = createdEnergyProfile.EnergyProfileId }, createdEnergyProfile);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<EnergyProfile>> Update(int id, EnergyProfile energyProfile)
        {
            if (id != energyProfile.EnergyProfileId)
            {
                return BadRequest();
            }

            var updatedEnergyProfile = await _repository.Update(id, energyProfile);
            if (updatedEnergyProfile == null)
            {
                return NotFound();
            }
            return Ok(updatedEnergyProfile);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var energyProfile = await _repository.GetById(id);
            if (energyProfile == null)
            {
                return NotFound();
            }

            await _repository.Delete(id);
            return NoContent();
        }
    }
}
