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
    public class NotificationRepository : RepositoryBase<Notifications>, INotificationRepository
    {
        public NotificationRepository(ApplicationDbContext db) : base(db)
        {
        }

        public async Task AddNotification(Notifications ntfc)
        {
            await AddObj(ntfc);
        }

        public async Task<IEnumerable<Notifications>> GetAllNotifications()
        {
            return await GetAllObj(false);
        }

        public async Task<Notifications> GetNotificationsById(int id)
        {
            return await  GetByIdObj(b => b.NotificationId == id); 
        }

        public async Task RemoveNotification(Notifications ntfc)
        {
            await DeleteObj(ntfc);
        }

        public async Task UpdateNotification(Notifications ntfc)
        {
            await UpdateObj(ntfc);
        }
    }
}
