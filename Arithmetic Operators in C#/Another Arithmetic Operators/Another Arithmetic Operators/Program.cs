﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Another_Arithmetic_Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********Arithmetic Operators*******");
           
            string repeat;
            do
            {
                double num1, num2, result;

                Console.WriteLine("Enter the Value of Num1");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the Value of Num2");
                num2 = Convert.ToDouble(Console.ReadLine());
                result = num1 + num2;
                Console.WriteLine("The Addition of {0} + {1} = {2} ", num1, num2, result);
                result = num1 - num2;
                Console.WriteLine("The Substraction of {0} - {1} = {2} ", num1, num2, result);
                result = num1 * num2;
                Console.WriteLine("The Multiplication of {0} * {1} = {2} ", num1, num2, result);
                result = num1 / num2;
                Console.WriteLine("The Division of {0} / {1} = {2} ", num1, num2, result);
                result = num1 % num2;
                Console.WriteLine("The Modulus of {0} % {1} = {2} ", num1, num2, result);
                Console.WriteLine("Do You Want to repeat Your Program Press Y otherwise N");
                repeat = Console.ReadLine();
            }
            while (repeat == "Y" || repeat == "y" || repeat == "yes" || repeat == "Yes" || repeat == "YES");
            Console.WriteLine("Thankyou!");
            Console.ReadLine();


            //while (true)
            //{
            //    string repeat;
            //    double num1;
            //    double num2, result;

            //    Console.WriteLine("Enter the Value of Num1");
            //    num1 = Convert.ToDouble(Console.ReadLine());
            //    Console.WriteLine("Enter the Value of Num2");
            //    num2 = Convert.ToDouble(Console.ReadLine());
            //    result = num1 + num2;
            //    Console.WriteLine("The Addition of {0} + {1} = {2} ", num1, num2, result);
            //    result = num1 - num2;
            //    Console.WriteLine("The Substraction of {0} - {1} = {2} ", num1, num2, result);
            //    result = num1 * num2;
            //    Console.WriteLine("The Multiplication of {0} * {1} = {2} ", num1, num2, result);
            //    result = num1 / num2;
            //    Console.WriteLine("The Division of {0} / {1} = {2} ", num1, num2, result);
            //    result = num1 % num2;
            //    Console.WriteLine("The Modulus of {0} % {1} = {2} ", num1, num2, result);
            //    Console.WriteLine("Do You Want to repeat Your Program Press Y otherwise N");
            //    repeat = Console.ReadLine();
            
            //    if(repeat == "Y" || repeat == "y")
            //    {
            //       continue;
            //    }
            //    else
            //    {
            //        break;
            //    }
            //}
            //Console.WriteLine("Thankyou!");
            //Console.ReadLine();
        }
    }
}
