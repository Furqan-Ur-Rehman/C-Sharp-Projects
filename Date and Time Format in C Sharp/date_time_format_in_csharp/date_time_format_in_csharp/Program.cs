using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace date_time_format_in_csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Date and Time Format in C#");

            DateTime dt = DateTime.Now;
            Console.WriteLine("Short Date is: {0:d}" , dt);
            Console.WriteLine("Long Date is: {0:D}", dt);
            Console.WriteLine("Short time is: {0:f}", dt);
            Console.WriteLine("Longe time is: {0:F}", dt);
            Console.WriteLine("General Date and Short time is: {0:g}", dt);
            Console.WriteLine("General Date and Long time is: {0:G}", dt);
            Console.WriteLine("Short Date and Long Date is: {0:d} {1:D}", dt, dt);
            Console.WriteLine("Short Date and Long time is: {0:d} {1:F}", dt, dt);
            Console.WriteLine("Month is: {0:m}", dt);
            Console.WriteLine("Month is: {0:M}", dt);
            Console.WriteLine("Only Short time is: {0:t}", dt);
            Console.WriteLine("Only Long time is: {0:T}", dt);
            Console.WriteLine("Only Month and Year is: {0:Y}", dt);
            Console.WriteLine("Only Date is: {0:yy}", dt);
            Console.WriteLine("Only full year is: {0:yyyy}", dt);
            Console.WriteLine("Represent the Abbreviation of day of the week is: {0:ddd}", dt);
            Console.WriteLine("Represent the Full day of the week is: {0:dddd}", dt);
            Console.WriteLine("Show the Second is: {0:FF}", dt);
            Console.WriteLine("Show the Hour in 00 to 23 format is: {0:HH}", dt);
            Console.WriteLine("Show the Month in number is: {0:MM}", dt);
            Console.WriteLine("Represent the Short Name of Month is: {0:MMM}", dt);
            Console.WriteLine("Represent the Second from 0 to 59 is: {0:ss}", dt);
            Console.WriteLine("Only Full Time is: {0:HH:mm:ss tt}", dt);
            Console.WriteLine("Only Date is: {0:dd-MM-yyyy}", dt);
            Console.ReadLine();
        }
    }
}
