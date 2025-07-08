using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TaskProjectManagement.Domain.Entities;

namespace TaskProjectManagement.Persistence.ApplicationDbContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Roles> Roles {  get; set; }
        public DbSet<Demand> Demands { get; set; }
        public DbSet<Mission> Missions { get; set; }
        public DbSet<MissionStatus> MissionStatus { get; set; }
        public DbSet<Notifications> Notifications { get; set; }
        public DbSet<SubTask> SubTasks { get; set; }
        public DbSet<SubTaskStatus> SubTasksStatus { get; set; }
        public DbSet<Team> Team { get; set; }
        public DbSet<TeamMember> TeamMember { get; set; }
        public DbSet<TeamStatus> TeamStatus { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserNotification> UsersNotification { get; set; }
    }
}
