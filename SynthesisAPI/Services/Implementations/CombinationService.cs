using Microsoft.EntityFrameworkCore;
using SynthesisAPI.Models;

namespace SynthesisAPI.Services;

public class CombinationService : ICombinationService
{
    private readonly MonsterDbContext _ctx;
    public CombinationService(MonsterDbContext ctx)
    {
        _ctx = ctx;
    }

    
    public async Task<List<Combination>> GetAll()
    => await _ctx.Combinations.ToListAsync();

    public async Task<Combination> GetById(Guid id)
    => await _ctx.Combinations.FirstAsync(c => c.CombinationId == id);

    public async Task<Combination> CreateAsync(List<Monster> monsters)
    {
        Combination combination = new Combination
        {
            MonstersToCombine = monsters
        };

        await _ctx.Combinations.AddAsync(combination);
        await _ctx.SaveChangesAsync();
        return combination;
    }

    public async Task DeleteAsync(Guid id)
    {
        Combination combination = await GetById(id);
        _ctx.Remove(combination);
        await _ctx.SaveChangesAsync();
    }

    public async Task UpdateAsync(Combination combination)
    {
        _ctx.Combinations.Update(combination);
        await _ctx.SaveChangesAsync();
    }
}