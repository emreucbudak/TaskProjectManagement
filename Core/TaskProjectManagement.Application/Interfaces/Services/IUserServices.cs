using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskProjectManagement.Domain.Entities;

namespace TaskProjectManagement.Application.Interfaces.Services
{
    public interface IUserServices
    {
        Task AddUserFromService(User user);
        Task UpdateUserFromService(User user);
        Task DeleteUserFromService(int id);
        Task<IEnumerable<User>> GetAllUsers();
        Task<User> GetUserById(int id);
    }
}
