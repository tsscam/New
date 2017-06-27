using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerciese_42
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point();
           
            Console.WriteLine("Enter an X Coordinate : ");
            string X = Console.ReadLine();

            Console.WriteLine("Enter an Y Coordinate : ");
            string Y = Console.ReadLine();

            p1.X = Double.Parse(X);
            p1.Y = Double.Parse(Y);

            Console.WriteLine("You have created a point object {0} and {1}.", p1.X, p1.Y);
            
            return;

        }
    }
}
