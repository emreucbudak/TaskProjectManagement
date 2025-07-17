using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskProjectManagement.Application.Interfaces.Repositories;
using TaskProjectManagement.Application.Interfaces.Services;
using TaskProjectManagement.Domain.Entities;
using TaskProjectManagement.Persistence.ProjectDbContext;
using TaskProjectManagement.Persistence.Repositories;

namespace TaskProjectManagement.Persistence.Services
{
    public class CompanyRequestService : ICompanyRequestService 
    {
        private readonly IRepositoryManager _repositoryManager;

        public CompanyRequestService(IRepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
        }

        public async Task AddCompanyRequestFromService(CompanyRequest request)
        {
            await _repositoryManager.companyRequestRepository.AddCompanyRequest(request);   
            await _repositoryManager.saveChangesAsync();

        }

        public async Task DeleteCompanyRequestFromService(int companyId)
        {
            var getCompanyRequestForDelete = await _repositoryManager.companyRequestRepository.GetCompanyById(companyId);
            await _repositoryManager.companyRequestRepository.DeleteCompanyRequest(getCompanyRequestForDelete);
            await _repositoryManager.saveChangesAsync();
        }

        public async Task<CompanyRequest> GetCompanyRequestFromService(int companyId)
        {
            return await _repositoryManager.companyRequestRepository.GetCompanyById(companyId);
        }

        public async Task<IEnumerable<CompanyRequest>> GetAllCompanyRequestFromService()
        {
            return await _repositoryManager.companyRequestRepository.GetAllCompanyRequests();
        }

        public async Task UpdateCompanyRequestFromService(CompanyRequest request)
        {
            await _repositoryManager.companyRequestRepository.UpdateCompanyRequest(request);
            await _repositoryManager.saveChangesAsync();
        }
    }
}
