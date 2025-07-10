using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskProjectManagement.Domain.Entities;

namespace TaskProjectManagement.Application.Interfaces.Services
{
    public interface IDemandServices
    {
        Task AddDemandFromService(Demand dem);
        Task DeleteDemandFromService (int demandId);
        Task<Demand> GetOneDemandFromService(int id);
        Task<IEnumerable<Demand>> GetAllDemandFromService(bool v);
        Task UpdateDemandFromService  (Demand demand);
    }
}
