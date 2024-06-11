using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    abstract class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Every Animal eats food in order to alive.");
        }

        public abstract void AnimalSound();
    }
    internal class Lion : Animal
    {
        public override void AnimalSound()
        {
            Console.WriteLine("Lion roars.");
        }
        static void Main(string[] args)
        {
            Lion lion = new Lion();
            lion.Eat();
            lion.AnimalSound();

            Console.Read();
        }
    }
}
