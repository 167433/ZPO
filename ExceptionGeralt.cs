using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZPO
{
    public class ExceptionGeralt : Exception
    {
        public ExceptionGeralt(string Name)
            : base($"NIE MOŻESZ NAZWAĆ POSTACI GERALT!!!")
        {
        }
    }

}
