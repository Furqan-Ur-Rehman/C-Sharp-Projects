using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUESTION_NO_02
{
    class Person
    {
        public string name;
        public int age;

        public Person(string name)
        {
            this.name = name;
        }

        public void Greet() //Creating Greet Method
        {
            Console.WriteLine(name + " says hello.");
        }
        public void SetAge(int n)
        {
            this.age = n;
        }

    }
    class Student : Person
    {
        public Student(string name) : base(name)
        {


        }
        public void GoToClasses()
        {
            Console.WriteLine("I'm going to class.");
        }
        public void ShowAge()
        {
            Console.WriteLine("My age is " + age + " years old.");
        }


    }
    class Teacher : Person
    {
        public Teacher(string name) : base(name)
        {


        }
        public void Explain()
        {
            Console.WriteLine("Explanation begins.");
        }


        private string subject;

    }
    internal class StudentAndTeacherTest
    {
        static void Main(string[] args)
        {
            //Create Person
            Person objPerson = new Person("xyz");
            objPerson.Greet();
            Console.WriteLine("------------------------------");

            //Create Student
            Student objStudent = new Student("Ali");
            objStudent.SetAge(20);
            objStudent.Greet();
            objStudent.ShowAge();
            objStudent.GoToClasses();
            Console.WriteLine("------------------------------");

            //Create Teacher
            Teacher objTeacher = new Teacher("Ahmed");
            objTeacher.SetAge(30);
            objTeacher.Greet();
            objTeacher.Explain();


            Console.Read();
        }
    }
}
