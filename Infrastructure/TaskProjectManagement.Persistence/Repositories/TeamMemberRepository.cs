using Microsoft.EntityFrameworkCore;
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
    public class TeamMemberRepository : RepositoryBase<TeamMember>, ITeamMemberRepository
    {
        public TeamMemberRepository(ApplicationDbContext db) : base(db)
        {
        }

        public async Task AddMember(int teamID, int userID)
        {
            var x = new TeamMember()
            {
                TeamId = teamID,
                UserId = userID
            };
            await AddObj(x);
        }

        public async Task DeleteMember(int teamID, int userID)
        {
            var x = await TeamMemberByUser(userID);
            if (x == null || x.Team == null)
            {
                throw new Exception("Kullanıcı herhangi bir takıma bağlı değil.");
            }
            else
            {
                await DeleteObj(x);
            }
        }

        public async Task<IEnumerable<TeamMember>> GetAllMembers(int teamID)
        {
            var x =  await GetAllTeamMember(teamID);
            return x;
        }

        public async Task<TeamMember> GetMember( int userID)
        {
            var x = await TeamMemberById(userID);
            return x;
        }
        private async Task<TeamMember> TeamMemberById(int userId) {
            var x = await GetAllObj(false);
            return  x.Where(b =>b.UserId == userId).FirstOrDefault();
        }
        private async Task<IEnumerable<TeamMember>> GetAllTeamMember (int teamID)
        {
            var x = await GetAllObj(false);
            return x.Where(b=> b.TeamId == teamID);

        }
        private async Task<TeamMember> TeamMemberByUser(int userId)
        {
            return await GetObjSps(false)
                .Where(b => b.UserId == userId)
                .Include(b => b.Team)
                .FirstOrDefaultAsync();
        }

    }

    }

