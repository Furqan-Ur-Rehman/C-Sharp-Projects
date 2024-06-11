using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constant_variable_in_csharp
{
    internal class Program
    {
        public const string abc = "I am C# Developer!";
        //string asx = "hhjuu";
        static void Main(string[] args)
        {
            Console.WriteLine("****************Constant Variable in C# **********************");
            Console.WriteLine("The Constant Variable is: " + abc);

            Console.WriteLine("OR");

            const int a = 20;
            Console.WriteLine("The Constant Variable is: " + a);
            Console.ReadLine();
        }
    }
}
