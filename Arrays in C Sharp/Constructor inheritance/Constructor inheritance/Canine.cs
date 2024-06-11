using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_inheritance
{
    class Animal
    {
        public Animal()
        {
            Console.WriteLine("Animal Constructor without Parameter.");
        }
        public Animal(string name)
        {
            Console.WriteLine("Animal Constructor with Parameter: " + name);
        }
    }
    internal class Canine : Animal
    {
        public Canine() : base("Lion")
        {
            Console.WriteLine("Canine");
        }
        static void Main(string[] args)
        {
            Canine canine = new Canine();


            Console.Read();
        }
    }
}
