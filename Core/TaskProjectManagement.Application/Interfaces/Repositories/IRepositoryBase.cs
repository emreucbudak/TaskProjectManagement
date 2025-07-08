using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TaskProjectManagement.Application.Interfaces.Repositories
{
    public interface IRepositoryBase <T> where T : class
    {
        Task AddObj(T entity);
        Task UpdateObj(T entity);
        Task DeleteObj(T entity);
        Task<T> GetByIdObj (Expression<Func<T, bool>> predicate);
        Task <IEnumerable<T>> GetAllObj (bool v);
    }
}
