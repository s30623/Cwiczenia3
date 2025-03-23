using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenia3
{
    public class OverfillException : Exception
    {
        public OverfillException() {
            throw new Exception("Przepelniono kontener");
        }
    }
}
