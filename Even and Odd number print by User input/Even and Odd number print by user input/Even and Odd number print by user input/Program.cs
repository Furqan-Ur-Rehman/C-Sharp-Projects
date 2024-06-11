using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Even_and_Odd_number_print_by_user_input
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Selection Statements
            int num;
            Console.WriteLine("Enter num: ");
            num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            for (int i = 0; i < 10; i++)
            {

                if (num % 2 == 0 || num % 2 != 0)
                {
                    if (num % 2 == 0)
                    {
                       
                        Console.WriteLine("Even numbers: " + num);

                    }

                    else
                    {
                        Console.WriteLine("Odd numbers: " + num);

                    }
                }
                num += 2; //num=num+2;   
            }
            Console.Read();
        }
    }
}
