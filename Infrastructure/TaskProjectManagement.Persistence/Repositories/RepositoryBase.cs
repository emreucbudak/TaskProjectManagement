using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TaskProjectManagement.Application.Interfaces.Repositories;
using TaskProjectManagement.Persistence.ProjectDbContext;


namespace TaskProjectManagement.Persistence.Repositories
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class, new()
    {
        private readonly ApplicationDbContext _db;

        public RepositoryBase(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task AddObj(T entity)
        {
            await _db.AddAsync(entity);
            await _db.SaveChangesAsync();

        }

        public async Task DeleteObj(T entity)
        {
             _db.Remove(entity);
            await _db.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> GetAllObj(bool v)
        {
            return v ?  await _db.Set<T>().AsNoTracking().ToListAsync() : await  _db.Set<T>().ToListAsync();
            
        }

        public async Task<T> GetByIdObj(Expression<Func<T, bool>> predicate)
        {
            return await _db.Set<T>().Where(predicate).SingleOrDefaultAsync();
        }

        public async Task UpdateObj(T entity)
        {
             _db.Update(entity);
            await _db.SaveChangesAsync();
        }
    }
}
