using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskProjectManagement.Domain.Entities;

namespace TaskProjectManagement.Application.Interfaces.Repositories
{
    public interface IMissionRepository
    {
        Task AddMission(Mission mission);
        Task DeleteMission(Mission mission);
        Task<IEnumerable<Mission>> GetAllMissions();
        Task UpdateMissions (Mission mission);
        Task<Mission> GetMission (int id);
    }
}
