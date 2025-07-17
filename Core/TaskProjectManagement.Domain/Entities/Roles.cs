using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskProjectManagement.Domain.Entities
{
    public class Roles
    {
        public int Id { get; set; }
        public string RoleName  { get; set; }
        public ICollection<OtherWorker>? OtherWorkers { get; set; }
    }
}
