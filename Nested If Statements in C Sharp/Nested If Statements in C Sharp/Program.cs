using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nested_If_Statements_in_C_Sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Nested If-Else Statements in C # just like Gmail Account
            Console.WriteLine("Enter Your Email Address: ");
            string Email = Console.ReadLine();

            if (Email == "furqan124@gmail.com")
            {
                Console.WriteLine("Enter Your Password: ");
                string Password = Console.ReadLine();

                if(Password == "Furqan124")
                {
                    Console.WriteLine("Login Successfully!");
                }
                else
                {
                    Console.WriteLine("You Entered In Correct Password!");
                }
            }
            else {
                Console.WriteLine("You Entered In Valid Email!");
            }
            Console.ReadLine();
            
        }
    }
}
