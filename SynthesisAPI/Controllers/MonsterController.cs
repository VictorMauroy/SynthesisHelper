using Microsoft.AspNetCore.Mvc;
using SynthesisAPI.Models;

namespace SynthesisAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class MonsterController : ControllerBase
{
    private readonly MonsterDbContext _context;
    public MonsterController(MonsterDbContext context){
        _context = context;
    }


    [HttpGet("{id}")]
    public async Task<ActionResult<Monster>> Get(int id){
        Monster? monster = await _context.Monsters.FindAsync(id);
        
        if(monster == null)
            return NotFound();

        return Ok(monster);
    }

    // GET ALL

    
    // Get lasts


    // GET BY NAME (LIKE)


    // POST


    // PUT (EDIT)


    // DELETE
}