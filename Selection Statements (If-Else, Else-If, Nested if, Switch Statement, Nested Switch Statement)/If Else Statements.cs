using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch = 'x';
            int x, y;
            x = y = 10;
            if(ch == 'x')
            {
                x += 10;
                Console.WriteLine("The Value of x is {0} and y is {1}", x, y);
            }
            Console.WriteLine();



            //Another Example
            string username;
            Console.WriteLine("Enter Username");
            username = Console.ReadLine();
            if(username == "admin" || username == "Admin")
            {
                Console.WriteLine("Login Successfully!");
            }


            else{
                Console.WriteLine("Login Failed!");
            }

            Console.WriteLine();

            
            
            //If Else Selection Statement

            int num;
            Console.Write("Enter Number: ");
            num = Convert.ToInt32(Console.ReadLine());

            if(num % 2 == 0)
            {
                Console.WriteLine("The given number {0} is Even!", num);
            }
            else
            {
                Console.WriteLine("The given number {0} is Odd!", num);
            }
            Console.Read();
        }
    }
}
