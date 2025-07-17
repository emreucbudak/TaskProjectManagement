using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskProjectManagement.Domain.Entities;

namespace TaskProjectManagement.Application.Interfaces.Repositories
{
    public interface ICompanyRequestRepository
    {
        Task AddCompanyRequest (CompanyRequest company);
        Task DeleteCompanyRequest (CompanyRequest company);
        Task UpdateCompanyRequest (CompanyRequest company);
        Task<IEnumerable<CompanyRequest>> GetAllCompanyRequests();
        Task<CompanyRequest> GetCompanyById (int id);
    }
}
