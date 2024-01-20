using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using SynthesisAPI.Models;

namespace SynthesisAPI.Repositories;

public class MonsterRepository : IMonsterRepository
{
    private MonsterDbContext _context;
    public MonsterRepository(MonsterDbContext context)
    {
        _context = context;
    }

    public async Task<Monster> GetByIdAsync(Guid id)
    {
        Monster monster = await _context.Monsters.FindAsync(id);
        return monster;
    }
    
    public Task<IEnumerable<Monster>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task CreateAsync(Monster monster)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(Monster monster)
    {
        throw new NotImplementedException();
    }

    public Task DisableAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task EnableAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task SaveChangesAsync()
    {
        throw new NotImplementedException();
    }
}