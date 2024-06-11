using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_Case_in_C_Sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Switch Case Statement
            Console.WriteLine("Enter your WeeK_Numbers: ");
            int Week_Numbers = int.Parse(Console.ReadLine());

            switch (Week_Numbers)
            {
                case 1:
                    Console.WriteLine("Monday!");
                    break;
                case 2:
                    Console.WriteLine("Tuesday!");
                    break;
                case 3:
                    Console.WriteLine("Wednesday!");
                    break;
                case 4:
                    Console.WriteLine("Thusday!");
                    break;
                case 5:
                    Console.WriteLine("Friday!");
                    break;
                case 6:
                    Console.WriteLine("Saturaday!");
                    break;
                case 7:
                    Console.WriteLine("Sunday!");
                    break;
                default:
                    Console.WriteLine("You Entered In valid Week_Numbers!");
                    break;
                    
            }
            Console.Read();
        }
    }
}
