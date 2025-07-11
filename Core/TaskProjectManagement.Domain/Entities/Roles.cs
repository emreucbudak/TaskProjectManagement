using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskProjectManagement.Domain.Entities
{
    public class Roles
    {
        [Key]
        public int AuthorizationId { get; set; }
        public string AuthorizationName { get; set; }
        public ICollection<User> Users { get; set; }
    }
}
