using SynthesisAPI.Models;

namespace SynthesisAPI.Services;

public interface ICombinationService {
    Task<Combination> GetById(Guid id);
    Task<List<Combination>> GetAll();
    Task CreateAsync(Combination combination);
    Task UpdateAsync(Combination combination);
    Task DeleteAsync(Guid id);
}