using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTwelveRock_Paper_Scissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Rock, Paper, Scirrors";


            Console.Title = "Rock, Paper, Scirros";
            Console.WriteLine("Ready, Set, Go! ");
            //Random

            Console.WriteLine("Please choose a player: ");
            string[] playerInput = { "Queen", "Pricess", "Mini"};
            Console.WriteLine("You are {0}," + playerInput);



            Random randomObject = new Random();
            int randomNumber = randomObject.Next(4);
            switch (randomNumber)
            {
                case 0:
                    {
                        Console.WriteLine("Rock!");
                        break;
                    }
                case 1:
                    {
                        Console.WriteLine("Paper!");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Scissors!");
                        break;
                    }
            }

        }
    }
}