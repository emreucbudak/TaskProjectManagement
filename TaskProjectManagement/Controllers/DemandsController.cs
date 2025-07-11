using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TaskProjectManagement.Domain.Entities;
using TaskProjectManagement.Persistence.ProjectDbContext;

namespace TaskProjectManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DemandsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public DemandsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Demands
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Demand>>> GetDemands()
        {
            return await _context.Demands.ToListAsync();
        }

        // GET: api/Demands/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Demand>> GetDemand(int id)
        {
            var demand = await _context.Demands.FindAsync(id);

            if (demand == null)
            {
                return NotFound();
            }

            return demand;
        }

        // PUT: api/Demands/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDemand(int id, Demand demand)
        {
            if (id != demand.DemandId)
            {
                return BadRequest();
            }

            _context.Entry(demand).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DemandExists(id))
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

        // POST: api/Demands
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Demand>> PostDemand(Demand demand)
        {
            _context.Demands.Add(demand);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDemand", new { id = demand.DemandId }, demand);
        }

        // DELETE: api/Demands/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDemand(int id)
        {
            var demand = await _context.Demands.FindAsync(id);
            if (demand == null)
            {
                return NotFound();
            }

            _context.Demands.Remove(demand);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DemandExists(int id)
        {
            return _context.Demands.Any(e => e.DemandId == id);
        }
    }
}
