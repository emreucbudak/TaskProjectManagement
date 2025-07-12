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
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(ApplicationDbContext db) : base(db)
        {
        }

        public async Task AddUser(User user)
        {
            await AddObj(user);
        }

        public async Task DeleteUser(User user)
        {
            await DeleteObj(user);
        }

        public async Task<IEnumerable<User>> GetAllUsers(bool v)
        {
            return await GetAllObj(v);
        }

        public async Task<User> GetUserById(int id)
        {
            return await GetByIdObj(b => b.UserId == id);
        }

        public async Task UpdateUser(User user)
        {
            await UpdateObj(user);
        }
    }
}
