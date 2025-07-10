using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskProjectManagement.Domain.Entities;

namespace TaskProjectManagement.Application.Interfaces.Services
{
    public interface INotificationsService
    {
        Task AddNotificationFromService(Notifications ntfc);
        Task RemoveNotificationFromService(int ntfc);
        Task UpdateNotificationFromService(Notifications ntfc);
        Task<Notifications> GetNotificationsFromService();
        Task<IEnumerable<Notifications>> GetAllNotificationsFromService();
    }
}
