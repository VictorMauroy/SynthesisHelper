using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SynthesisAPI.Models;

public class MonsterCombination {

    [Column("id"), Key]
    public Guid CombinationId { get; set; } = Guid.NewGuid();

    [Column("monsters")]
    public List<Monster> MonstersToCombine { get; set; } = new List<Monster>();
}