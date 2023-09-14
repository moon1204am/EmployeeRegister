using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeRegister
{
    internal class Block
    {
        Register register;

        public Block() 
        {
            register = new Register();
        }
        public void ShowOptions()
        {
            string command;
            Console.WriteLine("Hi.");
            do
            {
                Console.WriteLine("Enter command.");
                Console.WriteLine("[new] for adding new employee");
                Console.WriteLine("[list] for listing all employees");
                Console.WriteLine("[get] for getting a specific employee");
                Console.WriteLine("[exit] for terminating program");
                command = Console.ReadLine();

                switch (command)
                {
                    case "new":
                        CreateNewEmployee();
                        break;
                    case "list":
                        ListAllEmployees();
                        break;
                    case "get":
                        GetEmployeeById();
                        break;
                    default:
                        Console.WriteLine("Not a command. Try again.");
                        break;
                }
            }
            while (command != "exit");
        }

        public void CreateNewEmployee()
        {
            Console.WriteLine("Enter employee first name:");
            string fName = Console.ReadLine();

            Console.WriteLine("Enter employee last name:");
            string lName = Console.ReadLine();

            Console.WriteLine("Enter employee id. Needs to be unique!");
            int id = int.Parse(Console.ReadLine());
            bool isUnique = Register.checkUniqueId(id);
            while (!isUnique)
            {
                id = int.Parse(Console.ReadLine());
                isUnique = Register.checkUniqueId(id);
            }

            Console.WriteLine("Enter employee salary:");
            double s = double.Parse(Console.ReadLine());

            Employee emp = new Employee(fName, lName, id, s);

            register.AddEmployee(emp);
            Console.WriteLine("Added new employee " + emp.FirstName + " " + emp.LastName + ".");
        }

        public void ListAllEmployees()
        {
            IList<Employee> emps = Register.GetEmployees();
            for (int i = 0; i < emps.Count; i++)
            {
                Console.WriteLine(emps[i].ToString());
            }
        }

        public void GetEmployeeById()
        {
            Console.WriteLine("Enter employee id:");
            int empId = int.Parse(Console.ReadLine());
            Employee foundEmployee = register.GetEmployee(empId);
            Console.WriteLine(foundEmployee.ToString());
        }
    }
}
