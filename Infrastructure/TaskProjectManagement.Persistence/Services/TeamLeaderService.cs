using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskProjectManagement.Application.Interfaces.Repositories;
using TaskProjectManagement.Application.Interfaces.Services;
using TaskProjectManagement.Domain.Entities;
using TaskProjectManagement.Persistence.Errors.NotFoundExceptions;


namespace TaskProjectManagement.Persistence.Services
{
    public class TeamLeaderService : ITeamLeaderService
    {
        private readonly IRepositoryManager _repositoryManager;

        public TeamLeaderService(IRepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
        }

        public async Task AddTeamLeader(TeamLeader teamLeader)
        {

            teamLeader.Password = BCrypt.Net.BCrypt.EnhancedHashPassword(teamLeader.Password);
            await _repositoryManager.eamLeaderRepository.AddLeader(teamLeader); 
            await _repositoryManager.saveChangesAsync();
        }

        public async Task<TeamLeader> GetTeamLeader(int teamLeaderId)
        {
            var getTeamLeader =  await _repositoryManager.eamLeaderRepository.GetLeader(teamLeaderId);
            if (getTeamLeader is null)
            {
                throw new TeamLeaderNotFoundExceptions(teamLeaderId);
            }
            return getTeamLeader;
        }

        public async Task<IEnumerable<TeamLeader>> GetTeamLeaderList()
        {
            return await _repositoryManager.eamLeaderRepository.GetAllLeader();
        }

        public async Task RemoveTeamLeader(int teamLeader)
        {
            var getTeamLeaderForRemove = await _repositoryManager.eamLeaderRepository.GetLeader(teamLeader);
            if (getTeamLeaderForRemove is null)
            {
                throw new TeamLeaderNotFoundExceptions(teamLeader);
            }
            await _repositoryManager.eamLeaderRepository.RemoveLeader(getTeamLeaderForRemove);
            await _repositoryManager.saveChangesAsync();

        }

        public async Task UpdateTeamLeader(TeamLeader teamLeader)
        {
            var getTeamLeaderForUpdate = await _repositoryManager.eamLeaderRepository.GetLeader(teamLeader.Id);
            if (getTeamLeaderForUpdate is null)
            {
                throw new TeamLeaderNotFoundExceptions(teamLeader.Id);
            }
            getTeamLeaderForUpdate.Name = teamLeader.Name;
            getTeamLeaderForUpdate.Email = teamLeader.Email;
            getTeamLeaderForUpdate.Password = BCrypt.Net.BCrypt.EnhancedHashPassword(teamLeader.Password);
            await _repositoryManager.eamLeaderRepository.UpdateLeader(getTeamLeaderForUpdate);
            await _repositoryManager.saveChangesAsync();

        }
    }
}
