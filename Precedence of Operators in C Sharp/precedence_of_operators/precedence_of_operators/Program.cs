using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace precedence_of_operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Precedence or Importance of Operators in C#");
            int a = 8 / 2 - 3 + 2 * 2;
            // Highest Precedence = () / * 
            // Lowest Precedence = - +
            
            // 8 / 2 - 3 + 2 * 2
            //   4 - 3 + 4
            //     1 + 4
            // Result is = 5
            Console.WriteLine("Result According to Precedence: " + a); // result is = 5

            int b = 8 / 2 - (3 + 2) * 2;
            // 8 / 2 - (3 + 2) * 2
            // 8 / 2 - 5 * 2
            // 4 - 10
            // Result is = -6
            Console.WriteLine("Result According to Precedence: " + b);
            Console.ReadLine();
        }
    }
}
