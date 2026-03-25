using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_System.Exceptions
{
    internal class InvalidInput : Exception
    {
        public InvalidInput(string msg) : base(msg) { }
    }
}
