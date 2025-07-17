using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskProjectManagement.Domain.Entities;

namespace TaskProjectManagement.Application.Interfaces.Services
{
    public interface ITeamLeaderService
    {
        Task AddTeamLeader (TeamLeader teamLeader); 
        Task RemoveTeamLeader (int teamLeader);
        Task UpdateTeamLeader (TeamLeader teamLeader);
        Task<IEnumerable<TeamLeader>> GetTeamLeaderList (); 
        Task<TeamLeader> GetTeamLeader (int teamLeaderId);
    }
}
