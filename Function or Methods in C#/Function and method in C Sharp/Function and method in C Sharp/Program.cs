using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function_and_method_in_C_Sharp
{
    internal class Program
    {
        //Method in C #

        //1
        public void show()// non static/ instance method
        {
            Console.WriteLine("This is a non static/instance method in C #");
        }

        //2
        public static void show1()//Static method
        {
            Console.WriteLine("This is a static method in C # ");
        }

        //3 
        public static void add(int num1, int num2)//formal parameters
        {
            int result = num1 + num2;
            Console.WriteLine("Addition of two numbers are {0} + {1} = {2} " , num1, num2, result);
        }

        //4 
        public void showname(string name="MFurqan")//Optional Parameters
        {
            Console.WriteLine("Your name is: " + name);
        }
        //5
        void show_name_age(string name, int age)//non static parameterized method
        {
            Console.WriteLine("Your name is: " + name);
            Console.WriteLine("Your age is: " + age);
        }

        //6
        int ADD(int num1, int num2)
        {
            int result = num1 + num2;
            return result;
        }


        static void Main(string[] args)
        {
            //1) create object for non static/instance method
            Program method = new Program();

            //calling function or method for non static/instance method
            method.show();
            method.show();
            method.show();
            method.show();

            Console.WriteLine();

            //Calling function or method for non static/ instance method
            method.showname();
            Program.show1();

            Console.WriteLine();

            //2) calling a function with parameters for static method
            //without creating object.
            Console.WriteLine("Enter num1: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter num2: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Program.add(a, b);//actual arguments/parameters

            
            Console.WriteLine();
            Program.add(10, 20); //actual arguments/parameters
            Program.add(40, 50); // actual arguments/parameters

            //5
            method.show_name_age("Furqan", 30);
            //method.show_name_age(30, "Furqan"); Error in code due to
            // positing string to int
            method.show_name_age(age: 30, name: "Furqan");//name arguments

            Console.WriteLine();

            //6 return type 
            Console.WriteLine(method.ADD(20, 30));

            //or
            Console.WriteLine();

            int A = method.ADD(20, 30);

            int B = 10;

            int C = A + B;
            Console.WriteLine("Value of C is: " + C);

            Console.Read();
        }
    }
}
