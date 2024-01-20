using SynthesisAPI.Models;

namespace SynthesisAPI.Repositories;

public interface IMonsterRepository
{
    Task<IEnumerable<Monster>> GetAllAsync();
    Task<Monster> GetByIdAsync(Guid id);

    Task CreateAsync(Monster monster);
    Task UpdateAsync(Monster monster);
    Task DisableAsync(Guid id);
    Task EnableAsync(Guid id);
    Task SaveChangesAsync();
}