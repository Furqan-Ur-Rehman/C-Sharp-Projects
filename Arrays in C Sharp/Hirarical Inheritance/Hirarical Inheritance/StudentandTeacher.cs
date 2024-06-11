using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hirarical_Inheritance
{

    //Hirarical Inheritance
    class Person
    {
        public int age;
        public void Setage(int age)
        {
            this.age = age;
        }

        public void Greet()
        {
            Console.WriteLine("Hello!");
        }
    }

    class Student : Person
    {
        public void study()
        {
            Console.WriteLine("I am going to study...");
        }

        public void showage()
        {
            Console.WriteLine("My age is {0} years old." , age);
        }
    }

    class Teacher : Person
    {
        public void Teach()
        {
            Console.WriteLine("I am Teaching C# Programming..");
        }
    }
    internal class StudentandTeacher
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            //person.Setage(30);
            person.Greet();

            Student student = new Student();
            student.Setage(25);
            student.showage();
            student.study();

            Teacher teacher = new Teacher();
            teacher.Greet();
            
            teacher.Teach();


            Console.Read();
        }
    }
}
