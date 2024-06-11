using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nested_if_Job_requirement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("According to Our Job Requirements choose only two Department.");
            Console.WriteLine("(1) CS Department: ");
            Console.WriteLine("(2) IT Department: ");
            Console.WriteLine("Eligibility for Job: ");
            Console.WriteLine("Academic Percentage >=60 and age<50");
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("If you want to select CS Department then press 1 otherwise press 2:");

            int presskey =Convert.ToInt32(Console.ReadLine());

            if(presskey == 1)
            {
                Console.WriteLine("You have selected CS Department!");
                Console.WriteLine("Enter your Percentage: ");
                int per = Convert.ToInt32(Console.ReadLine());
                if(per >= 60)
                {
                    Console.WriteLine("Enter your Age: ");
                    int Age = Convert.ToInt32(Console.ReadLine());
                    
                    if(Age < 50)
                        {
                            Console.WriteLine("You are Eligible for this Post!");

                        }
                    else
                        {
                            Console.WriteLine("You are not Eligible for this Post!");
                        }
                }
                else
                {
                    Console.WriteLine("Your Percentage is not Suitable for this CS Post!");
                }
                
            }
            else if(presskey == 2)
            {
                Console.WriteLine("You have selected IT Department!");
                Console.WriteLine("Enter your Percentage: ");
                int per=Convert.ToInt32(Console.ReadLine());
                if(per >= 60)
                {
                    Console.WriteLine("Enter your Age: ");
                    int age = Convert.ToInt32(Console.ReadLine());
                    if (age < 50)
                    {
                        Console.WriteLine("You are Eliglible for IT post!");
                    }
                    else
                    {
                        Console.WriteLine("You are not Eligible for IT Post!");
                    }
                }
                else
                {
                    Console.WriteLine("Your Percentage is not Suitable for IT Post!");
                }
            }
            else
            {
                Console.WriteLine("You have not Selected neither CS Department nor IT Department.");
            }
            Console.ReadLine();
        }
    }
}
