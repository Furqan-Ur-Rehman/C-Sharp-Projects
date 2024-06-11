using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property
{
    internal class Student
    {
        private int id;
        private string name;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                if(value <= 0)
                {
                    Console.WriteLine("Id is not valid.");
                }
                else
                {
                    id = value;
                    Console.WriteLine("My id is: " + id);
                }
                
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {   if(string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Name is not Valid.");
                }
                else
                {
                    name = value;
                    Console.WriteLine("My name is: " + name);
                }
                
            }
        }
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Id = 101;
            //Console.WriteLine(student.Id);
            student.Name = "";


            Console.Read();
        }
    }
}
