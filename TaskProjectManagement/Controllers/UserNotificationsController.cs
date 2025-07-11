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
    public class UserNotificationsController : ControllerBase
    {
        private readonly IServiceManager _context;

        public UserNotificationsController(IServiceManager context)
        {
            _context = context;
        }

        // GET: api/UserNotifications
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserNotification>>> GetUsersNotification(int id)
        {
            return Ok(await _context.userNotifications.getUserNotifications(id));
        }




        // PUT: api/UserNotifications/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUserNotification( UserNotification userNotification)
        {
            await _context.userNotifications.updateUserNotificationFromService(userNotification);



            return NoContent();
        }

        // POST: api/UserNotifications
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<UserNotification>> PostUserNotification(UserNotification userNotification)
        {
            await _context.userNotifications.addUserNotificationFromService(userNotification.UserId,userNotification.NotificationId);
            return CreatedAtAction("GetUserNotification", new { id = userNotification.UserId }, userNotification);
        }




    }
}
