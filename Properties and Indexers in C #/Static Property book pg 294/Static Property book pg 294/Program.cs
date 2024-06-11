using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Property_book_pg_294
{
    public class University
    {
        private static string Department_Name;
        private static string University_Name;


        //static property
        public static string Department
        {
            set
            {
                Department_Name = value;
            }

            get
            {
                return Department_Name;
            }

        }

        //static property
        public static string Universityname
        {
            set
            {
                University_Name = value;
            }

            get
            {
                return University_Name;
            }
        }
    }
    internal class Physics
    {
        static void Main(string[] args)
        {
            University.Universityname = "Virtual University";
            University.Department = "Software Engineering";

            Console.WriteLine("University Name is: " + University.Universityname);
            Console.WriteLine("University's Department is: " + University.Department);

            Console.Read();
        }
    }
}
