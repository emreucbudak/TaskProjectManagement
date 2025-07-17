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
    public class OtherWorkerRepository : RepositoryBase<OtherWorker>, IOtherWorkerRepository
    {
        public OtherWorkerRepository(ApplicationDbContext db) : base(db)
        {
        }

        public async Task AddOtherWorkerFromRepo(OtherWorker otherWorker)
        {
            await AddObj(otherWorker);
        }

        public async Task DeleteOtherWorkerFromRepository(OtherWorker otherWorker)
        {
            await DeleteObj(otherWorker);
        }

        public async Task<IEnumerable<OtherWorker>> GetAllOtherWorkerFromRepository()
        {
            return await GetAllObj(false);
        }

        public async Task<OtherWorker> GetOtherWorkerFromRepository(int id)
        {
            return await GetByIdObj(b => b.OtherWorkerId == id);
        }

        public async Task UpdateOtherWorkerFromRepository(OtherWorker otherWorker)
        {
            await UpdateObj(otherWorker);
        }
    }
}
