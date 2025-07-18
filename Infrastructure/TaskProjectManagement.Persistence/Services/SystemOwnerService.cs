﻿using System;
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
    public class SystemOwnerService : ISystemOwnerService
    {
        private readonly IRepositoryManager _repositoryManager;

            public SystemOwnerService(IRepositoryManager repositoryManager)
            {
                _repositoryManager = repositoryManager;
        }

        public async Task AddOwner(SystemOwner owner)
        {

            owner.Password = BCrypt.Net.BCrypt.EnhancedHashPassword(owner.Password);
            await _repositoryManager.systemOwnerRepository.AddOwner(owner);
            await _repositoryManager.saveChangesAsync();

        }

        public async Task DeleteOwner(int owner)
        {
            var getOwnerForDelete = await _repositoryManager.systemOwnerRepository.GetOwner(owner);
            if (getOwnerForDelete is null )
            {
                throw new SystemOwnerNotFoundException(owner);
            }
            await _repositoryManager.systemOwnerRepository.DeleteOwner(getOwnerForDelete);
            await _repositoryManager.saveChangesAsync();
        }

        public async Task<IEnumerable<SystemOwner>> GetAllOwner()
        {
            return await _repositoryManager.systemOwnerRepository.GetAllOwner();
        }

        public async Task<SystemOwner> GetOwner(int ownerId)
        {
            var getSystemOwner =  await _repositoryManager.systemOwnerRepository.GetOwner(ownerId);
            if (getSystemOwner is null )
            {
                throw new SystemOwnerNotFoundException(ownerId);
            }
            return getSystemOwner;
        }

        public async Task UpdateOwner(SystemOwner owner)
        {
           var getOwnerForUpdate = await _repositoryManager.systemOwnerRepository.GetOwner(owner.SystemOwnerID);
            if (getOwnerForUpdate is null)
            {
                throw new SystemOwnerNotFoundException(owner.SystemOwnerID);
            }
           getOwnerForUpdate.Surname = owner.Surname;
           getOwnerForUpdate.Name = owner.Name;
            getOwnerForUpdate.Password = BCrypt.Net.BCrypt.EnhancedHashPassword(owner.Password);
            getOwnerForUpdate.Email = owner.Email;
            getOwnerForUpdate.IsSuperAdmin = owner.IsSuperAdmin;
            await _repositoryManager.systemOwnerRepository.UpdateOwner(getOwnerForUpdate);
            await _repositoryManager.saveChangesAsync();
        }
    }
}
