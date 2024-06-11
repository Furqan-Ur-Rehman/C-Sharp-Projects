using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Constructor
{
    internal class Multiplication
    {
        static readonly int valone = 10;
        static readonly int product;

        //create static constructor

        static Multiplication()
        {
            Console.WriteLine("Static Constructor initiliazed..");
            product = valone * valone;
        }
        public static void Method()
        {
            Console.WriteLine("The price of product is {0}", product + " Rs.");
        }
        static void Main(string[] args)
        {
            
            Multiplication.Method();

            Console.Read();
        }
    }
}
