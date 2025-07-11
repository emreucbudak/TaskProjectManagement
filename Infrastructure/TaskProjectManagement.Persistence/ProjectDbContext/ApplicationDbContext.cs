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
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Team-Creator ilişkisi (User > Team)
            modelBuilder.Entity<Team>()
                .HasOne(t => t.Creator)
                .WithMany()
                .HasForeignKey(t => t.CreatorId)
                .OnDelete(DeleteBehavior.Restrict);

            // Team-Mission ilişkisi (1:1)
            modelBuilder.Entity<Team>()
                .HasOne(t => t.Mission)
                .WithOne(m => m.Team)
                .HasForeignKey<Mission>(m => m.TeamId)
                .OnDelete(DeleteBehavior.Cascade);

            // User-Team ilişkisi (Team içinde olan kullanıcı)
            modelBuilder.Entity<User>()
                .HasOne(u => u.Team)
                .WithMany()
                .HasForeignKey(u => u.TeamId)
                .OnDelete(DeleteBehavior.Restrict);

            // User-CreatedTeam ilişkisi: Kullanıcının oluşturduğu takım
            modelBuilder.Entity<User>()
                .HasOne<Team>()
                .WithMany()
                .HasForeignKey(u => u.CreatedTeamId)
                .OnDelete(DeleteBehavior.Restrict); // Cascade kaldırıldı

            // User-CreatedBy ilişkisi: Kullanıcıyı oluşturan başka bir kullanıcı
            modelBuilder.Entity<User>()
                .HasOne(u => u.CreatedBy)
                .WithMany()
                .HasForeignKey(u => u.CreatedById)
                .OnDelete(DeleteBehavior.Restrict);

            // User-Roles ilişkisi
            modelBuilder.Entity<User>()
                .HasOne(u => u.Authorization)
                .WithMany()
                .HasForeignKey(u => u.AuthorizationId)
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<TeamMember>()
    .HasOne(tm => tm.User)
    .WithMany()
    .HasForeignKey(tm => tm.UserId)
    .OnDelete(DeleteBehavior.Restrict); // veya DeleteBehavior.NoAction

            modelBuilder.Entity<TeamMember>()
                .HasOne(tm => tm.Team)
                .WithMany()
                .HasForeignKey(tm => tm.TeamId)
                .OnDelete(DeleteBehavior.Cascade);
            // Bu ilişkide cascade güvenli
            modelBuilder.Entity<User>()
    .HasOne(u => u.CreatedTeam)
    .WithOne()
    .HasForeignKey<Team>(t => t.CreatorId);
            modelBuilder.Entity<Team>()
    .HasOne(t => t.Creator)
    .WithMany()
    .HasForeignKey(t => t.CreatorId)
    .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Demand>()
    .HasOne(d => d.User)
    .WithMany()
    .HasForeignKey(d => d.UserId)
    .OnDelete(DeleteBehavior.Restrict);
            
        }



    }
}
