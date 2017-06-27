using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoop
{
    class Program
    {
        static void Main(string[] args)

        {
            bool run = true;
            do
            {

                Console.WriteLine("Enter a Valid Number: ");
                int input1 = Int16.Parse(Console.ReadLine());
                if (input1 % 2 == 0)
                {
                    Console.WriteLine("The number is Even");
                  
                }

                while (!int.TryParse(Console.ReadLine(), out input1))
                {
                    Console.WriteLine("Nice Try..Enter a number", input1);
                    input1 = int.Parse(Console.ReadLine());
                    
                    run = false;
                }
            } while (run);
        }
    }
}
            
            
            
     