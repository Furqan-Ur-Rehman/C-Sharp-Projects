using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangular_Arrays_in_C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //********Rectangular Array***************
            Console.Write("Enter the num of Students: ");
            int noofStudents = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the num of Exams: ");
            int exams = Convert.ToInt32(Console.ReadLine());

            string[] stdNames = new string[noofStudents]; // Single Dimensional Array
            string[,] details = new string[noofStudents, exams];//Multi Dimensional Array

            for(int i=0; i<noofStudents; i++)
            {
                Console.Write("\nEnter Student Name: ");
                stdNames[i] = Console.ReadLine();

                for(int j=0; j<exams; j++)
                {
                    Console.Write("Enter scores in Exams: " + (j + 1 + " = "));
                    details[i, j] = Console.ReadLine();
                }
            }
            Console.WriteLine("Student Exam Details: ");
            Console.WriteLine("--------------");
            Console.WriteLine();
            Console.WriteLine("Students\t\tMarks");
            Console.WriteLine("------\t----------");

            for(int i=0; i <noofStudents; i++)
            {
                Console.WriteLine("{0}", stdNames[i] + "\t\t");
                Console.WriteLine();

                for(int j=0; j<exams; j++)
                {
                    Console.Write("\t\t\tExams " + (j + 1) + "=" + details[i, j] + "\n");
                }
            }
            Console.ReadLine();
        }
    }
}
