using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskProjectManagement.Domain.Entities;

namespace TaskProjectManagement.Application.Interfaces.Services
{
    public interface IMissionService
    {
        Task AddMission(Mission miss);
        Task RemoveMission(int miss);
        Task UpdateMigration (Mission miss);
        Task<Mission> GetMissionByIdFromService(int id);
        Task<IEnumerable<Mission>> GetAllMissionsFromService(bool v);
    }
}
