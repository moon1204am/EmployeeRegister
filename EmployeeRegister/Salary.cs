using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeRegister
{
    public class Salary
    {
        public double Amount { get; set; }
        public double TaxRate { get; set; } = 0.30;

        public Salary(double amount)
        {
            Amount = amount;
        }

        public double CalculateNetSalary(double amount)
        {
            double salaryAmountAfterTax = amount - (amount * TaxRate);

            return salaryAmountAfterTax;
        } 
    }
}
