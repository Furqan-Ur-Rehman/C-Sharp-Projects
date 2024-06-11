using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_using_Switch_Case_in_C_Sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Calculator in C#
            Console.WriteLine("*************Calculator in C#****************");
            double Value1;
            double Value2;
            string Operator;

            Console.WriteLine("Enter Value1: ");
            Value1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Operator i.e. (+, -, *, / and %)");
            Operator = Console.ReadLine();
            Console.WriteLine("Enter Value2: ");
            Value2 = Convert.ToDouble(Console.ReadLine());

            switch (Operator)
            
            {
                case "+":
                    double addition = Value1 + Value2;
                    Console.WriteLine("The Sum of {0} + {1} = {2}",Value1,Value2,addition);
                    break;

                case "-":
                    double substraction = Value1 - Value2;
                    Console.WriteLine("The Substraction of {0} - {1} = {2}", Value1, Value2,substraction);
                    break;

                case "*":
                    double multiplication= Value1 * Value2;
                    Console.WriteLine("The Multiplication of {0} * {1} = {2}", Value1, Value2,multiplication);
                    break;
                case "/":
                    double division = Value1 / Value2;
                    Console.WriteLine("The Division of {0} / {1} = {2}", Value1, Value2, division);
                    break;
                case "%":
                    double remainder = Value1 % Value2;
                    Console.WriteLine("The Modulus of {0} % {1} = {2}", Value1, Value2, remainder);
                    break;
               default:
                    Console.WriteLine("You Entered Invalid Character.");
                    break;
            }
            Console.ReadLine();


        }
    }
}
