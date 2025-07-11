using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskProjectManagement.Domain.Entities;

namespace TaskProjectManagement.Application.Interfaces.Services
{
    public interface ITeamMember
    {
        Task AddMemberFromService(TeamMember teamMember);
        Task DeleteMemberFromService(int teamId,int id);
        Task<TeamMember> GetMemberFromService(int userId);
        Task<IEnumerable<TeamMember>> GetAllMembersFromService(int teamId);
    }
}
