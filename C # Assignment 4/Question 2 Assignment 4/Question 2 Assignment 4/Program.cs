using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_2_Assignment_4
{
    class Person
    {
        public int age;
        //Create Method
        public void SetAge(int n)
        {
            age = n;
        }



        //Create another Method
        public void Greet()
        {
            Console.WriteLine("Hello!");
        }
    }

    class Student : Person
    {
        //Create Method
        public void GoToClasses()
        {
            Console.WriteLine("I'm going to Class.");
        }


        //Create another Method
        
        public void ShowAge()
        {
            Console.WriteLine("My Age is {0} years old. " , age);    
        }
    }

    class Teacher : Person
    {
        //Declare private field
        private string subject = "Computer Science";

        //Create Method
        public void Explain()
        {
            Console.WriteLine("Explanation Begins.");
        }

        //Create Another Method
        public void Subject()
        {
            
            Console.WriteLine("I am specilist in {0}!",subject);
        }
    }

    internal class StudentAndTeacherTest

    {
        static void Main(string[] args)
        {
            //Create Object for Person Class
            Console.WriteLine("Person's Object:");
            Person person = new Person();
            person.Greet(); //Person's own Method
            Console.WriteLine("----------------------------------------");

            Console.WriteLine();
            //Create Object for Student Class
            Console.WriteLine("Student's Object:");
            Student student = new Student();
            student.Greet();  //Person's Method but accessed by derived class.
            student.SetAge(23);//Person's Method but accessed by derived class.
            student.ShowAge(); // Student's  own Method.
            student.GoToClasses(); // Student's own Method.
            Console.WriteLine("----------------------------------------");


            Console.WriteLine();
            //Create Object for Teacher Class
            Console.WriteLine("Teacher's Object:");
            Teacher teacher = new Teacher();
            
            Console.WriteLine("I am a Teacher and my age is 30 years old.");
            teacher.Greet(); //Person's Method but accessed by derived class.
            teacher.Explain(); // Teacher's own Method.
            teacher.Subject(); // Teacher's own Method.


            Console.Read();
            
        }
    }
}
