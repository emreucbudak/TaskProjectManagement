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
    public class TeamRepository : RepositoryBase<Team>, ITeamRepository
    {
        public TeamRepository(ApplicationDbContext db) : base(db)
        {
        }

        public async Task AddTeam(Team team)
        {
            await AddObj(team);
        }

        public async Task<IEnumerable<Team>> GetAllTeams()
        {
            return await GetAllObj(false);
        }

        public async Task<Team> GetTeamById(int id)
        {
            return await GetByIdObj(b => b.TeamId == id);
        }

        public async Task RemoveTeam(Team team)
        {
            await DeleteObj(team);
        }

        public async Task UpdateTeam(Team team)
        {
            await UpdateObj(team);
        }
    }
}
