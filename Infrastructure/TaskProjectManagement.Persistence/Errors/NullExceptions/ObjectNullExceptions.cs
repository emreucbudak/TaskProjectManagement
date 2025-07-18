using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskProjectManagement.Persistence.Errors.NullExceptions
{
    public class ObjectNullExceptions : Exception
    {
        public ObjectNullExceptions() : base("Göndermeye çalıştığınız veri null!")
        {
        }
    }
}
