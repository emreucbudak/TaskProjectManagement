using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskProjectManagement.Domain.Entities
{
    public class SubTask
    {
        public int SubTaskId    { get; set; }
        public string TaskName { get; set; }
        public string TaskDescription { get; set; }
        public int WorkerId { get; set; }
        public Worker Worker { get; set; }
        public bool IsComplete { get; set; }

    }
}
