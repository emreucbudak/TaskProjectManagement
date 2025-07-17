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
    public class ReportSystemRepository : RepositoryBase<ReportSystem>, IReportSystemRepository
    {
        public ReportSystemRepository(ApplicationDbContext db) : base(db)
        {
        }

        public async Task AddReportFromRepo(ReportSystem reportSystem)
        {
            await AddObj(reportSystem);
        }

        public async Task CloseReportFromRepo(ReportSystem reportSystem)
        {
            await UpdateObj(reportSystem);
        }

        public async Task DeleteReportFromRepo(ReportSystem reportSystem)
        {
            await DeleteObj(reportSystem);
        }

        public async Task<IEnumerable<ReportSystem>> GetAllReportsFromRepo(int receiverId)
        {
            var allHaveReports = await GetAllObj(false);
            return allHaveReports.Where(b => b.WorkerId == receiverId);
        }

        public async Task<ReportSystem> GetPostForDeleteFromRepository(int postId)
        {
            var getPostForDelete = await GetAllObj(false);
            return getPostForDelete.Where(b => b.ReportId == postId).FirstOrDefault();

        }
        public async Task<ReportSystem> GetPostForUpdateFromRepository(int postId)
        {
            var getPostForDelete = await GetAllObj(false);
            return getPostForDelete.Where(b => b.ReportId == postId).FirstOrDefault();

        }

        public async Task<ReportSystem> GetReceiverReportFromRepo(int reportId , int receiverId)
        {
            var getOneReportFromReceiver = await GetAllObj(false);
            return getOneReportFromReceiver.Where(b => b.WorkerId==receiverId&& b.ReportId == reportId).FirstOrDefault();
        }

        public async Task<IEnumerable<ReportSystem>> GetSenderReportFromRepo(int userId)
        {
            var getOneReportFromSender = await GetAllObj(false);
            return getOneReportFromSender.Where(b => b.OtherWorkerId == userId);
        }

        public async Task UpdateReportFromRepo(ReportSystem reportSystem)
        {
            await UpdateObj(reportSystem);
        }
    }
}
