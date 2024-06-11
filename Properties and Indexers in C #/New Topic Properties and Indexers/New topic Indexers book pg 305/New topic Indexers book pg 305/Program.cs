using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_topic_Indexers_book_pg_305
{
    class Employee
    {
        private int[] Age = new int[3];

        public int this[int index]
        {
            get
            {
                return Age[index];
            }
            set
            {
                if(index >=0 && index < Age.Length)
                {
                    if(value > 0)
                    {
                        Age[index] = value;
                    }

                   
                    else
                    {
                        Console.WriteLine("Value is Invalid");
                    }
                }
                Age[index] = value;
            }
        }
        static void Main(string[] args)
        {
            Employee E = new Employee();

            E[0] = 24;
            E[1] = 15;
            E[2] = 19;

            Console.WriteLine("Employee Age:");
            for(int i=0; i<=2; i++)
            {
                Console.WriteLine(E[i] + "\t");
            }

            Console.Read();
        }
    }
}
