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
            //int[] myarray = new int[3];

            //myarray[0] = 10;
            //myarray[1] = 20;
            //myarray[2] = 30;

            //Console.WriteLine(myarray[0]);

            string[] mystring = new string[] { "Muniba", "Furqan", "Adnan", "Asma" };

            //or


            string[] mystring2 = {"Waheed" , "Wahaj"};

            //Console.WriteLine(mystring[0] + "" + mystring[1]);

            //for(int i=0; i<mystring.Length; i++)
            //{
            //    Console.WriteLine(mystring[i]);
            //}

            //Console.WriteLine(mystring.Rank);

            //int[] mystring3 = new int[2];

            //mystring3[0] = 20;
            //mystring3[1] = 30;

            //Console.WriteLine(mystring3[0] + " " + mystring3[1]);

            //for(int i = 0; i < mystring3.Length; i++)
            //{
            //    Console.WriteLine(mystring3[i]);
            //}

            //foreach(int i in mystring3)
            //{
            //    Console.WriteLine(i);
            //}
            //foreach (string s in mystring)
            //{
            //    Console.Write(s + " ");
            //}

            //int[,] multiarray = new int[,] //or [2,3]
            //{
            //    {10, 20, 30},
            //    {30, 40, 50,}
            //};

            //Console.WriteLine(multiarray[1,2]);

            //Console.WriteLine();

            //for(int i = 0; i < multiarray.GetLength(0); i++)
            //{
            //    for(int j=0; j < multiarray.GetLength(1); j++)
            //    {
            //        Console.Write(multiarray[i,j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //foreach(int i in multiarray)
            //{
            //    Console.Write(i + " ");
            //}

            //Console.WriteLine(multiarray.Rank);

            //int[][] jaggedarray = new int[2][];
            //jaggedarray[0] = new[] {10,20,30 };
            //jaggedarray[1] = new[] { 40, 50 };

            //Console.WriteLine(jaggedarray[0][2]);

            //for(int i = 0; i < jaggedarray.GetLength(0); i++)
            //{
            //    for(int j = 0; j < jaggedarray[i].Length; j++)
            //    {
            //        Console.Write(jaggedarray[i][j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //foreach(int[] i in jaggedarray)
            //{
            //    foreach(int j in i)
            //    {
            //        Console.Write(j + " ");
            //    }
            //    Console.WriteLine();
            //}

            Console.WriteLine("How many numbers of items are stored in an array?");
            int num = int.Parse(Console.ReadLine()); 
            int[] numbers = new int[num];

            for(int i = 0; i < num; i++)
            {
                Console.WriteLine("Enter Data on Location: " + (i+1));
                int data = int.Parse(Console.ReadLine());
                numbers[i] = data;
            }
            Console.WriteLine("**********Your Data******************");
            foreach(int i in numbers)
            {
                Console.WriteLine(i);
            }

            Console.Read();
        }
    }
}
