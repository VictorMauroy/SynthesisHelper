using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SynthesisAPI.Models;

public class Monster {
    
    [Column("id"), Key]
    public Guid MonsterId { get; set; } = Guid.NewGuid();


    //Informations
    [Column("name"), MaxLength(100)]
    public required string Name { get; set; }
    
    [Column("gameid"), MaxLength(20)]
    public string? GameID { get; set; }
    
    [Column("family"), MaxLength(20)]
    public required string Family { get; set; }
    
    [Column("rank")]
    public required char Rank { get; set; }

    [Column("details"), MaxLength(500)]
    public required string Details { get; set; }

    [Column("statistics")]
    public int[] Statistics { get; set; } = new int[5];


    // Management
    [Column("reservation_date")]
    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    public DateTime CreationDate { get; set; }

    [Column("isactive")]
    public bool IsActive { get; set; } = true;
    
    
    // Relationship
    [Column("combinations")]
    public List<MonsterCombination> Combinations { get; set; } = new();
    
    [Column("special_combinations")]
    public List<MonsterCombination> SpecialCombinations { get; set; } = new List<MonsterCombination>();

    /*
    Location with season
    How to get (events, quests)
    English name
    Japanese name
    Talents
    Traits
    Skills
    Weaknesses, Resistances
    */
}