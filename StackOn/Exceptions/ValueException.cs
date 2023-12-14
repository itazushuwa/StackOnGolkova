using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOn.Exceptions
{
    internal class ValueException : Exception
    {
        public ValueException(string message) : base(message)
        {

        }
    }
}