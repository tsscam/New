using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetBirthday
{
    class Program
    {
        static void Main(string[] args)
        {
                // Declare Variables
                DateTime birthdate;


                // User Input
                Console.WriteLine("Please Enter Your Birthdate in the Following Format --->  yyyy mm dd: ");


                // Validation
                while (!DateTime.TryParse(Console.ReadLine(), out birthdate))
                {
                    Console.WriteLine("Please Enter the Your Birthdate in the Correct Format Using Only Numbers");
                }


                // Get Current Time
                DateTime current = DateTime.Now;


                // Process
                System.TimeSpan diff = current.Subtract(birthdate);

                //int result = DateTime.Compare(birthdate, current);
                int year = diff.Days / 365;
                int days = (diff.Days % 365) % 31;


                // Output
                Console.WriteLine("");
                Console.WriteLine("You are " + year + " years and " + days + " days old!");


                // Find Out if Their Birthday is Today
                if (birthdate == current)

                    Console.WriteLine("Happy Birthday!!!!!!!!!!!!!!!!");
            }
        }
    }