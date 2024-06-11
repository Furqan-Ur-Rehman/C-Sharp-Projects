using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosntructor_Inheritance_in_C_Sharp
{
    //Create Base Class
    public class Metals
    {
        public string MetalType;

        //Create Method
        public Metals(string type)
        {
            MetalType = type;
            Console.WriteLine("Metals: " + MetalType);
        }

    }

    //Create Derived Class of Metals

        public class steelCompany : Metals
    {
        public string Grade;

        public steelCompany(string grade) : base("Steel")
        {
            Grade = grade;
            Console.WriteLine("Grade: " + Grade);
        }
    }
       

    class Automobiles : steelCompany
    {
        public string Part;
        public Automobiles(string part) : base("Cast Iron")
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
