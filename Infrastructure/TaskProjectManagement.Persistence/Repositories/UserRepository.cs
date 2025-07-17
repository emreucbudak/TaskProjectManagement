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
    public class UserRepository : RepositoryBase<CompanyLeader>, IUserRepository
    {
        public UserRepository(ApplicationDbContext db) : base(db)
        {
        }

        public async Task AddUser(CompanyLeader user)
        {
            await AddObj(user);
        }

        public async Task DeleteUser(CompanyLeader user)
        {
            await DeleteObj(user);
        }

        public async Task<IEnumerable<CompanyLeader>> GetAllUsers()
        {
            return await GetAllObj(false);
        }

        public async Task<CompanyLeader> GetUserById(int id)
        {
            return await GetByIdObj(b => b.UserId == id);
        }

        public async Task UpdateUser(CompanyLeader user)
        {
            await UpdateObj(user);
        }
    }
}
