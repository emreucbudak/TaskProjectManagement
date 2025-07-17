using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskProjectManagement.Domain.Entities;

namespace TaskProjectManagement.Application.Interfaces.Services
{
    public interface IOtherWorkerService
    {
        Task AddOtherWorker (OtherWorker worker);
        Task RemoveOtherWorker (int worker);

        Task<OtherWorker> GetOtherWorker (int worker);
        Task<IEnumerable<OtherWorker>> GetAllOtherWorkers ();   
        Task UpdateOtherWorker (OtherWorker worker);
    }
}
