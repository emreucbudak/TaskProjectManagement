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
    public class DemandServices : IDemandServices
    {
        private readonly IRepositoryManager _rp;

        public DemandServices(IRepositoryManager rp)
        {
            _rp = rp;
        }

        public async Task AddDemandFromService(Demand dem)
        {
            await _rp.demandRepository.AddDemand(dem);
            await _rp.saveChangesAsync();
        }

        public async Task DeleteDemandFromService(int demandId)
        {
            var getDemandForDelete = await _rp.demandRepository.GetDemandById(demandId);
            await _rp.demandRepository.DeleteDemand(getDemandForDelete);
            await _rp.saveChangesAsync();
        }

        public async Task<IEnumerable<Demand>> GetAllDemandFromService(bool v)
        {
            return await _rp.demandRepository.GetAllDemands(v);
        }

        public async Task<Demand> GetOneDemandFromService(int id)
        {
            return await _rp.demandRepository.GetDemandById(id);
        }

        public async Task UpdateDemandFromService(Demand demand)
        {
            var updateDemand = await _rp.demandRepository.GetDemandById(demand.DemandId);
            updateDemand.DemandTitle = demand.DemandTitle;
            updateDemand.DemandDescription = demand.DemandDescription;
            await _rp.demandRepository.UpdateDemand(updateDemand);
            await _rp.saveChangesAsync();

        }
    }
}
