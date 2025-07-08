using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskProjectManagement.Domain.Entities
{
    public class MissionStatus
    {
        public int MissionStatusId { get; set; }
        public string TaskStatus {  get; set; }
        public ICollection<Mission> Missions { get; set; }
    }
}
