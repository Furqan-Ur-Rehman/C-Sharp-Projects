using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Type_Casting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Using Integer Datatype
            int num = 15;
            int mynum = 20;
            Console.WriteLine(num);
            Console.WriteLine(mynum);


            //Using Two String Concatenate
            string FirstName = "John";
            string LastName = "Ibrahim";
            string FullName = FirstName + " " + LastName;
            Console.WriteLine(FullName);
            

            //Integer Addition
            int x = 5, y = 10, z = 20;
            Console.WriteLine(x + y + z);

            //Implicit Casting Converting Smaller into larger data types.
            int myInt = 9;
            double myDouble = myInt;
            Console.WriteLine(myInt);
            Console.WriteLine(myDouble);


            int Myint = 10;
            double Mydouble = Myint;
            Console.WriteLine(Myint);
            Console.WriteLine(Mydouble);


            //Explicit Casting Converting Larger into Smaller data types.
            double mydouble = 9.23;
            int INT = (int)mydouble;
            Console.WriteLine(INT);


            //Input from User
            Console.WriteLine("Enter your Name: ");
            string Name;
            Name = Console.ReadLine();
            Console.WriteLine("Hello! " + Name);
            Console.Read();
        }
    }
}
