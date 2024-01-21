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

        return Ok(await _context.Monsters.AddAsync(monster));

        // Should use a try catch
    }

    // PUT (EDIT)


    // DELETE
}