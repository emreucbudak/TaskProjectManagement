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
    public class UserNotificationsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public UserNotificationsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/UserNotifications
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserNotification>>> GetUsersNotification()
        {
            return await _context.UsersNotification.ToListAsync();
        }

        // GET: api/UserNotifications/5
        [HttpGet("{id}")]
        public async Task<ActionResult<UserNotification>> GetUserNotification(int id)
        {
            var userNotification = await _context.UsersNotification.FindAsync(id);

            if (userNotification == null)
            {
                return NotFound();
            }

            return userNotification;
        }

        // PUT: api/UserNotifications/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUserNotification(int id, UserNotification userNotification)
        {
            if (id != userNotification.UserId)
            {
                return BadRequest();
            }

            _context.Entry(userNotification).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserNotificationExists(id))
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

        // POST: api/UserNotifications
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<UserNotification>> PostUserNotification(UserNotification userNotification)
        {
            _context.UsersNotification.Add(userNotification);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUserNotification", new { id = userNotification.UserId }, userNotification);
        }

        // DELETE: api/UserNotifications/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUserNotification(int id)
        {
            var userNotification = await _context.UsersNotification.FindAsync(id);
            if (userNotification == null)
            {
                return NotFound();
            }

            _context.UsersNotification.Remove(userNotification);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool UserNotificationExists(int id)
        {
            return _context.UsersNotification.Any(e => e.UserId == id);
        }
    }
}
