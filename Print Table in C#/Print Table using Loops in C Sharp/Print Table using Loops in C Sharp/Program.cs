using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_Table_using_Loops_in_C_Sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Print Tables using Loops
            Console.WriteLine("Enter any Integer Number to Print Table: ");
            int num =Convert.ToInt32(Console.ReadLine());


            //1) For Loop
            //for(int i=1; i<=10; i++)
            //{

            //    Console.WriteLine(num + " X " + i + " = " + num*i);
            //}

            //2) While Loop

            //int i = 1;
            //while(i <= 10)
            //{
            //    Console.WriteLine(num + " X " + i + " = " + num*i);
            //    i++;

            //}


            //3) Do While Loop

            int i = 1;
            do
            {
                Console.WriteLine(num + " X " + i + " = " + num * i);
                i++;
            } while (i <= 10);




            Console.ReadLine();
        }
    }
}
