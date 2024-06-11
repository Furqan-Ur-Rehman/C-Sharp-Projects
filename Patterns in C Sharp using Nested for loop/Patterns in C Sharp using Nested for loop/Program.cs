using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_in_C_Sharp_using_Nested_for_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //*
            //**
            //***
            //****
            //*****
            //for(int i=1; i<=5; i++)
            //{
            //    for(int j=1; j<=i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            Console.WriteLine();


            //*****
            //****
            //***
            //**
            //*
            //for (int i=1; i<=5; i++)
            //{
            //    for(int j=i; j<=5; j++)
            //    {
            //        Console.Write("*");

            //    }
            //    Console.WriteLine();
            //}

            //1
            //12
            //123
            //1234
            //12345
            //for(int i=1; i<=5; i++)
            // {
            //     for(int j=1; j<=i; j++)
            //     {
            //         Console.Write(j);
            //     }
            //     Console.WriteLine();
            // }

            //1
            //22
            //333
            //4444
            //55555
            //for(int i=1; i<=5; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write(i);
            //    }
            //    Console.WriteLine();
            //}

            //1
            //23
            //456
            //78910

            //int no = 0;
            //for (int i = 1; i <= 4; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        no++;
            //        Console.Write(no);
            //    }
            //    Console.WriteLine();
            //}


            //*
            //**
            //***
            //****
            //*****
            //****
            //***
            //**
            //*
            //for(int i =1; i<=5; i++)
            //{
            //    for(int j=1; j<=i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //for (int i = 1; i <= 4; i++)
            //{
            //    for (int j = i; j <= 4; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //----*
            //---**
            //--***
            //-****
            //*****

            //for(int i = 1; i <=5; i++)
            //{
            //    for(int j=i; j<=4; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for(int k=1; k<=i; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

           
           //Pramide Pattern
            
            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = i; j <= 4; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 1; k <= i; k++)
            //    {
            //        Console.Write("* ");
            //    }
            //    Console.WriteLine();
            //}

            //*****
            //-****
            //--***
            //---**
            //----*

            for(int i=1; i<=5; i++)
            {
                for(int j=2; j<=i; j++)
                {
                    Console.Write(" ");
                }
                for(int k=i; k<=5; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
