using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    interface IAnimal
    {
        void Habitat();
    }

    internal class Dog : IAnimal
    {
       public void Habitat()
        {
            Console.WriteLine("Can be house with Human beings.");
        }
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.Habitat();
            Console.WriteLine(dog.GetType().Name);


            Console.Read();
        }
    }
}
