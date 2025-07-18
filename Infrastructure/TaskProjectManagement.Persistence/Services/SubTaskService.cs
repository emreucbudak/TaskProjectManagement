using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskProjectManagement.Application.Interfaces.Repositories;
using TaskProjectManagement.Application.Interfaces.Services;
using TaskProjectManagement.Domain.Entities;
using TaskProjectManagement.Persistence.Errors.NotFoundExceptions;


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
            var getSubTask =  await rp.subTaskRepository.GetSubTaskById(id);
            if(getSubTask is null )
            {
                throw new SubTaskNotFoundException(id);
            }
            return getSubTask;

        }

        public async Task RemoveSubTaskFromService(int id)
        {
            var getSubTaskForRemove = await rp.subTaskRepository.GetSubTaskById(id);
            if (getSubTaskForRemove is null )
            {
                throw new SubTaskNotFoundException(id);
            }
            await rp.subTaskRepository.DeleteSubtask(getSubTaskForRemove);
            await rp.saveChangesAsync();
        }

        public async Task UpdateSubTaskFromService(SubTask subTask)
        {
            var getSubTaskForUpdate = await rp.subTaskRepository.GetSubTaskById(subTask.SubTaskId);
            if (getSubTaskForUpdate is null )
            {
                throw new SubTaskNotFoundException(subTask.SubTaskId);
            }
            getSubTaskForUpdate.TaskName = subTask.TaskName;
            getSubTaskForUpdate.TaskDescription = subTask.TaskDescription;
            getSubTaskForUpdate.IsComplete = subTask.IsComplete;

            await rp.subTaskRepository.UpdateSubtask(getSubTaskForUpdate);
            await rp.saveChangesAsync();

        }
    }
}
