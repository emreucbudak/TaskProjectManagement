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
    public class SubTaskService : ISubtaskServices
    {
        private readonly IRepositoryManager rp;

        public SubTaskService(IRepositoryManager rp)
        {
            this.rp = rp;
        }

        public async Task AddSubTaskFromService(SubTask subTask)
        {
            await rp.subTaskRepository.AddSubtask(subTask);
            await rp.saveChangesAsync();
        }

        public async Task<IEnumerable<SubTask>> GetAllSubTasks(bool v)
        {
            return await rp.subTaskRepository.GetAllSubtasks(v);
        }

        public async Task<SubTask> GetSubTaskFromService(int id)
        {
            return await rp.subTaskRepository.GetSubTaskById(id);

        }

        public async Task RemoveSubTaskFromService(int id)
        {
            var getSubTaskForRemove = await rp.subTaskRepository.GetSubTaskById(id);
            await rp.subTaskRepository.DeleteSubtask(getSubTaskForRemove);
            await rp.saveChangesAsync();
        }

        public async Task UpdateSubTaskFromService(SubTask subTask)
        {
            var getSubTaskForUpdate = await rp.subTaskRepository.GetSubTaskById(subTask.SubTaskId);
            getSubTaskForUpdate.TaskName = subTask.TaskName;
            getSubTaskForUpdate.TaskDescription = subTask.TaskDescription;
            getSubTaskForUpdate.SubStatus.Status = subTask.SubStatus.Status;
            await rp.subTaskRepository.UpdateSubtask(getSubTaskForUpdate);
            await rp.saveChangesAsync();

        }
    }
}
