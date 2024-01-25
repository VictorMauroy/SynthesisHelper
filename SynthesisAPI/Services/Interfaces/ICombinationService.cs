using SynthesisAPI.Models;

namespace SynthesisAPI.Services;

public interface ICombinationService {
    Task<Combination> GetById(Guid id);
    Task<List<Combination>> GetAll();
    Task<Combination> CreateAsync(List<Monster> monsters);
    Task UpdateAsync(Combination combination);
    Task DeleteAsync(Guid id);
    Task DeleteMultipleAsync(List<Combination> combinations);
}