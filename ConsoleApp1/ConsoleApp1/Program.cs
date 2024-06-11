using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Selection Statements
            int num;
            Console.WriteLine("Enter num: ");
            num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= num; num++)
            {
                if (num % 2 == 0)
                {
                    Console.WriteLine(num);
                }


            }

            int num1 = 1;
            while(num1 <= 10)
            {
                if(num1 % 2 != 0)
                {
                    Console.WriteLine(num1);
                }
                num1++;
            }
            Console.Read();
        }
    }
}
