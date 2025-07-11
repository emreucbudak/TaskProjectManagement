using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskProjectManagement.Domain.Entities;

namespace TaskProjectManagement.Application.Interfaces.Repositories
{
    public interface INotificationRepository
    {
        Task AddNotification(Notifications ntfc);
        Task RemoveNotification(Notifications ntfc);
        Task UpdateNotification (Notifications ntfc);
        Task<IEnumerable<Notifications>> GetAllNotifications(bool v);
        Task<Notifications> GetNotificationsById(int id);
    }
}
