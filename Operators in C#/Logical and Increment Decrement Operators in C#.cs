using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;
            bool result;
            Console.WriteLine("Enter Value a: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Value b: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Value c: ");
            c = Convert.ToInt32(Console.ReadLine());

            //AND Logical Operator
            result = (a == b) && (c > b);
            Console.WriteLine("({0} == {1}) && ({2} > {1}) returns {3}", a, b, c, result);


            //OR Logical Operator
            result = (a == b) || (c < b);
            Console.WriteLine("({0} == {1}) || ({2} < {1}) returns {3}", a, b, c, result);


            //Not Logical Operator
            result = !(a != b);
            Console.WriteLine("!({0} != {1}) returns {2}", a, b, result);



            //Increment / Decrement OPerator
            int A = 4;
            int B = 3;
            int C;
            C = ++a + b++ - a + --b;
            Console.WriteLine("Value of a is: " + A);
            Console.WriteLine("Value of a is: " + B);
            Console.WriteLine("Value of a is: " + c);
            Console.Read();



        }
    }
}
