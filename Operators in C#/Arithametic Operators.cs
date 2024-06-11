using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arithametic_Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****Arithametic_Operators ****");
            double num1;
            double num2;
            double result;
            Console.WriteLine("Enter num1: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter num2: ");
            num2 = Convert.ToDouble(Console.ReadLine());
            result = num1 + num2;
            Console.WriteLine("Sum of: {0} + {1} = {2}", num1, num2, result);

            result = num1 - num2;
            Console.WriteLine("Substraction of: " + num1 + " - " + num2 + " = " + result);

            result = num1 * num2;
            Console.WriteLine("Multiplication of: {0} * {1} = {2}", num1, num2, result);
            Console.WriteLine("Multiplication of: " + num1 + " * " + num2 + " = " + result);
            
            result = num1 / num2;
            Console.WriteLine("Division of: {0} / {1} = {2}", num1, num2, result);

            result = num1 % num2;
            Console.WriteLine("Modulus of: " + num1 + " % " + num2 + " = " + result);
            Console.Read();        
        }
    }
}
