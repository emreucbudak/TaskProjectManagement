using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TaskProjectManagement.Domain.Entities;

namespace TaskProjectManagement.Persistence.ProjectDbContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Demand> Demands { get; set; }
        public DbSet<Mission> Missions { get; set; }
        public DbSet<Notifications> Notifications { get; set; }
        public DbSet<SubTask> SubTasks { get; set; }
        public DbSet<Team> Team { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<WorkerNotification> WorkersNotification { get; set; }
        public DbSet<Worker> Workers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Worker>().Property(b => b.IsAvailable).HasDefaultValue(true);
            modelBuilder.Entity<Demand>().Property(b => b.IsConfirmed).HasDefaultValue(false);
            modelBuilder.Entity<Mission>().Property(b=> b.IsCompleted).HasDefaultValue(false);
            modelBuilder.Entity<SubTask>().Property(b => b.IsComplete).HasDefaultValue(false);
            modelBuilder.Entity<Mission>().HasOne(b => b.Team).WithOne(b => b.Mission).HasForeignKey<Mission>(b => b.TeamId);
            modelBuilder.Entity<TeamLeader>().HasOne(b => b.Team).WithOne(b => b.teamLeader).HasForeignKey<TeamLeader>(b => b.TeamId);
            modelBuilder.Entity<WorkerNotification>().HasKey(b=> b.WorkerNotificationId);
            modelBuilder.Entity<Demand>().HasOne(b=> b.Team).WithMany(b=> b.Demands).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Demand>().HasOne(b => b.Worker).WithMany(b => b.Demands).OnDelete(DeleteBehavior.Restrict);

        }



    }
}
