using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeRegister
{
    internal class Validator
    {
        public bool ValidateName(string name)
        {
            return NameConsistsOfOnlyLetters(name) && NameNotIsEmpty(name);
        }

        private bool NameConsistsOfOnlyLetters(string name) 
        {
            try
            {
                foreach (char c in name)
                {
                    if (!char.IsLetter(c))
                    {
                        throw new NonAllowedInputException("\nName has to only contain letters.");
                    }
                }
            }
            catch (NonAllowedInputException e)
            {
                Console.WriteLine(e.Message);
                return false;
            }

            return true;
        }

        private bool NameNotIsEmpty(string name) 
        {
            return name.Length != 0;
        }

        public bool ValidateNumber(string num)
        {
            return IsANumber(num);
        }
        private bool IsANumber(string num) 
        {
            try
            {
                if (!int.TryParse(num, out int result))
                {
                    throw new NonAllowedInputException("\nID has to consist of only numbers.");
                }
            }
            catch (NonAllowedInputException e)
            {
                Console.WriteLine(e.Message);
                return false;
            }

            return true;
        }
    }
}
