using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_types_in_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1) Integers Data Types in C#
            
            //1) Signed Integers (Which takes negative and postive values)
            //2) Unsigned Integers (Which takes only postive values)
                    //SByte (signed)
                    //Byte (Un signed)
                    //SHORT (signed)
                    //UNSHORT (Un singed)
                    //int (signed)
                    //UINT (Un signed)
                    //Long (signed)
                    //ulong (un signed)

            byte a = 255;
            Console.WriteLine("The Minimum value of byte is: " + byte.MinValue);
            Console.WriteLine("The Max value of byte is: " + byte.MaxValue);
            Console.WriteLine(a);

            Console.WriteLine();
            Console.WriteLine();
            sbyte b = -128;
            Console.WriteLine("The Minimum value of sbyte is: " + sbyte.MinValue);
            Console.WriteLine("The Max value of sbyte is: " + sbyte.MaxValue);
            Console.WriteLine(b);
            Console.WriteLine();
            Console.WriteLine();

            int c = 2500000;
            Console.WriteLine("The Minimum value of int is: " + int.MinValue);
            Console.WriteLine("The Max value of int is: " + int.MaxValue);
            Console.WriteLine(c);
            Console.WriteLine();
            Console.WriteLine();

            uint d = 2500000;
            Console.WriteLine("The Minimum value of uint is: " + uint.MinValue);
            Console.WriteLine("The Max value of uint is: " + uint.MaxValue);
            Console.WriteLine(d);
            Console.WriteLine();
            Console.WriteLine();

            //2) Boolean Data Types 
            int x = 30;
            int z = 50;
            bool y = x > z;
            Console.WriteLine("The value is : " + y);


            Console.ReadLine();



        }
    }
}
