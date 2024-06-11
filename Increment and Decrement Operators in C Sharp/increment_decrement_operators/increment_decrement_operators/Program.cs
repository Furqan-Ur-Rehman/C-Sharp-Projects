using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace increment_decrement_operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=============Increment and Decrement Operators in C# ===============");
            int a = 5;
            Console.WriteLine(a++); // 5
            Console.WriteLine("Post Increment: " + a); // 6
            Console.WriteLine("Pre Increment: " + ++a); // 7
            Console.WriteLine("Post Decrement: " + a--); // 7
            Console.WriteLine("Pre Decrement: " + --a); // 5
            Console.ReadLine();
        }
    }
}
