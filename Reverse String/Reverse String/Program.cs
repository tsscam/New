using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1_ReverseNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //Prompt user to enter number. 
            Console.WriteLine("Enter a Number");
            //Convert the string representation of a number to an integer.
            int number = int.Parse(Console.ReadLine());
            int reverse = 0;
            //Use while loop to repeat code back.
            while (number > 0)
            //I had to look up the following equation online, to reverse the inputted number.
            {
                int rem = number % 10;
                reverse = (reverse * 10) + rem;
                number = number / 10;
            }
            //Use WriteLine to display string 'Reverse number', and ReadLine to display integers repeated back. 
            Console.WriteLine("Reverse number = {0}", reverse);
            Console.ReadLine();
        }
    }
}

