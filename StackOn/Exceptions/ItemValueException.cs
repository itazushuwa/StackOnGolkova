using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOn.Exceptions
{
    internal class ItemValueException : ValueException
    {
        public int Value;
        public ItemValueException(string message) : base(message)
        {
        }
    }
}