using api.Models;

namespace api.Repository
{
    public interface IMachineRepository
    {
        Task<List<Machine>> GetAllAsync();
        Task<Machine?> GetAsync(string id);
        Task<Machine?> UpdateStateAsync(string id);

    }
}