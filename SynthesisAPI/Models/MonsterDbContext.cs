using Npgsql;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace SynthesisAPI.Models;

public class MonsterDbContext : DbContext
{
    public MonsterDbContext(DbContextOptions<MonsterDbContext> options) : base(options)
    {
    }

    public DbSet<Monster> MonsterItems { get; set; } = null!;
}