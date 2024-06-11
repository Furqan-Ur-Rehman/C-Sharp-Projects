using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabonacci_Series_in_C_Sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("************Fabonacci Series***************");
            Console.WriteLine("Enter the value of num1 for Fabonacci Series: ");
            int num1 =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of num2 for Fabonacci Series: ");
            int num2 =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine();
            for (int i = 1; i <=10; i++)
            {
                
                int result = num1 + num2;//5 10 = 15
                Console.WriteLine(result);//10 15 = 25
                num1 = num2;// num1=10      num1=15
                num2 = result; //num2 =15  num2 =25
            }
            Console.ReadLine();
        }
    }
}
