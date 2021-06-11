using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System;
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
     private bool ParkExists(int id)
    {
      return _db.Parks.Any(e => e.ParkId == id);
    }

    private bool ParkWithAttributesExists(Park p)
    {
      return _db.Parks.Any(e => e.Name == p.Name && e.State == p.State && e.City == p.City && e.ZipCode == p.ZipCode);
    }
    /// <summary>
    /// This will create a single park
    /// </summary>
    /// <param name="park"></param>
    /// <returns>Park</returns>
  // POST api/parks
    [HttpPost]
    public async Task<ActionResult<Park>> Post(Park park)
    {
      if (!ParkWithAttributesExists(park))
      {
        _db.Parks.Add(park);
        await _db.SaveChangesAsync();
      }
      
      return CreatedAtAction(nameof(GetPark), new { id = park.ParkId }, park);
    }
    // GET api/parks
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Park>>> Get(string name, string state, string city, string type, string zipcode, string radius)
    {
      var query = _db.Parks.AsQueryable();
      if (name != null)
      {
        query = query.Where(p => p.Name == name);
      }
       if (state != null)
      {
        query = query.Where(p => p.State.Contains(state));
      }
       if (city != null)
      {
        query = query.Where(p => p.City == city);
      }
       if (type != null)
      {
        query = query.Where(p => p.Type == type);
      }
       if (zipcode != null && radius != null)
      {
        int zipCodeInt = Int32.Parse(zipcode);
        int radiusInt = Int32.Parse(radius);
        int lowerZip = zipCodeInt - radiusInt;
        int upperZip = zipCodeInt + radiusInt;
        query = query.Where(p => p.ZipCode >= lowerZip && p.ZipCode <= upperZip);
      }
      return await query.ToListAsync();
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

   
    // PUT: api/Parks/5
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Park park)
    {
      if (id != park.ParkId)
      {
        return BadRequest();
      }

      _db.Entry(park).State = EntityState.Modified;

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!ParkExists(id))
        {
          return NotFound();
        }
        else
        {
          throw;
        }
      }

      return NoContent();
    }
       // DELETE: api/Parks/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeletePark(int id)
    {
      var park = await _db.Parks.FindAsync(id);
      if (park == null)
      {
        return NotFound();
      }

      _db.Parks.Remove(park);
      await _db.SaveChangesAsync();

      return NoContent();
    }
   
  }
}