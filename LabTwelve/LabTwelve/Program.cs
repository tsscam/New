using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTwelve
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;


            Console.Title = "Rock, Paper, Scirros";
            Console.WriteLine("Ready, Set, Go! ");
            //Random
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
                        do
                        {
                                
                Console.WriteLine("");

                //directions for user
                Console.WriteLine("Rock, Paper, Scissors GAME: ");

                Console.WriteLine("Playing Rock, Paper, Scissors is fun: ");
                Console.WriteLine("==================================");

  
public Random getRandom()
        {
            String[] game = new String[3];
            game[0] = “Rock”;
            game[1] = “Paper”;
            game[2] = “Scissors”;

            int num = (int)(Math.random() * 3);//this was luck - but needs more explanation

            System.out.println(“The Jets: ” +game[num]);//how do I get userOpp to print with random number

            return random;
        }

    } while (run == true);
        }
    }
}
      