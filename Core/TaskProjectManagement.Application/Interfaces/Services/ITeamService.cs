using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskProjectManagement.Domain.Entities;

namespace TaskProjectManagement.Application.Interfaces.Services
{
    public interface ITeamService
    {
        Task AddTeam();
        Task RemoveTeam(int teamId);
        Task<IEnumerable<Team>> GetAllTeams(bool v);
        Task<Team> GetTeamById(int teamId);
        Task UpdateTeamFromService(Team team);
    }
}
