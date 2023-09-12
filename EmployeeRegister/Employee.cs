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
        static IList<Employee> employees = new List<Employee>();
        string FirstName { get; set; }
        string LastName { get; set; }
        int EmployeeId { get; set; }
        Salary Salary { get; set; }

        public Employee() { }

        public Employee(string firstName, string lastName, int employeeId, Salary salary)
        {
            FirstName = firstName;
            LastName = lastName;
            EmployeeId = employeeId;
            Salary = salary;
        }

        public IList<Employee> GetEmployees()
        {
            if(employees.Count != 0)
            {
                return employees;
            }
            throw new EmployeeListEmptyException("No employees registered.");

        }

        public Employee GetEmployee(int employeeId)
        {

            try
            {
                var employee = employees.Where(e => e.EmployeeId == employeeId).FirstOrDefault();
                if (employee == null)
                {
                    throw new EmployeeNotFoundException();
                }
                return employee;
            }
            catch (EmployeeNotFoundException ex)
            {
                throw new EmployeeNotFoundException("Employee with employee id " + employeeId + "not found.");
            }
        }

        public void AddEmployee(Employee emp)
        {
            employees.Add(emp);
        }

        public override string ToString()
        {
            return "Name: " + FirstName + " " + LastName + " " + "Salary: " +  Salary.Amount;
        }
    }
}
