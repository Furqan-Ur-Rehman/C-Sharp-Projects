using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumthreevalues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("************Sum Three Different Values***********");
            Console.WriteLine("Enter the Value of Num1:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Value of Num2:");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Value of Num3:");
            double num3 = Convert.ToDouble(Console.ReadLine());

            if(num1 != num2 && num1 != num3 && num2 != num3) //10 20 30
            {
                double result = num1 + num2 + num3;
                Console.WriteLine("The Values of {0} + {1} + {2} = {3}", num1, num2, num3, result);
                Console.ReadLine();
            }
            
        }
    }
}
