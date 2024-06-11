using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arithmetic_operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=====================Arithmetic Operator in C# =============================");
            int a = 10, b = 5, c, d,f,g, h;
            c = a + b;
            d = a - b;
            f = a * b;
            g = a / b;
            h = a % b;

            Console.WriteLine("The sum of a and b is = " + c);
            Console.WriteLine("The subtraction of a and b is = " + d);
            Console.WriteLine("The Multiplication of a and b is = " + f);
            Console.WriteLine("The Division of a and b is = " + g);
            Console.WriteLine("The Remainder or Modulus of a and b is = " + h);
            Console.ReadLine();
        }
    }
}
