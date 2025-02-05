﻿using System;
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
            Console.WriteLine("Animal Constructor without parameter");
        }

        public Animal(string name)
        {
            Console.WriteLine("Animal Construct with parameter string: " + name);   
        }
    }
    
    internal class Canine : Animal
    {
        /*Canine() : base() */// Print first Default Constructor (Animal Construct without parameter.)
        //then print Canine Constructor

        //or

        /*Canine()*/ /*Print first Default Constructor then Canine Constructor*/

        //or
        Canine() : base("Lion")  // Print First Parameterized Constructor(Lion)
            // then Canine Constructor.
        {
            Console.WriteLine("Canine");
        }
        static void Main(string[] args)
        {
            Canine cn = new Canine();

            Console.Read();
        }
    }
}
