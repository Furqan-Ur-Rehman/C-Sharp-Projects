using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_in_C_sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1) Write a Program to perform  all Arithmatic Operators
            //Console.WriteLine("******All Arithmatic Operators*******");
            //int num1;
            //int num2;
            //int result;
            //Console.WriteLine("Enter the Value of Num1: ");
            //num1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter the Value of Num2: ");
            //num2 = Convert.ToInt32(Console.ReadLine()); 

            //result = num1 + num2;
            //Console.WriteLine("The Sum of {0} + {1} = {2}",num1,num2,result);
            
            //result = num1 - num2;
            //Console.WriteLine("The Substraction of {0} - {1} = {2}", num1, num2, result);

            //result = num1 * num2;
            //Console.WriteLine("The Multiplication of {0} * {1} = {2}", num1, num2, result);

            //result = num1 / num2;
            //Console.WriteLine("The Division of {0} / {1} = {2}", num1, num2, result);

            //result = num1 % num2;
            //Console.WriteLine("The Modulus of {0} % {1} = {2}", num1, num2, result);
            //Console.WriteLine();
            //Console.WriteLine();

            ////All Arithmatic Operators without Using user's input

            //Console.WriteLine("All Arithmatic Operators without Using user's input");
            //int Number1 = 20;
            //int Number2 = 30;
            //int Result;

            //Result = Number1 + Number2;
            //Console.WriteLine("The Sum of Two numbers are: " + Result);

            //Result = Number1 - Number2;
            //Console.WriteLine("The Substraction of Two numbers are: " + Result);

            //Result = Number1 * Number2;
            //Console.WriteLine("The Multiplication of Two numbers are: " + Result);

            //Result = Number1 / Number2;
            //Console.WriteLine("The Division of Two numbers are: " + Result);

            //Result = Number1 % Number2;
            //Console.WriteLine("The Modulus of Two numbers are: " + Result);
            //Console.WriteLine();


            //2) Swaping Values
            //Console.WriteLine("*********Swaping Two Values*********");
            //int Value1;
            //int Value2;
            //int temp;
            //Console.WriteLine("Enter the Value1: ");
            //Value1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter the Value2: ");
            //Value2 =Convert.ToInt32(Console.ReadLine());

            //temp = Value1;
            //Value1 = Value2;
            //Value2 = temp;

            //Console.WriteLine("The Value of Value1 is {0}", Value1);
            //Console.WriteLine("The Value of Value2 is {0}", Value2);
            //Console.WriteLine();


            //3) Multiply Two Floating Points numbers
            //Console.WriteLine("******Multiply Two Floating values********");
            //float Value3;
            //float value4;
            //Console.WriteLine("Enter the First Float Value: ");
            //Value3 = Convert.ToSingle(Console.ReadLine());

            //Console.WriteLine("Enter the Second Float Value: ");
            //value4 = Convert.ToSingle(Console.ReadLine());

            //float Result = Value3 * value4;
            //Console.WriteLine("Multiply of Two Floating Values are: {0} * {1} = {2}", Value3, value4, Result);
            //Console.WriteLine();

            //// Multiply Two Floating numbers without using input
            //Console.WriteLine("****Multiply Two Floating Numbers without using input******");

            //float NewNumber = 30.5f;
            //float NewNumber2 = 10.5f;
            //float NewResult = NewNumber * NewNumber2;

            //Console.WriteLine("Multiply Two Floating Numbers are: " + NewResult);



            //4) Calculate Area of Circle (Area = Pi * radius * radius)
            Console.WriteLine("****Area of Circle********");
            double radius;
            Console.WriteLine("Enter the Value of Radius: ");
            radius = Convert.ToDouble(Console.ReadLine());

            double Area = 3.141 * radius * radius;
            Console.WriteLine("The Area of Circle is: {0}", Area);
            Console.WriteLine();


            //5) Calculate Area of Rectangle (Area = Length * Width)
            Console.WriteLine("****Area of Rectangle*****");
            int Length;
            int Width;
            Console.WriteLine("Enter the Value of Length: ");
            Length = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Value of Width: ");
            Width = Convert.ToInt32(Console.ReadLine());

            int a = Length * Width;
            Console.WriteLine("The Area of Rectangle is: {0}", a);
            Console.WriteLine();


            //6) Calculate Area of Square (Area = area * area)
            Console.WriteLine("****Area of Square**********");
            int A;
            Console.WriteLine("Enter the Value of A: ");
            A = Convert.ToInt32(Console.ReadLine());

            int area = A * A;
            Console.WriteLine("The Area of Square is: {0}",area);
            Console.Read();



        }
    }
}
