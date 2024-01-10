using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SynthesisAPI.Controllers;

public class Monster {
    
    [Key]
    [Column("id")]
    public Guid MonsterId { get; set; } = Guid.NewGuid();


    [Column("name"), MaxLength(100)]
    public required string Name { get; set; }
    
    [Column("name"), MaxLength(20)]
    public required string GameID { get; set; }
    
    [Column("name"), MaxLength(20)]
    public required string Family { get; set; }
    
    [Column("name")]
    public required char Rank { get; set; }

    public bool IsActive { get; set; } = true;
    

    /*
    Location with season and/or obtention ways (events, quests)
    Statistics (Ex: Strength, wisdom; from 0 to 5)
    Combinations (Classic)
    Combinations (Special)
    Creation date
    */
}