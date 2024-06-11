using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Key_word_with_New_Key_Word
{
    public class Employees
    {
        public int empId = 1;
        public string empName = "Amir Abbas";
        public int age = 33;
        

        public void Display()
        {
            Console.WriteLine("Employee ID: " + empId);
            Console.WriteLine("Employee Name: " + empName);
        }
    }
    internal class Department : Employees
    {
        int DepID = 222;
        string depName = "Sales";

        new void Display()
        {
            base.Display();
            Console.WriteLine("Department ID: " + DepID);
            Console.WriteLine("Department Name: " + depName);
        }

        static void Main(string[] args)
        {
            Department dep = new Department();
            dep.Display();

            Console.Read();
        }
    }
}
