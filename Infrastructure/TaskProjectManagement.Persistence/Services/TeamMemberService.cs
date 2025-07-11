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
    public class TeamMemberService : ITeamMember
    {
        private readonly IRepositoryManager _rp;

        public TeamMemberService(IRepositoryManager rp)
        {
            _rp = rp;
        }

        public async Task AddMemberFromService(TeamMember teamMember)
        {
            await _rp.teamMemberRepository.AddMember(teamMember.TeamId, teamMember.UserId);
            await _rp.saveChangesAsync();
        }

        public async Task DeleteMemberFromService(int teamId , int id)
        {
            var getMemberForService = await _rp.teamMemberRepository.GetMember(id);
            await _rp.teamMemberRepository.DeleteMember(teamId,id);
            await _rp.saveChangesAsync();
        }

        public async Task<IEnumerable<TeamMember>> GetAllMembersFromService(int teamId)
        {
            return await _rp.teamMemberRepository.GetAllMembers(teamId);

        }

        public async Task<TeamMember> GetMemberFromService(int userId)
        {
            return await _rp.teamMemberRepository.GetMember(userId);
            
        }


    }
}
