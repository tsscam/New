using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare Variables
            int input;
            string Continue;
            string name = "";
            name = GetName();

            // Loop if User Chooses to Continue
            while (true)
            {

                // Number Input
                Console.WriteLine(name + ", Enter a Number Between 1 and 100: ");
                Console.WriteLine();


                // Number Validation
                while (!int.TryParse(Console.ReadLine(), out input))
                {
                    Console.WriteLine(name + ", Please Enter a Number Between 1 and 100:   ");
                    Console.WriteLine();
                }


                // Spacing
                Console.WriteLine();


                // Process
                if (input % 2 != 0 && input <= 100)
                {

                    Console.WriteLine("The Number " + input + " is Odd.");
                }

                else if (input % 2 == 0 && input >= 2 && input <= 25)
                {

                    Console.WriteLine("The Number " + input + " is Even and Less Than 25.");
                }

                else if (input % 2 == 0 && input >= 26 && input <= 60)
                {

                    Console.WriteLine("The Number " + input + " is Even.");
                }

                else if (input % 2 == 0 && input > 60 && input <= 100)
                {

                    Console.WriteLine("The Number " + input + " is Even.");
                }

                else if (input % 2 != 0 && input > 60 && input <= 100)
                {

                    Console.WriteLine("The Number " + input + " is Odd.");
                }
                else
                    Console.WriteLine("You Must Enter a Number Between 1 and 100");



                // Continue Loop
                while (true)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Would You Like to Continue, " + name + "?  (y/n)");
                    Continue = Console.ReadLine().ToUpper();
                    Console.WriteLine("");

                    if (Continue == "Y")
                        break;

                    if (Continue == "N")
                    {
                        Console.WriteLine("Bye, " + name + "!");
                        return;
                    }

                    else
                        Console.WriteLine("Please Enter Y or N");
                }
            }
        }


        // Method

        public static string GetName()
        {
            // Name Input
            Console.WriteLine("Please Enter Your Name: ");
            string name = Console.ReadLine();
            Console.WriteLine();

            return name;
        }

    }
}
