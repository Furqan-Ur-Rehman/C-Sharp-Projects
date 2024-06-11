using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nested_switch_case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nested Switch Case in C#");
            Console.WriteLine("Enter Your Pizza Flavour: ");
            string pizza = Console.ReadLine();

            switch (pizza)
            {
                case "Fajita":
                case "fajita":
                    Console.WriteLine("You have Selected Fajita Pizza!");
                    break;
                case "Supreme":
                case "supreme":
                    Console.WriteLine("You have Selected Supreme Pizza!");
                    break;
                case "Cheese":
                case "cheese":
                    Console.WriteLine("You have Selected Cheese Pizza!");
                    break;
                case "Vegetable":
                case "vegetable":
                    Console.WriteLine("Please Enter Your Vegetable:");
                    string veg = Console.ReadLine();
                    switch (veg)
                    {
                        case "Olive":
                        case "olive":
                            Console.WriteLine("You have Selected Olives Pizza.");
                        break;
                        case "Onion":
                        case "onion":
                            Console.WriteLine("You have Selected Onion Pizza.");
                        break;
                        case "Mushrooms":
                        case "mushrooms":
                        case "Mushroom":
                        case "mushroom":
                            Console.WriteLine("You have Selected Mushrooms Pizza.");
                        break;
                        default:
                        Console.WriteLine("This Pizza Flavour in Vegetable is not available.");
                        break;
                    }
                    break;
                default:
                    Console.WriteLine("This Pizza Flavour is not available.");
                    break ;


            }
            Console.ReadLine();
        }
    }
}
