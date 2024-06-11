using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi_Level_Inheritance_book_example
{
    public class Metals
    {
        public string Metaltype;

        public Metals(string type)
        {
            Metaltype = type;
            Console.WriteLine("Metals: " + Metaltype);
        }
    }

     public class SteelCompany : Metals
    {
        public string Grade;

        public SteelCompany(string grade) : base("Steel")
        {
            Grade = grade;
            Console.WriteLine("Grade: " + Grade);
        }
    }
    internal class Automobiles : SteelCompany
    {
        public string Part;
        public Automobiles(string part) : base("Cast iron")
        {
            Part = part;
            Console.WriteLine("Part: " + Part);
        }
        static void Main(string[] args)
        {
            Automobiles automobiles = new Automobiles("Chassis");

            Console.Read();
        }
    }
}
