using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BurritoApi.Models;
using Microsoft.AspNetCore.Authorization;

namespace BurritoApi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  [Authorize]
  public class BurritosController : ControllerBase
  {
    private readonly BurritoApiContext _db;

    public BurritosController(BurritoApiContext db)
    {
      _db = db;
    }

    // GET: api/Burritos
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Burrito>>> Get(string protein, decimal maxPrice, Double minRating, bool random, int page = 1, int pageSize = 4)
    {
      IQueryable<Burrito> query = _db.Burritos.AsQueryable();
      if (random)
      {
        List<Burrito> allBurritos = await query.ToListAsync();
        if (allBurritos.Count == 0)
        {
          return NotFound();
        }

        List<Burrito> randomBurritos = allBurritos.OrderBy(x => Guid.NewGuid()).ToList();
        Burrito randomBurrito = randomBurritos.First();

        return Ok(new List<Burrito> { randomBurrito });
      }
      if (protein != null)
      {
        query = query.Where(entry => entry.Protein.Contains(protein));
      }
      if (maxPrice > 0)
      {
        query = query.Where(entry => entry.Price <= maxPrice);
      }
      if (minRating > 0)
      {
        query = query.Where(entry => entry.Rating >= minRating);
      }

      int skipCount = (page - 1) * pageSize;

      query = query.Skip(skipCount).Take(pageSize);

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

      if (!BurritoExists(id))
      {
        return NotFound();
      }

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
        throw;
      }

      return NoContent();
    }

    private bool BurritoExists(int id)
    {
      return _db.Burritos.Any(e => e.BurritoId == id);
    }
    // DELETE: api/Burritos/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteBurrito(int id, string user)
    {
      Burrito burrito = await _db.Burritos.FindAsync(id);
      if (burrito == null)
      {
        return NotFound();
      }
      if (user != burrito.User)
      {
        return Unauthorized();
      }

      _db.Burritos.Remove(burrito);
      await _db.SaveChangesAsync();

      return NoContent();
    }
  }
}