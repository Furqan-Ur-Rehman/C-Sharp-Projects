using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_and_character_Data_Types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------String and Character Data Types in C#------------------");
            //--String Stores multiple charachters in a single variable.
            //--Double quotes will be used with string data type.
            //--Char stores single character at a time in a variable.
            //--single quotes will be used for char data type.
            //Escape Sequence /

            string a = "\"Furqan-ur-Rehman\"";
            string b = "\\Furqan-ur-Rehman\\";
            char   c = 'f';
            string d = "\tFurqan-ur-Rehman";
            string e = "Furqan \nRehman";

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine();

            //Verbatim Literal @
            string f = @"D:\Furqan\practice\CSharp";
            Console.WriteLine(f);
            Console.ReadLine();
        }
    }
}
