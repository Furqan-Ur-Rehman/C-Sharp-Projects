﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Assignment_pg_117
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Book Assignment Pg no. 117
            string input;
            Console.WriteLine("Enter the Month: ");
            input = Console.ReadLine().ToUpper();

            switch (input)
            {
                case "JANUARY":
                case "MARCH":
                case "MAY":
                case "JULY":
                case "AUGUST":
                case "OCTOBER":
                case "DECEMBER":
                    Console.WriteLine("This month has 31 days.");
                    break;
                case "APRIL":
                case "JUNE":
                case "SEPTEMBER":
                case "NOVEMBER":
                    Console.WriteLine("This month has 30 days.");
                    break;
                case "FEBRUARY":
                    Console.WriteLine("This month has 28 days in a non-leap year and 29 days in a leap year");
                    break;
                default:
                    Console.WriteLine("Incorrect Choice.");
                    break;

                        
                
            }
            Console.ReadLine();
        }
    }
}
