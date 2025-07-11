using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskProjectManagement.Application.Interfaces.Services;
using TaskProjectManagement.Domain.Entities;

namespace TaskProjectManagement.Persistence.Services
{
    public class UserService : IUserServices
    {
        public Task AddUserFromService(User user)
        {
            throw new NotImplementedException();
        }

        public Task DeleteUserFromService(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User>> GetAllUsers(bool v)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetUserById(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateUserFromService(User user)
        {
            throw new NotImplementedException();
        }
    }
}
