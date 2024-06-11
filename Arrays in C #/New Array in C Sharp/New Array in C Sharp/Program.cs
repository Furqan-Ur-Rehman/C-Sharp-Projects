using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Array_in_C_Sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******Ist Example of Array.**********");
            int[] count = new int[3]; //Declaration of length of Array

            count[0] = 20; //Value stored in 0 index of array
            count[1] = 30; //Value stored in 1 index of array
            count[2] = 40; //Value stored in 2 index of array


            Console.WriteLine(count[0]); //Access value in print
            Console.WriteLine(count[1]);
            Console.WriteLine(count[2]);

            Console.WriteLine("**********2nd Example of Array.*******");
            //string[] arr = new string[] { "Muniba", "Furqan", "Adnan", "Waheed" };
            //or
            string[] arr1 = { "Muniba", "Furqan", "Adnan", "Waheed", "Wahaj" };

            Console.WriteLine("Total Length of the Array: " + arr1.Length);
            Console.WriteLine();

            for (int i = 0; i < arr1.Length; i++) //Access all values from array at a time
            {                                   // using for loop

                Console.WriteLine("Names of Student at index [{0}] = {1}", i, arr1[i]);
            }
            Console.WriteLine();

            //or

            //foreach loop

            foreach (string item in arr1)
            {
                Console.WriteLine(item);
            }

            //or

            Console.WriteLine();

            Console.WriteLine(arr1[0]); //Access value from arrays
            Console.WriteLine(arr1[1]);
            Console.WriteLine(arr1[2]);
            Console.WriteLine(arr1[3]);
            Console.WriteLine(arr1[4]);

            //Single Dimensional Array
            Console.WriteLine();
            Console.WriteLine("*********Single Dimensional Array**********");
            int[] singlearray = new int[3];

            singlearray[0] = 50;
            singlearray[1] = 20;
            singlearray[2] = 30;

            Console.WriteLine(singlearray[0]);
            Console.WriteLine(singlearray[1]);
            Console.WriteLine(singlearray[2]);

            Console.WriteLine();

            //or for Loop

            for (int i = 0; i < singlearray.Length; i++)
            {
                Console.WriteLine("Values at index [{0}] = {1}", i, singlearray[i]);
            }

            //or foreach loop

            foreach (int item in singlearray)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            //Multi Dimensional Array or 2D Array 
            // 1) Rectangular Multi Dimensional Array

            Console.WriteLine("********Multi Dimensional Array*********");
            int[,] multi_array = new int[3, 4]
            {
                { 20, 30, 40, 50 },
                { 60, 70, 80, 90 },
                { 100, 101, 102, 103 }
            };

            Console.WriteLine(multi_array.GetLength(0)); //Find Length of row at 0 index: 3
            Console.WriteLine(multi_array.GetLength(1)); // Find Length of col at 1 index: 4
            Console.WriteLine(multi_array.Rank);  // Find Dimension means row and col: 2
            Console.WriteLine(multi_array[0, 0]); // Access Value in console screen is:20
            Console.WriteLine(multi_array[1, 2]);

            Console.WriteLine();

            Console.WriteLine("*****Print Multi Arrays using Nested for loop*****");
            //or Nested for loop
            for(int i=0; i < multi_array.GetLength(0); i++) //for row
            {
                for(int j=0; j < multi_array.GetLength(1); j++) // for column
                {
                    Console.Write(multi_array[i,j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            // or For each loop
            foreach(int multi in multi_array)
            {
                Console.WriteLine(multi);
            }
            Console.WriteLine();

            //2) Jagged Multi Dimensional Array
            Console.WriteLine("*****Jagged Multi Dimensional Array*****");
            int[][] Jagged_array = new int[3][];

            Jagged_array[0] = new[] { 10, 20, 30, 40, 50, 60, 70 };
            Jagged_array[1] = new[] { 80, 90, 55, 75 };
            Jagged_array[2] = new[] { 25, 35, 65 };

            Console.WriteLine(Jagged_array[2][1]);

            Console.WriteLine();

            // or Print Jagged Multi Dimensional Array using Nested for loop

            for(int i=0; i < Jagged_array.GetLength(0); i++)
            {
                for(int j=0; j < Jagged_array[i].Length; j++)
                {
                    Console.Write(Jagged_array[i][j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            //or Print Jagged Multi Dimensional Array using foreach loop
            foreach(int [] items in Jagged_array)
            {
                foreach(int item in items)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            // Array References Book Page No. 161 heading  5.2.4

            string[] Classone = { "Allan", "Chris", "Monica" };
            string[] Classtwo = {"Katie", "Niel", "Mark" };
            Console.WriteLine("Students of Classone: \t Students of Classtwo: ");
            for(int i=0; i<3; i++)
            {
                Console.WriteLine(Classone[i] + "\t\t\t" + Classtwo[i]);
            }

            Classtwo = Classone;
            Console.WriteLine("\nStudents of Classtwo after referencing Classone: ");
            for(int i=0; i<3; i++)
            {
                Console.WriteLine(Classtwo[i] + " ");
            }
            Console.WriteLine();
            Classtwo[2] = "Mark";
            Console.WriteLine("Students of Classone after changing the third student in classtwo:");
            for(int i=0; i<3; i++)
            {
                Console.WriteLine(Classtwo[i] + " ");
            }

            Console.WriteLine();
            //Multi Dimensional Array Coaching Work
            int[,] dimensional = new int[2, 3]; //array Create
            for(int i=0; i<2; i++)
            {
                for(int j=0; j<3; j++)
                {
                    Console.WriteLine("Enter number arr[{0}][{1}]:",i,j);
                    dimensional[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("******Display Array******");
            for(int i=0; i<2; i++)
            {
                for(int j=0; j<3; j++)
                {
                    Console.Write("The number at arr[{0}][{1}] = {2}, ",i,j, dimensional[i,j]);  
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            //Rectangular Array Book Example Page no. 158
            Console.WriteLine("***Rectangular Array Book Example pg no. 158********");
            
            int[,] Rectangular_Array = new int[4, 5];
            int numone = 0;
            for(int i=0; i<4; i++)
            {
                for(int j=0; j<5; j++)
                {
                    Rectangular_Array[i, j] = numone;
                    numone++;
                }
            }
            for(int i=0; i<4; i++)
            {
                for(int j=0; j<5; j++)
                {
                    Console.Write(Rectangular_Array[i, j] + " ");
                }
                
                Console.WriteLine();
            }


            //Intializing or Creating array using user input
            Console.WriteLine("How many number of items u want to store in an array: ");
            int num = int.Parse(Console.ReadLine());
            int[] numbers = new int [num];

            for(int i=0; i<num; i++)
            {
                Console.WriteLine("Enter Data on Location: " + (i+1));
                int data = int.Parse(Console.ReadLine());
                numbers[i] = data;
            }
            Console.WriteLine("-------Your Data------------");
            for(int i=0; i<num; i++)
            {
                Console.Write(numbers[i] + " ");
            }

            Console.WriteLine();

            // or using foreach loop
            foreach(int item in numbers)
            {
                Console.Write(item + " ");
            }
            

            Console.Read();
        }
    }
}
