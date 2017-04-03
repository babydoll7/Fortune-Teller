using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_One_3_31_due_4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine();

            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine();

            int Age;
            Console.WriteLine("How old are you?");

            Age = int.Parse(Console.ReadLine());

            if (Age % 2 == 0)
                Console.WriteLine("You will retire in Seven Years!");

            else if (Age % 2 != 0)
                Console.WriteLine("You will retire in Ten Years!");

            Console.WriteLine("Enter the number that corresponds with your birth month");
            int birthMonth = int.Parse(Console.ReadLine());

            if (birthMonth == 1 - 4)
                Console.WriteLine("You will have 10000000000 in the bank!");
            else if (birthMonth == 5 - 8)
                Console.WriteLine("You will have 500000000 in the bank!");
            else if (birthMonth == 9 - 12)
                Console.WriteLine("You will have 4000000 in the bank!");
            else
                Console.WriteLine("You will be broke asf!");

            Console.WriteLine("How many siblings do you have?");
            int numberSiblings = int.Parse(Console.ReadLine());

            if (numberSiblings == 0)

            {
                Console.WriteLine("You will have a vacation home in Maui");
            }

            else if (numberSiblings == 1)
            {
                Console.WriteLine("You will have a vacation home in the Netherlands");
            }

            else if (numberSiblings == 2)
            {
                Console.WriteLine("You will have a vacation home in Hawaii");
            }
            else if (numberSiblings == 3)
            {
                Console.WriteLine("You will have a vacation home in Florida");
            }
            else if (numberSiblings > 3)
            {
                Console.WriteLine("You will have a vacation home in Cleveland");
            }
            else
            {
                Console.WriteLine("You will have a vacation home in Old Mother Hubbard's Cupboard");
            }

            if (Age % 2 == 0)
            {
                Console.WriteLine("You will retire in 7 years!");
            }
            else
            {
                Console.WriteLine("You will rerire in 10 years");
            }

            if (birthMonth == 1 - 4)
            {
                Console.WriteLine("You will have 5,000,000 in the bank");
            }
            else if (birthMonth == 5 - 8)
            {
                Console.WriteLine("You will have 2,000,000 in the bank");
            }
            else if (birthMonth == 9 - 12)
            {
                Console.WriteLine("You will have 1,000,000 in the bank");
            }
            else
            {
                Console.WriteLine("You will be broke asf");
            }

            {
                Console.WriteLine("What is your favorite ROYGBIV color?  If you don't know what ROYGBIV is, please type \"HELP\". ");
                char faveColor = char.Parse(Console.ReadLine());
                string Color = "Red";

                switch (Color)
                {
                    case "Red":
                        Console.WriteLine("You will drive an Aston Martin!");
                        break;

                    case "Orange":
                        Console.WriteLine("You will drive a Bentley!");
                        break;

                    case "Yellow":
                        Console.WriteLine("You will drive a Lambourghini!");
                        break;

                    case "Green":
                        Console.WriteLine("You will drive a Hummer!");
                        break;

                    case "Blue":
                        Console.WriteLine("You will drive a Range Rover!");
                        break;

                    case "Indigo":
                        Console.WriteLine("You will drive a BMW!");
                        break;

                    case "Violet":
                        Console.WriteLine("You will have a Yacht!");
                        break;

                    case "Help":
                        Console.WriteLine("ROYGBIV is RED, ORANGE, YELLOW, GREEN, BLUE, INDIGO, VIOLET");
                        break;

                    default:
                        Console.WriteLine("You will have a nice pair of rollerblades");
                        break;
                }

                string Fortune = firstName + lastName;
                
                Console.WriteLine("Hello" + string.Concat(firstName, lastName) + "You will retire in " + Age + "years with " + birthMonth + "in the bank wit a" + numberSiblings + "and" + Color);

            }
        }
    }
}
  