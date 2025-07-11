using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskProjectManagement.Domain.Entities;

namespace TaskProjectManagement.Application.Interfaces.Repositories
{
    public interface ITeamMemberRepository
    {
        Task AddMember(int teamID, int userID);
        Task DeleteMember(int teamID, int userID);
        Task<TeamMember> GetMember(int userID);
        Task<IEnumerable<TeamMember>> GetAllMembers(int teamID);

    }
}
