﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeMidTerm
{
    class Validtion
    {
        public static int GetValidInt()
        {

            int number;

            // Validate Input
            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine();

                // Number Validation with Colors
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine();
                Console.Write("You Must Select A Valid Number From The Menu:  --->   ");
                Console.ForegroundColor = ConsoleColor.DarkBlue;
            }

            return number;
        }



        // Method to Get Input and Validate That Number is Between 1 and 5.
        public static int GetRange(int min, int max)
        {

            // Get a Valid Int from Previous Method
            int number = GetValidInt();

            while (number < min || number > max)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"You MUST Enter a Number That is in Between {min} and {max}  --->   ");
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                number = GetValidInt();
            }

            return number;
        }



        //Input Method
        public static string GetValidString()
        {
            string Input = Console.ReadLine().ToUpper();

            // Validates There is User Input
            while ((string.IsNullOrEmpty(Input)) || (string.IsNullOrWhiteSpace(Input)))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You Must Enter Words!");
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Input = Console.ReadLine().ToUpper();
            }

            return Input;

        }




        // Method to Continue
        public static bool GetContinue()
        {
            string Continue;

            //Continue Loop
            while (true)
            {
                Console.WriteLine("\n");
                Console.WriteLine("Do You Need Help With Anything Else?  (y/n)");
                Continue = Console.ReadLine().ToUpper();
                Console.WriteLine("");
                if (Continue == "Y")
                    return true;

                if (Continue == "N")
                    return false;

                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;  // Red to Alert User Input is Invalid
                    Console.WriteLine("Please Enter Y or N");
                    Console.ForegroundColor = ConsoleColor.DarkBlue;   // Dark Blue to Go Back to Original Color
                }
            }
        }
    }
}
