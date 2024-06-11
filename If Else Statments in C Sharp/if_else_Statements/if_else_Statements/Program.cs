using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_else_Statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("============Selection Statements (if, else, else if, nested if, switch case & nested switch case)=================");
            string repeat;
            int user_count = 1, password_count = 1;
            start:
            Console.WriteLine("Enter the User Name for Login.");
            string user_name = Console.ReadLine();
            if(user_name == "Furqan" || user_name == "furqan")
            {
                start_from_password:
                Console.WriteLine("Enter the Correct Password for Login.");
                string password = Console.ReadLine();
                if(password == "786123")
                {
                    Console.WriteLine("You are Logged in Successfully!");
                }
                else
                {
                    Console.WriteLine(password_count + ") Your Password is incorrect, Sorry you are unable to login.");
                    Console.WriteLine("If Try Again then press y otherwise n.");
                    repeat = Console.ReadLine();
                    if (repeat == "y" || repeat == "Y" || repeat == "Yes" || repeat == "yes" || repeat == "YES")
                    {
                        password_count++;
                        if (password_count == 4)
                        {
                            Console.WriteLine("Sorry your 3 attemptations have been failed, you are unable to login.");
                        }
                        else
                        {
                            goto start_from_password;
                        }

                    }
                }
            }
            else if (user_name == "Furqan-ur-Rehman" || user_name == "Furqan-Ur-Rehman")
            {
                start_from_password:   
                Console.WriteLine("Enter the Correct Password for Login.");
                string password = Console.ReadLine();
                if (password == "786123")
                {
                    Console.WriteLine("You are Logged in Successfully!");
                }
                else
                {
                    Console.WriteLine(password_count + ") Your Password is incorrect, Sorry you are unable to login.");
                    Console.WriteLine("If Try Again then press y otherwise n.");
                    repeat = Console.ReadLine();
            
                    if (repeat == "y" || repeat == "Y" || repeat == "Yes" || repeat == "yes" || repeat == "YES")
                    {
                        password_count++;
                        if (password_count == 4)
                        {
                            Console.WriteLine("Sorry your 3 attemptations have been failed, you are unable to login.");
                        }
                        else
                        {
                            goto start_from_password;
                        }

                    }
                }
            }
            else
            {
                Console.WriteLine(user_count + ") Your User Name is incorrect, Sorry you are unable to login.");
                Console.WriteLine("If Try Again then press y otherwise n.");
                
                repeat = Console.ReadLine();
                if(repeat == "y" || repeat == "Y" || repeat == "Yes" || repeat == "yes" || repeat == "YES")
                {
                    user_count++;
                    if(user_count == 4)
                    {
                        Console.WriteLine("Sorry your 3 attemptations have been failed, you are unable to login.");
                    }
                    else
                    {
                        goto start;
                    }
                    
                }
            }
            Console.ReadLine();
        }
    }
}
