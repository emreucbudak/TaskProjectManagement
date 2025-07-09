using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskProjectManagement.Domain.Entities;

namespace TaskProjectManagement.Application.Interfaces.Repositories
{
    public interface ISubTaskRepository
    {
        Task AddSubtask (SubTask task);
        Task DeleteSubtask (SubTask task);
        Task UpdateSubtask (SubTask task);
        Task<IEnumerable<SubTask>> GetAllSubtasks ();
        Task<SubTask> GetSubTaskById (int id);
    }
}
