using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskProjectManagement.Application.Interfaces.Repositories;
using TaskProjectManagement.Domain.Entities;
using TaskProjectManagement.Persistence.ProjectDbContext;

namespace TaskProjectManagement.Persistence.Repositories
{
    public class SubTaskRepository : RepositoryBase<SubTask>, ISubTaskRepository
    {
        public SubTaskRepository(ApplicationDbContext db) : base(db)
        {
        }

        public async Task AddSubtask(SubTask task)
        {
            await AddObj(task);
        }

        public async Task DeleteSubtask(SubTask task)
        {
            await DeleteObj(task);
        }

        public async Task<IEnumerable<SubTask>> GetAllSubtasks(bool v)
        {
            return await GetAllObj(v);
        }

        public async Task<SubTask> GetSubTaskById(int id)
        {
            return await GetByIdObj(b=> b.SubTaskId == id);
        }

        public async Task UpdateSubtask(SubTask task)
        {
            await UpdateObj(task);
        }
    }
}
