namespace EmployeeRegister.Tests
{
    public class SalaryTest
    {
        [Fact]
        public void CalculateNetSalary_Calculates_Amount()
        {
            // Arrange
            int amount = 10000;
            Salary salary = new Salary(amount);

            // Act
            double result = salary.CalculateNetSalary(salary.Amount);
            double expected = 7000;

            // Assert
            Assert.Equal(expected, result);
        }
    }
}