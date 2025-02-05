﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Write_Only_Property_book_pg_290
{
    class Department
    {
        //Declare variable/fields
        string DeptName;
        int DeptID;

        //Create Write-Only property 
        public string DepartmentName
        {
            set
            {
                DeptName = value;
            }
        }

        public int DepartmentID
        {
            set
            {
                DeptID = value;
            }
        }


        //Create Instance Method for print set Values
        public void Display()
        {
            Console.WriteLine("Department Name: " + DeptName);
            Console.WriteLine("Department ID: " + DeptID);
        }



    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create Object
            Department objdepartment = new Department();

            //Value initialize in respective fields
            objdepartment.DepartmentName = "Software Department";
            objdepartment.DepartmentID = 1001;
            objdepartment.Display();

            Console.Read();
        }
    }
}
