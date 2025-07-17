using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskProjectManagement.Domain.Entities;

namespace TaskProjectManagement.Application.Interfaces.Services
{
    public interface IWorkerService
    {
        Task AddWorker (Worker worker);
        Task RemoveWorker (int worker);
        Task<Worker> GetWorker (int worker);
        Task UpdateWorker (Worker worker);  
        Task<IEnumerable<Worker>> GetWorkers ();    
    }
}
