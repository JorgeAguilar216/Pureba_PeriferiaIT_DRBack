using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CRUD_PeriferiaIT.Models;

namespace CRUD_PeriferiaIT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ViajesController : ControllerBase
    {
        private readonly ViajesContext _context;

        public ViajesController(ViajesContext context)
        {
            _context = context;
        }

        // GET: api/Viajes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Viajes>>> GetViajes()
        {
            return await _context.Viajes.ToListAsync();
        }

        // GET: api/Viajes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Viajes>> GetViajes(int id)
        {
            var viajes = await _context.Viajes.FindAsync(id);

            if (viajes == null)
            {
                return NotFound();
            }

            return viajes;
        }

        // PUT: api/Viajes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutViajes(int id, Viajes viajes)
        {
            if (id != viajes.ViajesID)
            {
                return BadRequest();
            }

            _context.Entry(viajes).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ViajesExists(id))
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

        // POST: api/Viajes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Viajes>> PostViajes(Viajes viajes)
        {
            _context.Viajes.Add(viajes);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetViajes", new { id = viajes.ViajesID }, viajes);
        }

        // DELETE: api/Viajes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteViajes(int id)
        {
            var viajes = await _context.Viajes.FindAsync(id);
            if (viajes == null)
            {
                return NotFound();
            }

            _context.Viajes.Remove(viajes);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ViajesExists(int id)
        {
            return _context.Viajes.Any(e => e.ViajesID == id);
        }
    }
}
