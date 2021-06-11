using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Parks.Models;

namespace Parks.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ParksController : ControllerBase
  {
    private readonly ParksContext _db;
    public ParksController(ParksContext db)
    {
      _db = db;
    }
    // GET api/parks
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Park>>> Get()
    {
      return await _db.Parks.ToListAsync();
    }
    // Get individual park with id ap/parks/id
    [HttpGet("{id}")]
public async Task<ActionResult<Park>> GetPark(int id)
{
    var park = await _db.Parks.FindAsync(id);

    if (park == null)
    {
        return NotFound();
    }

    return park;
}

    // POST api/parks
    [HttpPost]
    public async Task<ActionResult<Park>> Post(Park park)
    {
      _db.Parks.Add(park);
      await _db.SaveChangesAsync();

      return CreatedAtAction(nameof(GetPark), new { id = park.ParkId }, park);
    }
  }
}