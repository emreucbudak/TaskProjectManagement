using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskProjectManagement.Domain.Entities;

namespace TaskProjectManagement.Application.Interfaces.Services
{
    public interface ISubtaskServices
    {
        Task AddSubTaskFromService (SubTask subTask);
        Task RemoveSubTaskFromService(int id);
        Task UpdateSubTaskFromService(SubTask subTask);
        Task<SubTask> GetSubTaskFromService (int id);
        Task<IEnumerable<SubTask>> GetAllSubTasks ();

    }

}
