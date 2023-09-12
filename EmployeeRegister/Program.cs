namespace EmployeeRegister
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Employee employee = new Employee();
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
                        bool isUnique = employee.checkUniqueId(id);
                        while(!isUnique)
                        {
                            id = int.Parse(Console.ReadLine());
                            isUnique = employee.checkUniqueId(id);
                        }

                        Console.WriteLine("Enter employee salary");
                        double s = double.Parse(Console.ReadLine());
                        Salary salary = new Salary(s);

                        Employee emp = new Employee(fName, lName, id, salary);
                        emp.AddEmployee(emp);
                        Console.WriteLine("Added new Employee");
                        break;
                    case "list":
                        IList<Employee> emps = employee.GetEmployees();
                        for(int i = 0; i < emps.Count; i++)
                        {
                            Console.WriteLine(emps[i].ToString());
                        }
                        break;
                    case "get":
                        Console.WriteLine("Enter employee id");
                        int empId = int.Parse(Console.ReadLine());
                        Employee foundEmployee = employee.GetEmployee(empId);
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