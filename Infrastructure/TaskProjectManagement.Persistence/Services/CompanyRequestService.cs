using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskProjectManagement.Application.Interfaces.Repositories;
using TaskProjectManagement.Application.Interfaces.Services;
using TaskProjectManagement.Domain.Entities;
using TaskProjectManagement.Persistence.Errors.NotFoundExceptions;

using TaskProjectManagement.Persistence.Errors.UniqueExceptions;
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

            var getCompanyForAdd =  await _repositoryManager.companyRequestRepository.GetCompanyByName(request.CompanyName);
            if (getCompanyForAdd is not  null) {
                throw new NameUniqueExceptions();
            }
            else
            {
                await _repositoryManager.companyRequestRepository.AddCompanyRequest(request);
                await _repositoryManager.saveChangesAsync();
            }

        }

        public async Task DeleteCompanyRequestFromService(int companyId)
        {
            var getCompanyRequestForDelete = await _repositoryManager.companyRequestRepository.GetCompanyById(companyId);
            if (getCompanyRequestForDelete is null)
            {
                throw new CompanyRequestNotFound(companyId);
            }
            await _repositoryManager.companyRequestRepository.DeleteCompanyRequest(getCompanyRequestForDelete);
            await _repositoryManager.saveChangesAsync();
        }

        public async Task<CompanyRequest> GetCompanyRequestFromService(int companyId)
        {
            var x =  await _repositoryManager.companyRequestRepository.GetCompanyById(companyId);
            if(x is null)
            {
                throw new CompanyRequestNotFound(companyId);
            }
            return x;
        }

        public async Task<IEnumerable<CompanyRequest>> GetAllCompanyRequestFromService()
        {
            return await _repositoryManager.companyRequestRepository.GetAllCompanyRequests();
        }

        public async Task UpdateCompanyRequestFromService(CompanyRequest request)
        {
            var x = await _repositoryManager.companyRequestRepository.GetCompanyById(request.RequestId);
            if (x is null)
            {
                throw new CompanyRequestNotFound(request.RequestId);
            }
            x.CompanyName = request.CompanyName;
            x.CompanyLogo = request.CompanyLogo;
            await _repositoryManager.companyRequestRepository.UpdateCompanyRequest(x);
            await _repositoryManager.saveChangesAsync();
        }
    }
}
