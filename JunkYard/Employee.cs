using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JunkYard
{
    public class Employee
    {
        public string Name { get; set; }
        public string Department { get; set; }

        public Employee(string name , string department)
        {
            Name = name;
            Department = department;
        }
    }
}
