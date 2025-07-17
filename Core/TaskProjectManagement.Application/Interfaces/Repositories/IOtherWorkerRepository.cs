using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskProjectManagement.Domain.Entities;

namespace TaskProjectManagement.Application.Interfaces.Repositories
{
    public interface IOtherWorkerRepository
    {
        Task<IEnumerable<OtherWorker>> GetAllOtherWorkerFromRepository();
        Task<OtherWorker> GetOtherWorkerFromRepository(int id);
        Task AddOtherWorkerFromRepo (OtherWorker otherWorker);
        Task DeleteOtherWorkerFromRepository(OtherWorker otherWorker);
        Task UpdateOtherWorkerFromRepository (OtherWorker otherWorker);


    }
}
