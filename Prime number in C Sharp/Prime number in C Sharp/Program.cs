﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_number_in_C_Sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***************Prime Number******************");
            int count = 0;
            Console.WriteLine("Enter any number for number is Prime or not.");
            int num =Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <= num; i++)
            {

                if(num % i == 0)
                {
                    count++;
                }

            }
            if (count == 2)
            {
                Console.WriteLine("Given number {0} is Prime number.", num);
            }
            else
            {
                Console.WriteLine("Given number {0} is not Prime number.", num);
            }
            Console.ReadLine();
        }
    }
}
