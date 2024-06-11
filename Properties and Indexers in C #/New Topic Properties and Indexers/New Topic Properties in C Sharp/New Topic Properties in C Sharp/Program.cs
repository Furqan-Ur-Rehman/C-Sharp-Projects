using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Topic_Properties_in_C_Sharp
{
    class student
    {
        private int ID;
        private string Name;
        
        public int _ID // Property
        {
            get
            {
                return ID;
            }

            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Id is not Consider");
                }

                else
                {
                    ID = value;
                    Console.WriteLine("Student ID: " + ID);
                }

            }

        }

            public string _Name
        {
            get
            {
                return Name;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Name is not Consider");
                }


                else
                {
                    Name = value;
                    Console.WriteLine("Student Name: " + Name);
                }
            }

        }
       
        static void Main(string[] args)
        {
            student s = new student();
            s._ID = 32;
            s._Name = "xyz";
            Console.Read();
        }
    }
}
