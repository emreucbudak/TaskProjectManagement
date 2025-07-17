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
    public class RepositoryManager : IRepositoryManager
    {
        public ApplicationDbContext _db;
        private Lazy<IDemandRepository> _dm;
        private Lazy<IMissionRepository> _mission;
        private Lazy<INotificationRepository> _notifications;
        private Lazy<ISubTaskRepository> _sbs;
        private Lazy<ITeamRepository> _tm;

        private Lazy<IUserRepository> _user;
        private Lazy<ICompanyRepository> _company;
        private Lazy<ICompanyRequestRepository> _companyRequest;
        private Lazy<IOtherWorkerRepository> _therWorker;
        private Lazy<IReportSystemRepository> _report;
        private Lazy<ISystemOwnerRepository> _systemOwner;
        private Lazy<ITeamLeaderRepository> _therLeader;
        private Lazy<IWorkerNotificationRepository> _therWorkerNotification;
        private Lazy<IWorkerRepository> _therWorkerRepository;


        public RepositoryManager(ApplicationDbContext db)
        {
            _db = db;
            _dm = new Lazy<IDemandRepository>(() => new DemandRepository(_db));
            _mission = new Lazy<IMissionRepository>(() => new MissionRepository(_db));
            _notifications = new Lazy<INotificationRepository>(() => new NotificationRepository(_db));
            _sbs = new Lazy<ISubTaskRepository>(() => new SubTaskRepository(_db));
            _tm = new Lazy<ITeamRepository>(() => new TeamRepository(_db));
            _user = new Lazy<IUserRepository>(() => new UserRepository(_db));
            _company = new Lazy<ICompanyRepository>(() => new CompanyRepository(_db));
            _companyRequest = new Lazy<ICompanyRequestRepository>(() => new CompanyRequestRepository(_db));
            _therWorker = new Lazy<IOtherWorkerRepository>(() => new OtherWorkerRepository(_db));
            _report = new Lazy<IReportSystemRepository>(() => new ReportSystemRepository(_db));
            _systemOwner = new Lazy<ISystemOwnerRepository>(() => new SystemOwnerRepository(_db));
            _therLeader = new Lazy<ITeamLeaderRepository>(() => new TeamLeaderRepository(_db));
            _therWorkerRepository = new Lazy<IWorkerRepository>(() => new WorkerRepository(_db));
            _therWorkerNotification =   new Lazy<IWorkerNotificationRepository>(()=> new WorkerNotificationRepository(_db));


   
        }

        

        public IDemandRepository demandRepository => _dm.Value;

        public IMissionRepository missionRepository => _mission.Value;

        public INotificationRepository notificationRepository => _notifications.Value;

        public ISubTaskRepository subTaskRepository => _sbs.Value;



        public ITeamRepository teamRepository => _tm.Value;



        public IUserRepository userRepository => _user.Value;

        public ICompanyRepository companyRepository => throw new NotImplementedException();

        public ICompanyRequestRepository companyRequestRepository => throw new NotImplementedException();

        public IOtherWorkerRepository otherWorkerRepository => throw new NotImplementedException();

        public IReportSystemRepository reportSystemRepository => throw new NotImplementedException();

        public ISystemOwnerRepository systemOwnerRepository => throw new NotImplementedException();

        public ITeamLeaderRepository eamLeaderRepository => throw new NotImplementedException();

        public IWorkerNotificationRepository workerNotificationRepository => throw new NotImplementedException();

        public IWorkerRepository workerRepository => throw new NotImplementedException();

        public async Task saveChangesAsync()
        {
            await _db.SaveChangesAsync();
        }
    }
}
