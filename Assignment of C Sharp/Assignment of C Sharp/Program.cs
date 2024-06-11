using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_of_C_Sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Value of num1: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Value of num2: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Value of num3: ");
            double num3 = Convert.ToDouble(Console.ReadLine());

            if (num1 != num2 && num1 != num3 && num2 != num3)//10 20 30
            {
                double result = num1 + num2 + num3;
                Console.WriteLine("The Sum of not Same numbers are {0} + {1} + {2} = {3}", num1, num2, num3, result);
            }

            else if (num1 != num3 && num2 == num3)//10 20 20
            {
                double result = num1;
                Console.WriteLine("The not Same number is {0}", result);
            }
            else if (num1 != num2 && num1 == num3)//10 20 10

            {
                double result = num2;
                Console.WriteLine("The not Same number is {0}", result);
            }
            else if(num1 == num2 && num1 != num3)//10 10 20
            {
                double result = num3;
                Console.WriteLine("The not Same number is {0}", result);
            }
            else
            {
                Console.WriteLine("You Entered all numbers are Same, which are not calculated according to policy!");//10 10 10
            }
            

            Console.ReadLine();
        }
    }
}
