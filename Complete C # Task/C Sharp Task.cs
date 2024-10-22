﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // C # Task
            // 1) Area of Circle Formula(A = Pi * radius * radius)
            Console.WriteLine("***********Area of Circle**********");
            Console.WriteLine("Enter the Value of Radius:");
            double radius;
            radius = Convert.ToDouble(Console.ReadLine());
            double Area = Math.PI * radius * radius;
            Console.WriteLine("The Area of Circle is: " + Area);
            Console.WriteLine();
            
            
            //2) Area of Rectangle Formula( Area = Length * Width)
            
            Console.WriteLine("**********Area of Rectangle*********");
            int Length;
            int Width;
            Console.WriteLine("Enter the Value of Length: ");
            Length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Value of Width: ");
            Width = Convert.ToInt32(Console.ReadLine());
            int area = Length * Width;
            Console.WriteLine("The Area of Rectangle is {0} * {1} = {2}", Length, Width, area);
            Console.WriteLine();




            //3)Area of Square Formula(Area = a * a)
            Console.WriteLine("*********Area of Square**********");
            Console.WriteLine();
            int a;
            Console.WriteLine("Enter the Value of a: ");
            a = Convert.ToInt32(Console.ReadLine());
            double A = a * a;
            Console.WriteLine("The Area of Square is: {0}", A);
            Console.WriteLine();    

            //4) Swaping Two Values
            Console.WriteLine("*******Swap Values*******");
            Console.WriteLine(); //Line Break
            int num1;
            int num2;
            int temp;
            Console.WriteLine("Enter the Value of num1: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Value of num2: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine("The Value of num1 is: {0}", num1);
            Console.WriteLine("The Value of num2 is: {0}", num2);
            Console.WriteLine();




            //5) Perform All Arithmetic Operations (+ - * / %)
            Console.WriteLine("********All Arithmetic Operators(+ - * / %)");
            Console.WriteLine();
            int c;
            int d;
            Console.WriteLine("Enter the Value of c: ");
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Value f d: ");
            d = Convert.ToInt32(Console.ReadLine());
            int e = c + d;
            int f = c - d;
            int g = c * d;
            float h = c / d;
            float i = c % d;
            Console.WriteLine("Addition of {0} + {1} = {2}", c, d, e);
            Console.WriteLine("Substraction of {0} - {1} = {2}", c, d, f);
            Console.WriteLine("Multiplication of {0} * {1} = {2}", c, d, g);
            Console.WriteLine("Division of {0} / {1} = {2}", c, d, h);
            Console.WriteLine("Modulus of {0} % {1} = {2}", c, d, i);
            Console.WriteLine();




            //6) Multiply two Floating Point Numbers:
            Console.WriteLine("*******Multiply Two Floating Point Numbers: ");
            Console.WriteLine();
            float number1 =10.5f;
            float number2 = 10.30f;
            float result = number1 * number2;
            Console.WriteLine("The Multiply Two Floating Point Numbers are:{0} * {1} = {2}", number1, number2, result);
            Console.Read();

        }
    }
}
