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
    public class UserNotificationRepository : RepositoryBase<WorkerNotification>, IUserNotificationRepository
    {
        public UserNotificationRepository(ApplicationDbContext db) : base(db)
        {
        }

        public async Task AddUserNotification(int UserId, int NotificationsId)
        {
            var userNotification = new WorkerNotification()
            {
                UserId = UserId,
                NotificationId = NotificationsId
            };
            await AddObj(userNotification);
        }

        public async Task DeleteNotification(int NotificationsId)
        {
            var x = await GetByIdObj(b=> b.NotificationId == NotificationsId);
            await DeleteObj(x);
               
        }

        public async Task<IEnumerable<WorkerNotification>> GetAllNotifications(int id)
        {
           return await GetAllNotificationsByUserId(id);
            

 
        }



        public async Task  UpdateUserNotifications (WorkerNotification notification)
        {
            await UpdateObj(notification);
        }


        private async Task<IEnumerable<WorkerNotification>> GetAllNotificationsByUserId (int id )
        {
            var x = await GetAllObj(false);
            return x.Where(x=>x.UserId == id);
        }


    }
}
