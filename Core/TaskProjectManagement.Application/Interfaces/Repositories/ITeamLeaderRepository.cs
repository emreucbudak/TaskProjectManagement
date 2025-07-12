using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskProjectManagement.Domain.Entities;

namespace TaskProjectManagement.Application.Interfaces.Repositories
{
    public  interface ITeamLeaderRepository
    {
        Task AddLeader (TeamLeader teamLeader);
        Task RemoveLeader (TeamLeader teamLeader);
        Task UpdateLeader (TeamLeader teamLeader);
        Task<IEnumerable<TeamLeader>> GetAllLeader ();
        Task<TeamLeader> GetLeader (int id);
    }
}
