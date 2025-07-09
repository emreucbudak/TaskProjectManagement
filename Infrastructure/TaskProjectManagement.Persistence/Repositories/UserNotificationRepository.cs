using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskProjectManagement.Application.Interfaces.Repositories;
using TaskProjectManagement.Domain.Entities;
using TaskProjectManagement.Persistence.ProjectDbContext;

namespace TaskProjectManagement.Persistence.Repositories
{
    public class UserNotificationRepository : RepositoryBase<UserNotification>, IUserNotificationRepository
    {
        public UserNotificationRepository(ApplicationDbContext db) : base(db)
        {
        }

        public async Task AddUserNotification(int UserId, int NotificationsId)
        {
            var user = new UserNotification()
            {
                UserId = UserId,
                NotificationId = NotificationsId
            };
            await AddObj(user);
        }

        public async Task DeleteNotification(int NotificationsId)
        {
            var x = await GetByIdObj(b=> b.NotificationId == NotificationsId);
            await DeleteObj(x);
               
        }

        public async Task<IEnumerable<UserNotification>> GetAllNotifications(int id)
        {
           return await GetAllNotificationsByUserId(id);
            

 
        }

        public Task<UserNotification> GetUserNotification(int UserId, int NotificationsId)
        {
            throw new NotImplementedException();
        }
        private async Task<IEnumerable<UserNotification>> GetAllNotificationsByUserId (int id )
        {
            var x = await GetAllObj(false);
            return x.Where(x=>x.UserId == id);
        }


    }
}
