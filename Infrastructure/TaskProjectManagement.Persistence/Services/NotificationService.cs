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

        public Task<IEnumerable<Notifications>> GetAllNotificationsFromService()
        {
            throw new NotImplementedException();
        }

        public Task<Notifications> GetNotificationsFromService()
        {
            throw new NotImplementedException();
        }

        public Task RemoveNotificationFromService(int ntfc)
        {
            throw new NotImplementedException();
        }

        public Task UpdateNotificationFromService(Notifications ntfc)
        {
            throw new NotImplementedException();
        }
    }
}
