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
        Task AddUserFromService(CompanyLeader user);
        Task UpdateUserFromService(CompanyLeader user);
        Task DeleteUserFromService(int id);
        Task<IEnumerable<CompanyLeader>> GetAllUsers();
        Task<CompanyLeader> GetUserById(int id);
    }
}
