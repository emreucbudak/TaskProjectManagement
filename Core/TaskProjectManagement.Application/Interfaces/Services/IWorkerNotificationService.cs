using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskProjectManagement.Domain.Entities;

namespace TaskProjectManagement.Application.Interfaces.Services
{
    public interface IWorkerNotificationService
    {
        Task AddNotificationForWorker(int userId, int notificationsId);
        Task DeleteNotificationForWorker (int workerNotification);
        Task UpdateNotification (WorkerNotification workerNotification);
        Task<IEnumerable<WorkerNotification>> getAllWorkerNotification ();
        Task<WorkerNotification> GetWorkerNotification (int workerNotificationId);

    }
}
