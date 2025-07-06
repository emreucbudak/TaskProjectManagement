using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskProjectManagement.Domain.Entities
{
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Surname   { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int AuthorizationId { get; set; }
        public Authorization Authorization { get; set; }
        public ICollection<Notifications> Notifications { get; set; }
        public Team CreatedTeam { get; set; }
        public ICollection<Demand> Demands { get; set; }
        public int? CreatedById { get; set; }
        public User CreatedBy { get; set; }
        public ICollection<User> CreatedUsers { get; set; }

    }
}
