using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JunkYard
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, Employee> employees = new Dictionary<int, Employee>();

            Employee employeeA = new Employee("Ted J", "SD");
            Employee employeeB = new Employee("James J", "WD");
            Employee employeeC = new Employee("Greg J", "WD");

            employees.Add(1, employeeA);
            employees.Add(2, employeeB);
            employees.Add(3, employeeC);

            //loop threw the whole Dictionary<TKey,TValue>
            //foreach (var employee in employees)
            //{
            //    Console.WriteLine(employee.Value.Name);
            //}

            //loop threw the dictionary via values
            //foreach (var employee in employees.Values)
            //{
            //    if (employee.Name =="Greg J")
            //    {
            //        Console.WriteLine(employee.Department);
            //    }
            //}

            //loop threw dictionary and just checking the key to retrive the TValue
            foreach (var employee in employees)
            {
                
                    if (employee.Key ==2)
                    {
                        Console.WriteLine($"{employee.Value.Name}\n" +
                                          $"{employee.Value.Department}");
                    }
                
            }

            Console.ReadKey();
        }
    }
}
