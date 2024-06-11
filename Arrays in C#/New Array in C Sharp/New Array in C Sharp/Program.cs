using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Array_in_C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n******3rd Example******");
            string Arr;
            int[] arr = new int[5];

            Console.Write("Enter String: ");
            Arr = Console.ReadLine();
            Console.WriteLine("The String is: " + Arr);
            for(int i=0; i<arr.Length; i++)
            {
                arr[i] = Arr[i];
                Console.Write("{0} \t \t", arr[i]);
            }
            Console.Read();
        }
    }
}
