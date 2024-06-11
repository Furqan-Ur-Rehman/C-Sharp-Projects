using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overriding_in_C_Sharp
{
    public class Animal
    {
        public virtual void Eat()
        {
            Console.WriteLine("Every Animal Eats Something!");
        }

        protected void Dosomething()
        {
            Console.WriteLine("Every Animal does Something!");
        }
    }
    class Cat : Animal
    {
        public override void Eat()
        {
            base.Eat();
            Console.WriteLine("Cat Loves to eat the mouse!");
        }
        static void Main(string[] args)
        {
            Cat objcat = new Cat();
            objcat.Eat();
            objcat.Dosomething();

            Console.Read();
        }
    }
}
