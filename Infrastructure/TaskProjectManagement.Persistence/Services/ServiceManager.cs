using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskProjectManagement.Application.Interfaces.Repositories;
using TaskProjectManagement.Application.Interfaces.Services;

namespace TaskProjectManagement.Persistence.Services
{
    public class ServiceManager : IServiceManager
    {
        private Lazy<IDemandServices> _demandServices;
        private Lazy<IMissionService> _missonServices;
        private Lazy <INotificationsService> _notificationsService;
        private Lazy<ISubtaskServices> _subTask;
        private Lazy<ITeamMember> _teamMember;
        private Lazy<ITeamService> _teamService;
        private Lazy<IUserNotificationsServices> _userNotifications;
        private Lazy<IUserServices> _userServices;
        public ServiceManager(IRepositoryManager rp) {
            _demandServices = new Lazy<IDemandServices>(() => new DemandServices(rp));
            _missonServices = new Lazy<IMissionService>(() => new MissionService(rp));
            _notificationsService = new Lazy<INotificationsService>(() => new NotificationService(rp));
            _subTask = new Lazy<ISubtaskServices>(() => new SubTaskService(rp));
            _teamMember = new Lazy<ITeamMember>(() => new TeamMemberService(rp));
            _teamService = new Lazy<ITeamService>(() => new TeamService(rp));
            _userNotifications = new Lazy<IUserNotificationsServices>(() => new UserNotificationService(rp));
            _userServices = new Lazy<IUserServices>(() => new UserService(rp));
        }
        public IDemandServices demand => _demandServices.Value;

        public IMissionService mission => _missonServices.Value;

        public INotificationsService notificationsService => _notificationsService.Value;

        public ISubtaskServices subtask => _subTask.Value;

        public ITeamMember teamMember => _teamMember.Value;

        public ITeamService teamService => _teamService.Value;

        public IUserNotificationsServices userNotifications => _userNotifications.Value;

        public IUserServices users => _userServices.Value;
    }
}
