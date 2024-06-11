using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Inheritance_book_pg_220
{
    class Animal
    {
        protected string Food;
        protected string Activity;
    }
    internal class Cat : Animal
    {
        static void Main(string[] args)
        {
            Cat objCat = new Cat();
            objCat.Food = "Mouse";
            objCat.Activity = "Lazearound";
            Console.WriteLine("The Cat loves to eat " + objCat.Food + ".");
            Console.WriteLine("The Cat lovess to " + objCat.Activity + ".");

            Console.Read();
        }
    }
}
