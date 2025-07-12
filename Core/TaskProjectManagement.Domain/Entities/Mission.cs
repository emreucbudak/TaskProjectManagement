using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskProjectManagement.Domain.Entities
{
    public class Mission
    {
        public int MissionId { get; set; }
        public string MissionName { get; set; }
        public string MissionDescription { get; set; }
        public int TeamId { get; set; }
        public Team Team { get; set; }
        public bool IsCompleted { get; set; }

        
        
    }
}
