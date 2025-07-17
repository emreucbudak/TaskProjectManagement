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
    public class WorkerNotificationService : IWorkerNotificationService
    {
        private readonly IRepositoryManager _repositoryManager;

        public WorkerNotificationService(IRepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
        }

        public async Task AddNotificationForWorker(int userId , int notificationsId)
        {
            var addWorkerNotifications = new WorkerNotification()
            {
                UserId = userId,
                NotificationsId = notificationsId
            };
            await _repositoryManager.workerNotificationRepository.AddWorkerNotification(addWorkerNotifications);
        }

        public Task DeleteNotificationForWorker(int workerNotification)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<WorkerNotification>> getAllWorkerNotification()
        {
            throw new NotImplementedException();
        }

        public Task<WorkerNotification> GetWorkerNotification(int workerNotificationId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateNotification(WorkerNotification workerNotification)
        {
            throw new NotImplementedException();
        }
    }
}
