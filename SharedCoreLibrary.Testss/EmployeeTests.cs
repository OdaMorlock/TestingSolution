using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace SharedCoreLibrary.Testss
{
    public class EmployeeTests
    {
        private List<Employee> _employees { get; set; }
        public EmployeeTests()
        {
            _employees = new List<Employee>();
        }

        [Theory]
        [InlineData("Marcus","Bäckström")]
        [InlineData("Bästa", "Marcus")]
        public void AddEmployee_ShouldAddAnEmployeeToAListOfEmployees(string firstname, string lastname)
        {
            var employee = new Employee(firstname, lastname);
            _employees.Add(employee);

            Assert.Contains(employee, _employees);

            
        }

        [Fact]
        public void FullName_ShouldReturnTheFullNameOfTheEmployee()
        {
            Employee employee = new Employee() { FirstName = "Marcus", LastName = "Bäckström" };
            

            Assert.Equal("Marcus Bäckström", employee.FullName);
        }

       

        [Fact]
        public void Id_ShouldReturnGuidId()
        {
            Guid _id = Guid.NewGuid();

            Employee employee = new Employee() { Id = _id };
            Assert.Equal(_id, employee.Id);
        }

    }
}
