using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskProjectManagement.Application.Interfaces.Services;
using TaskProjectManagement.Domain.Entities;

namespace TaskProjectManagement.Persistence.Services
{
    public class TeamService : ITeamService
    {
        public Task AddTeam()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Team>> GetAllTeams(bool v)
        {
            throw new NotImplementedException();
        }

        public Task<Team> GetTeamById(int teamId)
        {
            throw new NotImplementedException();
        }

        public Task RemoveTeam(int teamId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateTeamFromService(Team team)
        {
            throw new NotImplementedException();
        }
    }
}
