using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskProjectManagement.Application.Interfaces.Repositories;
using TaskProjectManagement.Application.Interfaces.Services;
using TaskProjectManagement.Domain.Entities;
using TaskProjectManagement.Persistence.Errors.NotFoundExceptions;


namespace TaskProjectManagement.Persistence.Services
{
    public class ReportSystemService : IReportSystemService
    {
        private readonly IRepositoryManager _repositoryManager;

        public ReportSystemService(IRepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
        }

        public async Task AddReportFromService(ReportSystem reportSystem)
        {

            await _repositoryManager.reportSystemRepository.AddReportFromRepo(reportSystem);
            await _repositoryManager.saveChangesAsync();
        }

        public async Task<IEnumerable<ReportSystem>> GetAllReceiverReport(int receiverId)
        {
            return await  _repositoryManager.reportSystemRepository.GetAllReportsFromRepo(receiverId);

        }

        public async Task<ReportSystem> GetReceiverReportSystemById(int reportId)
        {
            var getReport =  await _repositoryManager.reportSystemRepository.GetReceiverReportFromRepo(reportId);
            if (getReport is null)
            {
                throw new   ReportNotFoundException(reportId);
            }
            return getReport;

        }

        public async Task<IEnumerable<ReportSystem>> GetSenderReportSystems(int senderId)
        {
            return await _repositoryManager.reportSystemRepository.GetSenderReportFromRepo(senderId);
        }

        public async Task RemoveReportFromService(int reportSystemId)
        {
            var getReportForRemove = await _repositoryManager.reportSystemRepository.GetPostForDeleteFromRepository(reportSystemId);
            await _repositoryManager.reportSystemRepository.DeleteReportFromRepo(getReportForRemove);
            await _repositoryManager.saveChangesAsync();
        }

        public async Task UpdateReportFromService(ReportSystem reportSystem)
        {
            var getPostForUpdate = await _repositoryManager.reportSystemRepository.GetPostForUpdateFromRepository(reportSystem.ReportId);   
            getPostForUpdate.ReportDescription = reportSystem.ReportDescription;
            getPostForUpdate.ReportTopic = reportSystem.ReportTopic;
            getPostForUpdate.ReportTitle = reportSystem.ReportTitle;
            getPostForUpdate.IsClosed = reportSystem.IsClosed;
            await _repositoryManager.reportSystemRepository.UpdateReportFromRepo(getPostForUpdate);
            await _repositoryManager.saveChangesAsync();


        }
    }
}
