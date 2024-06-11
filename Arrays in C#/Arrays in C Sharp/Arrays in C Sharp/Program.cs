using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_in_C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********1st Example***********");
            int[] count = new int[10];
            for(int i =0; i<count.Length; i++)
            {
                count[i] = i;
                Console.WriteLine("Array Index value Count[{0}] = {1}", i, count[i]);
            }




            Console.WriteLine("\n*************2nd Example**********");
            //Intialize single Dimensional Array
            string[] stud = new string[3] { "xyz", "abc", "efg" };
            for(int i =0; i< stud.Length; i++)
            {
                Console.WriteLine("Student Names at Index student [{0}] = {1}", i, stud[i]);
            }

            Console.Read();
        }
    }
}
