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

    // GET
    // [HttpGet("{id}")]
    // public Task<ActionResult> Get(){
    //     return ;
    // }

    // GET ALL

    
    // Get lasts


    // GET BY NAME (LIKE)


    // POST


    // PUT (EDIT)


    // DELETE
}