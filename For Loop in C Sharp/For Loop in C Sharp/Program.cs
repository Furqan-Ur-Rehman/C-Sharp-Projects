using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_Loop_in_C_Sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //FOR LOOP
            //for(int i =0; i <10; i++)
            //{
            //    Console.WriteLine(i);
            //}



            //Print Table Using For Loop
            //Console.WriteLine("Enter the Number: ");
            //int number = Convert.ToInt32(Console.ReadLine());

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(number + " X " + i + " = " + number * i);
            //}
            //Console.WriteLine();

            ////Print Reverse Number
            //for(int i= 10; i > 0; i--)
            //{
            //    Console.WriteLine(i);
            //}


            //2) While Loop

            //int i = 1;

            //while ( i < 10)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            // Print Table usig While loop
            //Console.WriteLine("Enter the Number: ");
            //int num = int.Parse(Console.ReadLine());
            //int i =1;
            //while ( i <= 10 )
            //{
            //    Console.WriteLine(num + " X " + i + " = " + num * i);
            //    i++;
            //}
            /*Console.WriteLine(i);*/


            //3) Do While Loop
            //int i = 0;

            //do
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}
            //while(i < 10);

            //4) Nested For loop
            //Print * using Nested for loop
            int i;
            int j;
            for (i = 0; i < 5; i++)
            {
                for (j = i; j < 5; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            int k;
            int l;
            for (k = 0; k < 5; k++)
            {
                for (l = k; l >= 0; l--)
                {
                    Console.Write("*");

                }
                Console.WriteLine();
            }

            
            
            
            
            
            Console.ReadLine();
        }
    }
}
