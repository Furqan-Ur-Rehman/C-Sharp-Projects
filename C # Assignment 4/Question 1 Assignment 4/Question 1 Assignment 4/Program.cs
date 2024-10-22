﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Assignment_No_4
{
    //Create public Class "Admission"

    class Admission
    {
        //Create required fields/variables for Admission of Students
        public string Name;
        public double Per_in_Matriculation;
        public double Per_in_Intermediate;
        public string Group_in_Matriculation;
        public string Group_in_Intermediate;
        public string Department;
        public int Age;


        //Create Parameterized Constructor for Setting Values.

        public Admission(string name, double per_in_Matric, double per_in_Inter, string group_in_Matric, string group_in_Inter, string department, int age)
        {

            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Enter your Name First!");

            }
            else
            {

                Name = name;
                Console.WriteLine("Student Name is: " + Name);
                if (per_in_Matric >= 70)
                {
                    Per_in_Matriculation = per_in_Matric;
                    Console.WriteLine("Percentage in Matric: " + Per_in_Matriculation + "%");
                    if (per_in_Inter >= 60)
                    {
                        Per_in_Intermediate = per_in_Inter;
                        Console.WriteLine("Percentage in Inter: " + Per_in_Intermediate + "%");
                        if (group_in_Matric == "Biological Science" || group_in_Matric == "Computer Science")
                        {
                            Group_in_Matriculation = group_in_Matric;
                            Console.WriteLine("Your Group in Matric is: " + Group_in_Matriculation);
                            if (group_in_Inter == "Pre-Engineering" || group_in_Inter == "Pre-Medical")
                            {
                                Group_in_Intermediate = group_in_Inter;
                                Console.WriteLine("Your Group in Inter is: " + Group_in_Intermediate);
                                if (department == "Business Administration" || department == "Computer Science" || department == "Electronics" || department == "Mathematics" || department == "Physics" || department == "Pharmacy" || department == "Botany" || department == "Zoology" || department == "Biochemistry" || department == "Chemistry")
                                {
                                    Department = department;
                                    Console.WriteLine("Department is: " + Department);
                                    if (age >= 18)
                                    {
                                        Age = age;
                                        Console.WriteLine("Your Age is suitable for Admission: " + Age);
                                        Console.WriteLine("Congratulations! Your Admission have Conformed Successfully.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Your Age is not suitable for Admission as shown above.");
                                        Console.WriteLine("Sorry! Your Admission is not Conformed.");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("You have selected invalid department which are not present in 'Group in Intermediate'  or improper Case as shown above.");
                                    Console.WriteLine("Sorry! Your Admission is not Conformed.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Your Group in Intermediate is not meets with Admission Policy or improper Case as shown above in Note..");
                                Console.WriteLine("Sorry! Your Admission is not Conformed.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Your Group in Matric is not meets with Admission Policy or improper Case as shown above in Note..");
                            Console.WriteLine("Sorry! Your Admission is not Conformed.");
                        }



                    }
                    else
                    {
                        Console.WriteLine("Your Percentage in Intermediate is not suitable for admission!");
                        Console.WriteLine("Sorry! Your Admission is not Conformed.");
                    }
                }

                else
                {
                    Console.WriteLine("Your Percentage in Matric is not suitable for admission!");
                    Console.WriteLine("Sorry! Your Admission is not Conformed.");
                }

            }
        }
    }
    class AdmissionMain
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*************************Welcome to Virtual University******************");
            Console.WriteLine("--Admission Open in Various Department with Eligibility Criteria--");
            Console.WriteLine("The Following Instructions must be read carefully for Confirmed Admission Successfully:");
            Console.WriteLine(" (a) Department Selection Criteria.");
            Console.WriteLine(" Group in Intermediate:");
            Console.WriteLine();
            Console.WriteLine("\t 1) Pre-Engineering: \t\t\t 2) Pre-Medical:");
            Console.WriteLine("\t\t i) Business Administration. \t\t i) Pharmacy.");
            Console.WriteLine("\t\t ii) Computer Science. \t\t\t ii) Botany.");
            Console.WriteLine("\t\t iii) Electronics. \t\t\t iii) Zoology.");
            Console.WriteLine("\t\t iv) Mathematics. \t\t\t iv) Biochemistry.");
            Console.WriteLine("\t\t v) Physics. \t\t\t\t v) Chemistry.");

            Console.WriteLine();
            Console.WriteLine(" (b) Some other necessary Criteria for applying Admission.");
            Console.WriteLine("\t\t i) No Student can opt for Department that was not in his study Group in Inter which are shown above.");
            Console.WriteLine("\t\t ii) Minimum Matriculation Percentage is 70%");
            Console.WriteLine("\t\t iii) Minimum Intermediate Percentage is 60%");
            Console.WriteLine("\t\t iv) Minimum Age is 18 years old.");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------");
            Console.WriteLine("\t\t***********Application Start Here************");
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("--------------------------------------------------------------------------------------------------------");

                Console.WriteLine("Note: All fields would be inserted in Proper Case i.e. (Pre-Engineering, Pre-Medical, Business Administration,\n Computer Science etc..), otherwise your data would not be accepted.");
                Console.WriteLine("************************************************");
                Console.WriteLine("Enter your Name:");
                string a = Console.ReadLine();

                Console.WriteLine("Enter your Matric Percentage:");
                double b = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter your Intermediate Percentage:");
                double c = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter your Group in Matriculation only(Biological Science/Computer Science)");
                string d = Console.ReadLine();

                Console.WriteLine("Enter your Group in Intermediate only(Pre-Engineering/Pre-Medical)");
                string e = Console.ReadLine();

                Console.WriteLine("Enter your Department for which you are applying for");
                string f = Console.ReadLine();

                Console.WriteLine("Enter your Age which is at least 18 years old.");
                int g = Convert.ToInt32(Console.ReadLine());



                Console.WriteLine("--------------------------------------------------------------------------------------------------------");

                Admission nameofstd = new Admission(a, b, c, d, e, f, g);
                Console.WriteLine();
            }

            Console.Read();
        }
    }
}
