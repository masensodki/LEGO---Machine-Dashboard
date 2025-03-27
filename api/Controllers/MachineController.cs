using api.Data;
using api.helpers;
using api.Repository;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [ApiController]
    [Route("api/machine")]
    public class MachineController : ControllerBase
    {
        private readonly ApplicationDBContext _dbContext;
        private readonly IMachineRepository _machineRepo;

        public MachineController(ApplicationDBContext dbContext, IMachineRepository machineRepo)
        {
            _dbContext = dbContext;
            _machineRepo = machineRepo;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var machines = await _machineRepo.GetAllAsync();
            return Ok(machines);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get([FromRoute] string id)
        {
            var machine = await _machineRepo.GetAsync(id);
            if (machine == null)
            {
                return NotFound();
            }
            return Ok(machine);
        }

        [HttpPut("updateState/{id}")]
        public async Task<IActionResult> UpdateState([FromRoute] string id)
        {
            var existingMachine = await _machineRepo.UpdateStateAsync(id);
            if (existingMachine == null)
            {
                return NotFound();
            }
            var newStatus = MachineStateHelpers.Next(existingMachine.State);
            existingMachine.State = newStatus;
            await _dbContext.SaveChangesAsync();

            return Ok(existingMachine);
        }
    }
}