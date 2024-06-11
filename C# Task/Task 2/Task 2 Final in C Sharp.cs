using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_using_Selection_Statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1 (Find the Largest number amoung three Numbers?)
            Console.WriteLine("***********Select Largest number amoung three numbers.*********");
            int num1;
            int num2;
            int num3;
            Console.WriteLine("Enter the Value of num1: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Value of num2: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Value of num3: ");
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine("The Value of num1 {0} is Greator than All! ", num1);
            }

            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine("The Value of num2 {0} is Greator than All! ", num2);
            }

            else
            {
                Console.WriteLine("The Value of num3 {0} is Greator than all of above! ", num3);
            }
            Console.WriteLine();

            //Task 2 (To Check a number is Positive, Negative, or Zero.)
            Console.WriteLine("*************Positive, Negative or Zero Number************");
            int Num1;
            Console.WriteLine("Enter the value of Num1: ");
            Num1 = Convert.ToInt32(Console.ReadLine());
            if (Num1 > 0)
            {
                Console.WriteLine("The Value of Num1 {0} is Positive! ", Num1);
            }

            else if (Num1 < 0)
            {
                Console.WriteLine("The Value of Num1 {0} is Negative! ", Num1);
            }
            else
            {
                Console.WriteLine("The Value of Num1 {0} is Zero! ", Num1);
            }
            Console.WriteLine();


            //Task 3  To Check UpperCase or LowerCase Alphabets.
            Console.WriteLine("****************LowerCase or UpperCase Character**************");
            char Ch;
            Console.WriteLine("Enter any Character: ");
            Ch = Convert.ToChar(Console.ReadLine());
            if (Ch >= 'a' && Ch <= 'z')
            {
                Console.WriteLine("The Character you entered {0} is LowerCase!", Ch);
            }

            else if(Ch >= 'A' && Ch <= 'Z')
            {
                Console.WriteLine("The Character you entered {0} is UpperCase!", Ch);
            }

            else
            {
                Console.WriteLine("The Character you entered {0} is not a Single Character, it is a string or You Entered a value.", Ch);
            }
            Console.WriteLine();

            // Task 4 (To Check Character is a Vowel or a Consonant)

            Console.WriteLine("***************Vowel or Consonant Character****************");
            char Character;
            Console.WriteLine("Enter the Any Character: ");
            Character = Convert.ToChar(Console.ReadLine());
            if (Character == 'a' || Character == 'e' || Character == 'i' || Character == 'o' || Character == 'u')
            {
                Console.WriteLine("The Character you Entered {0} is Vowel.", Character);
            }

            else if (Character == 'A' || Character == 'E' || Character == 'I' || Character == 'O' || Character == 'U')
            {
                Console.WriteLine("The Character you Entered {0} is Vowel.", Character);
            }

            else if (Character >= 'b' && Character <= 'd' || Character >= 'f' && Character <= 'h' || Character >= 'j' && Character <= 'n' || Character >= 'p' && Character <= 't' || Character >= 'v' && Character <= 'z')
            {
                Console.WriteLine("The Character you Entered {0} is Consonant.", Character);
            }

            else if (Character >= 'B' && Character <= 'D' || Character >= 'F' && Character <= 'H' || Character >= 'J' && Character <= 'N' || Character >= 'P' && Character <= 'T' || Character >= 'V' && Character <= 'Z')
            {
                Console.WriteLine("The Character you Entered {0} is Consonant.", Character);
            }

            else
            {
                Console.WriteLine("You Entered a value which is not a Character, Please type any Character!", Character);
            }

            Console.WriteLine();

            // Task 5 (To Determine Whether Age or Education of Voter for Casting Vote?)

            Console.WriteLine("*************Casting Vote*******************");
            int Age;
            string Education;
            Console.WriteLine("Enter your Age: ");
            Age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your Education: ");
            Education = Console.ReadLine();

            if (Age >= 18 && Education == "Matric" || Education == "Inter" || Education == "Graduate" || Education == "Master")
            {
                Console.WriteLine("You are Eligible for casting Vote!");
            }

            else if (Age >= 18 && Education == "matric" || Education == "inter" || Education == "graduate" || Education == "master")
            {
                Console.WriteLine("You are Eligible for casting Vote!");
            }

            else if (Age >= 18 && Education == "MATRIC" || Education == "INTER" || Education == "GRADUATE" || Education == "MASTER")
            {
                Console.WriteLine("You are Eligible for casting Vote!");
            }

            else if (Age >= 18 && Education == "Matriculation" || Education == "Intermediate" || Education == "Graduate" || Education == "Master")
            {
                Console.WriteLine("You are Eligible for casting Vote!");
            }

            else if (Age >= 18 && Education == "matriculation" || Education == "intermediate" || Education == "graduation" || Education == "master")
            {
                Console.WriteLine("You are Eligible for casting Vote!");
            }

            else if (Age >= 18 && Education == "MATRICULATION" || Education == "INTERMEDIATE" || Education == "GRADUATION" || Education == "MASTER")
            {
                Console.WriteLine("You are Eligible for casting Vote!");
            }

            else
            {
                Console.WriteLine("Sorry, Your are not Eligible for Casting Vote because, You typed invalid Education or You are under 18!");
            }

            Console.Read();
        }
    }
}
