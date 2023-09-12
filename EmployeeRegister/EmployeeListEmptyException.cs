using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeRegister
{
    internal class EmployeeListEmptyException : Exception
    {
        public EmployeeListEmptyException()
        {
        }

        public EmployeeListEmptyException(string message)
            : base(message)
        {
        }

        public EmployeeListEmptyException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
