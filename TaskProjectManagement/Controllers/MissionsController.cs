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
    public class MissionsController : ControllerBase
    {
        private readonly IServiceManager _context;

        public MissionsController(IServiceManager context)
        {
            _context = context;
        }

        // GET: api/Missions
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Mission>>> GetMissions()
        {
            return Ok(await _context.mission.GetAllMissionsFromService(false));
        }

        // GET: api/Missions/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Mission>> GetMission(int id)
        {
            return Ok(await _context.mission.GetMissionByIdFromService(id));
        }

        // PUT: api/Missions/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMission(Mission mission)
        {
            await _context.mission.UpdateMission(mission);

            return NoContent();
        }

        // POST: api/Missions
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Mission>> PostMission(Mission mission)
        {
            await _context.mission.AddMission(mission);
            return CreatedAtAction("GetMission", new { id = mission.MissionId }, mission);
        }

        // DELETE: api/Missions/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMission(int id)
        {


            await _context.mission.RemoveMission(id);
            return NoContent();
        }


    }
}
