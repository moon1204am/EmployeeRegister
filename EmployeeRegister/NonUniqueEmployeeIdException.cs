using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeRegister
{
    internal class NonUniqueEmployeeIdException : Exception
    {
        public NonUniqueEmployeeIdException()
        {
        }

        public NonUniqueEmployeeIdException(string message)
            : base(message)
        {
        }

        public NonUniqueEmployeeIdException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
