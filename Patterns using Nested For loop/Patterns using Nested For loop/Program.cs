using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_using_Nested_For_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //*****
            //*****
            //*****
            //*****
            //*****
            for(int k=1; k<=5; k++)
            {
                for(int l=1; l<=5; l++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();


            //*
            //**
            //***
            //****
            //*****

            for (int i=1; i<=5; i++)
            {
                for(int j=1; j<=i; j++)
                {
                    Console.Write("* ");

                }
                Console.WriteLine();
            }
            
            //*****
            //****
            //***
            //**
            //*
            for(int m=1; m<=5; m++)
            {
                for(int n=m; n<=5; n++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            //1
            //12
            //123
            //1234
            //12345
            for (int O=1; O<=5; O++)
            {
                for(int P=1; P<=O; P++)
                {
                    Console.Write(P);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //1
            //22
            //333
            //4444
            //55555
            for(int Q=1; Q<=5; Q++)
            {
                for(int R=1; R<=Q; R++)
                {
                    Console.Write(Q);
                }
                Console.WriteLine();
            }

            //1
            //23
            //456
            //78910
            int no=0;
            for (int S=1; S<=4; S++)
            {
                
                for (int T=1; T<=S; T++)
                {
                    no++;
                    Console.Write(no);
                    
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
