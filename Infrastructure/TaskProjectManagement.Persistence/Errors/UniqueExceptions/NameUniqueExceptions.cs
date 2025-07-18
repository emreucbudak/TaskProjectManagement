using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskProjectManagement.Persistence.Errors.UniqueExceptions
{
    public class NameUniqueExceptions : PropertyUniqueExceptions
    {
        public NameUniqueExceptions() : base("İsim Alanı Benzersiz Olmalıdır")
        {
        }
    }
}
