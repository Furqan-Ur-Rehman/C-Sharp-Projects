using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace float_Double_and_decimal_datatypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("================Float, Double and Decimal Data Types in C#===================");
            float a = 23.5305484587f;
            double b = 567.235478963254187;
            decimal c = 782.78546213569874524589678523698m;
            Console.WriteLine("The range of float with 7 No. of precisions: " + a);
            Console.WriteLine("The range of Double with 15 No. of precisions is: " + b);
            Console.WriteLine("The range of Decimal with 29 No. of precisions is: " + c);
            Console.ReadLine();

        }
    }
}
