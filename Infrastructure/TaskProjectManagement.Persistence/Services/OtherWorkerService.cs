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
    public class OtherWorkerService : IOtherWorkerService
    {
        private readonly IRepositoryManager _repositoryManager;

        public OtherWorkerService(IRepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
        }

        public async Task AddOtherWorker(OtherWorker worker)
        {

            worker.WorkerPassword = BCrypt.Net.BCrypt.EnhancedHashPassword(worker.WorkerPassword);
            await _repositoryManager.otherWorkerRepository.AddOtherWorkerFromRepo(worker);
            await _repositoryManager.saveChangesAsync();
        }

        public async Task<IEnumerable<OtherWorker>> GetAllOtherWorkers()
        {
            return await _repositoryManager.otherWorkerRepository.GetAllOtherWorkerFromRepository();
        }

        public async Task<OtherWorker> GetOtherWorker(int worker)
        {
            var otherWorkerForList =  await _repositoryManager.otherWorkerRepository.GetOtherWorkerFromRepository(worker);
            if (otherWorkerForList is null)
            {
                throw new OtherWorkerNotFoundException(worker);
            }
            return otherWorkerForList;

        }

        public async Task RemoveOtherWorker(int worker)
        {
            var getOtherWorkerForRemove = await _repositoryManager.otherWorkerRepository.GetOtherWorkerFromRepository(worker);
            if (getOtherWorkerForRemove is null)
            {
                throw new OtherWorkerNotFoundException(worker);
            }
            await _repositoryManager.otherWorkerRepository.DeleteOtherWorkerFromRepository(getOtherWorkerForRemove);
            await _repositoryManager.saveChangesAsync();
        }

        public async Task UpdateOtherWorker(OtherWorker worker)
        {
            var getOtherWorkerForUpdate = await _repositoryManager.otherWorkerRepository.GetOtherWorkerFromRepository(worker.OtherWorkerId);
            if (getOtherWorkerForUpdate is null)
            {
                throw new OtherWorkerNotFoundException(worker.OtherWorkerId);
            }
            getOtherWorkerForUpdate.WorkerEmail = worker.WorkerEmail;
            getOtherWorkerForUpdate.WorkerSurname = worker.WorkerSurname;
            getOtherWorkerForUpdate.WorkerName = worker.WorkerName;
            getOtherWorkerForUpdate.WorkerPassword = worker.WorkerPassword;
            await _repositoryManager.otherWorkerRepository.UpdateOtherWorkerFromRepository(getOtherWorkerForUpdate);
            await _repositoryManager.saveChangesAsync();
            
        }
    }
}
