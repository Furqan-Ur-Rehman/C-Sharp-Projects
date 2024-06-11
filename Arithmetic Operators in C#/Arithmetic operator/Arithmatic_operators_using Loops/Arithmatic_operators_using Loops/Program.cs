using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arithmatic_operators_using_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*******Arithmetic Operators**********");
            double num1, num2, result;
            string repeat;
            start:
            Console.WriteLine("Enter the value of num1.");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the value of num2.");
            num2 = Convert.ToDouble(Console.ReadLine());
            result = num1 + num2;
            Console.WriteLine("The Addition of {0} + {1} = {2}", num1, num2, result);
            result = num1 - num2;
            Console.WriteLine("The Subtraction of {0} - {1} = {2}", num1, num2, result);
            result = num1 * num2;
            Console.WriteLine("The Multiplication of {0} X {1} = {2}", num1, num2, result);
            result = num1 / num2;
            Console.WriteLine("The Division of {0} / {1} = {2}", num1, num2, result);
            result = num1 % num2;
            Console.WriteLine("The Modulus of {0} X {1} = {2}", num1, num2, result);
            
            Console.WriteLine("Are you sure you want to Continue Press [Y/N]");
            repeat = Console.ReadLine();
            if(repeat == "Y" || repeat == "y" || repeat == "Yes" || repeat == "YES" || repeat == "yes")
            {
                goto start;
            }
            else
            {
                Console.WriteLine("Thank You!..");
                
            }
            Console.ReadLine();
        }
    }
}
