using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskProjectManagement.Persistence.Errors.NotFoundExceptions
{
    public class SystemOwnerNotFoundException : ItemNotFoundException
    {
        public SystemOwnerNotFoundException(int id) : base($"{id}'e sahip istenilen öğe bulunamadı")
        {
        }
    }
}
