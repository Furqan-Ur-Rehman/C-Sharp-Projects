using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Keyword_in_Inheritance_book_pg_222
{
    public class Animal
    {
        public string color = "White";
    }
    
    internal class Dog : Animal

    {
        string color = "black";
        public void showColor()
        {
            Console.WriteLine(base.color);
            Console.WriteLine(color);
        }
        static void Main(string[] args)
        {
            Dog d = new Dog();
            d.showColor();
            Console.WriteLine(d.color);
            Console.Read();
        }
    }
}
