using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskProjectManagement.Application.Interfaces.Repositories;
using TaskProjectManagement.Application.Interfaces.Services;
using TaskProjectManagement.Domain.Entities;

namespace TaskProjectManagement.Persistence.Services
{
    public class TeamService : ITeamService
    {
        private readonly IRepositoryManager _rp;

        public TeamService(IRepositoryManager rp)
        {
            _rp = rp;
        }

        public async Task AddTeam(Team team)
        {
           team.MemberCount = 0;
            await _rp.teamRepository.AddTeam(team);
           await _rp.saveChangesAsync();
        }

        public async Task<IEnumerable<Team>> GetAllTeams(bool v)
        {
            return await _rp.teamRepository.GetAllTeams(v);
        }

        public async Task<Team> GetTeamById(int teamId)
        {
            return await _rp.teamRepository.GetTeamById(teamId);
        }

        public async Task RemoveTeam(int teamId)
        {
            var getTeamForRemove = await _rp.teamRepository.GetTeamById(teamId);
            await _rp.teamRepository.RemoveTeam(getTeamForRemove);
            await _rp.saveChangesAsync();
        }

        public async Task UpdateTeamFromService(Team team)
        {
            var getTeamForUpdate = await _rp.teamRepository.GetTeamById(team.TeamId);
            getTeamForUpdate.TeamName = team.TeamName;
            await _rp.teamRepository.UpdateTeam(getTeamForUpdate);
            await _rp.saveChangesAsync();

            
        }
    }
}
