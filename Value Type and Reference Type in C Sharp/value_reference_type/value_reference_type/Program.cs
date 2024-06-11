using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace value_reference_type
{
    struct Employee // "struct" is a "value type" which is saved in "Stack Memory"
    {
        public int salary;
        public int age;
    }

    class Employee1 // "class" is a "reference type" which is saved in "Heap Memory"
    {
        public int salary;
        public int age;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create emp object
            Employee emp = new Employee();
            emp.salary = 250000;
            emp.age = 25;

            // Create another emp2 and emp3 object and its values is emp object.
            Employee emp2 = emp;
            Employee emp3 = emp;

            emp.age = 32;
            Console.WriteLine(" The Salary of emp object is: " + emp.salary);
            Console.WriteLine("The age of emp object is: " + emp.age);
            Console.WriteLine("The age of emp2 object is: " + emp2.age);
            Console.WriteLine("The age of emp3 object is: " + emp3.age);

            Employee1 emp1 = new Employee1();
            emp1.salary = 250000;
            emp1.age = 25;

            Console.WriteLine();

            // Create another emp12 and emp13 object and its values is emp1 object.
            Employee1 emp12 = emp1;
            Employee1 emp13 = emp1;

            emp.age = 32;
            Console.WriteLine(" The Salary of emp1 object is: " + emp1.salary);
            Console.WriteLine("The age of emp1 object is: " + emp1.age);
            Console.WriteLine("The age of emp12 object is: " + emp12.age);
            Console.WriteLine("The age of emp13 object is: " + emp13.age);

            Console.ReadLine();
        }
    }
}
