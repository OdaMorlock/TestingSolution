using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedUwPLibrary.Models
{
    public class Employees : ObservableCollection<Employee>
    {
        public Employees()
        {
            Add(new Employee("Marcus", "Bäckström", "God"));
            Add(new Employee("Röd", "Vitt", "SL"));
        }
    }
}
