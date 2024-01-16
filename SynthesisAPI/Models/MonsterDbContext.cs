using Npgsql;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace SynthesisAPI.Models;

public class MonsterDbContext : DbContext
{
    public MonsterDbContext(DbContextOptions<MonsterDbContext> options) : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        /* All the code below is UNECESSARY: (but nice to know) */

        // Explicit definition of the relation many-to-many between the two tables (Monster and MonsterCombination)
        modelBuilder.Entity<MonsterCombination>()
            .HasMany(c => c.MonstersToCombine) // One MonsterCombination has many Monsters
            .WithMany(m => m.Combinations) // One Monster can have many MonsterCombinations

            .UsingEntity( // Define and configure the intermediate table
                mc => mc.HasOne(typeof(Monster)).WithMany(),
                m => m.HasOne(typeof(MonsterCombination)).WithMany(),
                intermediate => {
                    intermediate.HasKey("MonsterId", "CombinationId"); // Set the foreign keys
                    intermediate.ToTable("MonsterMonsterCombination"); // Allow to update the intermediate table name
                }
            );


        base.OnModelCreating(modelBuilder);
    }

    public DbSet<Monster> MonsterItems { get; set; } = null!;
}