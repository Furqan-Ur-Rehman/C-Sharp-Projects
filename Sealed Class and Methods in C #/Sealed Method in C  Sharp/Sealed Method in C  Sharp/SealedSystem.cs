using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sealed_Method_in_C__Sharp
{
    class ITSystem
    {
        public virtual void print()
        {
            Console.WriteLine("The System should be handled Carefully");
        }
    }

    class CompanySystem : ITSystem
    {
        public sealed override void print()
        {
            Console.WriteLine("The System information is confidential");
            Console.WriteLine("This information should not be overridden");
        }
    }
    class SealedSystem : CompanySystem 

    {
        public override void print()
        {
            Console.WriteLine("The statement won't get executed");
        }
        static void Main(string[] args)
        {
            SealedSystem objSealed = new SealedSystem();
            objSealed.print();
        }
    }   
}
