using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_loop_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //print Table using For loop

            //int num;
            //Console.WriteLine("Enter num: ");
            //num = Convert.ToInt32(Console.ReadLine());
            //for(int i=1; i<=10; i++)
            //{
            //    Console.WriteLine(num + " X " + i + " = " + num*i);
            //}

            //print Table using while loop
            int num1;
            int i = 1;
            Console.WriteLine("Enter num1: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            while (i <= 10)
            {
                Console.WriteLine(num1 + " X " + i + " = " + num1 * i);
                i++;
            }
            Console.WriteLine();
            //print Table using do while loop
            int num2 = 2;

            int j = 1;
            do
            {
                Console.WriteLine(num2 + " X " + j + " = " + num2 * j);
                j++;

            }while(j <= 10);




            Console.Read();
        }
    }
}
