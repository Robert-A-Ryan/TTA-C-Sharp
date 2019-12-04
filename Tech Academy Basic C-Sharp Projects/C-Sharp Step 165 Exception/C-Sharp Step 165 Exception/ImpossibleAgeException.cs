using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Step_165_Exception
{
    public class ImpossibleAgeException : Exception
    {
        public ImpossibleAgeException()
            : base() { }
        public ImpossibleAgeException(string message)
            : base(message) { }
    }
}
