using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Using Integer Datatype
            int num = 15;
            int myNum = 20;
            Console.WriteLine(myNum);
            //Using Two String Concatenate
            string firstName = "John";
            string lastName = "David";
            string fullName = firstName + " " + lastName;
            Console.WriteLine(fullName);
            //Integer Addition
            int x = 5, y = 6, z = 20;
            Console.WriteLine(x + y + z);
            

            //Implicit Casting
            int myInt1 = 9;
            double myDouble1 = myInt1;
            Console.WriteLine(myInt1);
            Console.WriteLine(myDouble1);

            //Explicit Casting
            double myDouble = 9.78;
            int myInt = (int) myDouble;
            Console.WriteLine(myDouble);
            Console.WriteLine(myInt);

            //Input from User
            string FirstName;
            Console.Write("Enter your Name: ");
            FirstName = Console.ReadLine();
            Console.WriteLine("Print Name: " + FirstName);
            Console.Read();

        }
    }
}
