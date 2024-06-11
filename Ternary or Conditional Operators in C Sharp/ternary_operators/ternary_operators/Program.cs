using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ternary_operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 20;
            string b = (a > 10) ? "a is Greator!" : "a is lesser";
            Console.WriteLine(b); //Output : a is Greator!

            Console.WriteLine();

            int c = int.Parse(Console.ReadLine());
            string d = (c >= 18) ? "You are Eligible for vote!" : "You are under 18 so you are not eligilbe for vote!";
            Console.WriteLine(d); // Output: You are Eligible for vote!
            Console.ReadLine();
        }
    }
}
