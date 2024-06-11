using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace relational_comparision_operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=============Relational or Comparision Operators in C# ================");
            int a = 30;
            int b = 20;
            bool c = a == b;
            Console.WriteLine("The value of 'a' {0} is equal to the value of 'b' {1} = {2}" , a, b, c);

            Console.WriteLine();

            bool d = a != b;
            Console.WriteLine("The value of 'a' {0} is not equal to the value of 'b' {1} = {2}", a, b, d);

            bool e = a > b;
            Console.WriteLine("The value of 'a' {0} is greator than the value of 'b' {1} = {2}", a, b, e);

            Console.WriteLine();

            bool f = a < b;
            Console.WriteLine("The value of 'a' {0} is Less than the value of 'b' {1} = {2}", a, b, f);

            Console.WriteLine();

            bool g = a >= b;
            Console.WriteLine("The value of 'a' {0} is Greator than or equal to the value of 'b' {1} = {2}", a, b, g);
            Console.ReadLine();
        }
    }
}
