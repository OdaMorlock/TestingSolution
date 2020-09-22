
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SharedUwPLibrary.Models;

namespace ShareUWPLibrary.Tests
{
    [TestClass]
    public class EmployeeTests
    {
        [TestMethod]
        public void FullName_ShouldReturnTheFullNameOfTheEmployee()
        {
            Employee employee = new Employee() { FirstName = "Marcus", LastName = "Bäckström" };

            Assert.AreEqual("Marcus Bäckström", employee.FullName);
        }
        
    }
}
