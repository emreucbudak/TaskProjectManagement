using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskProjectManagement.Application.Interfaces.Services;
using TaskProjectManagement.Domain.Entities;

namespace TaskProjectManagement.Persistence.Services
{
    public class UserNotificationService : IUserNotificationsServices
    {
        public Task addUserNotificationFromService(UserNotification userNotification)
        {
            throw new NotImplementedException();
        }

        public Task<UserNotification> getUserNotificationFromService(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<UserNotification>> getUserNotifications(bool v)
        {
            throw new NotImplementedException();
        }

        public Task removeUserNotificationFromService(int id)
        {
            throw new NotImplementedException();
        }

        public Task updateUserNotificationFromService(UserNotification usr)
        {
            throw new NotImplementedException();
        }
    }
}
