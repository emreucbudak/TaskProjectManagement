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
    public class WorkerService : IWorkerService
    {
        private readonly IRepositoryManager _repository;

        public WorkerService(IRepositoryManager repository)
        {
            _repository = repository;
        }

        public async Task AddWorker(Worker worker)
        {
            worker.Password = BCrypt.Net.BCrypt.EnhancedHashPassword(worker.Password);
            await _repository.workerRepository.AddWorker(worker);
            await _repository.saveChangesAsync();
        }

        public async Task<Worker> GetWorker(int worker)
        {
            return await _repository.workerRepository.GetWorker(worker);
        }

        public async Task<IEnumerable<Worker>> GetWorkers()
        {
            return await _repository.workerRepository.GetAllWorkers();
        }

        public async Task RemoveWorker(int worker)
        {
            var getWorkerForRemove = await _repository.workerRepository.GetWorker(worker);
            await _repository.workerRepository.DeleteWorker(getWorkerForRemove);
            await _repository.saveChangesAsync();
        }

        public async Task UpdateWorker(Worker worker)
        {
            var getWorkerForUpdate = await _repository.workerRepository.GetWorker(worker.Id);
            getWorkerForUpdate.Email = worker.Email;
            getWorkerForUpdate.Password = BCrypt.Net.BCrypt.EnhancedHashPassword(worker.Password);
            getWorkerForUpdate.Name = worker.Name;
            getWorkerForUpdate.IsAvailable = worker.IsAvailable;
            await _repository.workerRepository.UpdateWorker(getWorkerForUpdate);
            await _repository.saveChangesAsync();
        }
    }
}
