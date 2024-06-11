using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==============Simple & Compound Assignment Operators==================");
            int a = 10;
            a += 1; /*or   a = a + 1;     */
            Console.WriteLine("The Sum Compound Assignment Operator is: " + a);
            a -= 1; /*or   a = a - 1;     */
            Console.WriteLine("The Minus Compound Assignment Operator is: " + a);
            a *= 1; /*or   a = a * 1;     */
            Console.WriteLine("The Multiplication Compound Assignment Operator is: " + a);
            a /= 2; /*or   a = a / 2;     */
            Console.WriteLine("The Division Compound Assignment Operator is: " + a);
            a %= 5; /*or   a = a % 1;     */
            Console.WriteLine("The Modulus Compound Assignment Operator is: " + a);
            Console.ReadLine();
        }
    }
}
