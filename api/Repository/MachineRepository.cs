using api.Data;
using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Repository
{
    public class MachineRepository : IMachineRepository
    {
        private readonly ApplicationDBContext _dbContext;

        public MachineRepository(ApplicationDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Machine>> GetAllAsync()
        {
            return await _dbContext.Machines.OrderByDescending(s => s.Name).ToListAsync();
        }

        public async Task<Machine?> GetAsync(string id)
        {
            return await _dbContext.Machines.FindAsync(id);
        }

        public async Task<Machine?> UpdateStateAsync(string id)
        {
            return await _dbContext.Machines.FirstOrDefaultAsync(machine => machine.Id == id);
        }
    }
}