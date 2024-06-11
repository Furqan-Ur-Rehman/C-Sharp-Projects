using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_Case_Another_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Find Employee IDs using with Switch Case in C#
            Console.WriteLine("Enter the EmpID: ");
            int EmpID = Convert.ToInt32(Console.ReadLine());

            switch (EmpID)
            {
                case 101:
                    Console.WriteLine("EmpID {0} of Ali Ahmed", EmpID);
                    break;
                case 102:
                    Console.WriteLine("EmpID {0} of Noman Fazal.",EmpID);
                    break;
                case 103:
                    Console.WriteLine("EmpID {0} of Muniba.",EmpID);
                    break;
                case 104:
                    Console.WriteLine("EmpID {0} of Furqan.",EmpID);
                    break;
                default:
                    Console.WriteLine("You Entered in valid EmpID!");
                    break; 
            }
            Console.ReadLine();
        }
    }
}
