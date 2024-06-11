using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datatype_conversion_in_csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Data Type  Conversion in C#
            Console.WriteLine("************** Data Type Conversion in C# ****************");

            //implicit data type conversion
            int a = 20;
            float b = a;
            Console.WriteLine("The implicit data type conversion is: " + b);
            Console.WriteLine();

            //explicit data type conversion
            float c = 20.543f;
            int d = (int)c;
            Console.WriteLine("The explicit data type conversion is: " + d);
            Console.WriteLine("OR");
            Console.WriteLine();

            int e = Convert.ToInt32(c);
            Console.WriteLine("The explicit data type conversion is: " + e);
            
            Console.WriteLine("OR");
            Console.WriteLine();

            string st1 = "50";
            string st2 = "60";

            //int result = Convert.ToInt32(st1) + Convert.ToInt32(st2);
            int result = int.Parse(st1) + int.Parse(st2);
            Console.WriteLine("The explicit data type conversion is: " + result);


            Console.WriteLine();

            string s1 = "50.234";
            string s2 = "60.7562";
            float f = float.Parse(s1) + float.Parse(s2);
            Console.WriteLine("The explicit data type conversion is: " + f);
            Console.ReadLine();
        }
    }
}
