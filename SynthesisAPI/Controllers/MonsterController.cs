using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SynthesisAPI.Dtos;
using SynthesisAPI.Models;

namespace SynthesisAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class MonsterController : ControllerBase
{
    private readonly MonsterDbContext _context;
    private readonly IMapper _mapper;
    public MonsterController(MonsterDbContext context, IMapper mapper){
        _context = context;
        _mapper = mapper;
    }


    [HttpGet("{id}")]
    public async Task<ActionResult<Monster>> GetSingle(Guid id){
        Monster? monster = await _context.Monsters.FindAsync(id);
        
        if(monster == null)
            return NotFound();

        return Ok(monster);
    }

    // GET ALL
    [HttpGet]
    public async Task<ActionResult<List<Monster>>> GetAll(){
        return Ok(await _context.Monsters.ToListAsync());
    }
    
    // Get lasts


    // GET BY NAME (LIKE)


    // POST
    [HttpPost]
    public async Task<IActionResult> Create(CreateMonsterDto newMonster) 
    {
        Monster monster = _mapper.Map<Monster>(newMonster);
        monster.CreationDate = DateTime.UtcNow;

        try{
            await _context.Monsters.AddAsync(monster);
            _context.SaveChanges();
            return Ok(monster);
        } catch (Exception ex) {
            return BadRequest(ex.Message);
        }
    }

    // PUT (EDIT)
    [HttpPut]
    public async Task<IActionResult> Update(UpdateMonsterDto updatedMonster){
        Monster? monster = await _context.Monsters.FindAsync(updatedMonster.MonsterId);
        
        if(monster == null)
            return NotFound();

        try{
            monster.Name = updatedMonster.Name;
            monster.Rank = updatedMonster.Rank;
            monster.Statistics = updatedMonster.Statistics;
            monster.GameID = updatedMonster.GameID;
            monster.Combinations = updatedMonster.Combinations;
            monster.Details = updatedMonster.Details;
            monster.Family = updatedMonster.Family;

            _context.SaveChanges();
            return Ok(monster);

        } catch (Exception ex) {
            return BadRequest(ex.Message);
        }
    }

    // DELETE
}