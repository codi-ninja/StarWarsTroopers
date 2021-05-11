using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StarWarsTroopers.Context;
using StarWarsTroopers.Model;

namespace StarWarsTroopers.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class TroopersController : ControllerBase
    {
        private readonly AppDbContext _context;

        public TroopersController(AppDbContext context)
        {
            _context = context;
            _context.Database.EnsureCreated();
        }

        // GET: api/Troopers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Trooper>>> GetTroopers()
        {
            return await _context.Troopers.ToListAsync();
        }

        // GET: api/Troopers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Trooper>> GetTrooper(int id)
        {
            var trooper = await _context.Troopers.FindAsync(id);

            if (trooper == null)
            {
                return NotFound();
            }

            return trooper;
        }

        // PUT: api/Troopers/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTrooper(int id, Trooper trooper)
        {
            if (id != trooper.id)
            {
                return BadRequest();
            }

            _context.Entry(trooper).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TrooperExists(id))
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

        // POST: api/Troopers
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Trooper>> PostTrooper(Trooper trooper)
        {
            _context.Troopers.Add(trooper);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTrooper", new { id = trooper.id }, trooper);
        }

        // DELETE: api/Troopers/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Trooper>> DeleteTrooper(int id)
        {
            var trooper = await _context.Troopers.FindAsync(id);
            if (trooper == null)
            {
                return NotFound();
            }

            _context.Troopers.Remove(trooper);
            await _context.SaveChangesAsync();

            return trooper;
        }

        private bool TrooperExists(int id)
        {
            return _context.Troopers.Any(e => e.id == id);
        }
    }
}
