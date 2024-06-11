using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoked_base_class_constructor_book_pg_226
{
    //Multi Level hierarchy Inheritance

    //Create Base Class
    public class Metals
    {
        public string Metaltype;

        public Metals(string type)
        {
            Metaltype = type;
            Console.WriteLine("Metals: \t" + Metaltype);
        }
    }

    //Create Derived Class of Base Class(Metals)
    class SteelCompany : Metals
    {
        string grade;
       public SteelCompany(string grade) : base("Steel")
        {
            this.grade = grade;
            Console.WriteLine("Grade: \t \t" + grade);
        }
    }


    //Create Sub-Derived Class of Derive Class (Steel Company)
    internal class Automobiles : SteelCompany
    {
        string _part;

        public Automobiles(string part) : base ("Cast Iron")
        {
            _part = part;
            Console.WriteLine("Part: \t \t" + _part);
        }
        static void Main(string[] args)
        {
            Automobiles objautomobiles = new Automobiles("Chassis");

            Console.Read();

        }

        
    }
}
