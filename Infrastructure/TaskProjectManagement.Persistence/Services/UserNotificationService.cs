using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskProjectManagement.Application.Interfaces.Repositories;
using TaskProjectManagement.Application.Interfaces.Services;
using TaskProjectManagement.Domain.Entities;

namespace TaskProjectManagement.Persistence.Services
{
    public class UserNotificationService : IUserNotificationsServices
    {
        private readonly IRepositoryManager _rp;

        public UserNotificationService(IRepositoryManager rp)
        {
            _rp = rp;
        }

        public async Task addUserNotificationFromService(int userId,int notificationId)
        {
            await _rp.userNotificationRepository.AddUserNotification(userId,notificationId);
        }



        public async Task<IEnumerable<WorkerNotification>> getUserNotifications(int v)
        {
           return await _rp.userNotificationRepository.GetAllNotifications(v);
        }

        public async Task removeUserNotificationFromService(int notificationsId)
        {
            var removeUserNotification = await _rp.userNotificationRepository.GetAllNotifications(notificationsId);
            var chooseNotification = removeUserNotification.Where(b => b.NotificationsId == notificationsId).FirstOrDefault();
            if (chooseNotification != null) {
                await _rp.userNotificationRepository.DeleteNotification(chooseNotification.NotificationsId);
                await _rp.saveChangesAsync();  
            }
            
        }

        public async Task updateUserNotificationFromService(WorkerNotification usr)
        {
            var updateUserNotification = await _rp.userNotificationRepository.GetAllNotifications(usr.UserId);
            var mustChangeNotification = updateUserNotification.Where(b => b.NotificationsId == usr.NotificationsId).FirstOrDefault();
            if (mustChangeNotification != null) {
                mustChangeNotification.Notifications.NotificationText = usr.Notifications.NotificationText;
                mustChangeNotification.Notifications.NotificationTitle = usr.Notifications.NotificationTitle;
                await _rp.userNotificationRepository.UpdateUserNotifications(mustChangeNotification);
                await _rp.saveChangesAsync();   
            }

        }
    }
}
