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
    public class TeamLeaderRepository : RepositoryBase<TeamLeader>, ITeamLeaderRepository
    {
        public TeamLeaderRepository(ApplicationDbContext db) : base(db)
        {
        }

        public async Task AddLeader(TeamLeader teamLeader)
        {
            await AddObj(teamLeader);
        }

        public async Task<IEnumerable<TeamLeader>> GetAllLeader()
        {
            return await GetAllObj(false);
        }

        public async Task<TeamLeader> GetLeader(int id)
        {
           return await GetByIdObj(b => b.Id == id);
        }

        public async Task RemoveLeader(TeamLeader teamLeader)
        {
            await DeleteObj(teamLeader);
        }

        public async Task UpdateLeader(TeamLeader teamLeader)
        {
            await UpdateObj(teamLeader);
        }
    }
}
