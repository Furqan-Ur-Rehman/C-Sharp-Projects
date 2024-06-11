using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace functions
{
    internal class Program
    {
        public void Show() // Non-Static Function Defination or Non-Parameterized Function
        {
            Console.WriteLine("Welcome to C# Programming!");
        }

        public static void Show1()
        {
            Console.WriteLine("Welcome to C# Programming Language!");
        }

        public static void Add(int num1, int num2) // Parameterized Static Function
        {
            // Here result is a local variable which scope is inside this function only.
            int result = num1 + num2;
            Console.WriteLine("Addition of {0} + {1} = {2}" , num1, num2, result);
        }

        public static void Show_name(string name="Unknown Name") // Default Parameterized method
        {
            Console.WriteLine("Welcome to " + name + " in C# Prgramming Language!");
        }
        public static void Show_name_age(string name = "Unknown Name", int age=30) // Default Parameterized method
        {
            Console.Write("Your Name is: " + name);
            Console.WriteLine(" and Your Age is: " + age);
        }

        public static int Addition(int num1, int num2) // Parameterized Static Function
                                                        // with return keyword.
        {
            // Here result is a local variable which scope is inside this function only.
            int result = num1 + num2;
            return result;
        }
        static void Main(string[] args)
        {
            Program obj1 = new Program();
            obj1.Show(); // Calling a Non-Static Function through object
            Console.WriteLine();

            Program.Show1(); // Static Function Always calls with Class name.

            Console.WriteLine();

            Program.Add(35, 65); // Calling Parameterized Static Function or Method
            Program.Add(30, 70); // Inside the bracket is "Arguments i.e. 30, 70"
            Program.Add(20, 30);

            Console.WriteLine();
            Console.WriteLine("Enter the Value of num1: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Value of num2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Program.Add(num1, num2);

            Console.WriteLine();
            Program.Show_name("Furqan");

            Console.WriteLine();
            Program.Show_name_age(age: 31, name: "Furqan-ur-Rehman"); // Named Arguments

            Console.WriteLine();
            int a =  Program.Addition(20, 60);
            int b = 20;
            int c = a + b;
            Console.WriteLine("Your Function with Return Type is: " + c);
            Console.ReadLine();
        }
    }
}
