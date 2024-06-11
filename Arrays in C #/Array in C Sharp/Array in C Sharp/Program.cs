using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_in_C_Sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Array in C #
            Console.WriteLine("*********Ist Example of Array*********");
            int[] count = new int[10]; //declaration of Array
            for(int i = 0; i < count.Length; i++)
            {
                count[i] = i;
                Console.WriteLine("Array Index Value Count [{0}] = {1}",i, count[i]);
            }
            
            
            Console.WriteLine();

            Console.WriteLine("*********2nd Example of Array********");
            //Intialize Single Dimensional Array
            string[] arr = new string[3] { "xyz", "abc", "efg" };
            for(int i =0; i < arr.Length; i++)
            {
                Console.WriteLine("Student Names at Index Student [{0}] = {1}", i, arr[i]);
            }
            Console.WriteLine();

            Console.WriteLine("*********3rd Example of Array********");
            string Arr;
            int [] Array = new int[5];
            Console.WriteLine("Enter String: ");
            Arr = Console.ReadLine();
            Console.WriteLine("The String is: " + Arr);
            for(int i=0; i<Array.Length; i++)
            {
                Array[i] = Arr[i];
                Console.Write("{0} \t \t", Array[i]);

            }

            Console.ReadLine();
        }
    }
}
