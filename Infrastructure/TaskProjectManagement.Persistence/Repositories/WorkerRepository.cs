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
    public class WorkerRepository : RepositoryBase<Worker>, IWorkerRepository
    {
        public WorkerRepository(ApplicationDbContext db) : base(db)
        {
        }

        public async Task AddWorker(Worker worker)
        {
           await AddObj(worker);
            
        }

        public async Task DeleteWorker(Worker worker)
        {
            await DeleteObj(worker);
        }

        public async Task<IEnumerable<Worker>> GetAllWorkers()
        {
            return await GetAllObj(false);
        }

        public async Task<Worker> GetWorker(int worker)
        {
            return await GetByIdObj(b => b.Id == worker);

        }

        public async Task UpdateWorker(Worker worker)
        {
            await UpdateObj(worker);
        }
    }
}
