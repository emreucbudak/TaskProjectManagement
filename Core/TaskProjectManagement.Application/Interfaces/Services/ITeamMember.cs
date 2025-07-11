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
        Task DeleteMemberFromService(int id);
        Task UpdateMemberFromService(TeamMember member);
        Task<TeamMember> GetMemberFromService(int id);
        Task<IEnumerable<TeamMember>> GetAllMembersFromService(bool v);
    }
}
