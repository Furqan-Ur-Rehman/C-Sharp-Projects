using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_in_C_sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Make Calculator using with Switch Case Statement in C#
            Console.WriteLine("******CALCULATOR*************");
            Console.WriteLine();
            double FirstValue;
            double SecondValue;
            string Operator;


            Console.WriteLine("Enter First Value: ");
            FirstValue = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter Operator: ");
            Operator = Console.ReadLine();

            Console.WriteLine("Enter Second Value: ");
            SecondValue = Convert.ToDouble(Console.ReadLine());

            switch (Operator)
            {
                case "+":
                    double result = FirstValue + SecondValue;
                    Console.WriteLine("The Sum of {0} + {1} = {2}", FirstValue, SecondValue, result);
                    break;

                case "-":
                    double result1 = FirstValue - SecondValue;
                    Console.WriteLine("The Substrction of {0} - {1} = {2}", FirstValue, SecondValue, result1);
                    break;

                case "*":
                    double result2 = FirstValue * SecondValue;
                    Console.WriteLine("The Multiplication of {0} * {1} = {2}", FirstValue, SecondValue, result2);
                    break;

                case "/":
                    double result3 = FirstValue / SecondValue;
                    Console.WriteLine("The Division of {0} / {1} = {2}", FirstValue, SecondValue, result3);
                    break;

                case "%":
                    double result4 = FirstValue % SecondValue;
                    Console.WriteLine("The Modulus of {0} % {1} = {2}", FirstValue, SecondValue, result4);
                    break;

                default:
                    Console.WriteLine("You Entered in valid Operator!");
                    break;
            }
            Console.ReadLine();
        }
    }
}
