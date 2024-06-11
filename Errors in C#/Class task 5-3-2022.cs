using System;
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
            // char Ch = 'x';
            // int x, y;
            // x = y = 10;
            // if (Ch== 'x')
            // {
            //     x+= 10;
            //     Console.WriteLine("The value of x is {0} and y is {1}", x, y);
            //}

            // ///Example 2////

            // string username;
            // Console.WriteLine("enter username: ");
            // username = Console.ReadLine();
            // if (username == "admin" || username"Admin")

            //     Console.WriteLine("Login Successfull");
            //  }


            // ////if else condition statment////

            // int num;
            // Console.Write("Enter the Number");
            // num = Convert.ToInt32(Console.ReadLine());
            // if (num % 2 == 0)
            // { Console.WriteLine("The given numer is even");
            // }
            // else
            // {
            //     Console.WriteLine("The given numer is odd");
            // }

            //     Console.Read();
            //int num1;
            //int num2;
            //int num3;

            //Console.Write("Enter the Number 1");
            //num1 = Convert.ToInt32(Console.ReadLine());
            
            //Console.Write("Enter the Number 2");
            //num2 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter the Number 3");
            //num3 = Convert.ToInt32(Console.ReadLine());
            //if (num1 > num2 && num1 > num3)
            //{
            //    Console.WriteLine("The Value of of num1{0} is greater than all!", num1);
            //}
            //else if
            // (num2 > num1 && num2 > num3)

            //{
            //    Console.WriteLine("The Value of of num2{0} is greater than all!", num2);

            //}
            //else
            //    (num3 > num1 && num2 > num1)

            //{

            //    Console.WriteLine("The Value of of num3{0} is greater than all!", num3);
            //}

            ////////////// Positive and Nagitive Number////////

            //int Number1;
            
            //Console.Write("Enter the Number 1");
            //num1 = Convert.ToInt32(Console.ReadLine());
            
            //Console.Write("Enter the Number 2");
            //num2 = Convert.ToInt32(Console.ReadLine());
            //if (Number1)



                ///// Uper case and Lowercse/////
                char Ch;
                Console.Write("enter the charector: ");
            Ch = Convert.ToChar(Console.ReadLine());
            if (Ch >= 'a' && Ch <='z')
            {
                Console.WriteLine("The Charector entered {0} is Lower Case", Ch);

                 }
                       
            else if (Ch >= 'A' && Ch <= 'Z')
            {
                Console.WriteLine("The Charector entered {0} is Uper Case", Ch);

            }
            else             
                {
                Console.WriteLine("The Invalid Charector entered ", Ch);

            }

            Console.Read();
        }
    }
}
