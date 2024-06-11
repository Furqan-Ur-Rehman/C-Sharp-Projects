using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial_Series_in_C_Sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*************Factorial Number****************");
            int Factorial = 1;
            Console.WriteLine("Enter Any Number for finding Factorial of given Num: ");
            int num = Convert.ToInt32(Console.ReadLine());

            for(int i=1; i<=num; i++)
            {                               // Find Factorial of 5?
                Factorial = Factorial * i; //  (1) 1 * 1 = 1   (2) 1 * 2 = 2    (3) 2 * 3 = 6 
            }     // (4) 6 * 4 = 24      (5)  24 * 5 = 120
            Console.WriteLine("Factorial of given number {0} is: {1}",num, Factorial);

            Console.ReadLine();
        }
    }
}
