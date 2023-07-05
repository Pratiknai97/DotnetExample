using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceWithConstructure
{
    internal class Employee
    {
        public int ID {  get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }

        public Employee(int id, string name, int salary)
        {
            Console.WriteLine("print constructure");
            ID = id;
            Name = name;
            Salary = salary;
        }
    }
}
