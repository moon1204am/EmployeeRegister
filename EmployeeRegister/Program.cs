namespace EmployeeRegister
{
    internal class Program
    {
        static void Main(string[] args)
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
                        Console.WriteLine("Enter employee first name");
                        string fName = Console.ReadLine();

                        Console.WriteLine("Enter employee last name");
                        string lName = Console.ReadLine();

                        Console.WriteLine("Enter employee id. Needs to be unique");
                        int id = int.Parse(Console.ReadLine());
                        bool isUnique = Employee.checkUniqueId(id);
                        while(!isUnique)
                        {
                            id = int.Parse(Console.ReadLine());
                            isUnique = Employee.checkUniqueId(id);
                        }

                        Console.WriteLine("Enter employee salary");
                        double s = double.Parse(Console.ReadLine());
                        Salary salary = new Salary(s);

                        Employee emp = new Employee(fName, lName, id, salary);
                        emp.AddEmployee(emp);
                        Console.WriteLine("Added new employee " + emp.FirstName + " " + emp.LastName);
                        break;
                    case "list":
                        IList<Employee> emps = Employee.GetEmployees();
                        for(int i = 0; i < emps.Count; i++)
                        {
                            Console.WriteLine(emps[i].ToString());
                        }
                        break;
                    case "get":
                        Console.WriteLine("Enter employee id");
                        int empId = int.Parse(Console.ReadLine());
                        Employee foundEmployee = new Employee();
                        foundEmployee = foundEmployee.GetEmployee(empId);
                        Console.WriteLine(foundEmployee.ToString());
                        break;
                    default:
                        Console.WriteLine("Not a command. Try again.");
                        break;
                }
            }
            while (command != "exit");

        }
    }
}