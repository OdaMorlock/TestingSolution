using System;
using Xunit;

namespace SharedCoreLibrary.Testss
{
    public class CalculatorTests
    {
        [Fact]
        public void Add_ShouldCalculateTwoDoubleValues()
        {

            //Arrange - Setup
            var calculator = new Calculator();
            double expected = 10;
             
            //Act - utför
            double actual = calculator.Add(2, 3);

            // Assert - jämnför
            Assert.Equal(expected, actual);

        }






        [Fact]
        public void Subtract_ShouldSubtractOneDoubleValueFromAnother()
        {

        }

        [Fact]
        public void AddEmployeeAsync_ShouldAddAnAsyncEmployeeToAListOfEmployees()
        {

        }

        [Fact]
        public void AddEmployee_ShouldAddAnEmployeeToAListOfEmployees()
        {

        }

        [Fact]
        public void RemoveEmployee_ShouldRemoveAnEmployeeToAListOfEmployees()
        {

        }
    }
}
