using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_input_from_user
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //Input Array Length from User
            Console.WriteLine("How many number of items do u want to store in an array?");
            int num = Convert.ToInt32(Console.ReadLine());
            int[] number = new int[num];

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Enter Data: ");
                int data = Convert.ToInt32(Console.ReadLine());
                number[i] = data;
            }
            Console.WriteLine("-----------------Your Data--------------------");
            for(int i = 0; i < num; i++)
            {
                Console.WriteLine(number[i] + " ");
            }

            Console.WriteLine();

            foreach(int i in number)
            {
                Console.WriteLine(i + " ");
            }
            Console.Read();
        }
    }
}
