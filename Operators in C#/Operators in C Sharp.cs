using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_in_C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1;
            double num2;
            double result;
            Console.WriteLine("************Arithametic Operations*************");
            Console.Write("Enter Num1: ");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Num2: ");
            num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("*******Result of Arithametic Operator");
            //Arithmatic Operation
            //Console.WriteLine("Sum of: " + num1 + "+" + num2 + "=" + result);
            result = num1 + num2;
            Console.WriteLine("Sum of: {0} + {1} = {2}", num1, num2, result);
            //Substraction Operations
            result = num1 - num2;
            Console.WriteLine("Sum of: {0} - {1} = {2}", num1, num2, result);
            //Multiple Operations
            result = num1 * num2;
            Console.WriteLine("Sum of: {0} * {1} = {2}", num1, num2, result);
            //Division Operations
            result = num1 / num2;
            Console.WriteLine("Sum of: {0} / {1} = {2}", num1, num2, result);
            //Modulus Operations
            result = num1 % num2;
            Console.WriteLine("Sum of: {0} % {1} = {2}", num1, num2, result);
            Console.Read();
        }
    }
}
