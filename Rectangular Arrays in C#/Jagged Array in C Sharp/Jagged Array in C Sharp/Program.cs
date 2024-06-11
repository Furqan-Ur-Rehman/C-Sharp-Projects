using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jagged_Array_in_C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //**********Jagged Array************
            string[][] Companies = new string[3][];
            Companies[0] = new string[] { "Intel", "AMD" };
            Companies[1] = new string[] { "IBM", "Microsoft", "Sun" };
            Companies[2] = new string[] { "Hp", "Canon", "Lexmark", "Epson" };

            for(int i=0; i<Companies.GetLength(0); i++)
            {
                Console.Write("List of Companies in group" + (i + 1) + ":\t");

                for(int j=0; j<Companies[i].GetLength(0); j++)
                {
                    Console.Write(Companies[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
