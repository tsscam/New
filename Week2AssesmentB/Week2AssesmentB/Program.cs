using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2AssesmentB
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence;


           public static bool checkApp()
        {
            while (true)
            {
                Console.Write("Continue? (true/false): ");
                //Prompts user if he wants to continue

                string tfString = Console.ReadLine()

                if (tfString == "true")
                {
                    Console.WriteLine("You have entered True");
                    break;
                }
                else if (tfString == "false")
                {
                    Console.WriteLine("You have entered False");
                }
                else
                {
                    Console.WriteLine("Error: Input not y or n."); //Prompts error if input is not Y or N
                    Console.WriteLine();

                }
            }
        }
    }
}
