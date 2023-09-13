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

        public static IList<Employee> GetEmployees()
        {
            try
            {
                if (employees.Count == 0)
                {
                    throw new EmployeeListEmptyException("Could not fetch employees. No employees registered.");
                }
                
            } catch(EmployeeListEmptyException e)
            {
                Console.WriteLine(e.Message);
            }
            return employees;
        }

        public Employee GetEmployee(int employeeId)
        {
            var employee = employees.Where(e => e.EmployeeId == employeeId).FirstOrDefault();
            try
            {
                if (employee == null)
                {
                    throw new EmployeeNotFoundException("Employee with employee id " + employeeId + " not found.");
                }
            }
            catch (EmployeeNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            return employee;
        }

        public void AddEmployee(Employee emp)
        {
            employees.Add(emp);
        }

        public static bool checkUniqueId(int id)
        {
            var employee = employees.Where(e => e.EmployeeId == id).FirstOrDefault();
            try
            {
                if(employee != null)
                {
                    throw new NonUniqueEmployeeIdException("Employee id " + id + " already exists. Please enter another one");
                }
            } catch(NonUniqueEmployeeIdException e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            return true;
        }

        public override string ToString()
        {
            return "\n" + "Name: " + FirstName + " " + LastName + "\n" + "Employee ID: " + EmployeeId + "\n" + "Salary: " +  Salary.Amount + "\n";
        }
    }
}
