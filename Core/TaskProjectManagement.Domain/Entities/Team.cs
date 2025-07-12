using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskProjectManagement.Domain.Entities
{
    public class Team
    {
        public int TeamId { get; set; }
        public string TeamName { get; set; }
        public int teamLeaderId { get; set; }
        public TeamLeader teamLeader { get; set; }
        public ICollection<Worker>? Worker { get; set; }
        public ICollection<Demand>? Demands { get; set; }
        public int MissionId { get; set; }
        public Mission Mission { get; set; }
        public int MemberCount { get; set; } = 0;
        public bool IsOpen { get; set; }




    }
}
