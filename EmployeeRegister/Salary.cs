using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeRegister
{
    internal class Salary
    {
        public double Amount { get; set; }
        public double TaxRate { get; set; } = 0.30;

        public Salary(double amount)
        {
            Amount = amount;
        }

        public double CalculateSalary(double amount, double tax)
        {
            double salaryAmountAfterTax = amount - (amount * tax);

            return salaryAmountAfterTax;
        } 
    }
}
