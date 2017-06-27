using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool valid = true;
            int input;
            do
            {
                Console.WriteLine("Hello" + "\n Please Enter number: ");

                do
                {
                    valid = int.TryParse(Console.ReadLine(), out input);

                    if (input < 1 || input > 100)
                        valid = false;
                } while (!valid);
                }
            }
        }
    }
}
