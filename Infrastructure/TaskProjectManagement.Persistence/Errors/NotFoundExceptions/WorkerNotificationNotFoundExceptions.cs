using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskProjectManagement.Persistence.Errors.NotFoundExceptions
{
    public class WorkerNotificationNotFoundExceptions : ItemNotFoundException
    {
        public WorkerNotificationNotFoundExceptions(string? message) : base(message)
        {
        }
    }
}
