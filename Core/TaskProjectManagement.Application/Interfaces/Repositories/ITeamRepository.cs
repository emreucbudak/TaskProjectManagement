using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskProjectManagement.Domain.Entities;

namespace TaskProjectManagement.Application.Interfaces.Repositories
{
    public interface ITeamRepository
    {
        Task AddTeam(Team team);
        Task RemoveTeam(Team team);
        Task UpdateTeam(Team team);
        Task<IEnumerable<Team>> GetAllTeams(bool v);
        Task<Team> GetTeamById(int id);
    }
}
