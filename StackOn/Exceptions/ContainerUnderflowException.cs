using StackOn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOn.Exceptions
{
    internal class ContainerUnderflowException : ContainerCapacityException
    {
        public ContainerUnderflowException(string message) : base(message)
        {
        }
    }
}