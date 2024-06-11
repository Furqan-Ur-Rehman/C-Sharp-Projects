using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions_in_C_Sharp
{
    class Program
    {
        void print()
        {
            Console.WriteLine("Hello");
        }
        int sum(int num1, int num2)
        {
            int sum = num1 + num2;
            Console.WriteLine(sum + " ");
            return sum;
        }
        static void Main(string[] args)
        {
            Program objProg = new Program();
            Console.Write("Enter Num1: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Num2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            objProg.sum(num1, num2);

            Console.Read();
        }
    }
}
