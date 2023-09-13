using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EmployeeRegister
{

    internal class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int EmployeeId { get; set; }
        public Salary Salary { get; set; }

        public Employee() { }

        public Employee(string firstName, string lastName, int employeeId, Salary salary)
        {
            FirstName = firstName;
            LastName = lastName;
            EmployeeId = employeeId;
            Salary = salary;
        }

        public override string ToString()
        {
            return "\n" + "Name: " + FirstName + " " + LastName + "\n" + "Employee ID: " + EmployeeId + "\n" + "Salary: " +  Salary.Amount + "\n";
        }
    }
}
