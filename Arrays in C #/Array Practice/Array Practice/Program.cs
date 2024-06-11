using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            Console.WriteLine("**************Single Dimensional Array***********");
            int[] array1 = new int[3];

            array1[0] = 20;
            array1[1] = 30;
            array1[2] = 40;

            Console.WriteLine(array1[0]);
            Console.WriteLine(array1[1]);
            Console.WriteLine(array1[2]);

                //or
            for (int i = 0; i < array1.Length; i++)
            {
                Console.WriteLine("Values at index [{0}] = {1}",i, array1[i]);
            }
            Console.WriteLine();    

            Console.WriteLine("----------------------------------");
            string[] array2 = new string[] { "Ali", "Kamran" };

            Console.WriteLine(array2[0]);
            Console.WriteLine(array2[1]);

            //or
            foreach(string s in array2)
            {
                Console.WriteLine("Both Names are together: "+ s);
            }

            Console.WriteLine();

            Console.WriteLine("-----------------------------------");
            string[] array3 = { "Noman", "Raza" };

            for(int i= 0; i < array3.Length; i++)
            {
                Console.WriteLine("Both Names are [{0}] = {1}", i, array3[i]);
            }

            Console.WriteLine();

            //2
            Console.WriteLine("**************Multi Dimensional Array****************");
            Console.WriteLine("1) Rectangular Array");
            int[,] rectangular_Array = new int[3, 4]
            {
                {1, 2, 3, 4},
                {4, 5, 6, 7},
                {5, 6, 7, 8}
            };
            //Print Rectangular array using nested for loop
            for(int i= 0; i < rectangular_Array.GetLength(0); i++)
            {
                for(int j=0; j < rectangular_Array.GetLength(1); j++)
                {
                    Console.Write(rectangular_Array[i, j] + " ");
                }
                Console.WriteLine();
            }

            // or using foreach loop
            foreach(int i in rectangular_Array)
            {
                Console.Write(i + " ");
            }


            Console.WriteLine();

            Console.WriteLine("2) Jagged Array in Multi Dimensional Array.");
            int [][] jagged_Array = new int[3][];
            jagged_Array[0] = new int[] { 10, 20, 30, 40, 50 };
            jagged_Array[1] = new int[] { 60, 70, 80, 90 };
            jagged_Array[2] = new int[] { 55, 45, 65 };

            Console.WriteLine(jagged_Array[2][1]);//45

            //or
            for(int i =0; i < jagged_Array.GetLength(0); i++)
            {
                for( int j=0; j < jagged_Array[i].Length; j++)
                {
                    Console.Write(jagged_Array[i][j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            //Array References Book page No. 161 heading 5.2.4
            string[] Classone = { "Allan", "Chris", "Monica" };
            string[] Classtwo = { "Katie", "Niel", "Mark" };
            Console.WriteLine("Students of Classone: \t Students of Classtwo: ");
            for(int i = 0; i < Classone.Length; i++)
            {
                Console.WriteLine(Classone[i] + "\t\t\t" + Classtwo[i]);
            }
            Classtwo = Classone;
            Console.WriteLine("\nStudents of Classtwo after referencing Classone: ");
            for(int i=0; i < Classtwo.Length; i++)
            {
                Console.WriteLine(Classtwo[i] + " ");
            }

            Console.WriteLine();
            Classtwo[2] = "Mark";
            Console.WriteLine("\nStudents of Classone after Changing third Student in Classtwo:");
            for(int i=0; i< Classtwo.Length; i++)
            {
                Console.WriteLine(Classtwo[i] + " ");
            }


            // Step (1) Multi Dimensional Array using user input Coaching Work
            int[,] multi_Array = new int[3, 4];
            for (int i = 0; i < multi_Array.GetLength(0); i++)
            {
                for (int j = 0; j < multi_Array.GetLength(1); j++)
                {
                    Console.WriteLine("Enter number at arr[{0}][{1}]:", i, j);
                    //User input
                    multi_Array[i, j] = Convert.ToInt32(Console.ReadLine());
                }

            }
            Console.WriteLine("*****Display Array******");
            for (int i = 0; i < multi_Array.GetLength(0); i++)
            {
                for (int j = 0; j < multi_Array.GetLength(1); j++)
                {
                    Console.Write("The number at arr[{0}][{1}]: {2}, ", i, j, multi_Array[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            // Step (2) Rectangular Array Book Page No. 158
            int[,] Rectangular_Array = new int[4, 5];
            int numone = 0;
            for(int i=0; i<Rectangular_Array.GetLength(0); i++)
            {
                for(int j=0; j<Rectangular_Array.GetLength(1); j++)
                {
                    Rectangular_Array[i, j] = numone;//0 1 2 3 4
                    numone++;                        //5 6 7 8 9
                }                                   //10 11 12 13 14
                                                    //15 16 17 18 19
            }
            for(int i=0; i<Rectangular_Array.GetLength(0); i++)
            {
                for(int j=0; j<Rectangular_Array.GetLength(1); j++)
                {
                    Console.Write(Rectangular_Array[i, j] + " ");
                }
                Console.WriteLine();
            }


            // Step (3) Intializing or Creating Array using user input
            Console.WriteLine("How many number of Elements you want to store in an array?");
            int num = int.Parse(Console.ReadLine());
            int [] numbers = new int[num];
            for(int i=0; i<numbers.Length; i++)
            {
                Console.WriteLine("Enter Data on Location: " + (i + 1));
                int data=int.Parse(Console.ReadLine());
                numbers[i] = data;
            }
            Console.WriteLine("--------Your Data-------------");
            for(int i=0; i<numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.ReadLine();
        }
    }
}
