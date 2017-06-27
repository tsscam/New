using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTIme
{
    class Selection
    {
        //enum Book { Available, Not Available };

        string void Main(string[] args)
        {
            string[,] sections = new string[1, 3];
            sections[0, 0] = "top left";
            sections[0, 1] = "top center";
            sections[0, 2] = "top right";

            sections[1, 0] = "top left";
            sections[1, 1] = "top center";
            sections[1, 2] = "top right";

            sections[2, 0] = "top left";
            sections[2, 1] = "top center";
            sections[2, 2] = "top right";

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(sections[i, j] + "\t");
                    if ((j + 1) % 3 == 0)
                    {
                        Console.WriteLine("");
                    }
                }
            }
        }
    }
}


            //var thisFruit = Book.Available;
            //switch (thisBook)
            //{
            //    case Book.Available:
            //        Console.WriteLine("Your book is Availble");
            //        break;
            //    case Book.Not Available:
            //        Console.WriteLine("Sorry! Your book is Not Availble");
            //        Console.WriteLine("Your book is Availble for 14 days");
            //        break;
            //}
            //Book[] availablility = { List OF BOOKS }; // SHOWS AVAILBE BOOKS


       