using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Area of Circle
            Console.WriteLine("Enter the Value of Radius: ");
            double r;
             r = Convert.ToDouble(Console.ReadLine());
            double area = Math.PI * r * r;
            Console.WriteLine("The area of Circle is: " + area);
            Console.WriteLine();




            //Area of Rectangle             
            Console.WriteLine("Find the Value of Area of Rectangle:");
            Console.WriteLine("Enter the Value of Length: ");
            double Length;
            Length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Value of Width: ");
            double Width;
            Width = Convert.ToDouble(Console.ReadLine());
            double AreaofRectangle = Length * Width;
            Console.WriteLine("The Area of Rectangle is: {0} * {1} = {2}", Length, Width, AreaofRectangle);
            

            //Area of Square A = a2
            Console.WriteLine("Find the Value of Area of Square: ");
            Console.WriteLine("Enter the value of a: ");
            double a;
            a = Convert.ToDouble(Console.ReadLine());
            double A = a * a;
            Console.WriteLine("The Area of Square: " + A);
           

            //find the Value of Swap
            int num1;
            int num2;
            int temp;
           
            Console.WriteLine("Enter the Value of num1: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Value of num2: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            temp = num1;
            num1 = num2;
            num2 = temp;
            //temp = Convert.ToDouble(Console.ReadLine(num2));
            Console.WriteLine("The value of num1 is: {0} ", num1);
            Console.WriteLine("The value of num2 is: {0} ", num2);
            Console.Read();



        }
    }
}
