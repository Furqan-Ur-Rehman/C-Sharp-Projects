using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==========Switch Case in C# =======================");
            Console.WriteLine("Calculator using Switch Case in C#");
            start:
            Console.WriteLine("Enter the Value of num1:");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter any Operator i.e.(+ - * / %) for Calculation:");
            char opt = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Enter the Value of num2:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            switch (opt)
            {
                case '+':
                    double result_add = num1 + num2;
                    Console.WriteLine("The Sum of {0} + {1} = {2}" , num1, num2, result_add);
                    break;
                case '-':
                    double result_minus = num1 - num2;
                    Console.WriteLine("The Subtraction of {0} - {1} = {2}" , num1, num2, result_minus);
                    break;
                case '*':
                    double result_mul = num1 * num2;
                    Console.WriteLine("The Multiplication of {0} x {1} = {2}", num1, num2, result_mul);
                    break;
                case '/':
                    double result_div = num1 / num2;
                    Console.WriteLine("The Division of {0} / {1} = {2}", num1, num2, result_div);
                    break;
                case '%':
                    double result_modulus = num1 % num2;
                    Console.WriteLine("The Modulus of {0} % {1} = {2}", num1, num2, result_modulus);
                    break;

                default:
                    Console.WriteLine("Please Enter valid Operator i.e.(+ - * / %) only.");
                    break;

            }
            Console.WriteLine("Are you Continue Your Program then Press [Y/N]");
            string repeat = Console.ReadLine();
            if(repeat == "y" || repeat == "Y" || repeat == "Yes" || repeat == "YES" || repeat == "yes")
            {
                goto start;
            }
            Console.ReadLine();
        }
    }
}
