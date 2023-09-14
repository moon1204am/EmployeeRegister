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

        public Employee(string firstName, string lastName, int employeeId, double salary)
        {
            FirstName = firstName;
            LastName = lastName;
            EmployeeId = employeeId;
            Salary = new Salary(salary);
        }

        public double GetNetSalary()
        {
            return Salary.CalculateNetSalary(this.Salary.Amount);
        }

        public override string ToString()
        {
            return $"\n First name: {FirstName}\n Last name: {LastName}\n Employee ID: { EmployeeId}\n Salary: {Salary.Amount}\n Net salary: { GetNetSalary()} \n";
        }
    }
}
