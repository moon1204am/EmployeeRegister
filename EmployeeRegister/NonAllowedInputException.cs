using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeRegister
{
    internal class NonAllowedInputException : Exception
    {
        public NonAllowedInputException() { }

        public NonAllowedInputException(string message)
            : base(message)
        {
        }

        public NonAllowedInputException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
