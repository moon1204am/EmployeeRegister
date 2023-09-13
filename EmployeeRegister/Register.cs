using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeRegister
{
    internal class Register
    {
        static IList<Employee> employeeRegister = new List<Employee>();

        public static IList<Employee> GetEmployees()
        {
            try
            {
                if (employeeRegister.Count == 0)
                {
                    throw new EmployeeListEmptyException("Could not fetch employees. No employees registered.");
                }

            }
            catch (EmployeeListEmptyException e)
            {
                Console.WriteLine(e.Message);
            }
            return employeeRegister;
        }

        public Employee GetEmployee(int employeeId)
        {
            var employee = employeeRegister.Where(e => e.EmployeeId == employeeId).FirstOrDefault();
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
            employeeRegister.Add(emp);
        }

        public static bool checkUniqueId(int id)
        {
            var employee = employeeRegister.Where(e => e.EmployeeId == id).FirstOrDefault();
            try
            {
                if (employee != null)
                {
                    throw new NonUniqueEmployeeIdException("Employee id " + id + " already exists. Please enter another one");
                }
            }
            catch (NonUniqueEmployeeIdException e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            return true;
        }
    }
}
