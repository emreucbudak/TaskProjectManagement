using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskProjectManagement.Domain.Entities;

namespace TaskProjectManagement.Application.Interfaces.Services
{
    public interface IUserNotificationsServices
    {
        Task addUserNotificationFromService (int userId, int notificationId);

        Task updateUserNotificationFromService(UserNotification usr);
  
        Task<IEnumerable<UserNotification>> getUserNotifications(int v);
    }
}
