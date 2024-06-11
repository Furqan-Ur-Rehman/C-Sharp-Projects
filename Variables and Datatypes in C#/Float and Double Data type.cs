using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Float_and_Double_Data_type
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Area of Circle
            Console.WriteLine("Enter the Value of Radius: ");
            double r;
            r = Convert.ToDouble(Console.ReadLine());
            double area = Math.PI * r * r;
            Console.WriteLine("The area of Circle is: " + area);
            Console.Read();
        }
    }
}
