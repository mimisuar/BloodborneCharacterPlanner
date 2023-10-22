using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BloodborneCharacterPlanner.Data;
using BloodborneCharacterPlanner.Models;

namespace BloodborneCharacterPlanner.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BBCharactersController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public BBCharactersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/BBCharacters
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BBCharacter>>> GetCharacterSet()
        {
          if (_context.CharacterSet == null)
          {
              return NotFound();
          }
            return await _context.CharacterSet.ToListAsync();
        }

        // GET: api/BBCharacters/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BBCharacter>> GetBBCharacter(int id)
        {
          if (_context.CharacterSet == null)
          {
              return NotFound();
          }
            var bBCharacter = await _context.CharacterSet.FindAsync(id);

            if (bBCharacter == null)
            {
                return NotFound();
            }

            return bBCharacter;
        }

        // PUT: api/BBCharacters/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBBCharacter(int id, BBCharacter bBCharacter)
        {
            if (id != bBCharacter.Id)
            {
                return BadRequest();
            }

            _context.Entry(bBCharacter).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BBCharacterExists(id))
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

        // POST: api/BBCharacters
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<BBCharacter>> PostBBCharacter(BBCharacter bBCharacter)
        {
          if (_context.CharacterSet == null)
          {
              return Problem("Entity set 'ApplicationDbContext.CharacterSet'  is null.");
          }
            _context.CharacterSet.Add(bBCharacter);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBBCharacter", new { id = bBCharacter.Id }, bBCharacter);
        }

        // DELETE: api/BBCharacters/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBBCharacter(int id)
        {
            if (_context.CharacterSet == null)
            {
                return NotFound();
            }
            var bBCharacter = await _context.CharacterSet.FindAsync(id);
            if (bBCharacter == null)
            {
                return NotFound();
            }

            _context.CharacterSet.Remove(bBCharacter);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BBCharacterExists(int id)
        {
            return (_context.CharacterSet?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
