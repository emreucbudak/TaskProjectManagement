using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskProjectManagement.Domain.Entities;

namespace TaskProjectManagement.Application.Interfaces.Repositories
{
    public interface IDemandRepository
    {
        Task AddDemand(Demand dem);
        Task DeleteDemand(Demand demand);
        Task UpdateDemand(Demand demand);
        Task<Demand> GetDemandById (int id);
        Task<ICollection<Demand>> GetAllDemands();
    }
}
