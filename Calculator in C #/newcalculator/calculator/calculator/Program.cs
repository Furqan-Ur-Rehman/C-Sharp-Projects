using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double value1, value2;
            string opt;
            //Calculator
            Console.WriteLine("Enter the value 1");
            value1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter any Operator i.e. (+ - x / %)");
            opt = Console.ReadLine();
            Console.WriteLine("Enter the value 2");
            value2 = Convert.ToDouble(Console.ReadLine());

            switch (opt)
            {
                case "+":
                    double add = value1 + value2;
                    Console.WriteLine("The Sum of {0} and {1} is = {2}" , value1 , value2, add);
                    break;
                case "-":
                    double subtract = value1 - value2;
                    Console.WriteLine("The Substraction of {0} and {1} is = {2}", value1, value2, subtract);
                    break;
                case "*":
                    double mul = value1 * value2;
                    Console.WriteLine("The Multiplication of {0} and {1} is = {2}", value1, value2, mul);
                    break;
                case "/":
                    double div = value1 / value2;
                    Console.WriteLine("The Division of " + value1 + " and " + value2 + " is = " + div);
                    break;
                case "%":
                    double modulus = value1 % value2;
                    Console.WriteLine("The Modulus of {0} and {1} is = {2}", value1, value2, modulus);
                    break;
                default:
                    Console.WriteLine("You Enter only Valid Operator as shown above.");
                    break;

            }
            Console.ReadLine();
        }
    }
}
