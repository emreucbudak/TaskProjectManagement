using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskProjectManagement.Domain.Entities
{
    public class TeamStatus
    {
        public int Id { get; set; }
        public string Status{ get; set; }
        public int TeamId { get; set; }
        public Team Team { get; set; }




    }
}
