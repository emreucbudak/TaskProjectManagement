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
    public class CompanyRequestRepository : RepositoryBase<CompanyRequest>, ICompanyRequestRepository
    {
        public CompanyRequestRepository(ApplicationDbContext db) : base(db)
        {
        }

        public async Task AddCompanyRequest(CompanyRequest company)
        {
            await AddObj(company);

        }

        public async Task DeleteCompanyRequest(CompanyRequest company)
        {
            await DeleteObj(company);
            
        }

        public async Task<IEnumerable<CompanyRequest>> GetAllCompanyRequests()
        {
           return  await GetAllObj(false);
        }

        public async Task<CompanyRequest> GetCompanyById(int id)
        {
            return await GetByIdObj(b => b.RequestId == id);
        }

        public async Task UpdateCompanyRequest(CompanyRequest company)
        {
            await UpdateObj(company);
        }
    }
}
