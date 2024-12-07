using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TeamApi.Models;

namespace TeamApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BreakfastFoodController : ControllerBase
    {
        private readonly AppDbContext _context;

        public BreakfastFoodController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/BreakfastFood
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BreakfastFood>>> GetBreakfastFoods()
        {
            return await _context.BreakfastFoods.ToListAsync();
        }

        // GET: api/BreakfastFood/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BreakfastFood>> GetBreakfastFood(int id)
        {
            var breakfastFood = await _context.BreakfastFoods.FindAsync(id);

            if (breakfastFood == null)
            {
                return NotFound();
            }

            return breakfastFood;
        }

        // PUT: api/BreakfastFood/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBreakfastFood(int id, BreakfastFood breakfastFood)
        {
            if (id != breakfastFood.Id)
            {
                return BadRequest();
            }

            _context.Entry(breakfastFood).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BreakfastFoodExists(id))
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

        // POST: api/BreakfastFood
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<BreakfastFood>> PostBreakfastFood(BreakfastFood breakfastFood)
        {
            _context.BreakfastFoods.Add(breakfastFood);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBreakfastFood", new { id = breakfastFood.Id }, breakfastFood);
        }

        // DELETE: api/BreakfastFood/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBreakfastFood(int id)
        {
            var breakfastFood = await _context.BreakfastFoods.FindAsync(id);
            if (breakfastFood == null)
            {
                return NotFound();
            }

            _context.BreakfastFoods.Remove(breakfastFood);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BreakfastFoodExists(int id)
        {
            return _context.BreakfastFoods.Any(e => e.Id == id);
        }
    }
}
