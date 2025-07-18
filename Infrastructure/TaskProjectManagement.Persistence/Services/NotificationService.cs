using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskProjectManagement.Application.Interfaces.Repositories;
using TaskProjectManagement.Application.Interfaces.Services;
using TaskProjectManagement.Domain.Entities;
using TaskProjectManagement.Persistence.Errors.NotFoundExceptions;


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
            var getNotificationsById =  await _rp.notificationRepository.GetNotificationsById(id);
            if (getNotificationsById is null)
            {
                throw new NotificationNotFoundException(id);
            }
            return getNotificationsById;
        }

        public async Task RemoveNotificationFromService(int ntfc)
        {
            var getNotificationForDelete = await _rp.notificationRepository.GetNotificationsById(ntfc);
            if (getNotificationForDelete is null)
            {
                throw new NotificationNotFoundException(ntfc);
            }
            await _rp.notificationRepository.RemoveNotification(getNotificationForDelete);
        }

        public async Task UpdateNotificationFromService(Notifications ntfc)
        {
            var getNotificationForUpdate = await _rp.notificationRepository.GetNotificationsById(ntfc.NotificationId);
            if (getNotificationForUpdate is null)
            {
                throw new NotificationNotFoundException(ntfc.NotificationId);
            }
            getNotificationForUpdate.NotificationText = ntfc.NotificationText;
            getNotificationForUpdate.NotificationTitle = ntfc.NotificationTitle;
            await _rp.notificationRepository.UpdateNotification(getNotificationForUpdate);
            await _rp.saveChangesAsync();
        }
    }
}
