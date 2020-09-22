using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedUwPLibrary.Models
{
    public class Employee
    {

        public Guid Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Department { get; set; }

        public string FullName => $"{FirstName} {LastName}";


        public Employee()
        {
           // var employee = new Employee();
           // employee.FirstName = "Marcus"

            // var employee = new Employee() {}
        }

        public Employee(string firstname, string lastname)
        {
            Id = Guid.NewGuid();
            FirstName = firstname;
            LastName = lastname;

            // var employee = new Employee ("Marcus", "Bäckström");
        }

        public Employee(string firstname, string lastname, string department)
        {
            Id = Guid.NewGuid();
            firstname = FirstName;
            lastname = LastName;
            department = Department;

            // var employee = new Employee ("Marcus", "Bäckström", "DeparmentGod");
        }


    }
}
