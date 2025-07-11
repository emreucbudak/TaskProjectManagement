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
    public class SubTasksController : ControllerBase
    {
        private readonly IServiceManager _context;

        public SubTasksController(IServiceManager context)
        {
            _context = context;
        }

        // GET: api/SubTasks
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SubTask>>> GetSubTasks()
        {
            return Ok(await _context.subtask.GetAllSubTasks(false));
        }

        // GET: api/SubTasks/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SubTask>> GetSubTask(int id)
        {
            return Ok(await _context.subtask.GetSubTaskFromService(id));
        }

        // PUT: api/SubTasks/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSubTask(SubTask subTask)
        {
            await _context.subtask.UpdateSubTaskFromService(subTask);
            return Ok();
        }

        // POST: api/SubTasks
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SubTask>> PostSubTask(SubTask subTask)
        {
            await _context.subtask.AddSubTaskFromService(subTask);


            return CreatedAtAction("GetSubTask", new { id = subTask.SubTaskId }, subTask);
        }

        // DELETE: api/SubTasks/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSubTask(int id)
        {
            await _context.subtask.RemoveSubTaskFromService(id);

            return NoContent();
        }


    }
}
