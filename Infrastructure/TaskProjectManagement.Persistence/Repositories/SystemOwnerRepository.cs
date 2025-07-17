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
    public class SystemOwnerRepository : RepositoryBase<SystemOwner>, ISystemOwnerRepository
    {
        public SystemOwnerRepository(ApplicationDbContext db) : base(db)
        {
        }

        public async Task AddOwner(SystemOwner owner)
        {
            await AddObj(owner);
        }

        public async Task DeleteOwner(SystemOwner owner)
        {
            await DeleteObj(owner);
        }

        public async Task<IEnumerable<SystemOwner>> GetAllOwner()
        {
            return await GetAllObj(false);
        }

        public async Task<SystemOwner> GetOwner(int ownerId)
        {
            return await GetByIdObj(b=> b.SystemOwnerID == ownerId);
        }

        public async Task UpdateOwner(SystemOwner owner)
        {
            await UpdateObj(owner);
        }
    }
}
