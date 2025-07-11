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
        Task addUserNotificationFromService (UserNotification userNotification);
        Task removeUserNotificationFromService(int id);
        Task updateUserNotificationFromService(UserNotification usr);
        Task<UserNotification> getUserNotificationFromService (int id);
        Task<IEnumerable<UserNotification>> getUserNotifications(bool v);
    }
}
