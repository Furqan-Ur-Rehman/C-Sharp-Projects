using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overloading
{
    internal class Program
    {
        public void Show()
        {
            Console.WriteLine("This is the Method Overloading 1.");

        }

        string Name;
        public void Show(string name)
        {
            Name = name;
            Console.WriteLine("The Method Name is: " + Name);
        }
        static void Main(string[] args)
        {
            Program methodname = new Program();
            methodname.Show("Method Overloading.");

            Console.Read();
        }
    }
}
