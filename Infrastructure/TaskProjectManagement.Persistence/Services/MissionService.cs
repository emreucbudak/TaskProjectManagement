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
    public class MissionService : IMissionService
    {
        private readonly IRepositoryManager _rp;

        public MissionService(IRepositoryManager rp)
        {
            _rp = rp;
        }

        public async Task AddMission(Mission miss)
        {
           await _rp.missionRepository.AddMission(miss);
            await _rp.saveChangesAsync();
        }

        public async Task<IEnumerable<Mission>> GetAllMissionsFromService(bool v)
        {
            return await _rp.missionRepository.GetAllMissions(v);
        }

        public async Task<Mission> GetMissionByIdFromService(int id)
        {
            return await _rp.missionRepository.GetMission(id);
        }

        public async Task RemoveMission(int miss)
        {
            var getMissionForRemove = await _rp.missionRepository.GetMission(miss);
            await _rp.missionRepository.DeleteMission(getMissionForRemove);
        }

        public async Task UpdateMission(Mission miss)
        {
            var getMissionForUpdate = await _rp.missionRepository.GetMission(miss.MissionId);
            await _rp.missionRepository.DeleteMission(getMissionForUpdate);
            await _rp.saveChangesAsync();
        }
    }
}
