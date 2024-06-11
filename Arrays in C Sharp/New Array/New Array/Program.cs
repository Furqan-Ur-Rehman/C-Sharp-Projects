using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Multi Dimensional Array (Rectangle Array)

            //int[,] arr = new int[2, 3]
            //{
            //    {10,20,30 },
            //    {40,50,60 }
            //};

            //for(int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for(int j = 0; j < arr.GetLength(1); j++)
            //    {
            //        Console.Write(arr[i,j] + " ");
            //    }
            //    Console.WriteLine();
            //}


            //Multi Dimensional Array (jagged Array)

            int[][] Arr = new int[2][];
            Arr[0] = new int[] { 10, 20, 30, 40 };
            Arr[1] = new int[] { 10, 20, 30, };

            for(int i = 0; i < Arr.GetLength(0); i++)
            {
                for(int j = 0; j < Arr[i].Length; j++)
                {
                    Console.Write(Arr[i][j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            foreach(int[] i in Arr)
            {
                foreach(int j in i)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }





            Console.Read();

        }
    }
}
