using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskProjectManagement.Domain.Entities;

namespace TaskProjectManagement.Application.Interfaces.Repositories
{
    public interface IUserNotificationRepository
    {
        Task AddUserNotification(int UserId, int NotificationsId);
        Task DeleteNotification (int NotificationsId);
        Task<UserNotification> GetUserNotification(int UserId, int NotificationsId);
        Task<IEnumerable<UserNotification>> GetAllNotifications();
        Task UpdateNotificaton (int UserId, int NotificationsId,string notificationTitle,string notificationDesc);
    }
}
