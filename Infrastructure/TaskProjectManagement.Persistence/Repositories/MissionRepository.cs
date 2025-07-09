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
    public class MissionRepository : RepositoryBase<Mission>, IMissionRepository
    {
        public MissionRepository(ApplicationDbContext db) : base(db)
        {
        }

        public async Task AddMission(Mission mission)
        {
            await AddObj(mission);
        }

        public async Task DeleteMission(Mission mission)
        {
            await DeleteObj(mission);
        }

        public async Task<IEnumerable<Mission>> GetAllMissions()
        {
            return await GetAllObj(false);
        }

        public async Task<Mission> GetMission(int id)
        {
            return await GetByIdObj(b => b.MissionId == id);
        }

        public async Task UpdateMissions(Mission mission)
        {
            await UpdateObj(mission);
        }
    }
}
