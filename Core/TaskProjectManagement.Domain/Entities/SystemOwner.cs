using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskProjectManagement.Domain.Entities
{
    public class SystemOwner
    {
        public int SystemOwnerID { get; set; }
        public string Name { get; set; }
        public string Surname   { get; set; }
        public bool IsSuperAdmin { get; set; }
        public string Email     { get; set; }
        public string Password  { get; set; }

    }
}
