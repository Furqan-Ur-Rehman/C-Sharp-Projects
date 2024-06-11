using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace even_odd_using_jump_statement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Even or Odd using Jump Statement in C#");
            int i;
            for(i = 0; i < 10; i++)
            {
                if(i % 2 == 1)
                {
                    continue;
                }
                Console.WriteLine("The Even Number is: " + i);

            }
            Console.WriteLine("The value is after terminating loop: " + i);
            Console.WriteLine();
            Console.WriteLine();
            int j;
            for(j=0; j<10; j++)
            {
                if(j % 2 == 0)
                {
                    continue;
                }
                Console.WriteLine("The Odd Number is: " + j);
            }
            Console.WriteLine("The value is after terminating loop is: " + j);
            Console.ReadLine();
        }
    }
}
