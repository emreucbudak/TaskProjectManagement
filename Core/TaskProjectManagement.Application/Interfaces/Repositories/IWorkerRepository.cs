using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskProjectManagement.Domain.Entities;

namespace TaskProjectManagement.Application.Interfaces.Repositories
{
    public interface IWorkerRepository 
    {
        Task AddWorker(Worker worker);
        Task DeleteWorker(Worker worker);
        Task<Worker> GetWorker(int worker);
        Task<IEnumerable<Worker>> GetAllWorkers();
        Task UpdateWorker(Worker worker);

           

    }
}
