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
        private Lazy<ITeamMemberRepository> _ebam;
        private Lazy<ITeamRepository> _tm;
        private Lazy<IUserNotificationRepository> _users;
        private Lazy<IUserRepository> _user;

        public RepositoryManager(ApplicationDbContext db)
        {
            _db = db;
            _dm = new Lazy<IDemandRepository>(() => new DemandRepository(_db));
            _mission = new Lazy<IMissionRepository>(() => new MissionRepository(_db));
            _notifications = new Lazy<INotificationRepository>(() => new NotificationRepository(_db));
            _sbs = new Lazy<ISubTaskRepository>(() => new SubTaskRepository(_db));
            _ebam = new Lazy<ITeamMemberRepository>(() => new TeamMemberRepository(_db));
            _tm = new Lazy<ITeamRepository>(() => new TeamRepository(_db));
            _users = new Lazy<IUserNotificationRepository>(() => new UserNotificationRepository(_db));
            _user = new Lazy<IUserRepository>(() => new UserRepository(_db));

   
        }

        

        public IDemandRepository demandRepository => _dm.Value;

        public IMissionRepository missionRepository => _mission.Value;

        public INotificationRepository notificationRepository => _notifications.Value;

        public ISubTaskRepository subTaskRepository => _sbs.Value;

        public ITeamMemberRepository teamMemberRepository => _ebam.Value;

        public ITeamRepository teamRepository => _tm.Value;

        public IUserNotificationRepository userNotificationRepository => _users.Value;

        public IUserRepository userRepository => _user.Value;

        public async Task saveChangesAsync()
        {
            await _db.SaveChangesAsync();
        }
    }
}
