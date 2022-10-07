using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyPokeAPI.Models;

namespace MyPokeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MyPokemonsController : ControllerBase
    {
        private readonly MyPokemonContext _context;

        public MyPokemonsController(MyPokemonContext context)
        {
            _context = context;
        }

        // GET: api/MyPokemons
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MyPokemon>>> GetMyPokemons()
        {
            return await _context.MyPokemons.ToListAsync();
        }

        // GET: api/MyPokemons/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MyPokemon>> GetMyPokemon(int id)
        {
            var myPokemon = await _context.MyPokemons.FindAsync(id);

            if (myPokemon == null)
            {
                return NotFound();
            }

            return myPokemon;
        }

        // PUT: api/MyPokemons/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMyPokemon(int id, MyPokemon myPokemon)
        {
            if (id != myPokemon.Id)
            {
                return BadRequest();
            }

            _context.Entry(myPokemon).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MyPokemonExists(id))
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

        // POST: api/MyPokemons
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<MyPokemon>> PostMyPokemon(MyPokemon myPokemon)
        {
            _context.MyPokemons.Add(myPokemon);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMyPokemon", new { id = myPokemon.Id }, myPokemon);
        }

        // DELETE: api/MyPokemons/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMyPokemon(int id)
        {
            var myPokemon = await _context.MyPokemons.FindAsync(id);
            if (myPokemon == null)
            {
                return NotFound();
            }

            _context.MyPokemons.Remove(myPokemon);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MyPokemonExists(int id)
        {
            return _context.MyPokemons.Any(e => e.Id == id);
        }
    }
}
