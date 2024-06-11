using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace change_background_color_and_fontcolor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            //Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("C# Programmar!");
            Console.WriteLine("C# Programmar!");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("All Text Color Print below:");

            foreach(var item in Enum.GetValues(typeof(ConsoleColor)))
            {
                //Console.WriteLine(item.ToString());
                Console.ForegroundColor = (ConsoleColor)item;
                Console.WriteLine("C# Programmar!");
            }

            Console.ReadLine();
        }
    }
}
