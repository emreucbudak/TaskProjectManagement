using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskProjectManagement.Domain.Entities;

namespace TaskProjectManagement.Application.Interfaces.Services
{
    public interface ISystemOwnerService
    {
        Task AddOwner(SystemOwner owner);
        Task DeleteOwner(int owner);
        Task<SystemOwner> GetOwner(int ownerId);
        Task<IEnumerable<SystemOwner>> GetAllOwner();   
        Task UpdateOwner (SystemOwner owner); 

    }
}
