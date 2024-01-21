namespace SynthesisAPI.Dtos;

public class CreateMonsterDto
{
    public required string Name { get; set; }
    public string? GameID { get; set; }
    public required string Family { get; set; }
    public required char Rank { get; set; }
    public required string Details { get; set; }
    public int[] Statistics { get; set; } = new int[5];
}