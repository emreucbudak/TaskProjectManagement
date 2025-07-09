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
    public class DemandRepository : RepositoryBase<Demand>, IDemandRepository
    {
        public DemandRepository(ApplicationDbContext db) : base(db)
        {
        }

        public async Task AddDemand(Demand dem)
        {
            await AddObj(dem);
        }

        public async Task DeleteDemand(Demand demand)
        {
            await DeleteObj(demand);
        }

        public async Task<IEnumerable<Demand>> GetAllDemands()
        {
            return await GetAllObj(false);
        }

        public async Task<Demand> GetDemandById(int id)
        {
            return await GetByIdObj(b => b.DemandId == id);
        }

        public async Task UpdateDemand(Demand demand)
        {
            await UpdateObj(demand);
        }
    }
}
