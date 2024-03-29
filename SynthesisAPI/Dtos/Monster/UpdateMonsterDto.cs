using SynthesisAPI.Models;

namespace SynthesisAPI.Dtos;

public class UpdateMonsterDto
{
    public Guid MonsterId { get; set; }
    public required string Name { get; set; }
    public string? GameID { get; set; }
    public required string Family { get; set; }
    public required char Rank { get; set; }
    public required string Details { get; set; }
    public int[] Statistics { get; set; } = new int[5] {1, 1, 1, 1, 1};
    public bool IsActive { get; set; }
    public List<List<Monster>> Combinations { get; set; } = new List<List<Monster>>();
}