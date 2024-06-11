using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_Case_of_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Make Calculator using with Switch Case Statement in C#
            Console.WriteLine("******CALCULATOR*************");
            Console.WriteLine();
            int FirstValue;
            int SecondValue;
            string Operator;

            
            Console.WriteLine("Enter First Value: ");
            FirstValue = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Operator: ");
            Operator = Console.ReadLine();

            Console.WriteLine("Enter Second Value: ");
            SecondValue = Convert.ToInt32(Console.ReadLine());

            switch (Operator)
            {
                case "+":
                    int result = FirstValue + SecondValue;
                    Console.WriteLine("The Sum of {0} + {1} = {2}",FirstValue,SecondValue,result);
                    break;

                case "-":
                    int result1 = FirstValue - SecondValue;
                    Console.WriteLine("The Substrction of {0} - {1} = {2}", FirstValue, SecondValue,result1);
                    break;

                case "*":
                    int result2 = FirstValue * SecondValue;
                    Console.WriteLine("The Multiplication of {0} * {1} = {2}", FirstValue, SecondValue, result2);
                    break;

                case "/":
                    int result3 = FirstValue / SecondValue;
                    Console.WriteLine("The Division of {0} / {1} = {2}", FirstValue, SecondValue, result3);
                    break;

                case "%":
                    int result4 = FirstValue % SecondValue;
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
