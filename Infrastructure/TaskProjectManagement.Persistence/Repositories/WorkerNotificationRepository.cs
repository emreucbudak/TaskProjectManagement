using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskProjectManagement.Application.Interfaces.Repositories;
using TaskProjectManagement.Domain.Entities;
using TaskProjectManagement.Persistence.ProjectDbContext;

namespace TaskProjectManagement.Persistence.Repositories
{
    public class WorkerNotificationRepository : RepositoryBase<WorkerNotification>, IWorkerNotificationRepository
    {
        public WorkerNotificationRepository(ApplicationDbContext db) : base(db)
        {
        }

        public async Task AddWorkerNotification(WorkerNotification workers)
        {
            await AddObj(workers);

        }

        public async Task<IEnumerable<WorkerNotification>> getAllNotification(int userId)
        {
            var allNotification =  await GetAllObj(false);
            return allNotification.Where(b  => b.UserId == userId);
        }
    }
}
