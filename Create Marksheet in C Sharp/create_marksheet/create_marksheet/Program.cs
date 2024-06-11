using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace create_marksheet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=============Create Marksheet in C# ===================");
            Console.WriteLine("Enter Your Full Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Your Roll No:");
            string roll = Console.ReadLine();
            Console.WriteLine("Enter Your Examination Name i.e.(DAE (CS))");
            string exam_name = Console.ReadLine();
            Console.WriteLine("Enter Your Examination Year: (Annual/Supplementry)");
            string exam_year = Console.ReadLine();
            Console.WriteLine("Enter Your Board: ");
            string Board = Console.ReadLine();
            Console.WriteLine("Enter Passing/Failing Year: ");
            string passing_year = Console.ReadLine();
            Console.WriteLine("Enter the No. of Subjects for Calculating Marks & Percentage:");
            int No_of_Subjects = Convert.ToInt32(Console.ReadLine());
     
            string[] sub_name = new string[No_of_Subjects];
            float[] sub_marks = new float[No_of_Subjects];
            for (int i = 0; i < No_of_Subjects; i++)
            {
                Console.WriteLine("Enter the Subject Name: {0}" , (i+1));
                sub_name[i] = Console.ReadLine();
                Console.WriteLine("Enter the Obtained Marks of {0} is:" , sub_name[i]);
                sub_marks[i] = float.Parse(Console.ReadLine());
            }
                int total_marks = No_of_Subjects * 100;
                float total_obt_marks = 0;
                float percentage;

            for (int i = 0; i < No_of_Subjects; i++)
            {
                 total_obt_marks += sub_marks[i];    //0 = 0 + 50 
                                                    // 50 = 50 + 60
                                                    // 110 = 110 + 30
                //Console.WriteLine("Name of the Subjects: {0} " , sub_name[i]);
                //Console.WriteLine("Obtained Marks of {0} Subject: {1}", sub_name[i], sub_marks[i]);
            }
 
            percentage = total_obt_marks * 100 / total_marks;
            string Grade;
            if (percentage >= 80)
            {
                Grade = "A+";
                
            }
            else if (percentage >= 70 && percentage <= 79)
            {
                Grade = "A";
            }
            else if (percentage >= 60.0 && percentage <= 69.0)
            {
                Grade = "B";
            }
            else if (percentage >= 50.0 && percentage <= 59.0)
            {
                Grade = "C";
            }
            else if (percentage >= 40.0 && percentage <= 49.0)
            {
                Grade = "D";
            }
            else if (percentage >= 33.0 && percentage <= 39.0)
            {
                Grade = "E";
            }
            else
            {
                Grade = "Fail";
            }

            Console.WriteLine("***************************************************MARKS SHEET*********************************************************");
            Console.WriteLine();
            Console.Write("Name: " + name);
            Console.Write("\t\t\tRoll Number: " + roll);
            Console.WriteLine("\t\t\t Centre: " + Board);
            Console.Write("Exam Name: " + exam_name);
            Console.Write("\t\t\tExam Year: " + exam_year);
            Console.WriteLine("\t\t\t Passing/Failing Year: " + passing_year);
            Console.WriteLine("=======================================================================================================================");
            Console.Write("Subject Names");
            Console.Write("\t\t\tObtained Marks");
            Console.Write("\t\tTotal Marks");
            Console.Write("\t\tPassing Marks");
            Console.WriteLine("\t\tRemarks");
            Console.WriteLine("=======================================================================================================================");
            int total_marks_each_subj = 100;
            int passing_marks = 33;
            string individual_remarks;
            string remarks;
            string[] remarks_list = new string[No_of_Subjects];
            for (int i = 0; i < No_of_Subjects; i++)
            {
                if(sub_marks[i] >= 33)
                {
                    individual_remarks = "Pass";
                    remarks_list[i] = individual_remarks; // remarks_list[0] = Fail,
                                                          // remarks_list[1] = Pass,
                                                          // remarks_list[2] = Pass
                }
                else
                {
                    individual_remarks = "Fail";
                    remarks_list[i] = individual_remarks;
                }
                
                Console.Write(sub_name[i]);
                Console.Write("\t\t\t\t" + sub_marks[i]);
                Console.Write("\t\t\t" + total_marks_each_subj);
                Console.Write("\t\t\t" + passing_marks);
                Console.WriteLine("\t\t\t" + individual_remarks);
                Console.WriteLine();

                if(remarks_list[i] == "Fail")
                {
                    Grade = "Fail";
                }
                else if(remarks_list[i] == "Pass")
                {
                    
                    remarks = "Pass";

                }

            }
            if (Grade == "Fail")
            {
                remarks = "Fail";
            }
            else
            {
                remarks = "PASS";
            }
            Console.WriteLine("=======================================================================================================================");
            Console.WriteLine("Grand Total\t\t\t" + total_obt_marks + "\t\t\t" + total_marks);
            Console.WriteLine("=======================================================================================================================");
            Console.WriteLine("The Percentage of all Subjects are {0}%: ", percentage);
            Console.WriteLine("your Commulative Grade is: " + Grade);
            
            Console.WriteLine("Remarks: " + remarks);
            Console.ReadLine();
        }
    }
}
