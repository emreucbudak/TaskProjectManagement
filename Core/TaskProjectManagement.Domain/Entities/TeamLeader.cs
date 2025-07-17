using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskProjectManagement.Domain.Entities
{
    public class TeamLeader
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password  { get; set; }
        public int TeamId { get; set; }
        public Team Team { get; set; }
        public ICollection<Notifications>? Notifications { get; set; }   
        public int CompanyId { get; set; }
        public Company? Company { get; set; }

    }
}
