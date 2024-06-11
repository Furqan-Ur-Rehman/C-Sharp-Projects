using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pass_by_value_and_reference
{
    internal class Program
    {
        public static void PassbyValue(int a)
        {
            a += 10; // a = a + 10;
            Console.WriteLine("The Value inside the function PassbyValue is {0} ", a); // Output is 15
        }

        public static void PassbyReference(ref int a)
        {
            a += 10; // a = a + 10;
            Console.WriteLine("The Value inside the function PassbyReference is {0} ", a); // Output is 15
        }

        public static void PassbyOut(out int a)
        {
            a = 30; // a = 30;
            Console.WriteLine("The Value inside the function PassbyOut is {0} ", a); // Output is 30
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Pass by Value in C#");

            int value = 5;
            Program.PassbyValue(value); // Output is 15
            Console.WriteLine("The Value only valriable is: " + value);  // Output is: 5
            Console.WriteLine();

            Console.WriteLine("Pass by Reference in C#");

            int value1 = 5;
            Program.PassbyReference(ref value1); // Output is 15
            Console.WriteLine("The Value1 only valriable is: " + value1);  // Output is: 15
            Console.WriteLine();

            Console.WriteLine("Pass by Out in C#");
            int value2;
            Program.PassbyOut(out value2); // Output is 30
            Console.WriteLine("The Value2 only valriable is: " + value2);  // Output is: 30
            Console.ReadLine();
        }
    }
}
