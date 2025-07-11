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
    public class NotificationService : INotificationsService
    {
        private readonly IRepositoryManager _rp;

        public NotificationService(IRepositoryManager rp)
        {
            _rp = rp;
        }

        public async Task AddNotificationFromService(Notifications ntfc)
        {
            await _rp.notificationRepository.AddNotification(ntfc);
            await _rp.saveChangesAsync();
        }

        public async Task<IEnumerable<Notifications>> GetAllNotificationsFromService(bool v)
        {
            return await _rp.notificationRepository.GetAllNotifications(v);
        }

        public async Task<Notifications> GetNotificationsFromService(int id)
        {
            return await _rp.notificationRepository.GetNotificationsById(id);
        }

        public async Task RemoveNotificationFromService(int ntfc)
        {
            var getNotificationForDelete = await _rp.notificationRepository.GetNotificationsById(ntfc);
            await _rp.notificationRepository.RemoveNotification(getNotificationForDelete);
        }

        public async Task UpdateNotificationFromService(Notifications ntfc)
        {
            var getNotificationForUpdate = await _rp.notificationRepository.GetNotificationsById(ntfc.NotificationId);
            getNotificationForUpdate.NotificationText = ntfc.NotificationText;
            getNotificationForUpdate.NotificationTitle = ntfc.NotificationTitle;
            await _rp.notificationRepository.UpdateNotification(getNotificationForUpdate);
            await _rp.saveChangesAsync();
        }
    }
}
