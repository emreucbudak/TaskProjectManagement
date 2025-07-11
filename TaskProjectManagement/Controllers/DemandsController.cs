using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TaskProjectManagement.Application.Interfaces.Services;
using TaskProjectManagement.Domain.Entities;
using TaskProjectManagement.Persistence.ProjectDbContext;

namespace TaskProjectManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DemandsController : ControllerBase
    {
        private readonly IServiceManager _context;

        public DemandsController(IServiceManager context)
        {
            _context = context;
        }

        // GET: api/Demands
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Demand>>> GetDemands()
        {
            var x =  await _context.demand.GetAllDemandFromService(false);
            return Ok(x);
        }

        // GET: api/Demands/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Demand>> GetDemand(int id)
        {
            var demand = await _context.demand.GetOneDemandFromService(id);
            return Ok(demand);
        }

        // PUT: api/Demands/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDemand(Demand demand)
        {
            var demandUpdate = await _context.demand.GetOneDemandFromService(demand.DemandId);
            if (demandUpdate != null) {
                await _context.demand.UpdateDemandFromService(demandUpdate);
            }


            return NoContent();
        }

        // POST: api/Demands
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Demand>> PostDemand(Demand demand)
        {
            if (demand != null) {
                await _context.demand.AddDemandFromService(demand);

            }

            return Ok();
        }

        // DELETE: api/Demands/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDemand(int id)
        {
            await _context.demand.DeleteDemandFromService(id);
            return NoContent();
        }


    }
}
