﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {

            //Task 1 (Find the Largest number amoung three Numbers?)

            int num1;
            int num2;
            int num3;
            Console.WriteLine("Enter the Value of num1: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Value of num2: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Value of num3: ");
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine("The Value of num1 {0} is Greator than All! ", num1);
            }

            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine("The Value of num2 {0} is Greator than All! ", num2);
            }

            else
            {
                Console.WriteLine("The Value of num3 {0} is Greator than all of above! ", num3);
            }
            Console.WriteLine();

            //Task 2 (Find the Largest number amoung three Numbers?)
            int Num1;
            Console.WriteLine("Enter the value of Num1: ");
            Num1 = Convert.ToInt32(Console.ReadLine());
            if (Num1 > 0)
            {
                Console.WriteLine("The Value of Num1 {0} is Positive! ", Num1);
            }

            else if (Num1 < 0)
            {
                Console.WriteLine("The Value of Num1 {0} is Negative! ", Num1);
            }
            else
            {
                Console.WriteLine("The Value of Num1 {0} is Zero! ", Num1);
            }



            //Task 3 
            char Ch;
            Console.WriteLine("Enter the Any Character: ");
            Ch = Convert.ToChar(Console.ReadLine());
            if(Ch >= 'a' && Ch <= 'z')
            {
                Console.WriteLine("The Character you entered {0} is LowerCase!", Ch);
            }

            else if(Ch >= 'A' && Ch <= 'Z')
            {
                Console.WriteLine("The Character you entered {0} is UpperCase!", Ch);
            }

            else 
            {
                Console.WriteLine("The Character you entered {0} is not a Single Character neither UpperCase or LowerCase!", Ch);
            }
            Console.Read();
        }
    }
}
