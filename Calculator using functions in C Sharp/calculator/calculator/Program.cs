using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    internal class Program
    {
        public static void @Addition(float a, float b)
        {
            float result = a + b;
            Console.WriteLine("Addition result is: " + result);
        }
        public static void @Subtraction(float a, float b)
        {
            float result = a - b;
            Console.WriteLine("Subtraction result is: " + result);
        }
        public static void @Multiplication(float a, float b)
        {
            float result = a * b;
            Console.WriteLine("Multiplication result is: " + result);
        }
        public static void @Division(float a, float b)
        {
            float result = a / b;
            Console.WriteLine("Division result is: " + result);
        }
        public static void @Modulus(float a, float b)
        {
            float result = a % b;
            Console.WriteLine("Modulus result is: " + result);
        }
        static void Main(string[] args)
        {
            start_again:
            Console.WriteLine("Enter the Value of Num1: ");
            float num1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Value of Num2: ");
            float num2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Operator (+, -, *, /, %): ");
            string opt = Console.ReadLine();

            if (opt.Equals("+"))
            {
                Program.Addition(num1, num2);
            }
            else if (opt.Equals("-"))
            {
                Program.Subtraction(num1, num2);
            }
            else if (opt.Equals("*"))
            {
                Program.Multiplication(num1, num2);
            }
            else if (opt.Equals("/"))
            {
                Program.Division(num1, num2);
            }
            else if (opt.Equals("%"))
            {
                Program.Modulus(num1, num2);
            }
            else
            {
                Console.WriteLine("Please Enter Valid Operator i.e. (+, -, *, /, %)");
            }
            Console.WriteLine("Are You Sure You want to Continue again Press [Yes / No]");
            string repeat = Console.ReadLine().ToLower();
            if (repeat.Equals("yes"))
            {
                goto start_again;
            }
            Console.ReadLine();
        }
    }
}
