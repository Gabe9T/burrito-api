using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BurritoApi.Models;

namespace BurritoApi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class BurritosController : ControllerBase
  {
    private readonly BurritoApiContext _db;

    public BurritosController(BurritoApiContext db)
    {
      _db = db;
    }

    // GET: api/Animals
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Burrito>>> Get(string protein, decimal maxPrice, Double minRating)
    {
      IQueryable<Burrito> query = _db.Burritos.AsQueryable();

      if (protein != null)
      {
        query = query.Where(entry => entry.Protein == protein);
      }
      if (maxPrice > 0)
      {
        query = query.Where(entry => entry.Price <= maxPrice);
      }
      if (minRating > 0)
      {
        query = query.Where(entry => entry.Rating >= minRating);
      }

      return await query.ToListAsync();
    }

    // GET: api/Burritos/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Burrito>> GetBurrito(int id)
    {
      Burrito burrito = await _db.Burritos.FindAsync(id);

      if (burrito == null)
      {
        return NotFound();
      }

      return burrito;
    }
    // POST api/burritos
    [HttpPost]
    public async Task<ActionResult<Burrito>> Post(Burrito burrito)
    {
      _db.Burritos.Add(burrito);
      await _db.SaveChangesAsync();
      return CreatedAtAction(nameof(GetBurrito), new { id = burrito.BurritoId }, burrito);
    }
    // PUT: api/Burritos/5
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Burrito burrito, string user)
    {
      if (id != burrito.BurritoId)
      {
        return BadRequest();
      }

      // Check if the burrito exists
      if (!BurritoExists(id))
      {
        return NotFound();
      }

      // Check if the user is authorized to edit the burrito
      if (user != burrito.User)
      {
        return Unauthorized();
      }

      _db.Burritos.Update(burrito);

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        throw; // You may want to handle concurrency exceptions according to your application's needs
      }

      return NoContent();
    }

    private bool BurritoExists(int id)
    {
      return _db.Burritos.Any(e => e.BurritoId == id);
    }
    // DELETE: api/Burritos/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteBurrito(int id)
    {
      Burrito burrito = await _db.Burritos.FindAsync(id);
      if (burrito == null)
      {
        return NotFound();
      }

      _db.Burritos.Remove(burrito);
      await _db.SaveChangesAsync();

      return NoContent();
    }
  }
}