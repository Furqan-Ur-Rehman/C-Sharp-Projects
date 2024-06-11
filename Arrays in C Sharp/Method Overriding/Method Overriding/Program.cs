using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overriding
{
    class Parent
    {
        public virtual void Show()
        {
            Console.WriteLine("Parent Method.");
        }
    }

    class Child : Parent
    {
       public override void Show()
        {
            
            Console.WriteLine("Child Method.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Parent cc = new Child();
            cc.Show();
            


            Console.Read();
        }
    }
}
