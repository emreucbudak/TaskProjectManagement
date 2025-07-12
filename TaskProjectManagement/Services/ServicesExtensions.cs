using Microsoft.EntityFrameworkCore;
using TaskProjectManagement.Application.Interfaces.Repositories;
using TaskProjectManagement.Application.Interfaces.Services;
using TaskProjectManagement.Persistence.ProjectDbContext;
using TaskProjectManagement.Persistence.Repositories;
using TaskProjectManagement.Persistence.Services;

namespace TaskProjectManagement.Services
{
    public static class ServicesExtensions
    {
        public static void ConfigureSql (this IServiceCollection services,IConfiguration config)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(config.GetConnectionString("DefaultConnection")));

        }
        public static void RepositoryRegister (this IServiceCollection services)
        {
            services.AddScoped<IDemandRepository,DemandRepository>();
            services.AddScoped<IMissionRepository,MissionRepository>();
            services.AddScoped<INotificationRepository,NotificationRepository>();
            services.AddScoped<ISubTaskRepository,SubTaskRepository>();
            services.AddScoped<ITeamRepository,TeamRepository>();
            services.AddScoped<IUserServices, UserService>();
        }
        public static void RepositoryManage(this IServiceCollection services)
        {
            services.AddScoped<IRepositoryManager, RepositoryManager>();
        }
        public static void RepositoryBaseInclude(this IServiceCollection services)
        {
            services.AddScoped(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));
        }
        public static void ServiceManage(this IServiceCollection services)
        {
            services.AddScoped<IDemandServices, DemandServices>();
            services.AddScoped<IMissionService, MissionService>();
            services.AddScoped<INotificationsService, NotificationService>();
            services.AddScoped<ISubtaskServices,SubTaskService>();
            services.AddScoped<ITeamService, TeamService>();
            services.AddScoped<IUserServices,UserService>();
        }
        public static void ServiceBase(this IServiceCollection services)
        {
            services.AddScoped<IServiceManager, ServiceManager>();
        }

    }
}
