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
        modelBuilder.Entity<Combination>()
            .HasMany(c => c.MonstersToCombine) // One MonsterCombination has many Monsters
            .WithMany(m => m.Combinations) // One Monster can have many MonsterCombinations

            .UsingEntity( // Define and configure the intermediate table
                "MonsterCombination", // Name of the intermediate table
                
                // Configure keys
                mc => mc.HasOne(typeof(Monster)).WithMany()
                    .HasForeignKey(nameof(Monster.MonsterId)).HasPrincipalKey(nameof(Monster.MonsterId)), 
                m => m.HasOne(typeof(Combination)).WithMany()
                    .HasForeignKey(nameof(Combination.CombinationId)).HasPrincipalKey(nameof(Combination.CombinationId))
            );


        base.OnModelCreating(modelBuilder);
    }

    public DbSet<Monster> Monsters { get; set; } = null!;
    public DbSet<Combination> Combinations { get; set; } = null!;
}